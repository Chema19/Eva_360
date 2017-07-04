using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabajoFinal.Models;
using System.Data.Entity;

namespace TrabajoFinal.ViewModels.Supplier
{
    public class AddEditProveedorViewModel
    {
        public Int32? ProveedorId { get; set; }
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
        public void CargarDatos(EVA360Entities context, Int32? proveedorId)
        {
            LstTipoDocumentos = context.TipoDocumento.ToList();
            this.ProveedorId = proveedorId;
            if (this.ProveedorId.HasValue)
            {
                var proveedor = context.Proveedor.Include( x => x.Usuario).FirstOrDefault(x => x.ProveedorId == this.ProveedorId);
                Nombre = proveedor.Usuario.Nombre;
                Apellido = proveedor.Usuario.Apellido;
                Codigo = proveedor.Usuario.Codigo;
                FechaNacimiento = proveedor.Usuario.FechaNacimiento;
                NroDocumento = proveedor.Usuario.NroDocumento;
                TipoDocumentoId = proveedor.Usuario.TipoDocumentoId;
                Email = proveedor.Usuario.Email;
                Password = proveedor.Usuario.Password;
                Salt = proveedor.Usuario.Salt;
                Sexo = proveedor.Usuario.Sexo;
            }
        }
    }
}