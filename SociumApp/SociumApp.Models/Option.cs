﻿using SociumApp.Models.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SociumApp.Models
{
    public class Option : IEfModel
    {
        public Option()
        {
            this.Votes = new HashSet<Vote>();
        }

        [Key]
        public int Id { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Vote> Votes { get; set; }
    }
}
