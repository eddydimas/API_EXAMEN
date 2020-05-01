using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_EXAMEN.Entities
{
    public class Instrumento
    {
        [Key]
        public string Simbolo { get; set; }
        public decimal? UltimoHecho { get; set; }
        public decimal? ValorAnterior { get; set; }
        public decimal? VariacionUnitaria { get; set; }
        public decimal? VariacionPorcentual { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Campo001 { get; set; }
        public int? Campo008 { get; set; }
        public decimal? PrecioCompra { get; set; }
        public decimal? PrecioCompraAnterior { get; set; }
        public decimal? VariacionUnitariaCompra { get; set; }
        public decimal? VariacionPorcentualCompra { get; set; }
        public decimal? PrecioVenta { get; set; }
        public decimal? PrecioVentaAnterior { get; set; }
        public decimal? VariacionUnitariaVenta { get; set; }
        public string VariacionPorcentualVenta { get; set; }
    }
}
