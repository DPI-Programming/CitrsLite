﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helpline.Models
{
    /// <summary>
    /// One to many relationship to
    /// the Ticket Model. Determines 
    /// if the caller called by phone, 
    /// email, etc.
    /// </summary>
    public class CommunicationType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CreatedBy_UserName { get; set; }
        public DateTime CreationDate { get; set; }
        public string LastModifiedBy_UserName { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}