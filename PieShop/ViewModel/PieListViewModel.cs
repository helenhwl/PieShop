using PieShop.Models;
using System.Collections.Generic;

namespace PieShop.ViewModel
{
    public class PieListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string CurrentCategory { get; set; }
    }
}
