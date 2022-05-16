using employeeapi.Models;
using Microsoft.EntityFrameworkCore;

namespace employeeapi.Data
{
    public class employeeDbcontext:DbContext
    {
        public employeeDbcontext(DbContextOptions<employeeDbcontext> options) : base(options)
        {
        }
        public DbSet<employee> employee { get; set; }

    }
}
