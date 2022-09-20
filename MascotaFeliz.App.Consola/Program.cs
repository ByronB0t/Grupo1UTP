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
<<<<<<< HEAD
        private static IRepositorioMascota _repoMascota = new RepositorioMascota (new Persistencia.AppContext());
        
=======
>>>>>>> 010c81019b6f0397113eb89126416ab8053b9530
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddDueno();
<<<<<<< HEAD
            //BuscarDueno(1);
            //ListarDuenos();  
            //AddVeterinario();
            //AddMascota();
            //ListarMascotas();
            
=======
            AddVeterinario();

>>>>>>> 010c81019b6f0397113eb89126416ab8053b9530
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
<<<<<<< HEAD
    

   
=======
>>>>>>> 010c81019b6f0397113eb89126416ab8053b9530
        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
<<<<<<< HEAD
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
=======
                //Cedula = "121212",
                Nombres = "Pepito",
                Apellidos = "Garcia",
                Direccion = "En las nubes",
                Telefono = "546554",
                TarjetaProfesional = "tj456521"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }
>>>>>>> 010c81019b6f0397113eb89126416ab8053b9530
    }
}
// Ensayo
