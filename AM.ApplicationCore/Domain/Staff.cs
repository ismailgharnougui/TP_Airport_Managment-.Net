using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Staff : Passenger
    {

        public string Function { get; set; }
        public DateTime EmployementDate { get; set; }
        [DataType(DataType.Currency)] //une valeur monétaire

        public float Salary { get; set; }

        public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine("i am Staff");

        }
    }
}
