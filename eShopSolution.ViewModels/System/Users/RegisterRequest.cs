using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.System.Users
{
    public class RegisterRequest
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime Dob { get; set; }
        public String Email { get; set; }
        public String PhoneNumber { get; set; }
        public String UserName { get; set; }

        public String Password { get; set; }
        public String CofirmPassword { get; set; }
    }
}
