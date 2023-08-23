using ManagementPanelProject.Entity.Models;
using ManagementPanelProject.Entity.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Numerics;

namespace ManagementPanelProject.DAL.ContextInfo
{
    public class MyContext : DbContext
    {
        public MyContext()
        {
            
        }
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }
        public virtual DbSet<LoginActivityModel> LoginActivityList { get; set; }
        public virtual DbSet<UserModel> Users { get; set; }
        public virtual DbSet<RoleModel> Roles { get; set; }
        public virtual DbSet<UserRoleModel> UserRole { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer(@"Server=DESKTOP-TH53ANN;Database=UserManagementDB;Trusted_Connection=True;Integrated Security=true;TrustServerCertificate=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRoleModel>()
        .HasKey(nameof(UserRoleModel.UserRoleUserName), nameof(UserRoleModel.UserRoleRoleName));
            base.OnModelCreating(modelBuilder);

        }

    }
}
