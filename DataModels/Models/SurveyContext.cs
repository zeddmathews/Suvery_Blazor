using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DataModels.Models
{
    public partial class SurveyContext : DbContext
    {
        public SurveyContext()
        {
        }

        public SurveyContext(DbContextOptions<SurveyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Objective> Objectives { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Respondent> Respondents { get; set; }
        public virtual DbSet<RespondentResult> RespondentResults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Survey;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Objective>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("PK__Objectiv__4616479E52ABC273");

                entity.ToTable("Objective");

                entity.Property(e => e.ExpectationGap).HasColumnName("Expectation Gap");

                entity.Property(e => e.ManagerSTotal).HasColumnName("Manager's Total");

                entity.Property(e => e.ManagerSWeight).HasColumnName("Manager's Weight");

                entity.Property(e => e.Questions)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.RespondentsTotal).HasColumnName("Respondents Total");

                entity.Property(e => e.RespondentsWeight).HasColumnName("Respondents Weight");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.ToTable("Question");

                entity.Property(e => e.Questions)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Respondent>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Responde__1788CC4CAF0E7F74");

                entity.ToTable("Respondent");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RespondentResult>(entity =>
            {
                entity.HasKey(e => e.ResultId)
                    .HasName("PK__Responde__976902082D1287A9");

                entity.ToTable("Respondent Result");

                entity.Property(e => e.ArchitectureDesignAndPlanning).HasColumnName("Architecture Design and Planning");

                entity.Property(e => e.BackEndDevelopment).HasColumnName("Back-end Development");

                entity.Property(e => e.ClientMeetings).HasColumnName("Client Meetings");

                entity.Property(e => e.DbDesign).HasColumnName("DB Design");

                entity.Property(e => e.EmailsPhoneSkypeCalls).HasColumnName("Emails & Phone / Skype calls");

                entity.Property(e => e.FrontEndDevelopment).HasColumnName("Front-end Development");

                entity.Property(e => e.InternalMeetings).HasColumnName("Internal Meetings");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RespondentResults)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Responden__UserI__34C8D9D1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
