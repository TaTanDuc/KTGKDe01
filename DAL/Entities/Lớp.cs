namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Lớp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lớp()
        {
            SinhViens = new HashSet<SinhVien>();
        }

        [Key]
        [Column("Mã Lớp")]
        [StringLength(3)]
        public string Mã_Lớp { get; set; }

        [Column("Tên Lớp")]
        [Required]
        [StringLength(30)]
        public string Tên_Lớp { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SinhVien> SinhViens { get; set; }
    }
}
