using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Prenda : BaseEntity
    {
        public string IdPrenda { get; set; }
        public string Nombre { get; set; }
        public double ValorUnitCop { get; set; }
        public double ValorUnitUsd { get; set; }
        public int IdTipoProteccionFk { get; set; }
        public TipoProteccion TipoProteccion { get; set; }
        public int IdEstadoFk { get; set; }
        public Estado Estado { get; set; }
        public int IdGeneroFk { get; set; }
        public Genero Genero { get; set; }
                public ICollection<Insumo> Insumos { get; set; }

        public ICollection<Inventario> Inventarios { get; set; }
        public ICollection<InsumoPrenda> InsumosPrenda { get; set; }
        public ICollection<DetalleOrden> DetallesOrden { get; set; }

    }
}