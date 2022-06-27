﻿// <auto-generated />
using System;
using MAS_Core.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MAS_Core.Migrations
{
    [DbContext(typeof(CargoDatabaseContext))]
    [Migration("20220627090143_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CargoManifestWagon", b =>
                {
                    b.Property<int>("CargoManifestsCargoManifestID")
                        .HasColumnType("int");

                    b.Property<int>("WagonsWagonID")
                        .HasColumnType("int");

                    b.HasKey("CargoManifestsCargoManifestID", "WagonsWagonID");

                    b.HasIndex("WagonsWagonID");

                    b.ToTable("CargoManifestWagon");
                });

            modelBuilder.Entity("MAS_Core.Models.CargoManifest", b =>
                {
                    b.Property<int>("CargoManifestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CargoManifestID"), 1L, 1);

                    b.Property<string>("DeparturePlace")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DestinationPlace")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DispatcherID")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<double>("PayloadQty")
                        .HasColumnType("float");

                    b.Property<int>("PayloadType")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CargoManifestID");

                    b.HasIndex("DispatcherID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("CargoManifests");
                });

            modelBuilder.Entity("MAS_Core.Models.Clients", b =>
                {
                    b.Property<int>("ClientsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientsID"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientsID");

                    b.ToTable("Clients");

                    b.HasDiscriminator<string>("Type").HasValue("Clients");
                });

            modelBuilder.Entity("MAS_Core.Models.CustomerService", b =>
                {
                    b.Property<int>("CustomerServiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerServiceID"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("PESEL")
                        .HasColumnType("float");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerServiceID");

                    b.ToTable("CustomerService", (string)null);

                    b.HasData(
                        new
                        {
                            CustomerServiceID = 1,
                            Address = "Testowa 1/3, Wąchock 27-215,Polska",
                            DOB = new DateTime(1992, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Login = "jkowalski",
                            Name = "Jan",
                            PESEL = 92010636232.0,
                            Password = "abc123",
                            Phone = "123456789",
                            Salary = 6000.0,
                            Surname = "Kowalski"
                        },
                        new
                        {
                            CustomerServiceID = 2,
                            Address = "Testowa 10, Wąchock 27-215,Polska",
                            DOB = new DateTime(1965, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Login = "tzielinski",
                            Name = "Toamsz",
                            PESEL = 65032754459.0,
                            Password = "abc123",
                            Phone = "777888999",
                            Salary = 9000.0,
                            Surname = "Zieliński"
                        });
                });

            modelBuilder.Entity("MAS_Core.Models.Dispatcher", b =>
                {
                    b.Property<int>("DispatcherID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DispatcherID"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("PESEL")
                        .HasColumnType("float");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DispatcherID");

                    b.ToTable("Dispatcher", (string)null);

                    b.HasData(
                        new
                        {
                            DispatcherID = 1,
                            Address = "Testowa 1/3, Wąchock 27-215,Polska",
                            DOB = new DateTime(1992, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Login = "jkowalski",
                            Name = "Jan",
                            PESEL = 92010636232.0,
                            Password = "abc123",
                            Phone = "123456789",
                            Salary = 6000.0,
                            Surname = "Kowalski"
                        },
                        new
                        {
                            DispatcherID = 2,
                            Address = "Testowa 10, Wąchock 27-215,Polska",
                            DOB = new DateTime(1965, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Login = "tzielinski",
                            Name = "Toamsz",
                            PESEL = 65032754459.0,
                            Password = "abc123",
                            Phone = "777888999",
                            Salary = 9000.0,
                            Surname = "Zieliński"
                        });
                });

            modelBuilder.Entity("MAS_Core.Models.Form", b =>
                {
                    b.Property<int>("FormID")
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FormID"), 1L, 1);

                    b.Property<int?>("ClientsID")
                        .HasColumnType("int");

                    b.Property<int?>("CustomerServiceID")
                        .HasColumnType("int");

                    b.Property<string>("DepartureName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DestinationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DispatcherID")
                        .HasColumnType("int");

                    b.Property<int>("Distance")
                        .HasColumnType("int");

                    b.Property<int>("PayloadType")
                        .HasColumnType("int");

                    b.Property<int?>("PaymentID")
                        .HasColumnType("int");

                    b.HasKey("FormID");

                    b.HasIndex("CustomerServiceID");

                    b.HasIndex("DispatcherID");

                    b.ToTable("Forms");

                    b.HasData(
                        new
                        {
                            FormID = 1,
                            ClientsID = 1,
                            CustomerServiceID = 1,
                            DepartureName = "Rzeszów",
                            DestinationName = "Gdańsk",
                            DispatcherID = 2,
                            Distance = 3600,
                            PayloadType = 0
                        });
                });

            modelBuilder.Entity("MAS_Core.Models.Payment", b =>
                {
                    b.Property<int>("PaymentID")
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentID"), 1L, 1);

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<DateTime>("DateDue")
                        .HasColumnType("datetime2");

                    b.Property<int>("FormID")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaymentID");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("MAS_Core.Models.Price", b =>
                {
                    b.Property<int>("PriceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PriceID"), 1L, 1);

                    b.HasKey("PriceID");

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("MAS_Core.Models.Wagon", b =>
                {
                    b.Property<int>("WagonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WagonID"), 1L, 1);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("LoadQty")
                        .HasColumnType("float");

                    b.Property<int>("LoadType")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("WagonType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WagonID");

                    b.ToTable("Wagons");

                    b.HasDiscriminator<string>("WagonType").HasValue("Wagon");
                });

            modelBuilder.Entity("MAS_Core.Models.Warehouseman", b =>
                {
                    b.Property<int>("WarehousemanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WarehousemanID"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("PESEL")
                        .HasColumnType("float");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WarehousemanID");

                    b.ToTable("Warehouseman", (string)null);

                    b.HasData(
                        new
                        {
                            WarehousemanID = 1,
                            Address = "Testowa 1/3, Wąchock 27-215,Polska",
                            DOB = new DateTime(1992, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Login = "jkowalski",
                            Name = "Jan",
                            PESEL = 92010636232.0,
                            Password = "abc123",
                            Phone = "123456789",
                            Salary = 6000.0,
                            Surname = "Kowalski"
                        },
                        new
                        {
                            WarehousemanID = 2,
                            Address = "Testowa 10, Wąchock 27-215,Polska",
                            DOB = new DateTime(1965, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Login = "tzielinski",
                            Name = "Toamsz",
                            PESEL = 65032754459.0,
                            Password = "abc123",
                            Phone = "777888999",
                            Salary = 9000.0,
                            Surname = "Zieliński"
                        });
                });

            modelBuilder.Entity("MAS_Core.Models.Company", b =>
                {
                    b.HasBaseType("MAS_Core.Models.Clients");

                    b.Property<string>("CompanyAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("NIP")
                        .HasColumnType("bigint");

                    b.HasDiscriminator().HasValue("Company");

                    b.HasData(
                        new
                        {
                            ClientsID = 2,
                            Email = "abc@gmail.com",
                            PhoneNumber = "122334566",
                            Type = "Company",
                            CompanyAddress = "ABC123",
                            CompanyName = "ACME",
                            NIP = 1231273738L
                        });
                });

            modelBuilder.Entity("MAS_Core.Models.Flatbed", b =>
                {
                    b.HasBaseType("MAS_Core.Models.Wagon");

                    b.HasDiscriminator().HasValue("Flatbed");
                });

            modelBuilder.Entity("MAS_Core.Models.Gas", b =>
                {
                    b.HasBaseType("MAS_Core.Models.Wagon");

                    b.HasDiscriminator().HasValue("Gas");

                    b.HasData(
                        new
                        {
                            WagonID = 7,
                            Code = "YYY123",
                            LoadQty = 123.0,
                            LoadType = 1,
                            Status = 0,
                            WagonType = "Gas"
                        },
                        new
                        {
                            WagonID = 9,
                            Code = "XYX123",
                            LoadQty = 123.0,
                            LoadType = 1,
                            Status = 0,
                            WagonType = "Gas"
                        },
                        new
                        {
                            WagonID = 10,
                            Code = "ZZY123",
                            LoadQty = 131.0,
                            LoadType = 1,
                            Status = 0,
                            WagonType = "Gas"
                        },
                        new
                        {
                            WagonID = 13,
                            Code = "FAZ123",
                            LoadQty = 123.0,
                            LoadType = 1,
                            Status = 3,
                            WagonType = "Gas"
                        });
                });

            modelBuilder.Entity("MAS_Core.Models.Individual", b =>
                {
                    b.HasBaseType("MAS_Core.Models.Clients");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("PESEL")
                        .HasColumnType("float");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Client");

                    b.HasData(
                        new
                        {
                            ClientsID = 1,
                            Email = "abc@gmail.com",
                            PhoneNumber = "122334566",
                            Type = "Individual",
                            Name = "Jan",
                            PESEL = 85092234933.0,
                            Surname = "Kowalski"
                        });
                });

            modelBuilder.Entity("MAS_Core.Models.Liquid", b =>
                {
                    b.HasBaseType("MAS_Core.Models.Wagon");

                    b.HasDiscriminator().HasValue("Liquid");

                    b.HasData(
                        new
                        {
                            WagonID = 1,
                            Code = "XYZ123",
                            LoadQty = 33000.0,
                            LoadType = 0,
                            Status = 0,
                            WagonType = "Liquid"
                        },
                        new
                        {
                            WagonID = 2,
                            Code = "ZZZ310",
                            LoadQty = 33000.0,
                            LoadType = 0,
                            Status = 0,
                            WagonType = "Liquid"
                        },
                        new
                        {
                            WagonID = 3,
                            Code = "DSE223",
                            LoadQty = 33000.0,
                            LoadType = 0,
                            Status = 0,
                            WagonType = "Liquid"
                        },
                        new
                        {
                            WagonID = 11,
                            Code = "AAA123",
                            LoadQty = 33000.0,
                            LoadType = 0,
                            Status = 1,
                            WagonType = "Liquid"
                        },
                        new
                        {
                            WagonID = 12,
                            Code = "FFF123",
                            LoadQty = 33000.0,
                            LoadType = 0,
                            Status = 2,
                            WagonType = "Liquid"
                        });
                });

            modelBuilder.Entity("MAS_Core.Models.Loose", b =>
                {
                    b.HasBaseType("MAS_Core.Models.Wagon");

                    b.HasDiscriminator().HasValue("Loose");

                    b.HasData(
                        new
                        {
                            WagonID = 4,
                            Code = "GFH030",
                            LoadQty = 58.0,
                            LoadType = 2,
                            Status = 0,
                            WagonType = "Loose"
                        },
                        new
                        {
                            WagonID = 5,
                            Code = "KJH330",
                            LoadQty = 58.0,
                            LoadType = 2,
                            Status = 0,
                            WagonType = "Loose"
                        },
                        new
                        {
                            WagonID = 6,
                            Code = "LLL330",
                            LoadQty = 58.0,
                            LoadType = 2,
                            Status = 0,
                            WagonType = "Loose"
                        },
                        new
                        {
                            WagonID = 14,
                            Code = "XYZ123",
                            LoadQty = 53.0,
                            LoadType = 2,
                            Status = 3,
                            WagonType = "Loose"
                        });
                });

            modelBuilder.Entity("CargoManifestWagon", b =>
                {
                    b.HasOne("MAS_Core.Models.CargoManifest", null)
                        .WithMany()
                        .HasForeignKey("CargoManifestsCargoManifestID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MAS_Core.Models.Wagon", null)
                        .WithMany()
                        .HasForeignKey("WagonsWagonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MAS_Core.Models.CargoManifest", b =>
                {
                    b.HasOne("MAS_Core.Models.Dispatcher", null)
                        .WithMany("CreatedManifests")
                        .HasForeignKey("DispatcherID");

                    b.HasOne("MAS_Core.Models.Warehouseman", "Warehouseman")
                        .WithMany("AssignedCargos")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.ClientNoAction)
                        .IsRequired();

                    b.Navigation("Warehouseman");
                });

            modelBuilder.Entity("MAS_Core.Models.Form", b =>
                {
                    b.HasOne("MAS_Core.Models.CustomerService", "CustomerService")
                        .WithMany("CreatedForms")
                        .HasForeignKey("CustomerServiceID")
                        .OnDelete(DeleteBehavior.ClientNoAction);

                    b.HasOne("MAS_Core.Models.Dispatcher", "Dispatcher")
                        .WithMany("AssignedForms")
                        .HasForeignKey("DispatcherID")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("MAS_Core.Models.Company", "Company")
                        .WithMany("Forms")
                        .HasForeignKey("FormID")
                        .OnDelete(DeleteBehavior.ClientNoAction)
                        .IsRequired();

                    b.HasOne("MAS_Core.Models.Individual", "Individual")
                        .WithMany("Forms")
                        .HasForeignKey("FormID")
                        .OnDelete(DeleteBehavior.ClientNoAction)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("CustomerService");

                    b.Navigation("Dispatcher");

                    b.Navigation("Individual");
                });

            modelBuilder.Entity("MAS_Core.Models.Payment", b =>
                {
                    b.HasOne("MAS_Core.Models.Form", "AttachedForm")
                        .WithOne("Payment")
                        .HasForeignKey("MAS_Core.Models.Payment", "PaymentID")
                        .OnDelete(DeleteBehavior.ClientNoAction)
                        .IsRequired();

                    b.Navigation("AttachedForm");
                });

            modelBuilder.Entity("MAS_Core.Models.CustomerService", b =>
                {
                    b.Navigation("CreatedForms");
                });

            modelBuilder.Entity("MAS_Core.Models.Dispatcher", b =>
                {
                    b.Navigation("AssignedForms");

                    b.Navigation("CreatedManifests");
                });

            modelBuilder.Entity("MAS_Core.Models.Form", b =>
                {
                    b.Navigation("Payment");
                });

            modelBuilder.Entity("MAS_Core.Models.Warehouseman", b =>
                {
                    b.Navigation("AssignedCargos");
                });

            modelBuilder.Entity("MAS_Core.Models.Company", b =>
                {
                    b.Navigation("Forms");
                });

            modelBuilder.Entity("MAS_Core.Models.Individual", b =>
                {
                    b.Navigation("Forms");
                });
#pragma warning restore 612, 618
        }
    }
}
