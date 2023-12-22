using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User
    {
         public int UserId { get; set; }
        public string Name { get; set; } = String.Empty;  
         public string Email { get; set; }= String.Empty;

        public string Phone { get; set; }= String.Empty;
        public string Password { get; set; }=String.Empty;
        public DateTime Created { get; set; }= DateTime.Now;
       
            
    }
}
