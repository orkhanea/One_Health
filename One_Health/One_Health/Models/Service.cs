using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace One_Health.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Icon { get; set; }

        [MaxLength(100)]
        public string Text { get; set; }
    }
}
