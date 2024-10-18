using DenemeCalisma1.Data;
using DenemeCalisma1.Models.VeriTabani1;
using Microsoft.EntityFrameworkCore;

namespace DenemeCalisma1.Models.Services
{
    public class AcenteService
    {
        private readonly FirstDbContext _context;

        public AcenteService(FirstDbContext context)
        {
            _context = context;
        }

        public List<Sehir> GetSehirler()
        {
            return _context.Sehirler.ToList();
        }

        public List<Ilce> GetIlceler(int sehirlerID)
        {
            return _context.Ilceler.Where(ilce => ilce.SehirlerID == sehirlerID).ToList();
        }

        public Acente GetAcente(int acenteID)
        {
            return _context.Acenteler.Include(a => a.Sehir).Include(a => a.Ilce).FirstOrDefault(a => a.AcenteID == acenteID);
        }
    }
}
