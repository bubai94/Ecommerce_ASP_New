using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Models
{
    public class dbstruc :DbContext
    {
        public dbstruc(DbContextOptions<dbstruc> options) : base(options)
        {
        }
        
        public DbSet<Admin> tbl_Admin {  get; set; }

    }
}
