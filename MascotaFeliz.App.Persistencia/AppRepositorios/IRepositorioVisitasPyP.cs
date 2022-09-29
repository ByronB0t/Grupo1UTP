using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioVisitasPyP
    {
        VisitaPyP AddVisitasPyP(VisitaPyP VisitaPyP);
        void DeleteVisitasPyP(int idVisitasPyP);
        IEnumerable<VisitaPyP> GetAllVisitasPyPs();
        IEnumerable<VisitaPyP> GetVisitasPyPPorFiltro(string filtro);
        VisitaPyP GetVisitasPyP(int idVisitasPyP);
        VisitaPyP UpdateVisitasPyP(VisitaPyP visitasPyP);
        
    }
}