namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        [Key]
        [StringLength(6)]
        public string MSSV { get; set; }

        [Column("Họ Tên")]
        [StringLength(40)]
        public string Họ_Tên { get; set; }

        [Column("Ngày Sinh", TypeName = "date")]
        public DateTime? Ngày_Sinh { get; set; }

        [Column("Mã Lớp")]
        [StringLength(3)]
        public string Mã_Lớp { get; set; }

        public virtual Lớp Lớp { get; set; }
    }
}
