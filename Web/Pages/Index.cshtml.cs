using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using PhoneBooks;


namespace Web.Pages
{
    public class IndexModel : PageModel
    {
        public string Dayname { get; set; }
        public PhoneBook phoneBook { get; set; }

        public void OnGet()
        {
            ViewData["Title"] = "Информация телефонной книжки";
            var jset = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };
            var s = System.IO.File.ReadAllText("phoneBook.json");
            phoneBook = JsonConvert.DeserializeObject<PhoneBook>(s, jset);

            Dayname = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }
    }
}
