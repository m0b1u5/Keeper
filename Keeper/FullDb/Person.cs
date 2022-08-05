using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keeper
{
    public class Person
    {
        
        public int id { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public string Minister { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Occupation { get; set; }

        public int FamilyID { get; set; }
    }
}
