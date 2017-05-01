using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OpenDoors
{
    public static class DeviceHelper
    {
        public static Boolean IsMobileOrTablet(this HtmlHelper helper, HttpRequestBase request)
        {
            string strUserAgent = request.UserAgent.ToString().ToLower();
            if (strUserAgent != null)
            {
                if (request.Browser.IsMobileDevice == true || strUserAgent.Contains("iphone") ||
                    strUserAgent.Contains("blackberry") || strUserAgent.Contains("mobile") ||
                    strUserAgent.Contains("windows ce") || strUserAgent.Contains("opera mini") ||
                    strUserAgent.Contains("palm") || strUserAgent.Contains("android"))
                {
                    return true;
                }
            }
            return false;
        }
    }
}