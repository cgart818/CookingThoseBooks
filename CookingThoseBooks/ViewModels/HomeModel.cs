using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CookingThoseBooks.ViewModels
{
    public class HomeModel : PageModel
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
