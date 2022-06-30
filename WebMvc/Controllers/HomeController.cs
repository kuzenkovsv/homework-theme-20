using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebMvc.Models;
using PhoneBooks;
using Newtonsoft.Json;

namespace WebMvc.Controllers
{
    public class HomeController : Controller
    {
        private PhoneBook pb;
        private Contact cont;

        public HomeController()
        {
            var jset = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };
            var s = System.IO.File.ReadAllText("phoneBook.json");
            pb = JsonConvert.DeserializeObject<PhoneBook>(s, jset);
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Информация телефонной книжки";
            var model = new HomeIndexViewModel
            {
                Dayname = DateTime.Now.ToString("dddd, dd MMMM yyyy"),
                phoneBook = pb
            };
            return View(model);
        }

        public IActionResult ContactDetail(int? id)
        {
            ViewData["Message"] = "Данные контакта";

            foreach (var item in pb.Contacts)
            {
                if (id == item.Id)
                {
                    cont = item;
                }
            }

            var model = new ContactDetailsViewModel
            {
                Dayname = DateTime.Now.ToString("dddd, dd MMMM yyyy"),
                Item = cont
            };

            return View(model);
        }

    }
}
