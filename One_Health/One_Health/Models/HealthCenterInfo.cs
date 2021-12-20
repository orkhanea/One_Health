﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace One_Health.Models
{
    public class HealthCenterInfo
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }

        [MaxLength(2000)]
        public string Text { get; set; }

    }
}
