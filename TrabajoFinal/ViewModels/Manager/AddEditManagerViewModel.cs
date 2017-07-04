using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabajoFinal.Models;
using System.Data.Entity;

namespace TrabajoFinal.ViewModels.Manager
{
    public class AddEditManagerViewModel
    {
        public Int32? SupervisorId { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Codigo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public String Sexo { get; set; }
        public String NroDocumento { get; set; }
        public Int32 TipoDocumentoId { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public String Salt { get; set; }
        public List<TipoDocumento> LstTipoDocumentos { get; set; } = new List<TipoDocumento>();
        public void CargarDatos(EVA360Entities context, Int32? supervisorId)
        {
            LstTipoDocumentos = context.TipoDocumento.ToList();
            this.SupervisorId = supervisorId;
            if (this.SupervisorId.HasValue)
            {
                var supervisor = context.Supervisor.Include(x => x.Usuario).FirstOrDefault(x => x.SupervisorId == this.SupervisorId);
                Nombre = supervisor.Usuario.Nombre;
                Apellido = supervisor.Usuario.Apellido;
                Codigo = supervisor.Usuario.Codigo;
                FechaNacimiento = supervisor.Usuario.FechaNacimiento;
                NroDocumento = supervisor.Usuario.NroDocumento;
                TipoDocumentoId = supervisor.Usuario.TipoDocumentoId;
                Email = supervisor.Usuario.Email;
                Password = supervisor.Usuario.Password;
                Salt = supervisor.Usuario.Salt;
                Sexo = supervisor.Usuario.Sexo;
            }
        }
    }
}