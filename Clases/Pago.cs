using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrototipoGym.Clases;

namespace KinecticGym.Clases
{
    public class Pago : Movimiento
    {
        int medioPago; //1 (Efectivo) 2 (Tranferencia)

        // Constructor para generar nuevo pago desde el programa
        public Pago(Cuenta cuenta, int id, float monto, TipoMovmiento tipo, int medioPago)
            : base(cuenta, id, monto, tipo)
        {
            this.medioPago = medioPago;
        }

        // Constructor para cargar desde SQL
        public Pago(Cuenta cuenta, int id, float monto, TipoMovmiento tipo, DateTime fecha, int medioPago)
            : base(cuenta, id, monto, tipo, fecha)
        {
            this.medioPago = medioPago;
        }
        public int getMedioPago() 
        {
            return medioPago;
        }
        public void setMedio(int medioNuevo) { medioPago = medioNuevo ; }

    }
}
