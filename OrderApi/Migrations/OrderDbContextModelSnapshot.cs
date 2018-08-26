﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrderApi.Data;

namespace OrderApi.Migrations
{
    [DbContext(typeof(OrderDbContext))]
    partial class OrderDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:Sequence:.order_hilo", "'order_hilo', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OrderApi.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:HiLoSequenceName", "order_hilo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("BuyerId")
                        .IsRequired();

                    b.Property<DateTime>("EventEndDate");

                    b.Property<int>("EventId");

                    b.Property<DateTime>("EventStartDate");

                    b.Property<string>("EventTitle")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<DateTime>("OrderDate")
                        .HasMaxLength(40);

                    b.Property<string>("OrderStatus")
                        .IsRequired();

                    b.Property<decimal>("OrderTotal")
                        .HasMaxLength(500);

                    b.Property<string>("PaymentAuthCode")
                        .IsRequired();

                    b.Property<string>("PictureUrl")
                        .IsRequired();

                    b.Property<string>("StripeToken")
                        .IsRequired();

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.HasKey("OrderId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("OrderApi.Models.OrderTicket", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EventId");

                    b.Property<string>("ImageUrl")
                        .IsRequired();

                    b.Property<int?>("OrderId2");

                    b.Property<decimal>("Price");

                    b.Property<int>("Quantity");

                    b.Property<int>("TicketTypeId")
                        .HasMaxLength(50);

                    b.Property<string>("TypeName")
                        .IsRequired();

                    b.HasKey("OrderId");

                    b.HasIndex("OrderId2");

                    b.ToTable("OrderTicket");
                });

            modelBuilder.Entity("OrderApi.Models.OrderTicket", b =>
                {
                    b.HasOne("OrderApi.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OrderApi.Models.Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId2");
                });
#pragma warning restore 612, 618
        }
    }
}
