using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PieShop.Models;

namespace PieShop.ViewModel
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PieOfTheWeek { get; set; }
    }
}
