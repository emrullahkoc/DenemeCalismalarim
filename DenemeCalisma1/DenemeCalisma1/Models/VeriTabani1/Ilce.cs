using System.ComponentModel.DataAnnotations;

namespace DenemeCalisma1.Models.VeriTabani1
{
    public class Ilce
    {
        [Key]
        public int IlcelerID { get; set; }
        public string IlceAdi { get; set; }
        public int? SehirlerID { get; set; }
        public Sehir Sehir { get; set; }
    }
}
