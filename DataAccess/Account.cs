﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Account
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public Boolean Gender { get; set; }
        public DateTime Birth { get; set; }
    }
}