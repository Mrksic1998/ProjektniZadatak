using ProjektiZadatak.BLL.Interfaces;
using ProjektiZadatak.DAL.Interfaces;
using ProjektniZadatak.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektiZadatak.BLL
{
    public class RadnikBLL : IRadnikBLL
    {
        private readonly IRadnikDAL _iRadnikDAL;

        public RadnikBLL(IRadnikDAL iRadnikDAL)
        {
            _iRadnikDAL = iRadnikDAL;
        }

        public Radnik DajRadnika(int id)
        {
            return _iRadnikDAL.DajRadnika(id);
        }

        public List<Radnik> DajSveRadnike()
        {
            return _iRadnikDAL.DajSveRadnike();
        }

        public int DodajRadnika(Radnik r)
        {
            double najnizaOsnovica = 30880;
            double najvisaOsnovica = 441140;

            double neoporeziviIznos = 19300;
            double fiksniIznosZaUmanjnje = neoporeziviIznos * 0.1;

            //racunanje bruto1
            double bruto1 = (r.NetoPlata - fiksniIznosZaUmanjnje) / 0.701;

            

            if (bruto1 < najnizaOsnovica)
                bruto1 = (r.NetoPlata - fiksniIznosZaUmanjnje + najnizaOsnovica * .199) / 0.9;
            else if (bruto1 >= najvisaOsnovica)
                bruto1 = (r.NetoPlata - fiksniIznosZaUmanjnje + najvisaOsnovica * .199) / 0.9;
                
            
            //Racunanje Stpe Poreza
            double oporezivaOsnovica = bruto1 - neoporeziviIznos;
            r.StopaPoreza = oporezivaOsnovica * 0.1;
            if (bruto1 < najnizaOsnovica)
                bruto1 = najnizaOsnovica;
            else if (bruto1 >= najvisaOsnovica)
                bruto1 = najvisaOsnovica;
            

            //Racunanje doprinosa na teret radnika
            r.RPIO = bruto1 * .14;
            r.RZDR = bruto1 * .0515;
            r.RNZP = bruto1 * .0075;

            //Racunanje doprinosa na teret poslodavca
            r.PPIO = bruto1 * .11;
            r.PZDR = bruto1 * .0515;
            r.PNZP = bruto1 * 0;

            r.BrutoPlata = r.NetoPlata + r.StopaPoreza + r.RPIO + r.RZDR + r.RNZP + r.PPIO + r.PZDR + r.PNZP;

            return _iRadnikDAL.DodajRadnika(r);
        }

        public void Izbrisi(int ID)
        {
            _iRadnikDAL.Izbrisi(ID);
        }
    }
}
