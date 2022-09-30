using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioMascota : IRepositorioMascota
    {
        /// <summary>
        /// Referencia al contexto de Mascota
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        public RepositorioMascota(AppContext appContext)
        {
            _appContext = appContext;
        }

        public Mascota AddMascota(Mascota mascota)
        {
            var mascotaAdicionado = _appContext.Mascotas.Add(mascota);
            _appContext.SaveChanges();
            return mascotaAdicionado.Entity;
        }

        public void DeleteMascota(int idMascota)
        {
            var MascotaEncontrado = _appContext.Mascotas.FirstOrDefault(d => d.Id == idMascota);
            if (MascotaEncontrado == null)
                return;
            _appContext.Mascotas.Remove(MascotaEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Mascota> GetAllMascotas()
        {
        return _appContext.Mascotas.Include("Dueno").Include("Veterinario").Include("Historia");
        }
/*
       public IEnumerable<Mascota> GetAllMascotas()
        {
<<<<<<< Updated upstream
            return GetAllMascotas_();
        }*/
=======
            return _appContext.Mascotas.Include("Dueno").Include("Veterinario").Include("Historia");
        }
>>>>>>> Stashed changes

        public IEnumerable<Mascota> GetMascotasPorFiltro(string filtro)
        {
            var mascotas = GetAllMascotas(); // Obtiene todos los saludos
            if (mascotas != null)  //Si se tienen saludos
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
                {
                    mascotas = mascotas.Where(s => s.Nombre.Contains(filtro));
                }
            }
            return mascotas;
        }

        public Mascota GetMascota(int idMascota)
        {
            return _appContext.Mascotas.Include("Dueno").Include("Veterinario").Include("Historia").FirstOrDefault(d => d.Id == idMascota);
        }


       /* public Mascota GetMascota(int idMascota)
        {
<<<<<<< Updated upstream
            return _appContext.Mascotas.FirstOrDefault(d => d.Id == idMascota);
        }*/

        public Veterinario AsignarVeterinario(int idMascota, int idVeterinario)
        {
        var mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(m => m.Id == idMascota);
            if (mascotaEncontrado != null)
=======
            var mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(d => d.Id == mascota.Id);
            if (mascotaEncontrado != null)
            {
                mascotaEncontrado.Nombre = mascota.Nombre;
                mascotaEncontrado.Color = mascota.Color;
                mascotaEncontrado.Especie = mascota.Especie;
                mascotaEncontrado.Raza = mascota.Raza;
                mascotaEncontrado.Dueno = mascota.Dueno;
                mascotaEncontrado.Veterinario = mascota.Veterinario;
                mascotaEncontrado.Historia = mascota.Historia;
                
                _appContext.SaveChanges();
            }
            return mascotaEncontrado;
        }  

        public Veterinario AsignarVeterinario(int idMascota, int idVeterinario)
        {
            var mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(m => m.Id == idMascota);
            if (mascotaEncontrado != null)
            {
                var veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(v => v.Id == idVeterinario);
                if (veterinarioEncontrado != null)
>>>>>>> Stashed changes
                {
                    var veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(v => v.Id == idVeterinario);
                    if (veterinarioEncontrado != null)
                    {
                        mascotaEncontrado.Veterinario = veterinarioEncontrado;
                        _appContext.SaveChanges();
                    }
                return veterinarioEncontrado;
<<<<<<< Updated upstream
                }
        return null;
        }
=======
            }
            return null;
        }   
>>>>>>> Stashed changes



       public Dueno AsignarDueno(int idMascota, int idDueno)
        {
<<<<<<< Updated upstream
        var mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(m => m.Id == idMascota);
            if (mascotaEncontrado != null)
=======
            var mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(m => m.Id == idMascota);
            if (mascotaEncontrado != null)
            {
                var duenoEncontrado = _appContext.Duenos.FirstOrDefault(v => v.Id == idDueno);
                if (duenoEncontrado != null)
>>>>>>> Stashed changes
                {
                    var duenoEncontrado = _appContext.Duenos.FirstOrDefault(v => v.Id == idDueno);
                    if (duenoEncontrado != null)
                    {
                        mascotaEncontrado.Dueno = duenoEncontrado;
                        _appContext.SaveChanges();
                    }
                return duenoEncontrado;
<<<<<<< Updated upstream
                }
        return null;
        }
=======
            }
            return null;
        }   
>>>>>>> Stashed changes

        public Historia AsignarHistoria(int idMascota, int idHistoria)
        {
        var mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(m => m.Id == idMascota);
            if (mascotaEncontrado != null)
                {
                    var historiaEncontrado = _appContext.Historias.FirstOrDefault(v => v.Id == idHistoria);
                    if (historiaEncontrado != null)
                    {
                        mascotaEncontrado.Historia = historiaEncontrado;
                        _appContext.SaveChanges();
                    }
                return historiaEncontrado;
                }
        return null;
        }

        public Mascota UpdateMascota(Mascota mascota)
        {
            var mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(d => d.Id == mascota.Id);
            if (mascotaEncontrado != null)
            {
                mascotaEncontrado.Nombre = mascota.Nombre;
                mascotaEncontrado.Color = mascota.Color;
                mascotaEncontrado.Especie = mascota.Especie;
                mascotaEncontrado.Raza = mascota.Raza;
                _appContext.SaveChanges();
            }
<<<<<<< Updated upstream
            return mascotaEncontrado;
        }  
       
       

=======
            return null;
        }
>>>>>>> Stashed changes
    }
}