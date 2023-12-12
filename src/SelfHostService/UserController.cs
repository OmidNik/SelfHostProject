using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SelfHostService
{
    public class UsersController : ApiController
    {
        private List<User> Users = new List<User> {
            new User{ ID=1, City="Tehran", Email="Omid@gmail.com", Name="Omid", Phone="091234567891"},
            new User{ ID=2, City="Yaz", Email="Omid@hotmail.com", Name="Sepehr", Phone="091234567891"},
            new User{ ID=3, City="Rasht", Email="Omid@Yahoo.com", Name="Morteza", Phone="091234567891"},
        };

        [HttpGet]
        public IEnumerable<User> GetUsers()
        {
            return Users;
        }
    }


    public class User
    {
        public int ID { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public string Email { get; set; }
        [MaxLength(11)]
        public string Phone { get; set; }
        [MaxLength(50)]
        public string City { get; set; }
    }



}
