namespace Dava.AspitVisitor.Database.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MultipleChoiceQuestion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MultipleChoiceQuestion()
        {
            MultipleChoiceAnswers = new HashSet<MultipleChoiceAnswer>();
        }

        public int MultipleChoiceQuestionId { get; set; }

        [Required]
        public string Text { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MultipleChoiceAnswer> MultipleChoiceAnswers { get; set; }
    }
}
