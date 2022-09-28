using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TecproSas.App.Persistencia;
using TecproSas.App.Dominio;

namespace TecproSas.App.SitioWeb.Pages_Login
{
    public class EditModel : PageModel
    {
        private IRepositorioLogin _repoLogin {get; set;}
        [BindProperty]
        public Login login {get; set;}

        public EditModel()
        {
            _repoLogin = new RepositorioLogin(new TecproSas.App.Persistencia.AppContext());
        }

        public IActionResult OnGet(int id)
        {
            login = _repoLogin.GetLogin(id);
            if (login == null)
            {
                return RedirectToPage("/Login/List");
            }
            else
            {
                return Page();
            }
        }


        public IActionResult OnPost(Login login)
        {
            _repoLogin.UpdateLogin(login);
            return RedirectToPage("/Login/List");
        }
    }
}
