
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace One_Health.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(200)]
        public string Title { get; set; }

        [Column(TypeName =("ntext"))]
        public string Content { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        public DateTime CreatedDate { get; set; }

        [ForeignKey("CustomUser")]
        public string CustomUserId { get; set; }

        public CustomUser CustomUser { get; set; }

        public List<BlogCategoryToBlog> BlogCategoryToBlog { get; set; }
        public List<BlogTagToBlog> BlogTagToBlog { get; set; }
        public List<Comment> Comments { get; set; }




    }
}
