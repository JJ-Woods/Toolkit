/**********************************************\
 *ENGINEER REGISTRY UPDATER                    *
 *Version: 1.0.0                               *
 *Written for: Snap-On Diagnostics             *
 *Written by: Jamie Woods                      *
 *On: 08/04/2014                               *
 *                                             *
 *Data Version: 1                              *
 *Updated: 08/04/2014                          *
 \*********************************************/


namespace RegUpdater {

    public class InternalData {

        //Data store for the update shortcut field
        public static string[][] locationData = {
            new string[]{
                "Brake Tester",
                @"SOFTWARE\Snap-On Technologies Inc.\Sun Diagnostic Platform\Gas Analyser Settings\",
                "Testlane EXE Path",
                "Testlane Program Path"
                },
            new string[]{
                "Wheel Alignment",
                @"SOFTWARE\Snap-On Technologies Inc.\Sun Diagnostic Platform\Gas Analyser Settings\",
                "Alignment EXE Path",
                "Alignment Program Path"
                }
            };

        //Data store for the update option field
        public static string[][] optionData = {
                new string[]{
                    "John Bean",
                    "Brake Tester",
                    @"C:\bde40w3\bde40w4.EXE",
                    @"C:\Document and Settings\All Users\Start Menu\Programs\johnbean\johnbean",
                    @"C:\bde40w3\bde40w4.EXE",
                    @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\johnbean\johnbean"
                },
                new string[]{
                    "Hoffman",
                    "Brake Tester",
                    @"C:\safelane\safelane.EXE",
                    @"C:\Document and Settings\All Users\Start Menu\Programs\hofmann\hofmann",
                    @"C:\safelane\safelane.EXE",
                    @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\hofmann\hofmann"
                },
                new string[]{
                    "Sun - VIC3000",
                    "Brake Tester",
                    @"C:\VIC3000\VIC3000.EXE",
                    @"C:\Documents and Settings\All Users\Start Menu\Programs\VIC3000\vic3000",
                    @"C:\VIC3000\VIC3000.EXE",
                    @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\VIC3000\VIC3000"
                },
                new string[]{
                    "Snap-On - ATL",
                    "Brake Tester",
                    @"C:\Snapon-ATL\bde40w4.exe",
                    @"C:\Documents and Settings\All Users\Start Menu\Programs\snapon atl\atl",
                    @"C:\Snapon-ATL\bde40w4.exe",
                    @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\snapon atl\atl"
                },
                new string[]{
                    "Snap-On - RP",
                    "Brake Tester",
                    @"!",
                    @"!",
                    @"C:\program files\RP-Visualization\visualization.exe",
                    @"C:\program files\RP-Visualization\visualization.exe"
                },
                new string[]{
                    "Version 7.3",
                    "Wheel Alignment",
                    "!",
                    "!",
                    @"C:\program files\Snap-on technologies inc.\thundercloud\thundercloud.exe",
                    @"C:\users\public\desktop\pro42"
                },
                new string[]{
                    "Version 7.5",
                    "Wheel Alignment",
                    "!",
                    "!",
                    @"C:\program files\Snap-on technologies inc.\thundercloud\pro42.exe",
                    @"C:\users\public\desktop\pro42"
                },
            };

        //Data store for the operating system field
        public static string[] opSysData = {
            "Windows XP",
            "Windows 7"
        };
    }
}
