using System.Data.Entity;
using Exam.Models;

namespace Exam
{
    public class DBContext: DbContext
    {
        public DBContext() : base("DbConnection") { }

        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<ApartmentRealtor> ApartmentRealtors { get; set; }
        public DbSet<Realtor> Realtors { get; set; }

    }
}
