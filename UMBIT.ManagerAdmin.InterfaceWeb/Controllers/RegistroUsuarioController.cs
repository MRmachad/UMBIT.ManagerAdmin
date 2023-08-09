﻿using Microsoft.AspNetCore.Mvc;
using UMBIT.ManagerAdmin.Dominio.Servicos.Identidade;
using UMBIT.ManagerAdmin.InterfaceWeb.ViewModels;

namespace UMBIT.ManagerAdmin.InterfaceWeb.Controllers
{
    public class RegistroUsuarioController : Controller
    {
        private readonly IServicoDeIdentidade ServicoDeIdentidade;
        public RegistroUsuarioController(IServicoDeIdentidade servicoDeIdentidade)
        {
                this.ServicoDeIdentidade = servicoDeIdentidade;
        }
        public IActionResult Login()
        {
            return View(new LoginRequest());
        }

        [HttpPost]
        public IActionResult Login(LoginRequest loginRequest)
        {
            this.ServicoDeIdentidade.Login(loginRequest.Email, loginRequest.Senha);
            return RedirectToAction("Index", "Home");
        }
    }
}
