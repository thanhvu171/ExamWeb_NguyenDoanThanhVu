using System.ComponentModel.DataAnnotations;
namespace ExamWeb_NguyenDoanThanhVu.Models
{
    public class DiaNhac
    {
        public int Id { get; set; }

        [StringLength(250)]
        public string TuaCD { get; set; }

        [StringLength(50)]
        public string NgheSi { get; set; }

        public bool TrongNuoc { get; set; }

        public double GiaBan { get; set; }

        public int SoLuong { get; set; }
    }
}
