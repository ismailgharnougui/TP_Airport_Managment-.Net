using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {

        [Key]
        [StringLength(7)]
       // public int Id { get; set; }
        public string PassportNumber { get; set; }

     

   
        [DataType(DataType.Date)]
        [DisplayName("Date Of Birth")]
        public DateTime BirthDate { get; set; }

        [RegularExpression(@"^[0-9]{8}$", ErrorMessage = "Invalid Phone Number!")]
        public int? TelNumber { get; set; }


        [DataType(DataType.EmailAddress)]
        public string? EmailAddress { get; set; }

        public IList<Flight> Flights { get; set; }

        public FullName FullName;

        public bool checkProfile(string nom, string prenom)
            //polymorphisme par signature
        { /*if (FirstName==nom && LastName==prenom) 
            { return true; } return false; }
            */
        return FullName.FirstName ==nom && FullName.LastName ==prenom;
            }
        public bool checkProfile(string nom, string prenom,string email)
        {/*
            if (FirstName == nom && LastName == prenom && EmailAddress==mail)
            { return true; }
            return false;*/
         //  return FirstName == nom && LastName == prenom && EmailAddress==email;
            return checkProfile(nom, prenom) && EmailAddress ==email;

        }

        public bool login (string nom, string prenom,string email=null)
        {
            //if (email != null) { 
            //return checkProfile (nom, prenom,email);
            //        return checkProfile(nom, prenom);

            return email!=null ?checkProfile(nom, prenom,email) : checkProfile(nom,prenom);


        }

        public virtual void PassengerType()
        {
            Console.WriteLine("im passenger");
        }

        public override string ToString()
        {
            return "BirthDate:" + BirthDate + ";"
                + "PassportNumber:" + PassportNumber + ";"
                + "EmailAddress:" + EmailAddress + ";"
                + "FirstName:" + FullName.FirstName + ";"
                + "LastName:" + FullName.LastName + ";"
                + "TelNumber:" + TelNumber;
        }
        public IList<ReservationTicket> ReservationTickets { get; set; }


    }
}
