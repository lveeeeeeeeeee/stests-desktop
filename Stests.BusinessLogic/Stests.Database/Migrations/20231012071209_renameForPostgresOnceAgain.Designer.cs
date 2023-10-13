﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Stests.BusinessLogic.Models.JSON;
using Stests.Database;

#nullable disable

namespace Stests.Database.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231012071209_renameForPostgresOnceAgain")]
    partial class renameForPostgresOnceAgain
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Stests.BusinessLogic.Models.CorrectAnswers", b =>
                {
                    b.Property<Guid>("сorrect_answers_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("correct_answers_json")
                        .IsRequired()
                        .HasColumnType("jsonb");

                    b.Property<Guid>("test_id")
                        .HasColumnType("uuid");

                    b.HasKey("сorrect_answers_id");

                    b.ToTable("correct_answers");
                });

            modelBuilder.Entity("Stests.BusinessLogic.Models.Grades", b =>
                {
                    b.Property<Guid>("grade_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("grade")
                        .HasColumnType("integer");

                    b.Property<Guid>("test_id")
                        .HasColumnType("uuid");

                    b.Property<Guid>("test_session_id")
                        .HasColumnType("uuid");

                    b.Property<Guid>("user_id")
                        .HasColumnType("uuid");

                    b.HasKey("grade_id");

                    b.ToTable("grades");
                });

            modelBuilder.Entity("Stests.BusinessLogic.Models.TestSessions", b =>
                {
                    b.Property<Guid>("test_session_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("group_id")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("session_end")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("session_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("session_start")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("test_id")
                        .HasColumnType("uuid");

                    b.HasKey("test_session_id");

                    b.ToTable("test_sessions");
                });

            modelBuilder.Entity("Stests.BusinessLogic.Models.Tests", b =>
                {
                    b.Property<Guid>("test_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("test_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Questions>("test_questions")
                        .IsRequired()
                        .HasColumnType("jsonb");

                    b.HasKey("test_id");

                    b.ToTable("tests");
                });

            modelBuilder.Entity("Stests.BusinessLogic.Models.UserAnswers", b =>
                {
                    b.Property<Guid>("user_answers_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("test_id")
                        .HasColumnType("uuid");

                    b.Property<Guid>("test_session_id")
                        .HasColumnType("uuid");

                    b.Property<Answers>("user_answer")
                        .IsRequired()
                        .HasColumnType("jsonb");

                    b.Property<Guid>("user_id")
                        .HasColumnType("uuid");

                    b.HasKey("user_answers_id");

                    b.ToTable("users_answers");
                });

            modelBuilder.Entity("Stests.BusinessLogic.Models.UserGroupRelations", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("group_id")
                        .HasColumnType("uuid");

                    b.Property<Guid>("role_id")
                        .HasColumnType("uuid");

                    b.Property<Guid>("user_id")
                        .HasColumnType("uuid");

                    b.HasKey("id");

                    b.ToTable("user_group_relation");
                });

            modelBuilder.Entity("Stests.BusinessLogic.Models.UserGroups", b =>
                {
                    b.Property<Guid>("group_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("password_hash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("group_id");

                    b.HasIndex("name")
                        .IsUnique();

                    b.ToTable("user_groups");
                });

            modelBuilder.Entity("Stests.BusinessLogic.Models.UserRoles", b =>
                {
                    b.Property<Guid>("role_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("role_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("role_id");

                    b.ToTable("roles");
                });

            modelBuilder.Entity("Stests.BusinessLogic.Models.Users", b =>
                {
                    b.Property<Guid>("user_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.HasKey("user_id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Stests.BusinessLogic.Models.UsersInfo", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("login")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("password_hash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("patronymic")
                        .HasColumnType("text");

                    b.Property<string>("surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("user_id")
                        .HasColumnType("uuid");

                    b.HasKey("id");

                    b.HasIndex("login")
                        .IsUnique();

                    b.ToTable("user_info");
                });
#pragma warning restore 612, 618
        }
    }
}