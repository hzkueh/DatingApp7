using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class UserDto
    {
        public string Username {get;set;}

        public string Token {get;set;}
        public string PhotoUrl {get;set;}

    }
}