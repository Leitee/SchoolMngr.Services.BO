﻿using AutoMapper;
using SchoolMngr.BackOffice.Model.Entities;
using Reinforced.Typings.Attributes;
using System;

namespace SchoolMngr.BackOffice.Model.Dtos
{
    [TsInterface(AutoI = false, Name = "SubjectAssingment")]
    public sealed class SubjectAssingmentDto : SubjectAssingment
    {
        public override int Id { get => base.Id; set => base.Id = value; }
        public override DateTime Date { get => base.Date; set => base.Date = value; }
        public override bool Deleted { get => base.Deleted; set => base.Deleted = value; }
        public override int SubjectId { get => base.SubjectId; set => base.SubjectId = value; }
        public new SubjectDto Subject { get; set; }
        public override int ClassId { get => base.ClassId; set => base.ClassId = value; }
        public new ClassDto Class { get; set; }
        public override int? ClassRoomId { get => base.ClassRoomId; set => base.ClassRoomId = value; }
        public new ClassRoomDto ClassRoom { get; set; }
        public override int? TeacherId { get => base.TeacherId; set => base.TeacherId = value; }
        public new TeacherDto Teacher { get; set; }
    }
}
