﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrsLite.Data.Models
{
    public class TreeType
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Tree> Trees { get; set; }

        public string? Description { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        public DateTime CreationDate { get; set; }

        [Required]
        public string ModifiedBy { get; set; }

        public DateTime ModificationDate { get; set; }
    }
}
