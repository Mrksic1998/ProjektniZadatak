using ProjektiZadatak.DAL.Interfaces;
using ProjektiZadatak.Data;
using ProjektniZadatak.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektiZadatak.DAL
{
    public class RadnikDAL : IRadnikDAL
    {
        private readonly ApplicationDbContext _context;

        public RadnikDAL(ApplicationDbContext context)
        {
            _context = context;
        }
        public Radnik DajRadnika(int id)
        {
            return _context.Radnici.Where(x => x.ID == id).FirstOrDefault();
        }

        public List<Radnik> DajSveRadnike()
        {
            return _context.Radnici.ToList();
        }

        public int DodajRadnika(Radnik r)
        {
            _context.Radnici.Add(r);
            _context.SaveChanges();
            return r.ID;
        }

        public void Izbrisi(int ID)
        {
            _context.Radnici.Remove(this.DajRadnika(ID));
            _context.SaveChanges();
        }
    }
}
