using PhoneBooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMvc.Models
{
    public class HomeIndexViewModel
    {
        public string Dayname { get; set; }
        public PhoneBook phoneBook { get; set; }

    }
}
