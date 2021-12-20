
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace One_Health.Models
{
    public class DoctorSocialToDoctor
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        [ForeignKey("DoctorSocial")]
        public int DoctorSocialId { get; set; }
        public DoctorSocial DoctorSocial { get; set; }





    }
}
