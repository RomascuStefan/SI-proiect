using System.Data.Entity;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext() : base("name=ApplicationDbContext")
    {
    }

    public DbSet<Framework> Frameworks { get; set; }
    public DbSet<Algoritm> Algoritmi { get; set; }
    public DbSet<Fisier> Fisiere { get; set; }
    public DbSet<FisierAlgoritm> FisierAlgoritmi { get; set; }
    public DbSet<Chei> Chei { get; set; }
    public DbSet<Performanta> Performante { get; set; }
}
