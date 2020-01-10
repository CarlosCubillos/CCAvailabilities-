using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AvailabilityUI.Data;

namespace AvailabilityUI.Migrations
{
    [DbContext(typeof(AvailabilityUIContext))]
    [Migration("20200103211342_NullableCols")]
    partial class NullableCols
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

                    b.Property<int>("Rate");

                    b.Property<string>("Symbol");

                    b.HasKey("BrokerId");

                    b.ToTable("Availabilities");
                });
        }
    }
}
