namespace Dava.AspitVisitor.Database.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MultipleChoiceAnswer
    {
        public int MultipleChoiceAnswerId { get; set; }

        public int MultipleChoiceQuestionId { get; set; }

        public int PossibleAnswerId { get; set; }

        public int QuestionnaireAnswerId { get; set; }

        public virtual MultipleChoiceQuestion MultipleChoiceQuestion { get; set; }

        public virtual PossibleAnswer PossibleAnswer { get; set; }

        public virtual QuestionnaireAnswer QuestionnaireAnswer { get; set; }
    }
}
