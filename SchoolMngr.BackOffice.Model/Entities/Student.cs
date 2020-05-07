﻿using SchoolMngr.NetStdLibrary.Base.Abstractions;
using SchoolMngr.NetStdLibrary.Base.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolMngr.BackOffice.Model.Entities
{
    [Table("Students", Schema = "School")]
    public class Student : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public virtual int Id { get; set; }
        [MaxLength(200)]
        public virtual string Address { get; set; }
        [MaxLength]
        public virtual string Obs { get; set; }

        public virtual int ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        public virtual IEnumerable<StudentState> StudentStates { get; set; }
        public virtual IEnumerable<Attend> Attends { get; set; }
        public virtual IEnumerable<Exam> Exams { get; set; }
    }
}
