using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectR_B.Repositories.Entities
{
    public class User
    {
        public int Id { get; set; }//runing
        public string IdUser { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Min { get; set; }
        public string HMO { get; set; }
       // public List<Children> Childrens { get; set; }
        public User(/*int id,*/ string idUser, string firstName, string lastName, DateTime dateOfBirth, string min, string hmd/*,Children c=null*/)
        {
            //this.Id = id;   
            this.IdUser = idUser;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Min = min;
            this.HMO = hmd;
            //Childrens = new List<Children>((IEnumerable<Children>)c);
        }
        public User()
        {

        }
    }
}
