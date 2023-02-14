using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///last last last 
namespace MyProjectR_B.Repositories.Entities
{
    public class Children
    {
        public int Id { get; set; }//runing 
        public string IdChildren { get; set; }//tz
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        // public User user2 { get; set; }
        [ForeignKey("user")]
        public int IdU { get; set; }//helping id 
        // public int IdUser2 { get; set; }
         public User user { get; set; }

        public Children(string idchidren, string firstName, string lastName, DateTime date, int iduser/*, int iduser2*/)
        {
           // this.IdUser = id;   
            this.IdChildren = idchidren;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = date;
            this.IdU= iduser;
           // this.IdUser2 = IdUser2;
        }
        public Children()
        {

        }
    }
}
