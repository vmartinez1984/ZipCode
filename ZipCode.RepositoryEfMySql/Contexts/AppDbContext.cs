using Microsoft.EntityFrameworkCore;
using ZipCode.Core.Entities;

namespace ZipCode.RepositoryEfMySql.Contexts
{
    public class AppDbContext: DbContext
    {
        //private IConfiguration _configuration;

        public AppDbContext()
        {
            
        }

        // public AppDbContext(IConfiguration configuration)
        // {
        //     _configuration = configuration;
        // }

        // public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        // {

        // }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
                string conectionString;
                
                conectionString = "Server=localhost; Port=13306; Database=ZipCodes; Uid=root; Pwd=;";
                optionsBuilder.UseMySql(conectionString,ServerVersion.AutoDetect(conectionString));                
            }
        }

        public DbSet<ZipCodeEntity> ZipCode { get; set; }
    }
}