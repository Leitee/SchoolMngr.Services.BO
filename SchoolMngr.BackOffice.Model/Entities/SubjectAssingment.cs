﻿using SchoolMngr.NetStdLibrary.Base.Abstractions;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolMngr.BackOffice.Model.Entities
{
    [Table("SubjectAssingments", Schema = "School")]
    public class SubjectAssingment : TrackedEntity
    {
        public virtual int Id { get; set; }
        public virtual bool Deleted { get; set; }
        [Required]
        public virtual DateTime Date { get; set; }
        public virtual int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual int ClassId { get; set; }
        public virtual Class Class { get; set; }
        public virtual int? ClassRoomId { get; set; }
        public virtual ClassRoom ClassRoom { get; set; }
        public virtual int? TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
