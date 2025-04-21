using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PrototipoGym.Clases
{
    public class Movimiento
    {
        protected int id;
        protected Cuenta cuentaMovimiento;
        protected float monto;
        protected DateTime fecha; // Por predeterminado cada movimiento tiene la fecha de hoy
        protected TipoMovmiento tipo; 

        // Constructor Generar

        public Movimiento() { }
        public Movimiento(Cuenta cuenta, int id, float monto, TipoMovmiento tipo) //Construsctor para nuevos movimientos.
        {
            this.cuentaMovimiento = cuenta;
            this.id = id;
            this.monto = monto;
            this.tipo = tipo;
            fecha = DateTime.Now;
            
            impactarCuenta();
        }
        //Constructor SQL
        public Movimiento(Cuenta cuenta, int id, float monto, TipoMovmiento tipo,DateTime fecha)
        {
            this.cuentaMovimiento = cuenta;
            this.id = id;
            this.monto = monto;
            this.tipo = tipo;
            this.fecha = fecha;
        }

        // Método para obtener el ID de la cuenta de movimiento
        public Cuenta getCuentaMov()
        {
            return cuentaMovimiento;
        }

        protected void impactarCuenta()
        {
            cuentaMovimiento.addMovimiento(this);
        }

        // Método para convertir el objeto en un string
        public string toString()
        {
            return $"id = {id}, fecha= {fecha}, monto = {monto}";
        }

        // Método mixto para obtener la fecha y hora confiable

        public float getImporteFloat()
        {
            if (tipo.getTipoBool())
            {
                return monto;
            }
            return (-monto);

        }
        public void setFecha (DateTime fechaNueva) { fecha = fechaNueva; }


        public void setImporte (float importe) { this.monto = importe;  }
        public int getId() { return id; }
        public float getMonto() { return monto; }

        public DateTime getFecha() { return fecha; }

        public TipoMovmiento getTipo() { return tipo; }
    }


}
