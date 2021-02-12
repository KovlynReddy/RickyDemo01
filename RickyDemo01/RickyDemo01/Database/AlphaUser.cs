using System;
using System.Collections.Generic;
using System.Text;


namespace RickyDemo01.Database
{
    public class AlphaUser
   
    {

        public int ID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return $"Name : {UserName}  Email : {Email}";
        }
    }
}
