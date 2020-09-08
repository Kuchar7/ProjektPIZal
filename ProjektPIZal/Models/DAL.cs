namespace ProjektPIZal.Models
{
    using ProjektPIZal.Models.Model;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DAL : DbContext
    {

        public DAL()
            : base("name=DAL")
        {
        }
        public DbSet<UserDTO> Users { get; set; }
        public DbSet<RoleDTO> Roles { get; set; }
        public DbSet<UserRoleDTO> UserRoles { get; set; }
        public DbSet<TeaDTO> Teas { get; set; }
        public DbSet<CartDTO> Carts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserDTO>()
                        .HasOptional(s => s.CartDTO)
                        .WithRequired(ad => ad.UserDTO);
        }
    }
}