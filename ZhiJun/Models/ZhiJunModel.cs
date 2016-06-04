namespace ZhiJun.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ZhiJunModel : DbContext
    {
        public ZhiJunModel()
            : base("name=Entities")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Institute> Institutes { get; set; }
        public virtual DbSet<Level> Levels { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Programme> Programmes { get; set; }
        public virtual DbSet<StudyOption> StudyOptions { get; set; }
        public virtual DbSet<University> Universities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.News)
                .WithRequired(e => e.Category)
                .HasForeignKey(e => e.Category_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Institute>()
                .HasMany(e => e.Programmes)
                .WithRequired(e => e.Institute)
                .HasForeignKey(e => e.Institute_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Level>()
                .HasMany(e => e.Programmes)
                .WithRequired(e => e.Level)
                .HasForeignKey(e => e.Level_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StudyOption>()
                .HasMany(e => e.Programmes)
                .WithRequired(e => e.StudyOption)
                .HasForeignKey(e => e.StudyOption_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<University>()
                .HasMany(e => e.Institutes)
                .WithRequired(e => e.University)
                .HasForeignKey(e => e.University_Id)
                .WillCascadeOnDelete(false);
        }
    }
}