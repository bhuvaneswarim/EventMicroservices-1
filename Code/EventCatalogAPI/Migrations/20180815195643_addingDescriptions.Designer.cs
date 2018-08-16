﻿// <auto-generated />
using System;
using EventCatalogAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EventCatalogAPI.Migrations
{
    [DbContext(typeof(EventCatalogContext))]
    [Migration("20180815195643_addingDescriptions")]
    partial class addingDescriptions
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:Sequence:.event_category_hilo", "'event_category_hilo', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.event_hilo", "'event_hilo', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.event_type_hilo", "'event_type_hilo', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EventCatalogAPI.Domain.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:HiLoSequenceName", "event_hilo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("EndDate")
                        .HasMaxLength(20);

                    b.Property<int>("EventCategoryId");

                    b.Property<string>("EventDescription")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.Property<int>("EventTypeId");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("OrganizerDescription")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.Property<int>("OrganizerId")
                        .HasMaxLength(50);

                    b.Property<string>("OrganizerName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<decimal>("Price")
                        .HasMaxLength(10);

                    b.Property<DateTime>("StartDate")
                        .HasMaxLength(20);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Zipcode")
                        .IsRequired()
                        .HasMaxLength(11);

                    b.HasKey("Id");

                    b.HasIndex("EventCategoryId");

                    b.HasIndex("EventTypeId");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("EventCatalogAPI.Domain.EventCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:HiLoSequenceName", "event_category_hilo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("EventCategory");
                });

            modelBuilder.Entity("EventCatalogAPI.Domain.EventType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:HiLoSequenceName", "event_type_hilo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("EventType");
                });

            modelBuilder.Entity("EventCatalogAPI.Domain.Event", b =>
                {
                    b.HasOne("EventCatalogAPI.Domain.EventCategory", "EventCategory")
                        .WithMany()
                        .HasForeignKey("EventCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EventCatalogAPI.Domain.EventType", "EventType")
                        .WithMany()
                        .HasForeignKey("EventTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
