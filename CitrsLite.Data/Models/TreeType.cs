﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrsLite.Data.Models
{
    public class TreeType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Type { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreationDate { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime ModificationDate { get; set; }
    }
}