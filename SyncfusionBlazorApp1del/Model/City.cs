using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SyncfusionBlazorApp1del.Model
{
    public partial class City
    {
        [Key]
        [Column("CityID")]
        public int CityId { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string CityName { get; set; } = null!;
    }
}
