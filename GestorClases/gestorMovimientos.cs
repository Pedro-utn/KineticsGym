using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KinecticGym.Clases;
using PrototipoGym.Clases;

namespace PrototipoGym.GestoresDeClase
{
    public class gestorMovimientos
    {
        private List<Movimiento> movimientos;


        public gestorMovimientos()
        {
            movimientos = new List<Movimiento>();
        }

        public void addMovmiento(Movimiento movimiento)
        {
            movimientos.Add(movimiento);
        }
        public Movimiento getMovimiento(int id)
        {
            return movimientos.FirstOrDefault(mov => mov.getId() == id);
        }
        public List<Movimiento> getMovmientosList()
        {
            return movimientos;
        }
        public List<Pago> getPagosList()
        {
            List<Pago> pagos = new List<Pago>();

            foreach (Movimiento mov in movimientos)
            {
                if (mov is Pago pago)
                {
                    pagos.Add(pago);
                }
            }
            return pagos;
        }

        public int getLastIdMasuno()
        {
            if (movimientos.Count > 0) // Verifica si hay elementos en la lista
            {
                Movimiento ultimoMovmiento = movimientos[movimientos.Count - 1];
                return (ultimoMovmiento.getId()) + 1;
                // Aquí puedes trabajar con "ultimoTipo"
            }
            else
            {
                // Opcional: Si la lista está vacía, dar el id num 1.
                return 1;
            }
        }

        public void eliminarMovimiento(Movimiento mov)
        {
            movimientos.Remove(mov);
        }




        
            // Método para obtener el total en efectivo entre un rango de fechas
            public float getEfectivoTotal(DateTime desde, DateTime hasta)
            {
                float totalEfectivo = 0;

                foreach (Movimiento mov in movimientos)
                {
                    // Verificar si el movimiento es un pago y está dentro del rango de fechas
                    if (mov is Pago pago &&
                        mov.getFecha().Date >= desde.Date &&
                        mov.getFecha().Date <= hasta.Date)
                {
                        // Verificar si el medio de pago es efectivo (medio = 1)
                        if (pago.getMedioPago() == 1)
                        {
                            totalEfectivo += pago.getMonto();
                        }
                    }
                }

                return totalEfectivo;
            }

            // Método para obtener el total en transferencias entre un rango de fechas
            public float getTransferenciaTotal(DateTime desde, DateTime hasta)
            {
                float totalTransferencia = 0;

                foreach (Movimiento mov in movimientos)
                {
                    // Verificar si el movimiento es un pago y está dentro del rango de fechas
                    if (mov is Pago pago &&
                        mov.getFecha().Date >= desde.Date &&
                        mov.getFecha().Date <= hasta.Date)
                    {
                        // Verificar si el medio de pago es transferencia (medio = 2)
                        if (pago.getMedioPago() == 2)
                        {
                            totalTransferencia += pago.getMonto();
                        }
                    }
                }

                return totalTransferencia;
            }
    }
}





