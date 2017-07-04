using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabajoFinal.Helpers;
using TrabajoFinal.ViewModels.Evaluation;
using TrabajoFinal.Models;

namespace TrabajoFinal.Controllers
{
    public class EvaluationController : BaseController
    {
        // GET: Evaluation
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LstPeriodoEmpleado(Int32 EmpleadoId)
        {
            var model = new LstPeriodoEmpleadoViewModel();
            model.CargarDatos(context, EmpleadoId);
            return View(model);
        }
        public ActionResult AddEditPeriodoEmpleado(Int32 EmpleadoId, Int32? EmpleadoPeriodoId)
        {
            var model = new AddEditPeriodoEmpleadoViewModel();
            model.CargarDatos(context,EmpleadoId, EmpleadoPeriodoId);
            return View(model);
        }
        [HttpPost]
        public ActionResult AddEditPeriodoEmpleado(AddEditPeriodoEmpleadoViewModel model)
        {
            try
            {
                EmpleadoPeriodo EmpleadoPeriodo = null;
                if (model.EmpleadoPeriodoId.HasValue)
                {
                    EmpleadoPeriodo = context.EmpleadoPeriodo.FirstOrDefault(x => x.EmpleadoPeriodoId == model.EmpleadoPeriodoId);
                }
                else
                {
                    EmpleadoPeriodo = new EmpleadoPeriodo();
                    EmpleadoPeriodo.SupervisorId = Convert.ToInt32(Session["UsuarioId"].ToString());
                    EmpleadoPeriodo.UsuarioCreacionId = Convert.ToInt32(Session["UsuarioId"].ToString());
                    EmpleadoPeriodo.EmpleadoId = model.EmpleadoId;
                    EmpleadoPeriodo.FechaCreacion = DateTime.Now;
                    context.EmpleadoPeriodo.Add(EmpleadoPeriodo);
                }

                EmpleadoPeriodo.PeriodoId = model.PeriodoId;
                EmpleadoPeriodo.UsuarioModificacionId = Convert.ToInt32(Session["UsuarioId"].ToString());
                EmpleadoPeriodo.FechaModificacion = DateTime.Now;

                context.SaveChanges();
                PostMessage(MessageType.Success, "La operación fue realizada de forma correcta");
                return RedirectToAction("LstPeriodoEmpleado",new { EmpleadoId = model.EmpleadoId });
            }
            catch (Exception ex)
            {
                PostMessage(MessageType.Error, "Sucedió un error, intente nuevamente.");
                return RedirectToAction("LstPeriodoEmpleado", new { EmpleadoId = model.EmpleadoId });
            }
        }
        public ActionResult LstPeriodo()
        {
            var model = new LstPeriodoViewModel();
            model.CargarDatos(context);
            return View(model);
        }
        public ActionResult AddEditPeriodo(Int32? PeriodoId)
        {
            var model = new AddEditPeriodoViewModel();
            model.CargarDatos(context, PeriodoId);
            return View(model);
        }
        public ActionResult EliminarPeriodo(Int32? PeriodoId)
        {
            try
            {
                var Periodo = context.Periodo.FirstOrDefault(x => x.PeriodoId == PeriodoId);
                Periodo.Estado = ConstantHelpers.ESTADO_USUARIO.INACTIVO;
                context.SaveChanges();
                PostMessage(MessageType.Success, "La operación fue realizada de forma correcta");
                return RedirectToAction("LstPeriodo");
            }
            catch (Exception ex)
            {
                PostMessage(MessageType.Error, "Sucedió un error, intente nuevamente.");
                return RedirectToAction("LstPeriodo");
            }
        }
        [HttpPost]
        public ActionResult AddEditPeriodo(AddEditPeriodoViewModel model)
        {
            try
            {
                Periodo Periodo = null;
                if (model.PeriodoId.HasValue)
                {
                    Periodo = context.Periodo.FirstOrDefault(x => x.PeriodoId == model.PeriodoId);
                }
                else
                {
                    Periodo = new Periodo();
                    Periodo.UsuarioCreacionId = Convert.ToInt32(Session["UsuarioId"].ToString());
                    Periodo.FechaCreacion = DateTime.Now;
                    Periodo.Estado = ConstantHelpers.ESTADO_USUARIO.ACTIVO;
                    context.Periodo.Add(Periodo);
                }

                Periodo.UsuarioModificacionId = Convert.ToInt32(Session["UsuarioId"].ToString());
                Periodo.FechaModificacion = DateTime.Now;

                Periodo.Nombre = model.Nombre;
                Periodo.FechaFin = model.FechaFin;
                Periodo.FechaInicio = model.FechaInicio;

                context.SaveChanges();

                PostMessage(MessageType.Success, "La operación fue realizada de forma correcta");
                return RedirectToAction("LstPeriodo");
            }
            catch (Exception ex)
            {
                PostMessage(MessageType.Error, "Sucedió un error, intente nuevamente.");
                model.CargarDatos(context, model.PeriodoId);
                return View(model);
            }
        }
    }
}