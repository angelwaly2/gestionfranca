using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PruebaCSharp.Models;

namespace PruebaCSharp.Controllers
{
    public class TecnicoController : Controller
    {
        public TecnicoModel tecModel = new TecnicoModel();

        public ActionResult Index()
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            ViewBag.message = new SelectList(tecModel.listar_sucursales(),"id","sucursal");
            ViewBag.datos = new SelectList(tecModel.listar_Elementos(), "id_elemento", "nom_elemento");
            return View(tecModel.listar());
        }

        [HttpPost]
        public ActionResult Index(FormCollection formCollection)
        {
            try
            {
                // Insertar datos en sql server

                DataClasses1DataContext db = new DataClasses1DataContext();
                TecnicoModel.Tecnico tec = new TecnicoModel.Tecnico();
                return View();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
