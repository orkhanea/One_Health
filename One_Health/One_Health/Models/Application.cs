using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace One_Health.Models
{
    public class Application
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(250)]
        public string BgImage { get; set; }

        [NotMapped]
        public IFormFile BgImageFile { get; set; }

        [MaxLength(250)]
        public string PhoneImage { get; set; }

        [NotMapped]
        public IFormFile PhoneImageFile { get; set; }

        [MaxLength(250)]
        public string GPlayImage { get; set; }

        [NotMapped]
        public IFormFile GPlayImageFile { get; set; }

        [MaxLength(250)]
        public string AppStoreImage { get; set; }

        [NotMapped]
        public IFormFile AppStoreImageFile { get; set; }

        [MaxLength(100)]
        public string Title { get; set; }

    }
}
