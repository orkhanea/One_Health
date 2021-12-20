using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace One_Health.Models
{
    public class Commenter
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(60)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(50)]
        public string WebSite { get; set; }

        public string Content { get; set; }

        public DateTime CreatedDate { get; set; }

        public List<Comment> Comment { get; set; }

    }
}
