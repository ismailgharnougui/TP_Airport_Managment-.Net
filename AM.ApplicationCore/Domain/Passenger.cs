using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {


        public string PassportNumber { get; set; }
        public string FirstName { get; set; }
        public int Id { get; set; }
        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }
        public int? TelNumber { get; set; }
        public string? EmailAddress { get; set; }

        public IList<Flight> Flights { get; set; }

        public override string ToString()
        {
            return "FirstName: " + FirstName + " LastName: " + LastName + " date of Birth: " + BirthDate;
        }

        public bool checkProfile(string nom, string prenom)
            //polymorphisme par signature
        { /*if (FirstName==nom && LastName==prenom) 
            { return true; } return false; }
            */
        return FirstName ==nom && LastName ==prenom;
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

    }
}
