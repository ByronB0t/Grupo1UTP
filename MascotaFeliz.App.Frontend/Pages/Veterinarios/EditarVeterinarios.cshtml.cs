using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;


namespace MascotaFeliz.App.Frontend.Pages
{
    public class EditarVeterinariosModel : PageModel
    {
        private readonly IRepositorioVeterinario _repoDeuno;
        [BindProperty]
        public Veterinario veterinario {get;set;}
        
        public EditarVeterinariosModel()
        {
            this._repoDeuno = new RepositorioVeterinario(new Persistencia.AppContext());
        }
        public IActionResult OnGet(int? veterinarioId)
        {
            if (veterinarioId.HasValue)
            {
                veterinario = _repoDeuno.GetVeterinario(veterinarioId.Value);
            }
            else
            {
                veterinario = new Veterinario ();
            }
            if (veterinario == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if (veterinario.Id>0)
            {
                veterinario = _repoDeuno.UpdateVeterinario(veterinario);
            }
            else
            {
                _repoDeuno.AddVeterinario(veterinario);
            }
            return Page();
        }
    }
}
