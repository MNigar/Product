using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApp.Utils
{
    public class BookDataController : Controller
    {
        public string RecipeDate(DateTime date1, DateTime date2)
        {
            var date = date1 - date2;
            if (date.TotalMinutes < 60 && date.TotalHours < 1 && date.TotalDays < 1)
            {
                var minutes = string.Format("{0:0}", date.TotalMinutes);
                ViewData["Date"] = minutes + "minutes";
            }
            if (date.TotalMinutes > 60 && date.TotalHours > 0 && date.TotalDays < 1)
            {
                var hours= string.Format("{0:0}", date.TotalHours);
                ViewData["Date"] = hours + "hours";
            }
            if (date.TotalDays > 1)
            {
                ViewData["Date"] = date.TotalDays.ToString().Split('.')[0] + "days";
            }
            return ViewBag.Date;
        }
    }
}
