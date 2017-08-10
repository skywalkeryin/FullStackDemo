﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.Models.Models
{
    class StudentAddress
    {
       
        
            //[Key, ForeignKey("Student")]
            public int StudentId { get; set; }

            public string Address1 { get; set; }
            public string Address2 { get; set; }
            public string City { get; set; }
            public int Zipcode { get; set; }
            public string State { get; set; }
            public string Country { get; set; }

            public virtual Student Student { get; set; }
        
    }
}
