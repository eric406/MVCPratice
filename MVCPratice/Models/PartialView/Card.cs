using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPratice.Models.PartialView
{
    public class Card
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brief { get; set; }
        public string Photo { get; set; }
        public string WikiUrl { get; set; }
    }
}
