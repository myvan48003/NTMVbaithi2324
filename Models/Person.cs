using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NTMVbaithi2324.Model
{
    public class Person
    {
        [Key]
        [Display(Name = "Mã Person")]
        [MaxLength(20)]
        public string MaPerson { get; set; }

        [MaxLength(50)]
        [Display(Name = "Họ Tên")]
        public string HoTen { get; set; }

        [Display(Name = "Age")]
        [ForeignKey("Age")]
        public int? Age { get; set; }

    }
}