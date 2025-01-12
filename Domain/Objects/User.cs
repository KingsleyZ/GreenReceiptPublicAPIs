﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Objects
{
    public class User : Base
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Username { get; set; }

        public UserRole Role { get; set; }

        public virtual ICollection<Receipt> Receipts { get; set; }

        public User()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
            Password = string.Empty;
            Username = string.Empty;
        }

        public override bool PreSave()
        {
            return true;
        }

        public override bool PreUpdate()
        {
            return true;
        }
    }
}
