using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace EAgendaWeb.WebApp.Modulos.ModuloContato.Apresentacao;

public class ContatoController : Controller
{
    public ActionResult Listar()
    {
        return View();
    }
}
