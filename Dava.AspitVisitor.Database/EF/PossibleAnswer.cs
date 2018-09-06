namespace Dava.AspitVisitor.Database.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PossibleAnswer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PossibleAnswer()
        {
            MultipleChoiceAnswers = new HashSet<MultipleChoiceAnswer>();
        }

        public int PossibleAnswerId { get; set; }

        [Column("PossibleAnswer")]
        [Required]
        public string PossibleAnswer1 { get; set; }

        public int QuestionId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MultipleChoiceAnswer> MultipleChoiceAnswers { get; set; }
    }
}
