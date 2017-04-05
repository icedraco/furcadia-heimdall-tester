using System;
using System.Collections.Generic;
using System.Text;

namespace Heimdall_Tester
{
    public class HeimdallCheckController
    {
        public struct HeimdallStatus {
            public bool HasHeimdall;
            public bool HasHorton;
            public bool HasTribble;
            public int HeimdallQTEMP;
            public int HortonQTEMP;
            public int TribbleQTEMP;
            public int Hits;
        };

        /*** Members ***/
        bool bReady = false;
        int nRequestsMade = 0;
        int nMaxRequests = 0;
        HeimdallStatus[] statusList;
        HeimdallCheck[] checkList;

        public List<string> Errors = new List<string>();
        public Settings AppSettings = null;

        /*** Properties ***/
        public bool Ready { get { return bReady; } }
        public int HeimdallAmount { get { return statusList.Length; } }
        public int HeimdallsScanned
        {
            get
            {
                int n = 0;
                foreach (HeimdallStatus hds in statusList)
                    if (hds.Hits > 0)
                        n++;
                return n;
            }
        }

        public int RequestsMade { get { return nRequestsMade; } }
        public int MaxRequests { get { return nMaxRequests; } }

        /*** Constructor ***/
        public HeimdallCheckController() {}
        public HeimdallCheckController(Settings sets)
        {
            AppSettings = sets;
        }

        /*** Methods ***/
        public void Start()
        {
            bReady = false;

            // Create an array for the right amount of heimdalls & init all.
            int nHeimdalls = AppSettings.HeimdallAmount;
            statusList = new HeimdallStatus[nHeimdalls];
            for (int i = 0; i < nHeimdalls; i++)
            {
                statusList[i].HasHeimdall = false;
                statusList[i].HasHorton = false;
                statusList[i].HasTribble = false;
                statusList[i].HeimdallQTEMP = 0;
                statusList[i].HortonQTEMP = 0;
                statusList[i].TribbleQTEMP = 0;
                statusList[i].Hits = 0;
            }

            // Determine the maximal amount of requests we should make.
            nMaxRequests = AppSettings.ConnectionAttempts;

            // Create a checklist and run the checks.
            HeimdallCheck[] cl = new HeimdallCheck[AppSettings.UserAmount];
            string[] usernames = new string[AppSettings.UserList.Count];
            AppSettings.UserList.Keys.CopyTo(usernames, 0);

            for (int i = 0; i < cl.Length; i++)
            {
                string username = usernames[i];
                string password = AppSettings.UserList[username];
                cl[i] = RunHeimdallCheck(username, password);
            }

            checkList = cl;
            // From here, use Update() periodically to keep things going.
        }

        public void Stop()
        {
            // If the member wasn't assigned an array yet, don't bother.
            if (checkList == null)
                return;

            // Go through the checklist and stop everything.
            foreach (HeimdallCheck hdc in checkList)
            {
                try
                {
                    hdc.Stop();
                }
                catch
                {
                    // Do nothing if something's wrong
                }
            }
        }

        public void Update()
        {
            // If the lookup is ready, we have nothing to do here.
            if (bReady)
                return;

            // Go through each check and handle it.
            foreach (HeimdallCheck hdc in checkList)
            {
                // If the check is still running, let it run.
                if (hdc.Running)
                    continue;

                //-- From here, we assume that the check is complete.

                // If there was an error, log it and don't count the readings.
                if (hdc.Error)
                {
                    Errors.Add(String.Format("HDC[{0}] C.ATT#{1}: {2} (Heimdall {3}{4}{5})",
                        hdc.Name,
                        RequestsMade,
                        hdc.ErrorMessage,
                        hdc.HeimdallNumber,
                        hdc.HasHorton ? "" : " <NOHORTON>",
                        hdc.HasTribble ? "" : " <NOTRIBBLE>"
                        ));
                }
                else
                {
                    // I'll store the number locally to save unnecessary property
                    // access. Properties seem to work like functions/methods.
                    int hdn = hdc.HeimdallNumber - 1;

                    // If this check managed to detect a heimdall number, consider
                    // the readings important.
                    if (hdn >= 0)
                    {
                        statusList[hdn].HasHeimdall = hdc.HasHeimdall;
                        statusList[hdn].HasHorton = hdc.HasHorton;
                        statusList[hdn].HasTribble = hdc.HasTribble;
                        statusList[hdn].HeimdallQTEMP = hdc.HeimdallQTEMP;
                        statusList[hdn].HortonQTEMP = hdc.HortonQTEMP;
                        statusList[hdn].TribbleQTEMP = hdc.TribbleQTEMP;
                        statusList[hdn].Hits++;
                    }
                }

                // Save the login data from this instance for possible reuse.
                string username = hdc.Name;

                // Now, we should reuse this name to do another check unless
                // we're done. If we're done, set the Ready flag.
                if (HasEverything() || nRequestsMade >= nMaxRequests)
                {
                    bReady = true;
                }
                else
                {
                    HeimdallCheck hc = RunHeimdallCheck(username, AppSettings.UserList[username]);

                    // Insert this instead of its "brother" in the list.
                    for (int i = 0; i < checkList.Length; i++)
                        if (checkList[i] == hdc)
                            checkList[i] = hc;
                }
            }
        }

        public HeimdallStatus GetHeimdallStatus(int heimdallId)
        {
            // Since the array starts from 0 and our heimdall count starts from
            // 1, we'll have to adjust the index to fit our array.
            // That's also why we don't let them see the actual array.
            return statusList[heimdallId - 1];
        }

        public HeimdallStatus[] GetHeimdallStatusList()
        {
            // NOTE: Heimdall 1 is in position 0 inside the array!
            return statusList;
        }

        /*** Helper Methods (PRIVATE) ***/
        private HeimdallCheck RunHeimdallCheck(string username, string password)
        {
            HeimdallCheck hc = new HeimdallCheck();
            hc.SetAddress(AppSettings.Address, AppSettings.Port);
            hc.SetLogin(username, password);
            hc.Start();
            nRequestsMade++;
            return hc;
        }

        private bool HasEverything()
        {
            // See if all the heimdalls are accounted for.
            foreach (HeimdallStatus status in statusList)
            {
                // If at least one of them has no hits, then we didn't reach
                // all of them yet.
                if (status.Hits == 0)
                    return false;
            }
            return true;
        }
    }
}
