namespace Dava.AspitVisitor.Database.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FreeTextAnswer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FreeTextAnswerId { get; set; }

        [Required]
        public string Answer { get; set; }

        public int FreeTextQuestionId { get; set; }

        public int QuestionnaireAnswerId { get; set; }

        public virtual FreeTextQuestion FreeTextQuestion { get; set; }

        public virtual QuestionnaireAnswer QuestionnaireAnswer { get; set; }
    }
}
