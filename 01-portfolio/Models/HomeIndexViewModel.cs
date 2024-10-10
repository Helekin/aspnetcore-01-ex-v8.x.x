using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_portfolio.Models
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Project>? Projects { get; set; }
    }
}