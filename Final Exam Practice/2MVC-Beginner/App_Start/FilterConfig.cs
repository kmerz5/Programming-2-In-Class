﻿using System.Web;
using System.Web.Mvc;

namespace _2MVC_Beginner
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}