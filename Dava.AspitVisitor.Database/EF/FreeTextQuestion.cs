namespace Dava.AspitVisitor.Database.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FreeTextQuestion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FreeTextQuestion()
        {
            FreeTextAnswers = new HashSet<FreeTextAnswer>();
        }

        public int FreeTextQuestionId { get; set; }

        [Required]
        public string Text { get; set; }

        public int QuestionnaireIs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FreeTextAnswer> FreeTextAnswers { get; set; }
    }
}
