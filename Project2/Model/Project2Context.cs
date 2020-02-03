using Project1.Model;
using System.Data.Entity;

namespace Project2.Model
{
    public class Project2Context : DbContext, IAnimalContext
    {
        public Project2Context():base()
        {
            
        }
        public Project2Context(string connectionString)
        {
            Database.Connection.ConnectionString = connectionString;
        }
        public virtual DbSet<Plant> Plants { get; set; }
        public virtual DbSet<Animal> Animals { get; set; }
    }
}
