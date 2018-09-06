namespace Dava.AspitVisitor.Database.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class QuestionnaireAnswer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QuestionnaireAnswer()
        {
            FreeTextAnswers = new HashSet<FreeTextAnswer>();
            MultipleChoiceAnswers = new HashSet<MultipleChoiceAnswer>();
        }

        public int QuestionnaireAnswerId { get; set; }

        public DateTime Time { get; set; }

        public int VisitorId { get; set; }

        public int QuestionnaireId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FreeTextAnswer> FreeTextAnswers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MultipleChoiceAnswer> MultipleChoiceAnswers { get; set; }

        public virtual Questionnaire Questionnaire { get; set; }

        public virtual Visitor Visitor { get; set; }
    }
}
