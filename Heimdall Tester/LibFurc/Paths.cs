/*
 *** Furcadia Paths and Location - Furcadia Library
 *
 * Copyright (c) 2009 by IceDragon of QuickFox.org - All rights reserved.
 * 
 * <icedragon@quickfox.org>
 * http://www.icerealm.org/
 * 
 * This file contains functions and settings for detection and location
 * of Furcadia files and the paths they are stored in.
 */

using System;
using System.IO;
using Microsoft.Win32;

namespace Furcadia
{
    public class Paths
    {
        // Storing localdir upon class generation so the information is cached.
        // Otherwise, each property would have to look up localdir separately.
        private static string sLocaldirPath = GetFurcadiaLocaldirPath();

        public static bool UsingLocaldir
        {
            get { return (sLocaldirPath != null); }
        }

        //--- FURCADIA PERSONALIZED FILES -----------------------------------//

        /// <summary>
        /// Personal data path - contains user-specific files such as logs,
        /// patches, screenshots and character files.
        ///
        /// Default: My Documents\Furcadia\
        /// </summary>
        public static string PersonalDataPath
        {
            get
            {
                return (UsingLocaldir) ? sLocaldirPath : DefaultPersonalDataPath;
            }
        }
        public static string DefaultPersonalDataPath
        {
            get
            {
                return System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                    @"\Furcadia";
            }
        }

        /// <summary>
        /// Character file path - contains furcadia.ini files with login
        /// information for each character.
        /// 
        /// Default: My Documents\Furcadia\Furcadia Characters\
        /// </summary>
        public static string CharacterPath
        {
            get
            {
                return (UsingLocaldir) ? sLocaldirPath : DefaultCharacterPath;
            }
        }
        public static string DefaultCharacterPath
        {
            get
            {
                return DefaultPersonalDataPath + @"\Furcadia Characters";
            }
        }

        /// <summary>
        /// Dreams path - contains Furcadia dreams made by the player.
        /// 
        /// Default: My Documents\Furcadia\Dreams
        /// </summary>
        public static string DreamsPath
        {
            get
            {
                return (UsingLocaldir) ? sLocaldirPath : DefaultDreamsPath;
            }
        }
        public static string DefaultDreamsPath
        {
            get
            {
                return DefaultPersonalDataPath + @"\Dreams";
            }
        }

        /// <summary>
        /// Logs path - contains session logs for each character and a
        /// subfolder with whisper logs, should Pounce be enabled.
        /// 
        /// Default: My Documents\Furcadia\Logs
        /// </summary>
        public static string LogsPath
        {
            get
            {
                return (UsingLocaldir) ? sLocaldirPath + @"\logs" : DefaultLogsPath;
            }
        }
        public static string DefaultLogsPath
        {
            get
            {
                return DefaultPersonalDataPath + @"\Logs";
            }
        }

        /// <summary>
        /// Whisper logs path - contains whisper logs for each character
        /// whispered, recorded by Pounce with the whisper windows.
        /// 
        /// Default: My Documents\Furcadia\Logs\Whispers
        /// </summary>
        public static string WhisperLogsPath
        {
            get
            {
                return (UsingLocaldir) ? LogsPath + @"\whispers" : DefaultWhisperLogsPath;
            }
        }
        public static string DefaultWhisperLogsPath
        {
            get
            {
                return DefaultLogsPath + @"\Whispers";
            }
        }

        /// <summary>
        /// Screenshots path - contains screen shot files taken by Furcadia
        /// with the CTRL+F1 hotkey. At the time of writing, in PNG format.
        /// 
        /// Default: My Documents\Furcadia\Screenshots
        /// </summary>
        public static string ScreenshotsPath
        {
            get
            {
                return (UsingLocaldir) ? sLocaldirPath + @"\screenshots" : DefaultScreenshotsPath;
            }
        }
        public static string DefaultScreenshotsPath
        {
            get
            {
                return DefaultPersonalDataPath + @"\Screenshots";
            }
        }

        /// <summary>
        /// Local skins path - contains Furcadia skins used locally by each
        /// user.
        /// 
        /// Default: My Documents\Furcadia\Skins
        /// </summary>
        public static string LocalSkinsPath
        {
            get
            {
                return (UsingLocaldir) ? sLocaldirPath + @"\skins" : DefaultLocalSkinsPath;
            }
        }
        public static string DefaultLocalSkinsPath
        {
            get
            {
                return DefaultPersonalDataPath + @"\Skins";
            }
        }


        //--- FURCADIA CACHE ------------------------------------------------//

        /// <summary>
        /// Cache path - contains all the Furcadia cache and resides in the
        /// global user space.
        /// 
        /// Default: %ALLUSERSPROFILE%\Dragon's Eye Productions\Furcadia
        /// </summary>
        public static string CachePath
        {
            get
            {
                return (UsingLocaldir) ? sLocaldirPath + @"\tmp" : DefaultCachePath;
            }
        }
        public static string DefaultCachePath
        {
            get
            {
                return System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) +
                    @"\Dragon's Eye Productions\Furcadia";
            }
        }

