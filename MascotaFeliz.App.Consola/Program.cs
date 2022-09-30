using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;

namespace MascotaFeliz.App.Consola
{
    class Program
    {
        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        private static IRepositorioHistoria _repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
        private static IRepositorioVisitasPyP _repoVisitasPyP = new RepositorioVisitasPyP(new Persistencia.AppContext());
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddDueno();   testing
            //AddVeterinario();
            //BuscarDueno(10);
            //ListarDuenos();
            //AddMascota();
            //ListarMascotas();
            //AsignarVeterinario();
            //AddHistoria();
            AsignarVisitaPyP(1);
        }
        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                //Cedula = "1212",
                Nombres = "Juan",
                Apellidos = "Sin Miedo",
                Direccion = "Bajo un puente",
                Telefono = "1234567891",
                Correo = "juansinmiedo@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }
        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                //Cedula = "1212",
                Nombres = "Jose",
                Apellidos = "Mendoza",
                Direccion = "La Montana",
                Telefono = "96359636",
                TarjetaProfesional = "986636"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }
        
        private static void BuscarDueno(int idDueno)
        {
            var dueno = _repoDueno.GetDueno(idDueno);
            Console.WriteLine(dueno.Id + " " + dueno.Nombres + " " + dueno.Apellidos + " " + dueno.Direccion + " " + dueno.Telefono + " " + dueno.Correo);
        }
       
       private static void ListarDuenos()
        {
            var duenos = _repoDueno.GetAllDuenos();
            foreach (Dueno d in duenos)
            {
                Console.WriteLine(d.Nombres + " " + d.Apellidos);
            }
        }
        private static void AddMascota()
        {
            var mascota = new Mascota
            {
                //Cedula = "1212",
                Nombre = "Wendy",
                Color = "Azul",
                Especie = "Loro",
                Raza = "Lorito",
            };
            _repoMascota.AddMascota(mascota);
        }
        private static void ListarMascotas()
        {
            var mascotas = _repoMascota.GetAllMascotas();
            foreach (Mascota d in mascotas)
            {
                Console.WriteLine(d.Nombre + " " + d.Color);
            }
        }    
     
        private static void AddHistoria()
        {
            var historia = new Historia
            {
                FechaInicial = new DateTime(2022, 09, 02)
            };
            
            _repoHistoria.AddHistoria(historia);
        }

        private static void AsignarVeterinario()
        {
            var veterinario = _repoMascota.AsignarVeterinario(1,4);
            Console.WriteLine(veterinario.Nombres + " " + veterinario.Apellidos);
        } 

    private static void AsignarVisitaPyP(int idHistoria)
        {
            var historia = _repoHistoria.GetHistoria(idHistoria);
            
            if (historia != null)
            {
                if (historia.VisitaPyP != null)
                {
                    historia.VisitaPyP.Add(new VisitaPyP { FechaVisita = new DateTime(2022, 09, 01), Temperatura = 38.0F, Peso = 30.0F, FrecuenciaRespitaria = 71.0F, FrecuenciaCardiaca = 71.0F, EstadoAnimo = "Muy cansón", Recomendaciones = "Dieta extrema", IdVeterinario =123 });
                }
                else
                {
                    historia.VisitaPyP = new List<VisitaPyP>{
                        new VisitaPyP{ FechaVisita = new DateTime(2022, 09, 01), Temperatura = 38.0F, Peso = 30.0F, FrecuenciaRespitaria = 71.0F, FrecuenciaCardiaca = 71.0F, EstadoAnimo = "Muy cansón", Recomendaciones = "Dieta extrema", IdVeterinario =123 }
                    };
                }
                _repoHistoria.UpdateHistoria(historia);
            }
            else{
            Console.WriteLine(" La Vista no existe ");
            }
        }

    }

}

