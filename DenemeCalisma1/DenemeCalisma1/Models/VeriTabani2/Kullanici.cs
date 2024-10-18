using System.ComponentModel.DataAnnotations;

namespace DenemeCalisma1.Models.VeriTabani2
{
    public class Kullanici
    {
        [Key]
        public int KullaniciID { get; set; }
        public string KullaniciAdiSoyadi { get; set; }
        public string KullaniciSifresi { get; set; }
        public int? SehirlerID { get; set; }
        public int? IlcelerID { get; set; }
    }
}
