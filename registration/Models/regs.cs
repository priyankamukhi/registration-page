using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace registration.Models
{
    
    public class regs
    {
        sqlconnection con = new sqlconnection(@"Data Source = DESKTOP - 6H8AVCC; Initial Catalog = db; Integrated Security = True; MultipleActiveResultSets=True;Application Name = EntityFramework");
        public int regsid { get; set; }
        public string regsname { get; set; }
        public Int32 regsrollno { get; set; }
        public int regsage { get; set; }
        public string regsemailid { get; set; }
        public Int64 regscontactno { get; set; }
    }
}