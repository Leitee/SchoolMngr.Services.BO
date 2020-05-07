﻿using SchoolMngr.NetStdLibrary.Base.Abstractions;
using SchoolMngr.NetStdLibrary.Base.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolMngr.BackOffice.Model.Entities
{
    [Table("Teachers", Schema = "School")]
    public class Teacher : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public virtual int Id { get; set; }
        [MaxLength(200)]
        public virtual string Address { get; set; }
        [MaxLength]
        public virtual string Obs { get; set; }

        public virtual int ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        public virtual IEnumerable<SubjectAssingment> SubjectAssingments { get; set; }

    }
}
