using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrototipoGym.Clases;

namespace PrototipoGym.GestoresDeClase
{
    public class gestorCuenta
    {
        List<Cuenta> cuentas;

        public gestorCuenta()
        {
            cuentas = new List<Cuenta>();
        }
        public Cuenta getCuenta(int idCuenta)
        {

            foreach (Cuenta cuenta in cuentas)
            {
                if (cuenta.getIdCuenta() == idCuenta)
                {
                    return cuenta;
                }
            }
            return null;
        }

        public void addCuenta(Cuenta cuenta)
        {
            cuentas.Add(cuenta);
        }

    }

}
