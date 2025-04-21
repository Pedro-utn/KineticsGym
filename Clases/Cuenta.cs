using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoGym.Clases
{
    public class Cuenta
    {
        private List<Movimiento> movimientos;
        private float saldo;
        private int id;

        public Cuenta(int id)
        {
            this.id = id;
            movimientos = new List<Movimiento>();
        }

        public void addMovimiento(Movimiento nuevoMovimiento) { // se guarda el movmiento y se modifica el saldo
            movimientos.Add(nuevoMovimiento);

            actualizarSaldo();
        }

        public int getIdCuenta() {
            return id;
        }
        public string showMovimientos()
        {
            string cadena = "Movimientos:\n";
            foreach (Movimiento movimiento in movimientos)
            {
                cadena += $"{movimiento.toString()}\n";
            }
            return cadena;
        }
        public override string ToString()
        {
            return $"Movimientos: {showMovimientos()} saldo = {saldo}";
        }
        public float getSaldo() {
            actualizarSaldo();
            return saldo;
        }
        public List<Movimiento> getListMovimientos() { return movimientos; }

        public void actualizarSaldo ()
        {
            saldo = 0;
            foreach (Movimiento mov in movimientos )
            {
                saldo += mov.getImporteFloat();
            }
        }
        public float getSaldoAnterior(DateTime fechasDesde)
        {
            float saldoAnterior = saldo;
            movimientos.Sort((a, b) => b.getFecha().CompareTo(a.getFecha()));
            foreach (Movimiento mov in movimientos)
            {
                if (mov.getFecha() >= fechasDesde)
                {
                    saldoAnterior -= mov.getImporteFloat();
                }  
                else
                {
                    break;
                }
            }
            return saldoAnterior;

        }


        public void eliminarMovimiento(Movimiento mov) 
        {
            movimientos.Remove(mov);
            //Se corrige el saldo
            saldo -= mov.getImporteFloat();

        }



    }
}
