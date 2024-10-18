using System.ComponentModel.DataAnnotations;

namespace DenemeCalisma1.Models.VeriTabanı3
{
    public class Kullanici
    {
        [Key]
        public int KullaniciID { get; set; }
        public string KullaniciAdiSoyadi { get; set; }
        public string KullaniciSifresi { get; set; }
    }
}
