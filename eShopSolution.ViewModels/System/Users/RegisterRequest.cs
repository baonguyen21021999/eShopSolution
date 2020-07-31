﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eShopSolution.ViewModels.System.Users
{
    public class RegisterRequest
    {
        [Display(Name = "Tên")]
        public String FirstName { get; set; }
        [Display(Name = "Họ")]
        public String LastName { get; set; }
        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }
        [Display(Name = "Hòm thư")]
        public String Email { get; set; }
        [Display(Name = "Số diện thoại")]
        public String PhoneNumber { get; set; }
        [Display(Name = "Tài khoản")]
        public String UserName { get; set; }
        [Display(Name = "Mật khẩu")]
        [DataType(DataType.Password)]
        public String Password { get; set; }
        [Display(Name = "Xác nhận mật khẩu")]
        [DataType(DataType.Password)]
        public String ConfirmPassword { get; set; }
    }
}
