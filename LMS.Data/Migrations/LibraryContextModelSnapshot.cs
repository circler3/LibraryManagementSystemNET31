﻿// <auto-generated />
using System;
using LMS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LMS.Data.Migrations
{
    [DbContext(typeof(LibraryContext))]
    partial class LibraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("LMS.Core.Domain.Books.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("AuthorId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Authors", (string)null);
                });

            modelBuilder.Entity("LMS.Core.Domain.Books.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CallNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Language")
                        .HasColumnType("TEXT");

                    b.Property<int>("MaxIssueDays")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(10);

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("BookId");

                    b.HasIndex("ISBN")
                        .IsUnique();

                    b.ToTable("Books", (string)null);
                });

            modelBuilder.Entity("LMS.Core.Domain.Books.BookAuthor", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AuthorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("BookId", "AuthorId");

                    b.HasIndex("AuthorId");

                    b.ToTable("BookAuthor", (string)null);
                });

            modelBuilder.Entity("LMS.Core.Domain.Books.BookSubject", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SubjectId")
                        .HasColumnType("INTEGER");

                    b.HasKey("BookId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.ToTable("BookSubject", (string)null);
                });

            modelBuilder.Entity("LMS.Core.Domain.Books.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("SubjectId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Subjects", (string)null);
                });

            modelBuilder.Entity("LMS.Core.Domain.Issues.Issue", b =>
                {
                    b.Property<int>("IssueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("MemberId")
                        .HasColumnType("INTEGER");

                    b.HasKey("IssueId");

                    b.HasIndex("BookId")
                        .IsUnique();

                    b.HasIndex("MemberId");

                    b.ToTable("Issues", (string)null);
                });

            modelBuilder.Entity("LMS.Core.Domain.Members.Member", b =>
                {
                    b.Property<int>("MemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("MemberType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MemberId");

                    b.ToTable("Members", (string)null);
                });

            modelBuilder.Entity("LMS.Core.Domain.Books.BookAuthor", b =>
                {
                    b.HasOne("LMS.Core.Domain.Books.Author", "Author")
                        .WithMany("BookAuthors")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LMS.Core.Domain.Books.Book", "Book")
                        .WithMany("BookAuthors")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("LMS.Core.Domain.Books.BookSubject", b =>
                {
                    b.HasOne("LMS.Core.Domain.Books.Book", "Book")
                        .WithMany("BookSubjects")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LMS.Core.Domain.Books.Subject", "Subject")
                        .WithMany("BookSubjects")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("LMS.Core.Domain.Issues.Issue", b =>
                {
                    b.HasOne("LMS.Core.Domain.Books.Book", "Book")
                        .WithOne("Issue")
                        .HasForeignKey("LMS.Core.Domain.Issues.Issue", "BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LMS.Core.Domain.Members.Member", "Member")
                        .WithMany("Issues")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("LMS.Core.Domain.Books.Author", b =>
                {
                    b.Navigation("BookAuthors");
                });

            modelBuilder.Entity("LMS.Core.Domain.Books.Book", b =>
                {
                    b.Navigation("BookAuthors");

                    b.Navigation("BookSubjects");

                    b.Navigation("Issue");
                });

            modelBuilder.Entity("LMS.Core.Domain.Books.Subject", b =>
                {
                    b.Navigation("BookSubjects");
                });

            modelBuilder.Entity("LMS.Core.Domain.Members.Member", b =>
                {
                    b.Navigation("Issues");
                });
#pragma warning restore 612, 618
        }
    }
}
