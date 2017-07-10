using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Angular_2.Persitence;

namespace Vega.Migrations
{
    [DbContext(typeof(VegaDbContext))]
    [Migration("20170620204852_NewVehicle")]
    partial class NewVehicle
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Angular_2.Model.Feature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Features");
                });

            modelBuilder.Entity("Vega.Model.Make", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Makes");
                });

            modelBuilder.Entity("Vega.Model.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MakeId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("MakeId");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("Vega.Model.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ContactEmai")
                        .HasMaxLength(255);

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("ContactPhone")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("iastUpdate");

                    b.Property<bool>("isResitered");

                    b.Property<int>("modelID");

                    b.HasKey("Id");

                    b.HasIndex("modelID");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("Vega.Model.VehicleFeature", b =>
                {
                    b.Property<int>("FeatureID");

                    b.Property<int>("VehicleID");

                    b.HasKey("FeatureID", "VehicleID");

                    b.HasIndex("VehicleID");

                    b.ToTable("VehicleFeatures");
                });

            modelBuilder.Entity("Vega.Model.Model", b =>
                {
                    b.HasOne("Vega.Model.Make", "Make")
                        .WithMany("models")
                        .HasForeignKey("MakeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Vega.Model.Vehicle", b =>
                {
                    b.HasOne("Vega.Model.Model", "Model")
                        .WithMany()
                        .HasForeignKey("modelID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Vega.Model.VehicleFeature", b =>
                {
                    b.HasOne("Angular_2.Model.Feature", "Feature")
                        .WithMany()
                        .HasForeignKey("FeatureID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Vega.Model.Vehicle", "Vehicle")
                        .WithMany("Features")
                        .HasForeignKey("VehicleID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
