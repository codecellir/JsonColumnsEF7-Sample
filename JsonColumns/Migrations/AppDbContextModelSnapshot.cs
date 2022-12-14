// <auto-generated />
using JsonColumns.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JsonColumns.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JsonColumns.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Person", (string)null);
                });

            modelBuilder.Entity("JsonColumns.Models.Person", b =>
                {
                    b.OwnsOne("JsonColumns.Models.Contact", "Contact", b1 =>
                        {
                            b1.Property<int>("PersonId")
                                .HasColumnType("int");

                            b1.Property<string>("Phone")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("PersonId");

                            b1.ToTable("Person");

                            b1.ToJson("Contact");

                            b1.WithOwner()
                                .HasForeignKey("PersonId");

                            b1.OwnsOne("JsonColumns.Models.Address", "Address", b2 =>
                                {
                                    b2.Property<int>("ContactPersonId")
                                        .HasColumnType("int");

                                    b2.Property<string>("City")
                                        .IsRequired()
                                        .HasColumnType("nvarchar(max)");

                                    b2.Property<string>("Country")
                                        .IsRequired()
                                        .HasColumnType("nvarchar(max)");

                                    b2.Property<string>("Postcode")
                                        .IsRequired()
                                        .HasColumnType("nvarchar(max)");

                                    b2.Property<string>("Street")
                                        .IsRequired()
                                        .HasColumnType("nvarchar(max)");

                                    b2.HasKey("ContactPersonId");

                                    b2.ToTable("Person");

                                    b2.WithOwner()
                                        .HasForeignKey("ContactPersonId");
                                });

                            b1.Navigation("Address")
                                .IsRequired();
                        });

                    b.OwnsMany("JsonColumns.Models.Statistic", "Statistics", b1 =>
                        {
                            b1.Property<int>("PersonId")
                                .HasColumnType("int");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            b1.Property<string>("Key")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("PersonId", "Id");

                            b1.ToTable("Person");

                            b1.ToJson("Statistics");

                            b1.WithOwner()
                                .HasForeignKey("PersonId");

                            b1.OwnsMany("JsonColumns.Models.StatisticDetail", "Details", b2 =>
                                {
                                    b2.Property<int>("StatisticPersonId")
                                        .HasColumnType("int");

                                    b2.Property<int>("StatisticId")
                                        .HasColumnType("int");

                                    b2.Property<int>("Id")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("int");

                                    b2.Property<int>("Count")
                                        .HasColumnType("int");

                                    b2.Property<string>("Term")
                                        .IsRequired()
                                        .HasColumnType("nvarchar(max)");

                                    b2.HasKey("StatisticPersonId", "StatisticId", "Id");

                                    b2.ToTable("Person");

                                    b2.WithOwner()
                                        .HasForeignKey("StatisticPersonId", "StatisticId");
                                });

                            b1.Navigation("Details");
                        });

                    b.Navigation("Contact")
                        .IsRequired();

                    b.Navigation("Statistics");
                });
#pragma warning restore 612, 618
        }
    }
}
