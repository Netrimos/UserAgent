using System;
using System.Collections.Generic;
using System.Data;
using System.Web;

namespace Class_UserAgent
{
    public class TracysRow
    {
        public string UserAgent { get; set; }
        public bool UserAgent_IsNull { get; set; }
        public int IsCompatible { get; set; }
        public string SystemPlatform { get; set; }
        public string SecurityFlag { get; set; }
        public string OperatingSystem { get; set; }
        public string OperatingSystemVersion { get; set; }
        public string OperatingSystemFamily { get; set; }
        public string BrowserName { get; set; }
        public string BrowserVersion { get; set; }
        public string NETFrameworkVersion { get; set; }
        public int IsMobile { get; set; }
        public int IsAppleWebKit { get; set; }
        public string ApplicationName { get; set; }
        public string ApplicationVersion { get; set; }

    }

    public class Tracy
    {
        TracysRow Row = new TracysRow();

        public TracysRow tracyAgent(string Agent)
        {
            Row.UserAgent_IsNull = false;
            Row.UserAgent = Agent;

            if (Row.UserAgent_IsNull == false)
            {
                ///ApplicationName
                if (Row.UserAgent.IndexOf("Mozilla") >= 0)
                { Row.ApplicationName = "Mozilla"; }
                else if (Row.UserAgent.IndexOf("RMA") >= 0)
                { Row.SystemPlatform = "RMA"; }
                else if (Row.UserAgent.IndexOf("Opera") >= 0)
                { Row.SystemPlatform = "Opera"; }


                /// IsCompatible
                if (Row.UserAgent.IndexOf("compatible") > 0)
                { Row.IsCompatible = 1; }
                else { Row.IsCompatible = 0; }

                /// SystemPlatform
                if (Row.UserAgent.IndexOf("Windows") > 0)
                { Row.SystemPlatform = "Windows"; }
                else if (Row.UserAgent.IndexOf("Macintosh") > 0)
                { Row.SystemPlatform = "Macintosh"; }
                else if (Row.UserAgent.IndexOf("PSP") > 0)
                { Row.SystemPlatform = "PSP"; }
                else if (Row.UserAgent.IndexOf("Playstation") > 0)
                { Row.SystemPlatform = "Playstation"; }
                else if (Row.UserAgent.IndexOf("ubuntu") > 0)
                { Row.SystemPlatform = "Linux"; }
                else if (Row.UserAgent.IndexOf("Linux") > 0)
                { Row.SystemPlatform = "Linux"; }
                else if (Row.UserAgent.IndexOf("Nokia") > 0)
                { Row.SystemPlatform = "Nokia"; }
                else if (Row.UserAgent.IndexOf("iPhone") > 0)
                { Row.SystemPlatform = "Apple"; }
                else if (Row.UserAgent.IndexOf("iPad") > 0)
                { Row.SystemPlatform = "Apple"; }

                ///SecurityFlag
                if (Row.UserAgent.IndexOf(" U;") > 0)
                { Row.SecurityFlag = "U"; }
                else if (Row.UserAgent.IndexOf(" N;") > 0)
                { Row.SecurityFlag = "N"; }
                else if (Row.UserAgent.IndexOf(" I;") > 0)
                { Row.SecurityFlag = "I"; }

                ///OperatingSystem
                if (Row.UserAgent.IndexOf("Windows") > 0)
                { Row.OperatingSystem = "Windows"; }
                else if (Row.UserAgent.IndexOf("Macintosh") > 0)
                { Row.OperatingSystem = "Macintosh"; }
                else if (Row.UserAgent.IndexOf("Linux") > 0)
                { Row.OperatingSystem = "Linux"; }
                else if (Row.UserAgent.IndexOf("Ubuntu") > 0)
                { Row.OperatingSystem = "Linux"; }
                else if (Row.UserAgent.IndexOf("Symbian") > 0)
                { Row.OperatingSystem = "Symbian"; }
                else if (Row.UserAgent.IndexOf("iPhone") > 0)
                { Row.OperatingSystem = "iPhone"; }
                else if (Row.UserAgent.IndexOf("iPad") > 0)
                { Row.OperatingSystem = "iPad"; }

                ///OperatingSystemVersion
                if (Row.UserAgent.IndexOf("Windows NT 6.0") > 0)
                { Row.OperatingSystemVersion = "Windows Vista"; }
                else if (Row.UserAgent.IndexOf("Windows NT 5.1") > 0)
                { Row.OperatingSystemVersion = "Windows XP"; }
                else if (Row.UserAgent.IndexOf("Windows NT 6.1") > 0)
                { Row.OperatingSystemVersion = "Windows 7"; }
                else if (Row.UserAgent.IndexOf("Windows NT") > 0)
                { Row.OperatingSystemVersion = "Windows NT"; }
                else if (Row.UserAgent.IndexOf("Mac OS X") > 0)
                { Row.OperatingSystemVersion = "Mac OS X"; }

                ///OperatingSystemFamily
                if (Row.UserAgent.IndexOf("Windows NT") > 0)
                { Row.OperatingSystemFamily = "Windows"; }
                else if (Row.UserAgent.IndexOf("Mac OS X") > 0)
                { Row.OperatingSystemFamily = "Macintosh"; }
                else if (Row.UserAgent.IndexOf("Playstation") > 0)
                { Row.OperatingSystemFamily = "Sony"; }

                ///LanguageType
                //if (Row.UserAgent.IndexOf("en-us") > 0)
                //{ Row.LanguageType = "EN-US"; }
                //else if (Row.UserAgent.IndexOf(" en") > 0)
                //{ Row.LanguageType = "EN"; }

                ///BrowserName
                if (Row.UserAgent.IndexOf("MSIE") > 0)
                { Row.BrowserName = "Internet Explorer"; }
                else if (Row.UserAgent.IndexOf("Safari") > 0)
                { Row.BrowserName = "Safari"; }
                else if (Row.UserAgent.IndexOf("Firefo") > 0)
                { Row.BrowserName = "Firefox"; }
                else if (Row.UserAgent.IndexOf("Chrome") > 0)
                { Row.BrowserName = "Chrome"; }
                else if (Row.UserAgent.IndexOf("Opera") > 0)
                { Row.BrowserName = "Opera"; }
                else if (Row.UserAgent.IndexOf("Netscape") > 0)
                { Row.BrowserName = "Netscape"; }
                else if (Row.UserAgent.IndexOf("Camino") > 0)
                { Row.BrowserName = "Camino"; }
                else if (Row.UserAgent.IndexOf("SeaMonkey") > 0)
                { Row.BrowserName = "SeaMonkey"; }
                else if (Row.UserAgent.IndexOf("Konqueror") > 0)
                { Row.BrowserName = "Konqueror"; }
                else if (Row.UserAgent.IndexOf("Teleca") > 0)
                { Row.BrowserName = "Netscape"; }
                else if (Row.UserAgent.IndexOf("BrowserNG") > 0)
                { Row.BrowserName = "Nokia"; }
                else if (Row.UserAgent.IndexOf("K-Meleon") > 0)
                { Row.BrowserName = "K-Meleon"; }
                else if (Row.UserAgent.IndexOf("NetFront") > 0)
                { Row.BrowserName = "NetFront"; }
                else if (Row.UserAgent.IndexOf("Boxee") > 0)
                { Row.BrowserName = "Boxee"; }
                else if (Row.UserAgent.IndexOf("Songbird") > 0)
                { Row.BrowserName = "Songbird"; }
                else if (Row.UserAgent.IndexOf("Rekong") > 0)
                { Row.BrowserName = "Rekong"; }
                else if (Row.UserAgent.IndexOf("Lobo") > 0)
                { Row.BrowserName = "Lobo"; }
                else if (Row.UserAgent.IndexOf("X-Smile") > 0)
                { Row.BrowserName = "X-Smile"; }
                else if (Row.UserAgent.IndexOf("Blackbird") > 0)
                { Row.BrowserName = "Blackbird"; }
                else if (Row.UserAgent.IndexOf("iPhone") > 0)
                { Row.BrowserName = "Safari"; }
                else if (Row.UserAgent.IndexOf("iPad") > 0)
                { Row.BrowserName = "Safari"; }
                else if (Row.UserAgent.IndexOf("Mozilla") > 0)
                { Row.BrowserName = "Mozilla"; }
                else if (Row.UserAgent.IndexOf("Playstation") > 0)
                { Row.BrowserName = "Playstation"; }
                else if (Row.UserAgent.IndexOf("RealPlayer") > 0)
                { Row.BrowserName = "RealPlayer"; }


                ///NETFrameworkVersion
                if (Row.UserAgent.IndexOf(".NET CLR 4.5") > 0)
                { Row.NETFrameworkVersion = "4.5"; }
                else if (Row.UserAgent.IndexOf(".NET CLR 4.1") > 0)
                { Row.NETFrameworkVersion = "4.1"; }
                else if (Row.UserAgent.IndexOf(".NET CLR 4.0") > 0)
                { Row.NETFrameworkVersion = "4.0"; }
                else if (Row.UserAgent.IndexOf(".NET CLR 3.5") > 0)
                { Row.NETFrameworkVersion = "3.5"; }
                else if (Row.UserAgent.IndexOf(".NET CLR 3.0") > 0)
                { Row.NETFrameworkVersion = "3.0"; }
                else if (Row.UserAgent.IndexOf(".NET CLR 2.0") > 0)
                { Row.NETFrameworkVersion = "2.0"; }
                else if (Row.UserAgent.IndexOf(".NET CLR 1.0") > 0)
                { Row.NETFrameworkVersion = "1.0"; }

                ///IsMobile
                if (Row.UserAgent.IndexOf("Mobile") > 0)
                { Row.IsMobile = 1; }
                else if (Row.UserAgent.IndexOf("Vodafone") > 0)
                { Row.IsMobile = 1; }
                else if (Row.UserAgent.IndexOf("Blackberry") > 0)
                { Row.IsMobile = 1; }
                else if (Row.UserAgent.IndexOf("iPhone") > 0)
                { Row.IsMobile = 1; }
                else if (Row.UserAgent.IndexOf("iPad") > 0)
                { Row.IsMobile = 1; }
                else if (Row.UserAgent.IndexOf("Nokia") > 0)
                { Row.IsMobile = 1; }
                else if (Row.UserAgent.IndexOf("Samsung") > 0)
                { Row.IsMobile = 1; }

                ///IsAppleWebKit
                if (Row.UserAgent.IndexOf("AppleWebKit") > 0)
                { Row.IsAppleWebKit = 1; }

                ///BrowserVersion
                if (Row.UserAgent.IndexOf("MSIE 7.0") > 0)
                { Row.BrowserVersion = "7.0"; }
                else if (Row.UserAgent.IndexOf("MSIE 8.0") > 0)
                { Row.BrowserVersion = "8.0"; }
                else if (Row.UserAgent.IndexOf("MSIE 9.0") > 0)
                { Row.BrowserVersion = "9.0"; }
                else if (Row.UserAgent.IndexOf("MSIE 6.0") > 0)
                { Row.BrowserVersion = "6.0"; }
                else if (Row.UserAgent.IndexOf("MSIE 4.01") > 0)
                { Row.BrowserVersion = "4.01"; }
                //else if (Row.UserAgent.IndexOf("Firefox/") > 0)
                //{
                //    //if (Row.UserAgent.IndexOf(".") > 0)
                //    //{
                //    //    Console.WriteLine(Row.UserAgent.IndexOf("."));
                //    //    Console.WriteLine(Row.UserAgent.IndexOf("Firefox/"));

                //    //Row.BrowserVersion = Row.UserAgent.Substring(Row.UserAgent.IndexOf("Firefox/") + 8
                //    //    ,((Row.UserAgent.IndexOf(".",Row.UserAgent.IndexOf("Firefox/"))+2) - Row.UserAgent.IndexOf("Firefox/")));
                //    //}
                //    //else
                //    {Row.BrowserVersion = Row.UserAgent.Substring(Row.UserAgent.IndexOf("Firefox/") + 8);}
                //}
                //else if (Row.UserAgent.IndexOf("Safari/") > 0)
                //{ Row.BrowserVersion = Row.UserAgent.Substring(Row.UserAgent.IndexOf("Safari/") + 7,1); }
                //else if (Row.UserAgent.IndexOf("Netscape/") > 0)
                //{ Row.BrowserVersion = Row.UserAgent.Substring(Row.UserAgent.IndexOf("Netscape/") + 9,1); }
                //else if (Row.UserAgent.IndexOf("BrowserNG/") > 0)
                //{ Row.BrowserVersion = Row.UserAgent.Substring(Row.UserAgent.IndexOf("BrowserNG/") + 10,1); }
                //else if (Row.UserAgent.IndexOf("K-Meleon/") > 0)
                //{ Row.BrowserVersion = Row.UserAgent.Substring(Row.UserAgent.IndexOf("K-Meleon/") + 9,1); }
                //else if (Row.UserAgent.IndexOf("SeaMonkey/") > 0)
                //{ Row.BrowserVersion = Row.UserAgent.Substring(Row.UserAgent.IndexOf("SeaMonkey/") + 10,1); }

                ///ApplicationVersion
                //if (Row.UserAgent.IndexOf("Mozilla/") > 0)
                //{ Row.ApplicationVersion = Row.UserAgent.Substring(Row.UserAgent.IndexOf("Mozilla/") + 8,1); }
                //else if (Row.UserAgent.IndexOf("RMA/") > 0)
                //{ Row.ApplicationVersion = Row.UserAgent.Substring(Row.UserAgent.IndexOf("RMA/") + 4, 1); }
                //else if (Row.UserAgent.IndexOf("Opera/") > 0)
                //{ Row.ApplicationVersion = Row.UserAgent.Substring(Row.UserAgent.IndexOf("Opera/") + 6, 1); }

                
            }
            return Row;
        }
    }
}