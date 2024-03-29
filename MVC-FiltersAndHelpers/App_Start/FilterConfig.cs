﻿using MVC_FiltersAndHelpers.Models.Filters;
using System.Web;
using System.Web.Mvc;

namespace MVC_FiltersAndHelpers
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new LogActionFilter());
        }
    }
}
