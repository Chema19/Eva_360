using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabajoFinal.Models;
using System.Data.Entity;

namespace TrabajoFinal.ViewModels.Evaluation
{
    public class AddEditPeriodoEmpleadoViewModel
    {
        public Int32 EmpleadoId { get; set; }
        public Int32 PeriodoId { get; set; } 
        public Int32? EmpleadoPeriodoId { get; set; }

        public String NombreEmpleado { get; set; }
        public List<Periodo> LstPeriodos { get; set; } = new List<Periodo>();
        public void CargarDatos(EVA360Entities context, Int32 empleadoId, Int32? empleadoPeriodoId)
        {
            this.EmpleadoId = EmpleadoId;
            this.EmpleadoPeriodoId = empleadoPeriodoId;

            var usuario = context.Empleado.FirstOrDefault(x => x.EmpleadoId == EmpleadoId).Usuario;
            NombreEmpleado = usuario.Nombre + " " + usuario.Apellido;

            if (this.EmpleadoPeriodoId.HasValue)
            {
                var empleadoPeriodo = context.EmpleadoPeriodo.FirstOrDefault( x => x.EmpleadoPeriodoId == EmpleadoPeriodoId);
                PeriodoId = empleadoPeriodo.PeriodoId;
            }
        }
    }
}