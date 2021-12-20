using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using One_Health.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace One_Health.Data
{
    public class AppDbContext: IdentityDbContext
    {
        public AppDbContext(DbContextOptions option) : base(option)
        {

        }

        public DbSet<Application> Applications { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<AppointmentCategory> AppointmentCategories { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<BlogCategoryToBlog> BlogCategoryToBlogs { get; set; }
        public DbSet<BlogTag> BlogTags { get; set; }
        public DbSet<BlogTagToBlog> BlogTagToBlogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Commenter> Commenters { get; set; }
        public DbSet<CustomUser> CustomUsers { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorProfession> DoctorProfessions { get; set; }
        public DbSet<DoctorSocial> DoctorSocials { get; set; }
        public DbSet<DoctorSocialToDoctor> DoctorSocialToDoctors { get; set; }
        public DbSet<HealthCenterInfo> HealthCenterInfos { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Paragraph> Paragraphs { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<SiteSocial> SiteSocials { get; set; }
    }
}
