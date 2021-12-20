
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace One_Health.Models
{
    public class DoctorSocial
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Icon { get; set; }

        public List<DoctorSocialToDoctor> DoctorSocialToDoctor { get; set; }



    }
}
