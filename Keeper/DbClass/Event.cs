using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keeper
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string StartDate { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Address { get; set; }
    }
}
