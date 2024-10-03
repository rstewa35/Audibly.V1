﻿// <auto-generated />
using System;
using Audibly.Repository.Sql;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Audibly.Repository.Migrations
{
    [DbContext(typeof(AudiblyContext))]
    partial class AudiblyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("Audibly.Models.Audiobook", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Composer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CoverImagePath")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CurrentSourceFileIndex")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DateLastPlayed")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsNowPlaying")
                        .HasColumnType("INTEGER");

                    b.Property<double>("PlaybackSpeed")
                        .HasColumnType("REAL");

                    b.Property<double>("Progress")
                        .HasColumnType("REAL");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ThumbnailPath")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Volume")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("Author", "Title")
                        .IsUnique();

                    b.ToTable("Audiobooks");
                });

            modelBuilder.Entity("Audibly.Models.ChapterInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<uint>("EndOffset")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("EndTime")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Index")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("SourceFileId")
                        .HasColumnType("TEXT");

                    b.Property<uint>("StartOffset")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("StartTime")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Subtitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UniqueID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("UseOffset")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SourceFileId");

                    b.ToTable("Chapters");
                });

            modelBuilder.Entity("Audibly.Models.SourceFile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("AudiobookId")
                        .HasColumnType("TEXT");

                    b.Property<int?>("CurrentChapterIndex")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CurrentTimeMs")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Duration")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Index")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AudiobookId");

                    b.ToTable("SourceFile");
                });

            modelBuilder.Entity("Audibly.Models.ChapterInfo", b =>
                {
                    b.HasOne("Audibly.Models.SourceFile", null)
                        .WithMany("Chapters")
                        .HasForeignKey("SourceFileId");
                });

            modelBuilder.Entity("Audibly.Models.SourceFile", b =>
                {
                    b.HasOne("Audibly.Models.Audiobook", null)
                        .WithMany("SourcePaths")
                        .HasForeignKey("AudiobookId");
                });

            modelBuilder.Entity("Audibly.Models.Audiobook", b =>
                {
                    b.Navigation("SourcePaths");
                });

            modelBuilder.Entity("Audibly.Models.SourceFile", b =>
                {
                    b.Navigation("Chapters");
                });
#pragma warning restore 612, 618
        }
    }
}
