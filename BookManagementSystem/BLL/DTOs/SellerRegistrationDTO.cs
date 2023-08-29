﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class SellerRegistrationDTO
    {
        public int Id { get; set; }
        public string uname { get; set; }
        public string gender { get; set; }
        public System.DateTime DOB { get; set; }
        public string phone { get; set; }
        public string user_type { get; set; }
        public string shop_name { get; set; }
        public string password { get; set; }
    }
}
