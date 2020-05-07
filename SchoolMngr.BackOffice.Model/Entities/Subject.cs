﻿using SchoolMngr.NetStdLibrary.Base.Abstractions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolMngr.BackOffice.Model.Entities
{
    [Table("Subjects", Schema = "School")]
    public class Subject : IEntity
    {
        public virtual int Id { get; set; }
        [Required, MaxLength(50)]
        public virtual string Name { get; set; }
        public virtual int? SubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public virtual Subject PreReqSubject { get; set; }
        public virtual IEnumerable<SubjectAssingment> SubjectAssingments { get; set; }
        public virtual IEnumerable<StudentState> StudentStates { get; set; }
        public virtual IEnumerable<Attend> Attends { get; set; }
        public virtual IEnumerable<Exam> Exams { get; set; }

        #region subject constrains

        public static int MaxAbsencesAllowed { get { return 2; } }
        public static int MinExamScoreRequired { get { return 6; } }

        #endregion
    }
}
