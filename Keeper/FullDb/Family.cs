using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keeper
{
    public class Family
    {
       
        public int Id { get; set; }        
        public int FamilyID { get; set; }

        public string Reference { get; set; }
        public string Refecence2 { get; set; }
        public string Refecence3 { get; set; }
        public string Refecence4 { get; set; }
        public string Refecence5 { get; set; }
        public string Refecence6 { get; set; }
        public string Refecence7 { get; set; }
    }



    }
