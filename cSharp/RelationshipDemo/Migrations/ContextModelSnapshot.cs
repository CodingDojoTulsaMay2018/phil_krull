﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using RelationshipDemo.Models;
using System;

namespace RelationshipDemo.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("RelationshipDemo.Models.Dojo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created_at");

                    b.Property<string>("Name");

                    b.Property<DateTime>("Updated_at");

                    b.HasKey("Id");

                    b.ToTable("Dojos");
                });

            modelBuilder.Entity("RelationshipDemo.Models.Ninja", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created_at");

                    b.Property<long?>("DojoId");

                    b.Property<string>("Name");

                    b.Property<DateTime>("Updated_at");

                    b.HasKey("Id");

                    b.HasIndex("DojoId");

                    b.ToTable("Ninjas");
                });

            modelBuilder.Entity("RelationshipDemo.Models.Ninja", b =>
                {
                    b.HasOne("RelationshipDemo.Models.Dojo", "Dojo")
                        .WithMany("Ninjas")
                        .HasForeignKey("DojoId");
                });
#pragma warning restore 612, 618
        }
    }
}
