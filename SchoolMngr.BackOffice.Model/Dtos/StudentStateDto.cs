﻿using AutoMapper;
using SchoolMngr.NetStdLibrary.Base.Utils;
using SchoolMngr.BackOffice.Model.Entities;
using SchoolMngr.BackOffice.Model.Enums;
using Reinforced.Typings.Attributes;
using System;

namespace SchoolMngr.BackOffice.Model.Dtos
{
    [TsInterface(AutoI = false, Name = "StudentState")]
    public sealed class StudentStateDto : StudentState
    {
        public override int Id { get => base.Id; set => base.Id = value; }
        public override StudentStateEnum AcademicState { get => base.AcademicState; set => base.AcademicState = value; }
        public string AcademicStateDescription { get { return AcademicState.GetDescription(); } }
        public override DateTime DateFrom { get => base.DateFrom; set => base.DateFrom = value; }
        public override DateTime? DateTo { get => base.DateTo; set => base.DateTo = value; }
        [IgnoreMap]
        public new StudentDto Student { get; set; }
        [IgnoreMap]
        public new SubjectDto Subject { get; set; }
        public override string Obs { get => base.Obs; set => base.Obs = value; }

    }
}
