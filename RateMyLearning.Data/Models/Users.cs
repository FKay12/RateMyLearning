﻿using System;
using System.Collections.Generic;

namespace RateMyLearning.Data
{
    public partial class Users
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public long TypeId { get; set; }
        public DateTime CreatedOn { get; set; }
        public long? StudentId { get; set; }
        public long? EmployeeId { get; set; }

        public virtual UsersType Type { get; set; }
    }
}
