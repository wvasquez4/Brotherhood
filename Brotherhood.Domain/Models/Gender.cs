﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Brotherhood.Domain.Models
{
    public partial class Gender : EntityBase
    {
        public string Description { get; set; }
        // public virtual Comic Comic { get; set; }
    }
}
