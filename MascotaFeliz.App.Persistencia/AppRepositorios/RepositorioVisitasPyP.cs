using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioVisitasPyP : IRepositorioVisitasPyP
    {
        /// <summary>
        /// Referencia al contexto de VisitasPyP
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        
        public RepositorioVisitasPyP(AppContext appContext)
        {
            _appContext = appContext;
        }

        public VisitaPyP AddVisitasPyP(VisitaPyP visitasPyP)
        {
            var visitasPyPAdicionado = _appContext.VisitasPyP.Add(visitasPyP);
            _appContext.SaveChanges();
            return visitasPyPAdicionado.Entity;
        }

        public void DeleteVisitasPyP(int idVisitasPyP)
        {
            var VisitasPyPEncontrado = _appContext.VisitasPyP.FirstOrDefault(d => d.Id == idVisitasPyP);
            if (VisitasPyPEncontrado == null)
                return;
            _appContext.VisitasPyP.Remove(VisitasPyPEncontrado);
            _appContext.SaveChanges();
        }

       public IEnumerable<VisitaPyP> GetAllVisitasPyPs()
        {
            return GetAllVisitasPyPs_();
        }

        public IEnumerable<VisitaPyP> GetAllVisitasPyPs_()
        {
            return _appContext.VisitasPyP;
        }


        public IEnumerable<VisitaPyP> GetVisitasPyPPorFiltro(string filtro)
        {
            var visitasPyP = GetAllVisitasPyPs(); // Obtiene todos los saludos
            if (visitasPyP != null)  //Si se tienen saludos
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
                {
                    //visitasPyP = visitasPyP.Where(s => s.Nombre.Contains(filtro));
                }
            }
            return visitasPyP;
        }

        public VisitaPyP GetVisitasPyP(int idVisitaPyP)
        {
            return _appContext.VisitasPyP.FirstOrDefault(d => d.Id == idVisitaPyP);
        }

        public VisitaPyP UpdateVisitasPyP(VisitaPyP visitasPyP)
        {
            var visitasPyPEncontrado = _appContext.VisitasPyP.FirstOrDefault(d => d.Id == visitasPyP.Id);
            if (visitasPyPEncontrado != null)
            {
                visitasPyPEncontrado.FechaVisita = visitasPyP.FechaVisita;
                visitasPyPEncontrado.Temperatura = visitasPyP.Temperatura;
                visitasPyPEncontrado.Peso = visitasPyP.Peso;
                visitasPyPEncontrado.FrecuenciaRespitaria = visitasPyP.FrecuenciaRespitaria;
                visitasPyPEncontrado.FrecuenciaCardiaca = visitasPyP.FrecuenciaCardiaca;
                visitasPyPEncontrado.EstadoAnimo = visitasPyP.EstadoAnimo;
                visitasPyPEncontrado.IdVeterinario = visitasPyP.IdVeterinario;
                visitasPyPEncontrado.Recomendaciones = visitasPyP.Recomendaciones;
                _appContext.SaveChanges();
            }
            return visitasPyPEncontrado;
        }     
       
       
    }
}