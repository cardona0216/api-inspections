using Microsoft.EntityFrameworkCore;

namespace InspectionAPI.Data
{
    public class DataContex : DbContext
    {
        public DataContex(DbContextOptions<DataContex> options) : base(options) {  }

        public DbSet<Inspection> Inspects { get; set; }

        public DbSet<InspectionType> InspectionTypes { get; set; }

        public DbSet<Estado> Estados { get; set; }

    }
}
