using MySql.Data.EntityFramework;
using System.Data.Entity;

namespace PocMySQL.Domain
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class StoreContext : DbContext
    {
        public string Guid  { get;set; }
        public DbSet<Store> Stores { get; set; }

        public StoreContext() : base("default")
        {
            this.Guid = System.Guid.NewGuid().ToString();
            System.Diagnostics.Debug.WriteLine("PocMySQL:::StoreContext:::created:::" + Guid);

            Database.Log = (p => 
            {
                System.Diagnostics.Debug.Write(p); 
            });
        }

        protected override void Dispose(bool disposing)
        {
            System.Diagnostics.Debug.WriteLine("PocMySQL:::StoreContext:::disposed:::" + Guid);
            base.Dispose(disposing);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StoreMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
