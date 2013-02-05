using System;
using System.Collections.Generic;


namespace Class_UserAgent
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserAgent ua = new UserAgent("localTestApp",Request.UserAgent,Request.UserHostAddress);
            Response.Write("agentString = " + ua.agentString + "<br>");
            Response.Write("osName = " + ua.osName + "<br>");
            Response.Write("Browser = " + ua.browserName + "<br><br>");
            //Response.Write("Date = " + ua.dt + "<br><br>");
            Response.Write("isPhone = " + ua.isPhone.ToString() + "<br>");
            Response.Write("isTablet = " + ua.isTablet.ToString() + "<br>");
            Response.Write("isDesktop = " + ua.isDesktop.ToString() + "<br>");
            Response.Write("isIntelMac = " + ua.isIntelMac.ToString() + "<br>");
            Response.Write("isConsole = " + ua.isConsole.ToString() + "<br><br>");

            Response.Write("isiOS = " + ua.isiOS.ToString() + "<br>");
            Response.Write("isAndroid = " + ua.isAndroid.ToString() + "<br>");
            Response.Write("isKindle = " + ua.isKindle.ToString() + "<br>");
            Response.Write("isXbox = " + ua.isXbox.ToString() + "<br>");
            Response.Write("isPs3 = " + ua.isPs3.ToString() + "<br><br>");
            
            Response.Write("isIE = " + ua.isIE.ToString() + "<br>");
            Response.Write("isFF = " + ua.isFF.ToString() + "<br>");
            Response.Write("isChrome = " + ua.isChrome.ToString() + "<br>");
            Response.Write("isSafari = " + ua.isSafari.ToString() + "<br>");
            Response.Write("isOpera = " + ua.isOpera.ToString() + "<br><br>");

            Response.Write("written to DB = " + ua.writeToDB + "<br>");
            Response.Write("SessionId = " + ua.agentId);

            

        }
    }
}