        /// <summary>
        /// Permanent Maps cache path - contains downloaded main maps such as
        /// the festival maps or other DEP-specific customized dreams.
        /// 
        /// Default: %ALLUSERSPROFILE%\Dragon's Eye Productions\Furcadia\Permanent Maps
        /// </summary>
        public static string PermanentMapsCachePath
        {
            get
            {
                return (UsingLocaldir) ? sLocaldirPath + @"\maps" : DefaultPermanentMapsCachePath;
            }
        }
        public static string DefaultPermanentMapsCachePath
        {
            get
            {
                return DefaultCachePath + @"\Permanent Maps";
            }
        }

        /// <summary>
        /// Portrait cache path - contains downloaded portraits and desctags
        /// cache for faster loading and bandwidth optimization.
        /// 
        /// Default: %ALLUSERSPROFILE%\Dragon's Eye Productions\Furcadia\Portrait Cache
        /// </summary>
        public static string PortraitCachePath
        {
            get
            {
                return (UsingLocaldir) ? sLocaldirPath + @"\portraits" : DefaultPortraitCachePath;
            }
        }
        public static string DefaultPortraitCachePath
        {
            get
            {
                return DefaultCachePath + @"\Portrait Cache";
            }
        }

        /// <summary>
        /// Temporary dreams path - contains downloaded player dreams for
        /// subsequent loading.
        /// 
        /// Default: %ALLUSERSPROFILE%\Dragon's Eye Productions\Furcadia\Temporary Dreams
        /// </summary>
        public static string TemporaryDreamsPath
        {
            get
            {
                return (UsingLocaldir) ? CachePath : DefaultTemporaryDreamsPath;
            }
        }
        public static string DefaultTemporaryDreamsPath
        {
            get
            {
                return DefaultCachePath + @"\Temporary Dreams";
            }
        }

        /// <summary>
        /// Temporary files path - contains downloaded and uploaded files that
        /// are either used to upload packages or download them for extraction.
        /// 
        /// Default: %ALLUSERSPROFILE%\Dragon's Eye Productions\Furcadia\Temporary Files
        /// </summary>
        public static string TemporaryFilesPath
        {
            get
            {
                return (UsingLocaldir) ? CachePath : DefaultTemporaryFilesPath;
            }
        }
        public static string DefaultTemporaryFilesPath
        {
            get
            {
                return DefaultCachePath + @"\Temporary Files";
            }
        }

        /// <summary>
        /// Temporary patch path - contains downloaded temporary patches. This
        /// technology is never in use, yet supported, so this folder is always
        /// empty.
        /// 
        /// Default: %ALLUSERSPROFILE%\Dragon's Eye Productions\Furcadia\Temporary Patches
        /// </summary>
        public static string TemporaryPatchesPath
        {
            get
            {
                return (UsingLocaldir) ? CachePath : DefaultTemporaryPatchesPath;
            }
        }
        public static string DefaultTemporaryPatchesPath
        {
            get
            {
                return DefaultCachePath + @"\Temporary Patches";
            }
        }

        /// <summary>
        /// LocalDir path - a specific path where all the player-specific and
        /// cache data is stored in its classic form. Used mainly to retain
        /// the classic path structure or to run Furcadia from a removable
        /// disk.
        /// </summary>
        public static string LocaldirPath
        {
            get
            {
                return GetFurcadiaLocaldirPath();
            }
        }


        //--- FURCADIA PERSONALIZED SETTINGS --------------------------------//

