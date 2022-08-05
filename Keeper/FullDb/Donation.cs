using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keeper
{
    public class Donation
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public string Mode { get; set; }
        public string Purpose { get; set; }
        public string Dated { get; set; }

    }
}
