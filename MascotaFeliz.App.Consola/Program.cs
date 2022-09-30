using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;

namespace MascotaFeliz.App.Consola
{
    class Program
    {
<<<<<<< Updated upstream
=======
       
>>>>>>> Stashed changes
        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        private static IRepositorioHistoria _repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
<<<<<<< Updated upstream
        private static IRepositorioVisitasPyP _repoVisitasPyP = new RepositorioVisitasPyP(new Persistencia.AppContext());
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddDueno();   testing
=======
        private static IRepositorioVisitaPyP _repoVisitaPyP = new RepositorioVisitaPyP(new Persistencia.AppContext());
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hola amigos vamos a empezar a trabajar con las tablas");

            //ListarDuenosFiltro();      
            //AddDueno();
            //BuscarDueno(1);
            
            //ListarDuenos();

            //ListarVeterinariosFiltro();
>>>>>>> Stashed changes
            //AddVeterinario();
            //BuscarDueno(10);
            //ListarDuenos();
            //AddMascota();
            //ListarMascotas();
            //AsignarVeterinario();
            //AddHistoria();
<<<<<<< Updated upstream
            AsignarVisitaPyP(1);
=======
            //AsignarVisitaPyP(2);
            ListarMascotas();

>>>>>>> Stashed changes
        }

        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                Cedula = "4545",
                Nombres = "Juanito",
                Apellidos = "Alimaña",
                Direccion = "Casa de los padres",
                Telefono = "515151515",
                Correo = "juanitoalimana@gmail.com"
            };
            dueno = _repoDueno.AddDueno(dueno);
          
        }
<<<<<<< Updated upstream
=======

>>>>>>> Stashed changes
        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
<<<<<<< Updated upstream
                //Cedula = "1212",
                Nombres = "Jose",
                Apellidos = "Mendoza",
                Direccion = "La Montana",
                Telefono = "96359636",
                TarjetaProfesional = "986636"
=======
                Cedula = "555555",
                Nombres = "La Chilindrina",
                Apellidos = "No se sabe",
                Direccion = "Transversal 5 # 17A-155",
                Telefono = "2222222222",
                TarjetaProfesional = "TP0001"
>>>>>>> Stashed changes
            };
            _repoVeterinario.AddVeterinario(veterinario);

        }
<<<<<<< Updated upstream
        
        private static void BuscarDueno(int idDueno)
        {
            var dueno = _repoDueno.GetDueno(idDueno);
            Console.WriteLine(dueno.Id + " " + dueno.Nombres + " " + dueno.Apellidos + " " + dueno.Direccion + " " + dueno.Telefono + " " + dueno.Correo);
=======

        private static void AddMascota()
        {
            var mascota = new Mascota
            {
                Nombre = "Ragnar",
                Color = "Sable",
                Especie = "Canino",
                Raza = "Husky"
            };
            _repoMascota.AddMascota(mascota);

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
                    historia.VisitasPyP.Add(new VisitaPyP { FechaVisita = new DateTime(1000, 09, 21), Temperatura = 38.0F, Peso = 30.0F, FrecuenciaRespiratoria = 71.0F, FrecuenciaCardiaca = 71.0F, EstadoAnimo = "Muy cansón", CedulaVeterinario = "123", Recomendaciones = "Dieta extrema"});
                }
                else
                {
                    historia.VisitasPyP = new List<VisitaPyP>{
                        new VisitaPyP{FechaVisita = new DateTime(2000, 01, 01), Temperatura = 38.0F, Peso = 30.0F, FrecuenciaRespiratoria = 71.0F, FrecuenciaCardiaca = 71.0F, EstadoAnimo = "Muy cansón", CedulaVeterinario = "123", Recomendaciones = "Dieta extrema" }
                    };
                }
                _repoHistoria.UpdateHistoria(historia);
            }
        }

        private static void BuscarDueno(int idDueno)
        {
            var dueno = _repoDueno.GetDueno(idDueno);
            Console.WriteLine(dueno.Cedula + " " + dueno.Nombres + " " + dueno.Apellidos + " " + dueno.Direccion + " " + dueno.Telefono + " " + dueno.Correo);
        }

        private static void BuscarVeterinario(int idVeterinario)
        {
            var veterinario = _repoVeterinario.GetVeterinario(idVeterinario);
            Console.WriteLine(veterinario.Nombres + " " + veterinario.Apellidos);
        }

        private static void BuscarMascota(int idMascota)
        {
            var mascota = _repoMascota.GetMascota(idMascota);
            Console.WriteLine(mascota.Nombre + " " + mascota.Dueno.Nombres);        
        }

        private static void ListarDuenosFiltro()
        {
            var duenosM = _repoDueno.GetDuenosPorFiltro("Ped");
            foreach (Dueno p in duenosM)
            {
                Console.WriteLine(p.Nombres + " " + p.Apellidos);
            }

>>>>>>> Stashed changes
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
            foreach (Mascota m in mascotas)
            {
                Console.WriteLine(m.Nombre + " " + m.Raza + " le pertenece a " + m.Dueno.Nombres + " " + m.Dueno.Apellidos+ " y lo atiende " + m.Veterinario.Nombres);
            }

        }

        private static void ListarHistorias()
        {
            var historias = _repoHistoria.GetAllHistorias();
            foreach (Historia h in historias)
            {
<<<<<<< Updated upstream
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
=======
                Console.WriteLine(h.Id + " Este es el id de la historia");
            }
        }

        private static void ListarVeterinariosFiltro()
        {
            var veterinariosM = _repoVeterinario.GetVeterinariosPorFiltro("e");
            foreach (Veterinario p in veterinariosM)
            {
                Console.WriteLine(p.Nombres + " " + p.Apellidos);
            }

>>>>>>> Stashed changes
        }

        private static void AsignarVeterinario()
        {
<<<<<<< Updated upstream
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

=======
            var veterinario = _repoMascota.AsignarVeterinario(1, 2);
            Console.WriteLine(veterinario.Nombres + " " + veterinario.Apellidos);
        }

        private static void AsignarDueno()
        {
            var dueno = _repoMascota.AsignarDueno(1, 4);
            Console.WriteLine(dueno.Nombres + " " + dueno.Apellidos);
        }

        private static void AsignarHistoria()
        {
            var historia = _repoMascota.AsignarHistoria(1,1);
        }


    }
}
>>>>>>> Stashed changes
