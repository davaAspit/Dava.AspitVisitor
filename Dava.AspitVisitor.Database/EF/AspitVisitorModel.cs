namespace Dava.AspitVisitor.Database.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AspitVisitorModel : DbContext
    {
        public AspitVisitorModel()
            : base("name=AspitVisitorModel")
        {
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<FreeTextAnswer> FreeTextAnswers { get; set; }
        public virtual DbSet<FreeTextQuestion> FreeTextQuestions { get; set; }
        public virtual DbSet<MultipleChoiceAnswer> MultipleChoiceAnswers { get; set; }
        public virtual DbSet<MultipleChoiceQuestion> MultipleChoiceQuestions { get; set; }
        public virtual DbSet<Municipality> Municipalities { get; set; }
        public virtual DbSet<PossibleAnswer> PossibleAnswers { get; set; }
        public virtual DbSet<QuestionnaireAnswer> QuestionnaireAnswers { get; set; }
        public virtual DbSet<Questionnaire> Questionnaires { get; set; }
        public virtual DbSet<Visitor> Visitors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .HasMany(e => e.Visitors)
                .WithRequired(e => e.Department)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FreeTextQuestion>()
                .HasMany(e => e.FreeTextAnswers)
                .WithRequired(e => e.FreeTextQuestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MultipleChoiceQuestion>()
                .HasMany(e => e.MultipleChoiceAnswers)
                .WithRequired(e => e.MultipleChoiceQuestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Municipality>()
                .HasMany(e => e.Visitors)
                .WithRequired(e => e.Municipality)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PossibleAnswer>()
                .HasMany(e => e.MultipleChoiceAnswers)
                .WithRequired(e => e.PossibleAnswer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<QuestionnaireAnswer>()
                .HasMany(e => e.FreeTextAnswers)
                .WithRequired(e => e.QuestionnaireAnswer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<QuestionnaireAnswer>()
                .HasMany(e => e.MultipleChoiceAnswers)
                .WithRequired(e => e.QuestionnaireAnswer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Questionnaire>()
                .HasMany(e => e.QuestionnaireAnswers)
                .WithRequired(e => e.Questionnaire)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Visitor>()
                .HasMany(e => e.QuestionnaireAnswers)
                .WithRequired(e => e.Visitor)
                .WillCascadeOnDelete(false);
        }
    }
}
