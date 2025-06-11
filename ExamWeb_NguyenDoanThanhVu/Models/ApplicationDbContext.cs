using Microsoft.EntityFrameworkCore;

namespace ExamWeb_NguyenDoanThanhVu.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<DiaNhac> DiaNhacs { get; set; }
    }
}
