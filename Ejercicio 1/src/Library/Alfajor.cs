using System;

namespace Expert_SRP
{
    public class Alfajor 
    {
        // La clase alfajor cumple con SRP y Expert porque es el experto que maneja los datos de alfajor
        // y tiene una única responsabilidad
        public Alfajor(double precioMasa, double precioDulce)
        {
            this.PrecioDulce = precioDulce;
            this.PrecioMasa = precioMasa;
        }
        public Double PrecioDulce {get;set;}
        public Double PrecioMasa {get; set;}
    }
}