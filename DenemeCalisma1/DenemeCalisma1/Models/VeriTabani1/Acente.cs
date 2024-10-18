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

    }
}
