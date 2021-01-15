﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Brotherhood.Domain.Models
{
    public partial class Comics : EntityBase
    {
        public string Title { get; set; }
        public byte[] Cover { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateReleased { get; set; }
        public string Genders { get; set; }
        public string Synopsis { get; set; }
        public virtual ICollection<Chapter> Chapters { get; set; }
    }
}
