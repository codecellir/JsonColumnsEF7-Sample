using JsonColumns.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JsonColumns.Maps
{
    public class PersonMap : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Person");

            builder.HasKey(x => x.Id);

            builder.OwnsOne(x => x.Contact, options =>
            {
                options.ToJson();
                options.OwnsOne(c => c.Address);
            });

            builder.OwnsMany(x => x.Statistics, options =>
            {
                options.ToJson();
                options.OwnsMany(x => x.Details);
            });
        }
    }
}
