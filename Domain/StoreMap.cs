using System.Data.Entity.ModelConfiguration;

namespace PocMySQL.Domain
{
    public partial class StoreMap : EntityTypeConfiguration<Store>
    {
        public StoreMap()
        {
            this.ToTable("Store");
            this.HasKey(s => s.Id);
            this.Property(s => s.Name).IsRequired();
        }
    }
}
