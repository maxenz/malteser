using Malteser.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Malteser.Controllers
{
    [Authorize]
    public class OperativaController : Controller
    {
        private ShamanContext db = new ShamanContext();
        //
        // GET: /Operativa/

        public ActionResult Index()
        {
            ViewBag.Title = "Control de la Operativa";

	    'desdewindows
            return View();
        }

        [HttpGet]
        public JsonResult getFinalizados()
        {
            var query = Request.QueryString;
            string vDesde = query.GetValues("fecDesde")[0].ToString();
            string vHasta = query.GetValues("fecHasta")[0].ToString();

            string qryIncidentes =
              "SELECT inc.ID ID, CONVERT(VARCHAR, inc.FecIncidente, 3) FechaInc, inc.NroIncidente NroInc, 0 AS NroInterno, inc.NroAfiliado NroAfiliado," +
              "inc.Paciente Paciente,dom.Domicilio Domicilio, loc.Descripcion Localidad,inc.Sintomas Sintomas," +
              "con.AbreviaturaId Grado,CASE vij.DiagnosticoId WHEN 0 THEN mot.Descripcion ELSE dig.Descripcion END Cierre," +
              "CASE vij.horFinalizacion WHEN '2999-12-31' THEN NULL ELSE CONVERT(VARCHAR, vij.horFinalizacion, 3) END AS Final  " +
              "FROM Incidentes inc " +
              "INNER JOIN Clientes cli ON (inc.ClienteId = cli.ID) " +
              "INNER JOIN IncidentesDomicilios dom ON (inc.ID = dom.IncidenteId) " +
              "INNER JOIN IncidentesViajes vij ON (dom.ID = vij.IncidenteDomicilioId) " +
              "LEFT JOIN Localidades loc ON (dom.LocalidadId = loc.ID) " +
              "INNER JOIN GradosOperativos gdo ON (inc.GradoOperativoId = gdo.ID) " +
              "LEFT JOIN ConceptosFacturacion con ON (gdo.ConceptoFacturacion1Id = con.ID) " +
              "LEFT JOIN Diagnosticos dig ON (vij.DiagnosticoId = dig.ID) " +
              "LEFT JOIN MotivosNoRealizacion mot ON (vij.MotivoNoRealizacionId = mot.ID) " +
              "WHERE inc.FecIncidente BETWEEN '" + vDesde + "' AND '" + vHasta + "' " +
              "AND cli.AbreviaturaId = 'SWISS' ";

            IEnumerable<Incidente> incidentes =
              db.Database.SqlQuery<Incidente>(qryIncidentes);

            return Json(incidentes, JsonRequestBehavior.AllowGet);
        }

    }
}
