namespace Laba2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Route")]
    public partial class Route
    {
        public int Id { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [StringLength(50)]
        public string Duration { get; set; }

        [Required]
        [StringLength(20)]
        public string Disnatce { get; set; }

        [Required]
        public DbGeometry Way { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string WayOGC { get; set; }

        public int ID_Driver { get; set; }

        public virtual Driver Driver { get; set; }
    }
}
