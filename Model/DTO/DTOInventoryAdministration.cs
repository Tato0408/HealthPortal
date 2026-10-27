using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthPortal.Model.DTO
{
    internal class DTOInventoryAdministration : dbContext
    {
        private int cantidadMedicamento;
        private int idMedicamento;
        private string nombreMedicamento;
        private int existencia;
        private int envases;
        private DateTime fechaVencimiento;
        private DateTime ingreso;
        private string salida;
        private string descripcion;
        private int idCategoria;
        private int idCategoriaInventario;
        private int idEntradaSalida;
        private byte[] imagen;
        private string categoriaMedicamento;
        private DateTime fechaInicio;
        private DateTime fechaFin;

        public string NombreMedicamento { get => nombreMedicamento; set => nombreMedicamento = value; }
        public int Existencia { get => existencia; set => existencia = value; }
        public DateTime FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
        public DateTime Ingreso { get => ingreso; set => ingreso = value; }
        public string Salida { get => salida; set => salida = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public int IdCategoriaInventario { get => idCategoriaInventario; set => idCategoriaInventario = value; }
        public int IdMedicamento { get => idMedicamento; set => idMedicamento = value; }
        public int CantidadMedicamento { get => cantidadMedicamento; set => cantidadMedicamento = value; }
        public int IdEntradaSalida { get => idEntradaSalida; set => idEntradaSalida = value; }
        public int Envases { get => envases; set => envases = value; }
        public byte[] Imagen { get => imagen; set => imagen = value; }
        public string CategoriaMedicamento { get => categoriaMedicamento; set => categoriaMedicamento = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
    }
}