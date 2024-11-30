using Projeto_PIM.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Projeto_PIM.Controllers
{
    public class HomeController : Controller
    {
        private CadClientesEntities1 db = new CadClientesEntities1();

        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult LoginEmpresa()
        {
            return View();
        }

        public ActionResult CadEmpresa()
        {
            return View();
        }

        public ActionResult Menu()
        {
            return View();
        }

        public ActionResult CadCliente()
        {
            return View();
        }
        public ActionResult Produtos()
        {
            return View();
        }
        public ActionResult ProdutoAlecrim()
        {
            return View();
        }
        public ActionResult ProdutoLavanda()
        {
            return View();
        }
        public ActionResult ProdutoOregano()
        {
            return View();
        }
        public ActionResult ProdutoHortela()
        {
            return View();
        }
        public ActionResult ProdutoCoentro()
        {
            return View();
        }
        public ActionResult Carrinho()
        {

            return View();
        }




        [HttpPost]
        public ActionResult Login(CadCliente usuario)
        {
            if (ModelState.IsValid)
            {
                // Verifica se o CPF e a senha estão corretos
                var cliente = db.CadCliente.SingleOrDefault(a => a.CPF == usuario.CPF && a.Senha == usuario.Senha);

                if (cliente != null)
                {
                    TempData["ToastrMessage"] = "Login realizado com sucesso!";
                    TempData["ToastrType"] = "success";
                    return RedirectToAction("Menu");
                }
                else
                {
                    TempData["ToastrMessage"] = "CPF ou senha incorretos.";
                    TempData["ToastrType"] = "error";
                }
            }
            else
            {
                TempData["ToastrMessage"] = "Por favor, preencha todos os campos obrigatórios.";
                TempData["ToastrType"] = "error";
            }
            return View(usuario);
        }

        [HttpPost]
        public ActionResult LoginEmpresa(CadEmpresa empresa)
        {
            if (ModelState.IsValid)
            {
                // Verifica se o CNPJ e a senha estão corretos
                var cliente = db.CadEmpresa.SingleOrDefault(a => a.CNPJ == empresa.CNPJ && a.Senha == empresa.Senha);

                if (cliente != null)
                {
                    TempData["ToastrMessage"] = "Login realizado com sucesso!";
                    TempData["ToastrType"] = "success";
                    return RedirectToAction("Menu");
                }
                else
                {
                    TempData["ToastrMessage"] = "CNPJ ou senha incorretos.";
                    TempData["ToastrType"] = "error";
                }
            }
            else
            {
                TempData["ToastrMessage"] = "Por favor, preencha todos os campos obrigatórios.";
                TempData["ToastrType"] = "error";
            }
            return View(empresa);
        }

        [HttpPost]
        public ActionResult CadEmpresa(CadEmpresa empresa)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // Adiciona a empresa ao banco de dados
                    db.CadEmpresa.Add(empresa);
                    db.SaveChanges();

                    TempData["ToastrMessage"] = "Cadastro realizado com sucesso!";
                    TempData["ToastrType"] = "success";

                    return RedirectToAction("LoginEmpresa");
                }
                catch (System.Exception ex)
                {
                    TempData["ToastrMessage"] = "Erro ao salvar os dados: " + ex.Message;
                    TempData["ToastrType"] = "error";
                }
            }
            else
            {
                TempData["ToastrMessage"] = "Por favor, preencha todos os campos corretamente.";
                TempData["ToastrType"] = "error";
            }
            return View(empresa);
        }

        public ActionResult Sobre2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CadCliente(CadCliente cliente)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // Adiciona o cliente ao banco de dados
                    db.CadCliente.Add(cliente);
                    db.SaveChanges();

                    TempData["ToastrMessage"] = "Cadastro realizado com sucesso!";
                    TempData["ToastrType"] = "success";

                    return RedirectToAction("Login");
                }
                catch (System.Exception ex)
                {
                    TempData["ToastrMessage"] = "Erro ao salvar os dados: " + ex.Message;
                    TempData["ToastrType"] = "error";
                }
            }
            else
            {
                TempData["ToastrMessage"] = "Por favor, preencha todos os campos corretamente.";
                TempData["ToastrType"] = "error";
            }
            return View(cliente);
        }
    }

}
