﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace All_cSharp3.DomainClass
{
    [Table("DongSP")]
    [Index(nameof(Ma), Name = "UQ__DongSP__3214CC9EF66D6C4E", IsUnique = true)]
    public partial class DongSp
    {
        public DongSp()
        {
            ChiTietSps = new HashSet<ChiTietSp>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [StringLength(30)]
        public string Ten { get; set; }

        [InverseProperty(nameof(ChiTietSp.IdDongSpNavigation))]
        public virtual ICollection<ChiTietSp> ChiTietSps { get; set; }
    }
}
