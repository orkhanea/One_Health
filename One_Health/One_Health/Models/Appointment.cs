using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace One_Health.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(60)]
        public string FullName { get; set; }

        [MaxLength(25)]
        public string Phone { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(2000)]
        public string Text { get; set; }

        [MaxLength(100)]
        public string AboutUsTitle { get; set; }

        public DateTime CreatedDate { get; set; }

        [ForeignKey("AppointmentCategory")]
        public int AppointmentCategoryId { get; set; }
        public AppointmentCategory AppointmentCategory { get; set; }


    }
}
