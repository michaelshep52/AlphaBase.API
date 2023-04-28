﻿using System;
namespace Alpha.API.Data.Entities
{
    public class EmailAddress
    {
        public int EmailAddressId { get; set; }
        public string? Email { get; set; }

        // 1 User to Many Emails
        public virtual User? User { get; set; }
        public int? UserId { get; set; }
        
        
    }
}
