using System.Linq;
using System.Web.Mvc;
using ContrachequeOnline.Models;

public class ContrachequesController : Controller
{
    private ContrachequeContext db = new ContrachequeContext();

    public ActionResult Index()
    {
        int funcionarioId = (int)Session["FuncionarioId"];
        var contracheques = db.Contracheques.Where(c => c.FuncionarioId == funcionarioId).ToList();
        return View(contracheques);
    }

    [HttpGet]
    public ActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Create(Contracheque contracheque)
    {
        int funcionarioId = (int)Session["FuncionarioId"];
        contracheque.FuncionarioId = funcionarioId;
        if (ModelState.IsValid)
        {
            db.Contracheques.Add(contracheque);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(contracheque);
    }

    [HttpGet]
    public ActionResult Edit(int id)
    {
        var contracheque = db.Contracheques.Find(id);
        return View(contracheque);
    }

    [HttpPost]
    public ActionResult Edit(Contracheque contracheque)
    {
        if (ModelState.IsValid)
        {
            db.Entry(contracheque).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(contracheque);
    }

    public ActionResult Delete(int id)
    {
        var contracheque = db.Contracheques.Find(id);
        db.Contracheques.Remove(contracheque);
        db.SaveChanges();
        return RedirectToAction("Index");
    }
}
