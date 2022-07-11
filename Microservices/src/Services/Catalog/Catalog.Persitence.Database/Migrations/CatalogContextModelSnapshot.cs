﻿// <auto-generated />
using Catalog.Persitence.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Catalog.Persitence.Database.Migrations
{
    [DbContext(typeof(CatalogContext))]
    partial class CatalogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Catalog")
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Catalog.Domain.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products", "Catalog");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Product item description #1",
                            Name = "Product item name #1",
                            Price = 581m
                        },
                        new
                        {
                            Id = 2,
                            Description = "Product item description #2",
                            Name = "Product item name #2",
                            Price = 589m
                        },
                        new
                        {
                            Id = 3,
                            Description = "Product item description #3",
                            Name = "Product item name #3",
                            Price = 855m
                        },
                        new
                        {
                            Id = 4,
                            Description = "Product item description #4",
                            Name = "Product item name #4",
                            Price = 852m
                        },
                        new
                        {
                            Id = 5,
                            Description = "Product item description #5",
                            Name = "Product item name #5",
                            Price = 839m
                        },
                        new
                        {
                            Id = 6,
                            Description = "Product item description #6",
                            Name = "Product item name #6",
                            Price = 520m
                        },
                        new
                        {
                            Id = 7,
                            Description = "Product item description #7",
                            Name = "Product item name #7",
                            Price = 638m
                        },
                        new
                        {
                            Id = 8,
                            Description = "Product item description #8",
                            Name = "Product item name #8",
                            Price = 602m
                        },
                        new
                        {
                            Id = 9,
                            Description = "Product item description #9",
                            Name = "Product item name #9",
                            Price = 878m
                        },
                        new
                        {
                            Id = 10,
                            Description = "Product item description #10",
                            Name = "Product item name #10",
                            Price = 826m
                        },
                        new
                        {
                            Id = 11,
                            Description = "Product item description #11",
                            Name = "Product item name #11",
                            Price = 646m
                        },
                        new
                        {
                            Id = 12,
                            Description = "Product item description #12",
                            Name = "Product item name #12",
                            Price = 620m
                        },
                        new
                        {
                            Id = 13,
                            Description = "Product item description #13",
                            Name = "Product item name #13",
                            Price = 559m
                        },
                        new
                        {
                            Id = 14,
                            Description = "Product item description #14",
                            Name = "Product item name #14",
                            Price = 309m
                        },
                        new
                        {
                            Id = 15,
                            Description = "Product item description #15",
                            Name = "Product item name #15",
                            Price = 833m
                        },
                        new
                        {
                            Id = 16,
                            Description = "Product item description #16",
                            Name = "Product item name #16",
                            Price = 959m
                        },
                        new
                        {
                            Id = 17,
                            Description = "Product item description #17",
                            Name = "Product item name #17",
                            Price = 982m
                        },
                        new
                        {
                            Id = 18,
                            Description = "Product item description #18",
                            Name = "Product item name #18",
                            Price = 474m
                        },
                        new
                        {
                            Id = 19,
                            Description = "Product item description #19",
                            Name = "Product item name #19",
                            Price = 922m
                        },
                        new
                        {
                            Id = 20,
                            Description = "Product item description #20",
                            Name = "Product item name #20",
                            Price = 247m
                        },
                        new
                        {
                            Id = 21,
                            Description = "Product item description #21",
                            Name = "Product item name #21",
                            Price = 656m
                        },
                        new
                        {
                            Id = 22,
                            Description = "Product item description #22",
                            Name = "Product item name #22",
                            Price = 607m
                        },
                        new
                        {
                            Id = 23,
                            Description = "Product item description #23",
                            Name = "Product item name #23",
                            Price = 222m
                        },
                        new
                        {
                            Id = 24,
                            Description = "Product item description #24",
                            Name = "Product item name #24",
                            Price = 941m
                        },
                        new
                        {
                            Id = 25,
                            Description = "Product item description #25",
                            Name = "Product item name #25",
                            Price = 572m
                        },
                        new
                        {
                            Id = 26,
                            Description = "Product item description #26",
                            Name = "Product item name #26",
                            Price = 606m
                        },
                        new
                        {
                            Id = 27,
                            Description = "Product item description #27",
                            Name = "Product item name #27",
                            Price = 381m
                        },
                        new
                        {
                            Id = 28,
                            Description = "Product item description #28",
                            Name = "Product item name #28",
                            Price = 512m
                        },
                        new
                        {
                            Id = 29,
                            Description = "Product item description #29",
                            Name = "Product item name #29",
                            Price = 929m
                        },
                        new
                        {
                            Id = 30,
                            Description = "Product item description #30",
                            Name = "Product item name #30",
                            Price = 674m
                        },
                        new
                        {
                            Id = 31,
                            Description = "Product item description #31",
                            Name = "Product item name #31",
                            Price = 771m
                        },
                        new
                        {
                            Id = 32,
                            Description = "Product item description #32",
                            Name = "Product item name #32",
                            Price = 231m
                        },
                        new
                        {
                            Id = 33,
                            Description = "Product item description #33",
                            Name = "Product item name #33",
                            Price = 154m
                        },
                        new
                        {
                            Id = 34,
                            Description = "Product item description #34",
                            Name = "Product item name #34",
                            Price = 338m
                        },
                        new
                        {
                            Id = 35,
                            Description = "Product item description #35",
                            Name = "Product item name #35",
                            Price = 590m
                        },
                        new
                        {
                            Id = 36,
                            Description = "Product item description #36",
                            Name = "Product item name #36",
                            Price = 710m
                        },
                        new
                        {
                            Id = 37,
                            Description = "Product item description #37",
                            Name = "Product item name #37",
                            Price = 800m
                        },
                        new
                        {
                            Id = 38,
                            Description = "Product item description #38",
                            Name = "Product item name #38",
                            Price = 535m
                        },
                        new
                        {
                            Id = 39,
                            Description = "Product item description #39",
                            Name = "Product item name #39",
                            Price = 118m
                        },
                        new
                        {
                            Id = 40,
                            Description = "Product item description #40",
                            Name = "Product item name #40",
                            Price = 731m
                        },
                        new
                        {
                            Id = 41,
                            Description = "Product item description #41",
                            Name = "Product item name #41",
                            Price = 726m
                        },
                        new
                        {
                            Id = 42,
                            Description = "Product item description #42",
                            Name = "Product item name #42",
                            Price = 720m
                        },
                        new
                        {
                            Id = 43,
                            Description = "Product item description #43",
                            Name = "Product item name #43",
                            Price = 899m
                        },
                        new
                        {
                            Id = 44,
                            Description = "Product item description #44",
                            Name = "Product item name #44",
                            Price = 437m
                        },
                        new
                        {
                            Id = 45,
                            Description = "Product item description #45",
                            Name = "Product item name #45",
                            Price = 532m
                        },
                        new
                        {
                            Id = 46,
                            Description = "Product item description #46",
                            Name = "Product item name #46",
                            Price = 507m
                        },
                        new
                        {
                            Id = 47,
                            Description = "Product item description #47",
                            Name = "Product item name #47",
                            Price = 297m
                        },
                        new
                        {
                            Id = 48,
                            Description = "Product item description #48",
                            Name = "Product item name #48",
                            Price = 523m
                        },
                        new
                        {
                            Id = 49,
                            Description = "Product item description #49",
                            Name = "Product item name #49",
                            Price = 695m
                        },
                        new
                        {
                            Id = 50,
                            Description = "Product item description #50",
                            Name = "Product item name #50",
                            Price = 833m
                        },
                        new
                        {
                            Id = 51,
                            Description = "Product item description #51",
                            Name = "Product item name #51",
                            Price = 119m
                        },
                        new
                        {
                            Id = 52,
                            Description = "Product item description #52",
                            Name = "Product item name #52",
                            Price = 627m
                        },
                        new
                        {
                            Id = 53,
                            Description = "Product item description #53",
                            Name = "Product item name #53",
                            Price = 885m
                        },
                        new
                        {
                            Id = 54,
                            Description = "Product item description #54",
                            Name = "Product item name #54",
                            Price = 397m
                        },
                        new
                        {
                            Id = 55,
                            Description = "Product item description #55",
                            Name = "Product item name #55",
                            Price = 345m
                        },
                        new
                        {
                            Id = 56,
                            Description = "Product item description #56",
                            Name = "Product item name #56",
                            Price = 336m
                        },
                        new
                        {
                            Id = 57,
                            Description = "Product item description #57",
                            Name = "Product item name #57",
                            Price = 339m
                        },
                        new
                        {
                            Id = 58,
                            Description = "Product item description #58",
                            Name = "Product item name #58",
                            Price = 820m
                        },
                        new
                        {
                            Id = 59,
                            Description = "Product item description #59",
                            Name = "Product item name #59",
                            Price = 443m
                        },
                        new
                        {
                            Id = 60,
                            Description = "Product item description #60",
                            Name = "Product item name #60",
                            Price = 152m
                        },
                        new
                        {
                            Id = 61,
                            Description = "Product item description #61",
                            Name = "Product item name #61",
                            Price = 804m
                        },
                        new
                        {
                            Id = 62,
                            Description = "Product item description #62",
                            Name = "Product item name #62",
                            Price = 497m
                        },
                        new
                        {
                            Id = 63,
                            Description = "Product item description #63",
                            Name = "Product item name #63",
                            Price = 799m
                        },
                        new
                        {
                            Id = 64,
                            Description = "Product item description #64",
                            Name = "Product item name #64",
                            Price = 290m
                        },
                        new
                        {
                            Id = 65,
                            Description = "Product item description #65",
                            Name = "Product item name #65",
                            Price = 724m
                        },
                        new
                        {
                            Id = 66,
                            Description = "Product item description #66",
                            Name = "Product item name #66",
                            Price = 798m
                        },
                        new
                        {
                            Id = 67,
                            Description = "Product item description #67",
                            Name = "Product item name #67",
                            Price = 405m
                        },
                        new
                        {
                            Id = 68,
                            Description = "Product item description #68",
                            Name = "Product item name #68",
                            Price = 852m
                        },
                        new
                        {
                            Id = 69,
                            Description = "Product item description #69",
                            Name = "Product item name #69",
                            Price = 624m
                        },
                        new
                        {
                            Id = 70,
                            Description = "Product item description #70",
                            Name = "Product item name #70",
                            Price = 776m
                        },
                        new
                        {
                            Id = 71,
                            Description = "Product item description #71",
                            Name = "Product item name #71",
                            Price = 660m
                        },
                        new
                        {
                            Id = 72,
                            Description = "Product item description #72",
                            Name = "Product item name #72",
                            Price = 155m
                        },
                        new
                        {
                            Id = 73,
                            Description = "Product item description #73",
                            Name = "Product item name #73",
                            Price = 866m
                        },
                        new
                        {
                            Id = 74,
                            Description = "Product item description #74",
                            Name = "Product item name #74",
                            Price = 688m
                        },
                        new
                        {
                            Id = 75,
                            Description = "Product item description #75",
                            Name = "Product item name #75",
                            Price = 503m
                        },
                        new
                        {
                            Id = 76,
                            Description = "Product item description #76",
                            Name = "Product item name #76",
                            Price = 811m
                        },
                        new
                        {
                            Id = 77,
                            Description = "Product item description #77",
                            Name = "Product item name #77",
                            Price = 155m
                        },
                        new
                        {
                            Id = 78,
                            Description = "Product item description #78",
                            Name = "Product item name #78",
                            Price = 117m
                        },
                        new
                        {
                            Id = 79,
                            Description = "Product item description #79",
                            Name = "Product item name #79",
                            Price = 618m
                        },
                        new
                        {
                            Id = 80,
                            Description = "Product item description #80",
                            Name = "Product item name #80",
                            Price = 306m
                        },
                        new
                        {
                            Id = 81,
                            Description = "Product item description #81",
                            Name = "Product item name #81",
                            Price = 200m
                        },
                        new
                        {
                            Id = 82,
                            Description = "Product item description #82",
                            Name = "Product item name #82",
                            Price = 381m
                        },
                        new
                        {
                            Id = 83,
                            Description = "Product item description #83",
                            Name = "Product item name #83",
                            Price = 377m
                        },
                        new
                        {
                            Id = 84,
                            Description = "Product item description #84",
                            Name = "Product item name #84",
                            Price = 440m
                        },
                        new
                        {
                            Id = 85,
                            Description = "Product item description #85",
                            Name = "Product item name #85",
                            Price = 469m
                        },
                        new
                        {
                            Id = 86,
                            Description = "Product item description #86",
                            Name = "Product item name #86",
                            Price = 954m
                        },
                        new
                        {
                            Id = 87,
                            Description = "Product item description #87",
                            Name = "Product item name #87",
                            Price = 866m
                        },
                        new
                        {
                            Id = 88,
                            Description = "Product item description #88",
                            Name = "Product item name #88",
                            Price = 285m
                        },
                        new
                        {
                            Id = 89,
                            Description = "Product item description #89",
                            Name = "Product item name #89",
                            Price = 887m
                        },
                        new
                        {
                            Id = 90,
                            Description = "Product item description #90",
                            Name = "Product item name #90",
                            Price = 507m
                        },
                        new
                        {
                            Id = 91,
                            Description = "Product item description #91",
                            Name = "Product item name #91",
                            Price = 119m
                        },
                        new
                        {
                            Id = 92,
                            Description = "Product item description #92",
                            Name = "Product item name #92",
                            Price = 869m
                        },
                        new
                        {
                            Id = 93,
                            Description = "Product item description #93",
                            Name = "Product item name #93",
                            Price = 652m
                        },
                        new
                        {
                            Id = 94,
                            Description = "Product item description #94",
                            Name = "Product item name #94",
                            Price = 340m
                        },
                        new
                        {
                            Id = 95,
                            Description = "Product item description #95",
                            Name = "Product item name #95",
                            Price = 954m
                        },
                        new
                        {
                            Id = 96,
                            Description = "Product item description #96",
                            Name = "Product item name #96",
                            Price = 169m
                        },
                        new
                        {
                            Id = 97,
                            Description = "Product item description #97",
                            Name = "Product item name #97",
                            Price = 635m
                        },
                        new
                        {
                            Id = 98,
                            Description = "Product item description #98",
                            Name = "Product item name #98",
                            Price = 885m
                        },
                        new
                        {
                            Id = 99,
                            Description = "Product item description #99",
                            Name = "Product item name #99",
                            Price = 712m
                        },
                        new
                        {
                            Id = 100,
                            Description = "Product item description #100",
                            Name = "Product item name #100",
                            Price = 224m
                        });
                });

            modelBuilder.Entity("Catalog.Domain.ProductInStock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("Stocks", "Catalog");
                });

            modelBuilder.Entity("Catalog.Domain.ProductInStock", b =>
                {
                    b.HasOne("Catalog.Domain.Product", null)
                        .WithOne("Stock")
                        .HasForeignKey("Catalog.Domain.ProductInStock", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Catalog.Domain.Product", b =>
                {
                    b.Navigation("Stock")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
