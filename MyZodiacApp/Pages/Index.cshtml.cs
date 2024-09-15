using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyZodiacApp.Models;
using System;

namespace MyZodiacApp.Pages
{
    public class ZodiacModel : PageModel
    {
        [BindProperty]
        public int Year { get; set; }

        public string ZodiacSign { get; set; }
        public string ErrorMessage { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (Year < 1900 || Year > DateTime.Now.Year + 1)
            {
                ErrorMessage = "Please enter a year between 1900 and the current year.";
                ZodiacSign = null;
            }
            else
            {
                ErrorMessage = null;
                ZodiacSign = Utils.GetZodiac(Year);
            }
        }
    }
}
