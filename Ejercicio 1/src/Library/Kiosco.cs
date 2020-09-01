using System;

namespace Expert_SRP
{
    // La clase Kiosco cumple con Expert,
    // porque es el experto con la informacion para verificar si se puede comprar un alfajor o no
    // La clase Kiosco no comple SRP, 
    // porque tiene más de una razón posible de cambio. Se encarga de ver si se puede comprar o no, 
    // pero también es el responsable de convertir la moneda según el tipo de cambio 

    public class Kiosco         
    {
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            Double pesos = ConvertirAPesos(dinero, moneda);
            return pesos >= a.PrecioDulce + a.PrecioMasa;
        }
        private Double ConvertirAPesos(Double dinero, String moneda)
        {
            if (moneda.Equals("U$S")) 
            {
                return dinero / 30;
            } 
            else if (moneda.Equals("$")) 
            {
                return dinero;
            }
            else 
            {
                return -1;
            }
        }
    }
}