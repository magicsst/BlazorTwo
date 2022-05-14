using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SyncfusionBlazorApp1del.Model
{
    public partial class Employee
    {
        [Key]
        [Column("EmployeeID")]
        public int EmployeeId { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [StringLength(20)]
        [Unicode(false)]
        public string City { get; set; } = null!;
        [StringLength(20)]
        [Unicode(false)]
        public string Department { get; set; } = null!;
        [StringLength(6)]
        [Unicode(false)]
        public string Gender { get; set; } = null!;
    }
}
