
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace One_Health.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(60)]
        public string FullName { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [ForeignKey("DoctorProfession")]
        public int DoctorProfessionId { get; set; }

        public DoctorProfession DoctorProfession { get; set; }

        public List<DoctorSocialToDoctor> DoctorSocialToDoctor { get; set; }



    }
}