        /// <summary>
        /// Personal settings path - contains all the Furcadia settings for
        /// each user that uses it.
        /// 
        /// Default (VISTA+): %USERPROFILE%\Local\AppData\Dragon's Eye Productions\Furcadia
        /// </summary>
        public static string SettingsPath
        {
            get
            {
                return (UsingLocaldir) ? sLocaldirPath + @"\settings" : DefaultSettingsPath;
            }
        }
        public static string DefaultSettingsPath
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) +
                    @"\Dragon's Eye Productions\Furcadia";
            }
        }

        //--- FURCADIA PROGRAM FILES ----------------------------------------//

        /// <summary>
        /// Default Furcadia install folder - this path is used by default to
        /// install Furcadia to.
        /// 
        /// Default: c:\Program Files\Furcadia
        /// </summary>
        public static string DefaultFurcadiaPath
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) +
                    @"\Furcadia";
            }
        }

        /// <summary>
        /// Furcadia install path - this path corresponds to the path where
        /// Furcadia is installed on the current machine. If Furcadia is
        /// not found, this property will be null.
        /// </summary>
        public static string FurcadiaPath
        {
            get
            {
                return GetFurcadiaInstallPath();
            }
        }

        /// <summary>
        /// Furcadia Localdir path - this path (when explicitly set), indicates
        /// the whereabouts of the data files used in Furcadia. If localdir.ini
        /// is present in the Furcadia folder, Furcadia.exe will load those
        /// files from the specific path and not the regular ones.
        /// 
        /// Default: -NONE-
        /// </summary>
        public static string FurcadiaLocaldirPath
        {
            get
            {
                return GetFurcadiaLocaldirPath();
            }
        }

        /// <summary>
        /// Path to the default patch (graphics, sounds, layout) folder used
        /// to display Furcadia itself, its tools and environment.
        /// 
        /// Default: c:\Program Files\Furcadia\patches\default
        /// </summary>
        public static string DefaultPatchPath
        {
           get
           {
               return GetDefaultPatchPath();
           }
        }

        /// <summary>
        /// Path to the global skins that change Furcadia's graphical layout.
        /// They are stored in the Furcadia program files folder.
        /// 
        /// Default: c:\Program Files\Furcadia\skins
        /// </summary>
        public static string GlobalSkinsPath
        {
            get
            {
                string path = FurcadiaPath;
                return (path != null) ? path + @"\skins" : null;
            }
        }
        public static string DefaultGlobalSkinsPath
        {
            get
            {
                return DefaultFurcadiaPath + @"\skins";
            }
        }

        /// <summary>
        /// Path to the global maps, distributed with Furcadia and loadable
        /// during gameplay in some main dreams.
        /// 
        /// Default: c:\Program Files\Furcadia\maps
        /// </summary>
        public static string GlobalMapsPath
        {
            get
            {
                string path = FurcadiaPath;
                return (path != null) ? path + @"\maps" : null;
            }
        }
        public static string DefaultGlobalMapsPath
        {
            get
            {
                return DefaultFurcadiaPath + @"\maps";
            }
        }


        //--- Static Functions ---//
        /// <summary>
        /// Find the path to Furcadia data files currently installed on this
        /// system.
        /// </summary>
        /// <returns>Path to the Furcadia program folder or null if not found/not installed.</returns>
        public static string GetFurcadiaInstallPath()
        {
            string path;

            // Checking registry for a path first of all.
            RegistryKey regkey = Registry.LocalMachine;
            try
            {
                regkey = regkey.OpenSubKey(@"SOFTWARE\Dragon's Eye Productions\Furcadia\Programs", false);
                path = regkey.GetValue("Path").ToString();
                regkey.Close();
                if (System.IO.Directory.Exists(path))
                    return path; // Path found
            }
            catch
            {
            }

            // Making a guess from the FurcadiaDefaultPath property.
            path = DefaultFurcadiaPath;
            if (System.IO.Directory.Exists(path))
                return path; // Path found

            // All options were exhausted - assume Furcadia not installed.
            return null ;
        }

        /// <summary>
        /// Find the current localdir path where data files would be stored
        /// on the current machine.
        /// </summary>
        /// <returns>Path to the data folder from localdir.ini or null if not found.</returns>
        public static string GetFurcadiaLocaldirPath()
        {
            string path;
            string install_path = FurcadiaPath;

            sLocaldirPath = null; // Reset in case we don't find it.

            // If we can't find Furc, we won't find localdir.ini
            if (install_path == null)
                return null; // Furcadia install path not found.

            // Try to locate localdir.ini
            string ini_path = String.Format("{0}\\localdir.ini", install_path);
            if (!System.IO.File.Exists(ini_path))
                return null; // localdir.ini not found - regular path structure applies.

            // Read localdir.ini for remote path and verify it.
            StreamReader sr = new StreamReader(ini_path);
            path = sr.ReadLine();
            path.Trim();
            sr.Close();

            if (!System.IO.Directory.Exists(path))
                return null; // localdir.ini found, but the path in it is missing.

            sLocaldirPath = path; // Cache for the class use.

            return sLocaldirPath; // Localdir path found!
        }

        /// <summary>
        /// Find the path to the default patch folder on the current machine.
        /// </summary>
        /// <returns>Path to the default patch folder or null if not found.</returns>
        public static string GetDefaultPatchPath()
        {
            string path;

            // Checking registry for a path first of all.
            RegistryKey regkey = Registry.LocalMachine;
            try
            {
                regkey = regkey.OpenSubKey(@"SOFTWARE\Dragon's Eye Productions\Furcadia\Patches", false);
                path = regkey.GetValue("default").ToString();
                regkey.Close();
                if (System.IO.Directory.Exists(path))
                    return path; // Path found
            }
            catch
            {
            }

            // Making a guess from the FurcadiaPath or FurcadiaDefaultPath property.
            path = FurcadiaPath;
            if (path == null)
                path = DefaultFurcadiaPath;

            path += @"\patches\default";

            if (System.IO.Directory.Exists(path))
                return path; // Path found

            // All options were exhausted - assume Furcadia not installed.
            return null;
        }
    }
}