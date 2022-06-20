using ProjektiZadatak.BLL.Interfaces;
using ProjektiZadatak.UI.Interfaces;
using ProjektniZadatak.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektiZadatak.UI
{
    public class RadnikUI : IRadnikUI
    {
        private readonly IRadnikBLL _iRadnikBLL;

        public RadnikUI(IRadnikBLL iRadnikBLL)
        {
            _iRadnikBLL = iRadnikBLL;
        }
        
        public Radnik DajRadnika(int id)
        {
            return _iRadnikBLL.DajRadnika(id);
        }

        public List<Radnik> DajSveRadnike()
        {
            return _iRadnikBLL.DajSveRadnike();
        }

        public int DodajRadnika(Radnik r)
        {
            return _iRadnikBLL.DodajRadnika(r);
        }

        public void Izbrisi(int ID)
        {
            _iRadnikBLL.Izbrisi(ID);
        }
    }
}
