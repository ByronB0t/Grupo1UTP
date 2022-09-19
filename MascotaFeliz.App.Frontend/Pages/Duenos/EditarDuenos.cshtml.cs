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
    public class EditarDuenosModel : PageModel
    {
        private readonly IRepositorioDueno _repoDeuno;
        [BindProperty]
        public Dueno dueno {get;set;}
        
        public EditarDuenosModel()
        {
            this._repoDeuno = new RepositorioDueno(new Persistencia.AppContext());
        }
        public IActionResult OnGet(int? duenoId)
        {
            if (duenoId.HasValue)
            {
                dueno = _repoDeuno.GetDueno(duenoId.Value);
            }
            else
            {
                dueno = new Dueno ();
            }
            if (dueno == null)
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
            if (dueno.Id>0)
            {
                dueno = _repoDeuno.UpdateDueno(dueno);
            }
            else
            {
                _repoDeuno.AddDueno(dueno);
            }
            return Page();
        }
    }
}
