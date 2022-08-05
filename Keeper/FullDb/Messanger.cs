using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Keeper
{
    public class Messanger
    {
        [Key]
        public int id { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string Createdon { get; set; }
        public string Category { get; set; }
    }
}
