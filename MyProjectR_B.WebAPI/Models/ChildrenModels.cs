using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectR_B.Recources.DTOs
{
    public class ChildrenModels
    {

       // public int Id { get; set; }
        public string IdChildren { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
       // public UserModels user { get; set; }
        //public UserDTO user2 { get; set; }
        public int IdUser    { get; set; }
        //public int IdUser2 { get; set; }

        public ChildrenModels( string idChidren,string firstName, string lastName, DateTime date, int iduser/*, int iduser2 */)
        {
            this.IdChildren = idChidren;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = date;
            this.IdUser = iduser;
            //this.IdUser2 = iduser2;
        }
        public ChildrenModels()
        {
           
        }

    }
}
