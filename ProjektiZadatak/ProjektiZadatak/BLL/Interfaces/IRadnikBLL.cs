﻿using ProjektniZadatak.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektiZadatak.BLL.Interfaces
{
    public interface IRadnikBLL
    {
        int DodajRadnika(Radnik r);
        Radnik DajRadnika(int id);
        List<Radnik> DajSveRadnike();
        void Izbrisi(int ID);
    }
}
