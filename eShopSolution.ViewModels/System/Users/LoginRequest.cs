﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.System.Users
{
    public class LoginRequest
    {
        public String UserName { get; set; }
        public String Password { get; set; }
        public bool RememberMe { get; set; }
    }
}