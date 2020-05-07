﻿using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolMngr.BackOffice.Model.Entities
{
    [Table("ClassRooms", Schema = "School")]
    public class ClassRoom
    {
        public virtual int Id { get; set; }
        [Required, MaxLength(50)]
        public virtual string Description { get; set; }
        [Required]
        public virtual short Capacity { get; set; }
        public virtual bool? HasNetworkConexion { get; set; }
        public virtual bool? HasScreenProjector { get; set; }
    }
}
