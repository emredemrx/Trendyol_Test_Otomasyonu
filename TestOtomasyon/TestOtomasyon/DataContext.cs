using System.Data.Entity;
using TestOtomasyon.Entities;

namespace TestOtomasyon
{
    public class DataContext : DbContext
    {
        public DbSet<LogData> LogSave { get; set; }
    }
}
