﻿using Reinforced.Typings.Attributes;
using System.ComponentModel;

namespace SchoolMngr.BackOffice.Model.Enums
{
    [TsEnum]
    public enum AttendanceEnum
    {
        [Description("Presente")]
        ATTEND = 1,
        [Description("Ausente")]
        MISS,
        [Description("Justificado")]
        REASON,
    }
}
