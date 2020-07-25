using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingThoseBooks.ViewModels
{
    public class HomeModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        [ViewData]
        public string Title { get; set; }

        public void OnGet()
        {
            Title = "Index";
        }

        public int Number { get; set; }
        
        public int AddingNumbers ()
        {
            Number = 69;
            Number++;
            return Number;
        }

    }
}
