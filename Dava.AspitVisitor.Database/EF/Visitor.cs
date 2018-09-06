namespace Dava.AspitVisitor.Database.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Visitor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Visitor()
        {
            QuestionnaireAnswers = new HashSet<QuestionnaireAnswer>();
        }

        public int VisitorId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public DateTime VisitTime { get; set; }

        public int DepartmentId { get; set; }

        public int MunicipalityId { get; set; }

        public int Age { get; set; }

        public bool WantsToEnrollAspit { get; set; }

        public virtual Department Department { get; set; }

        public virtual Municipality Municipality { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuestionnaireAnswer> QuestionnaireAnswers { get; set; }
    }
}
