using Microsoft.EntityFrameworkCore;

namespace CustomersAPIProject.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
                
        }
    }
}
