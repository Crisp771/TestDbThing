using System.Data.Entity;

namespace Project1.Model
{
    public interface IAnimalContext
    {
        DbSet<Animal> Animals { get; set; }
    }
}