using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabajoFinal.Models;
using System.Data.Entity;

namespace TrabajoFinal.ViewModels.Evaluation
{
    public class LstPeriodoEmpleadoViewModel
    {
        public List<EmpleadoPeriodo> LstPeriodo { get; set; }
        public Int32 EmpleadoId { get; set; }
        public String NombreEmpleado { get; set; }
        public void CargarDatos(EVA360Entities context, Int32 empleadoId)
        {
            this.EmpleadoId = empleadoId;
            var usuario = context.Empleado.FirstOrDefault(x => x.EmpleadoId == EmpleadoId).Usuario;
            NombreEmpleado = usuario.Nombre + " " + usuario.Apellido;
            LstPeriodo = context.EmpleadoPeriodo.Where(x => x.EmpleadoId == EmpleadoId).ToList();
        }
    }
}