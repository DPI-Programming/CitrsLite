﻿using System;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrsLite.Data.Models
{
    /// <summary>
    ///  This represents an instance of a tree 
    ///  in a location.
    /// </summary>
    public class TreeLocation
    {
        public int Id { get; set; }

        public int ParticipantId { get; set; }
        public Participant Participant { get; set; }

        public int TreeId { get; set; }
        public Tree Tree { get; set; }
        public string BlockNumber { get; set; }
        public string Row { get; set; }
        public DateTime DatePlanted { get; set; }
        public DateTime? DateRemoved { get; set; }

        public bool IsActive { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }

        [Required]
        public string ModifiedBy { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}
