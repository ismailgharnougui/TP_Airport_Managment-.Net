
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{   //cettte classe doit etre de type complexe 
   // [Owned]
    public class FullName
    {
        [MinLength(3, ErrorMessage = "MinLength 3")]
        [MaxLength(25, ErrorMessage = "MaxLength 25")]
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
