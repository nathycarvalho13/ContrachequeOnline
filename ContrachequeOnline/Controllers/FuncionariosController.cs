using System.Linq;
using System.Web.Mvc;
using ContrachequeOnline.Models;

public class FuncionariosController : Controller
{
    private ContrachequeContext db = new ContrachequeContext();

    [HttpGet]
    public ActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Login(string cpf, string senha)
    {
        var funcionario = db.Funcionarios.FirstOrDefault(f => f.CPF == cpf && f.Senha == senha);
        if (funcionario != null)
        {
            Session["FuncionarioId"] = funcionario.FuncionarioId;
            return RedirectToAction("Index", "Home");
        }
        ViewBag.Error = "Usuário ou senha inválidos.";
        return View();
    }

    [HttpGet]
    public ActionResult Cadastro()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Cadastro(Funcionario funcionario)
    {
        if (ModelState.IsValid)
        {
            db.Funcionarios.Add(funcionario);
            db.SaveChanges();
            return RedirectToAction("Login");
        }
        return View(funcionario);
    }
}
