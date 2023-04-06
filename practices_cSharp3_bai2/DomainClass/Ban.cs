﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace practices_cSharp3_bai2.DomainClass
{
    [Table("Ban")]
    [Index(nameof(Ma), Name = "UQ__Ban__3214CC9EF2995560", IsUnique = true)]
    public partial class Ban
    {
        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [StringLength(30)]
        public string Ten { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }
        [StringLength(30)]
        public string SoThich { get; set; }
        public int? GioiTinh { get; set; }
        [Column("IdMQH")]
        public Guid? IdMqh { get; set; }
        public int? TrangThai { get; set; }

        [ForeignKey(nameof(IdMqh))]
        [InverseProperty(nameof(MoiQuanHe.Bans))]
        public virtual MoiQuanHe IdMqhNavigation { get; set; }
    }
}
