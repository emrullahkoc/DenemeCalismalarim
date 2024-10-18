using DenemeCalisma1.Data;
using DenemeCalisma1.Models.VeriTabani1;
using DenemeCalisma1.Models.VeriTabani2;
using Microsoft.EntityFrameworkCore;

namespace DenemeCalisma1.Models.Services
{
    public class KullaniciService
    {
        private readonly FirstDbContext _firstDbContext;

        public KullaniciService(FirstDbContext firstDbContext)
        {
            _firstDbContext = firstDbContext;
        }

        public bool ValidateUser(string kullaniciAdi, string sifre, int acenteID)
        {
            var acente = _firstDbContext.Acenteler.FirstOrDefault(a => a.AcenteID == acenteID);
            if (acente == null)
                return false;

            var connectionString = $"Server={acente.VeriTabaniServerName};Database={acente.AcenteAdi};User Id={acente.VeriTabaniLogin};Password={acente.VeriTabaniSifre};";
            using (var dynamicContext = new DynamicDbContext(connectionString))
            {
                var kullanici = dynamicContext.Kullanicilar.FirstOrDefault(k => k.KullaniciAdiSoyadi == kullaniciAdi && k.KullaniciSifresi == sifre);
                return kullanici != null;
            }
        }
    }
}
