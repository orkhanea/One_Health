using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace One_Health.Models
{
    public class BlogCategoryToBlog
    {
        [Key]
        public int Id { get; set; }
       
        [ForeignKey("Blog")]
        public int BlogId { get; set; }
        public Blog Blog { get; set; }

        [ForeignKey("BlogCategory")]
        public int BlogCategoryId { get; set; }
        public BlogCategory BlogCategory { get; set; }



    }
}
