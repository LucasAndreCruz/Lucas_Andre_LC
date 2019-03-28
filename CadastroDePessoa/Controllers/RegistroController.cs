using CadastroDePessoa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadastroDePessoa.Controllers
{
    public class RegistroController : Controller
    {
        // GET: Registro
        [HttpPost]
        public ActionResult Index(int PessoaId, string Nome, string DataDeNascimento, string RG, string CPF)
        {

            ViewData["PessoaId"] = PessoaId;
            ViewData["Nome"] = Nome;
            ViewData["DataDeNascimento"] = DataDeNascimento;
            ViewData["RG"] = RG;
            ViewData["CPF"] = CPF;

            return View();
        }
    }
}