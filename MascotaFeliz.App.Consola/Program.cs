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
        private static IRepositorioVisitaPyP _repoVisitaPyP = new RepositorioVisitaPyP(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //ListarDuenosFiltro();      
            //AddDueno();
            //BuscarDueno(1);
            
            //ListarDuenos();

            //ListarVeterinariosFiltro();
            //AddVeterinario();
            //BuscarVeterinario(1);
            //BuscarMascota(1);

            //AddMascota();
            //AsignarVeterinario();
            //AsignarDueno();
            //AsignarHistoria();

            //ListarMascotas();
            //ListarHistorias();
            
            //AddHistoria();
            //AsignarVisitaPyP(2);
            //ListarMascotas();
                        


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
                Nombres = "Pepito",
                Apellidos = "Perez",
                Direccion = "La lomita",
                Telefono = "777",
                TarjetaProfesional = "999999"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }

        private static void AddMascota()
        {
            var mascota = new Mascota
            {
                Nombre = "Coco",
                Color = "Gris",
                Especie = "Perro",
                Raza = "Chitsu"
                
            };
            _repoMascota.AddMascota(mascota);
        }


        private static void BuscarDueno(int idDueno)
        {
            var dueno = _repoDueno.GetDueno(idDueno);
            Console.WriteLine(dueno.Id + " " + dueno.Nombres + 
            " " + dueno.Apellidos + " " 
            + dueno.Direccion + " " + dueno.Telefono + " " + dueno.Correo);
        }

        private static void ListarDuenos()
        {
            var duenos = _repoDueno.GetAllDuenos();
            foreach (Dueno d in duenos)
            {
                Console.WriteLine(d.Nombres + " " + d.Apellidos);
            }
        }

        private static void ListarMascotas()
        {
            var mascotas = _repoMascota.GetAllMascotas();
            foreach (Mascota d in mascotas)
            {
                Console.WriteLine(d.Nombre + " " + d.Raza);
            }
        }

        private static void AsignarVeterinario()
        {
            var veterinario = _repoMascota.AsignarVeterinario(1,2);
            Console.WriteLine(veterinario.Nombres + " " + veterinario.Apellidos);
        }

        private static void AsignarDueno()
        {
            var dueno = _repoMascota.AsignarDueno(2,1);
            Console.WriteLine(dueno.Nombres + " " + dueno.Apellidos);
        }

        
        private static void AsignarHistoria()
        {
            var historia = _repoMascota.AsignarHistoria(1,1);
        }

        private static void AddHistoria()
        {
            var historia = new Historia
            {
                FechaInicial = new DateTime(2020, 01, 01)
                

            };
            _repoHistoria.AddHistoria(historia);
        }

        private static void AsignarVisitaPyP(int idHistoria)
        {
            var historia = _repoHistoria.GetHistoria(idHistoria);
            if (historia != null)
            {
                if (historia.VisitasPyP != null)
                {
                    historia.VisitasPyP.Add(new VisitaPyP { FechaVisita = new DateTime(1000, 09, 21), Temperatura = 38.0F, Peso = 30.0F, FrecuenciaRespiratoria = 71.0F, FrecuenciaCardiaca = 71.0F, EstadoAnimo = "Muy cansón", IdVeterinario = 123, Recomendaciones = "Dieta extrema"});
                }
                else
                {
                    historia.VisitasPyP = new List<VisitaPyP>{
                        new VisitaPyP{FechaVisita = new DateTime(2000, 01, 01), Temperatura = 38.0F, Peso = 30.0F, FrecuenciaRespiratoria = 71.0F, FrecuenciaCardiaca = 71.0F, EstadoAnimo = "Muy cansón", IdVeterinario = 123, Recomendaciones = "Dieta extrema" }
                    };
                }
                _repoHistoria.UpdateHistoria(historia);
            }

    }

    }
}            
