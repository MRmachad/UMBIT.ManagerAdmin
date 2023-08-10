using Microsoft.AspNetCore.Mvc;
using UMBIT.ManagerAdmin.InterfaceWeb.Controllers.Base;
using UMBIT.ManagerAdmin.InterfaceWeb.Recursos.CustomAtributte;

namespace UMBIT.ManagerAdmin.InterfaceWeb.Controllers
{
    public class ProdutosController : ServiceController
    {
        [ServiceAttribute("Cadastro de Produto")]
        public IActionResult CadastroProduto()
        {
            return View();  
        }
    }
}
