using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Proje.Web.Models
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        static readonly string connectionString = "server=localhost;port=3306;database=tekrardb;user=root;password=12345678;Connection Timeout=30;TreatTinyAsBoolean=true;convert zero datetime=True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}
