using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AvailabilityUI.Data;

namespace AvailabilityUI.Migrations
{
    [DbContext(typeof(AvailabilityUIContext))]
    [Migration("20200103222215_RateDecimal")]
    partial class RateDecimal
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AvailabilityUI.Models.Availability", b =>
                {
                    b.Property<long>("BrokerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BrokerCode");

                    b.Property<int?>("BrokerSource");

                    b.Property<DateTime?>("BusinnessDate");

                    b.Property<long>("Quantity");

                    b.Property<decimal>("Rate");

                    b.Property<string>("Symbol");

                    b.HasKey("BrokerId");

                    b.ToTable("Availabilities");
                });
        }
    }
}
