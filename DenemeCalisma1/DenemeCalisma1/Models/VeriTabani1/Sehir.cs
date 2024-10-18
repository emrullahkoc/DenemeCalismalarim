using System.ComponentModel.DataAnnotations;

namespace DenemeCalisma1.Models.VeriTabani1
{
    public class Sehir
    {
        [Key]
        public int SehirlerID { get; set; }
        public string SehirAdi { get; set; }
        public short SehirPlakasi { get; set; }
    }
}
