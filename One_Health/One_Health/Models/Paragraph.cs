using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace One_Health.Models
{
    public class Paragraph
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName =("ntext"))]
        public string Text { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
