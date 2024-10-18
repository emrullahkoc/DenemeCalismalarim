using System.ComponentModel.DataAnnotations;

namespace DenemeCalisma1.Models.VeriTabani1
{
    public class Acente
    {
        [Key]
        public int AcenteID { get; set; }
        public string AcenteAdi { get; set; }
        public string VeriTabaniServerName { get; set; }
        public string VeriTabaniLogin { get; set; }
        public string VeriTabaniSifre { get; set; }

        public int? SehirlerID { get; set; }
        public Sehir Sehir { get; set; }

        public int? IlcelerID { get; set; }
        public Ilce Ilce { get; set; }
    }
}
