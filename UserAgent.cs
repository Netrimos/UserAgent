using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Class_UserAgent
{
    public class UserAgent
    {
        public string jsonAgent;
        public string applicationName;
        public string agentString, ipAddress, osName, deviceName, browserName, browserBuild, osVersion;
        public bool isTablet, isPhone, isDesktop, isXbox, isPs3, isiOS, isAndroid, isIntelMac, isBB, isKindle, isConsole;
        public bool isIE, isFF, isChrome, isSafari, isOpera;
        public bool writeToDB;
        public Guid agentId;
        //public DateTime dt;

        public UserAgent(string appName, string userAgentString, string userIpAddress) {
            applicationName = appName;
            ipAddress = userIpAddress;
            agentString = userAgentString;
            userAgentString = userAgentString.ToLower();
//OS Detect
            if (userAgentString.IndexOf("windows") != -1){
                isDesktop = true;
                deviceName = "Windows Desktop";
                osName = "Windows";
            }
            else if (userAgentString.IndexOf("ubuntu") != -1){
                isDesktop = true;
                deviceName = "Linux Desktop";
                osName = "Ubuntu";
            }
            else if (userAgentString.IndexOf("silk") != -1 || userAgentString.IndexOf("kindle") != -1) { } //Duplicate used to block Macintosh
            else if (userAgentString.IndexOf("macintosh") != -1){
                isDesktop = true;
                deviceName = "Mac Desktop";
                osName = "Macintosh";
                if (userAgentString.IndexOf("intel") != -1) isIntelMac = true;
            }
            else if (userAgentString.IndexOf("blackberry") != -1){
                isBB = true;
                isPhone = true;
            }
            else if (userAgentString.IndexOf("xbox") != -1)
            {
                isXbox = true;
                isConsole = true;
            }
            else if (userAgentString.IndexOf("playstation") != -1)
            {
                isPs3 = true;
                isConsole = true;
            }


//Device Detect
            if (userAgentString.IndexOf("ipad") != -1) {
                isiOS = true;
                isTablet = true;
                osName = "iOS";
                deviceName = "iPad";
            }
            else if (userAgentString.IndexOf("iphone") != -1){
                isiOS = true;
                isPhone = true;
                osName = "iOS";
                deviceName = "iPhone";
            }
            else if (userAgentString.IndexOf("kindle") != -1){
                isKindle = true;
                isTablet = true;
                osName = "Linux";
                deviceName = "Kindle";
            }
            else if (userAgentString.IndexOf("silk") != -1){
                isKindle = true;
                isTablet = true;
                osName = "Linux";
                deviceName = "Kindle";
            }
            else if (userAgentString.IndexOf("android") != -1){
                osName = "Linux";
                deviceName = "Android";
                isAndroid = true;
                if (userAgentString.IndexOf("mobile") != -1) isPhone = true;
                else isTablet = true;
            }
            
//Browser Detect            
            if (userAgentString.IndexOf("msie") != -1){
                isIE = true;
                browserName = "MSIE";
            }
            else if (userAgentString.IndexOf("firefox") != -1){
                isFF = true;
                browserName = "FireFox";
            }
            else if (userAgentString.IndexOf("opera") != -1){
                isOpera = true;
                browserName = "Opera";
            }
            else if (userAgentString.IndexOf("android") != -1){ //Android has Safari in it, so it needs to go first
                browserName = "Android";
                //in device?
            }
            else if (userAgentString.IndexOf("chrome") != -1 || userAgentString.IndexOf("crios") != -1)
            { //Chrome has Safari in it, so it needs to go first
                browserName = "Chrome";
                isChrome = true;
            }
            else if (userAgentString.IndexOf("silk") != -1 || userAgentString.IndexOf("kindle") != -1) { //Duplicate used to block safari
                browserName = "Silk";
            }

            else if (userAgentString.IndexOf("safari") != -1){
                isSafari = true;
                browserName = "Safari";
            }

            writeAgentToDb();
        }

        public void writeAgentToDb() {
            MySqlConnection conn = new MySqlConnection("Server=192.168.210.101;Database=Users;Uid=sa;Pwd=WencyLee1699");
            //MySqlConnection conn = new MySqlConnection("Server=10.0.1.210;Database=User;Uid=root;Pwd=");
            //MySqlConnection conn = new MySqlConnection("Server=192.168.210.126;Database=Users;Uid=sa;Pwd=wlee1699");
            MySqlCommand cmd;
            
            
            agentId = Guid.NewGuid();
            //dt = DateTime.UtcNow;

            string query = "INSERT INTO userAgent ";
            query += "(applicationName, agentGuid, agentString, ipAddress, osName, deviceName, browserName, browserBuild, osVersion, ";
            query += "isTablet, isPhone, isDesktop, isXbox, isPs3, isiOS, isAndroid, isIntelMac, isBB, isKindle, isConsole, ";
            query += "isIE, isFF, isChrome, isSafari, isOpera, timestamp) ";
            query += "VALUES ('" + applicationName + "', '"+agentId + "', '" + agentString + "', '" + ipAddress + "', '" + osName + "', '" + deviceName + "', '" + browserName +"', '"+ browserBuild + "', '" + osVersion + "', ";
            query += isTablet + ", " + isPhone + ", " + isDesktop + ", " + isXbox + ", " + isPs3 + ", " + isiOS + ", " + isAndroid + ", " + isIntelMac + ", " + isBB + ", " + isKindle + ", " + isConsole + ", ";
            query += isIE + ", " + isFF + ", " + isChrome + ", " + isSafari + ", " + isOpera + ", NOW())";
           
           try
           {
                conn.Open();
                cmd = conn.CreateCommand();
                //dt = DateTime.UtcNow;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                writeToDB = true;
               
           }
            catch (Exception) {
                writeToDB = false;

           }
            conn.Close();
        }
    }
}
