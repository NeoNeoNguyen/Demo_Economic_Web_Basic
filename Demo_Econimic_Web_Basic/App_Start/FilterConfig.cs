﻿using System.Web;
using System.Web.Mvc;

namespace Demo_Econimic_Web_Basic
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
