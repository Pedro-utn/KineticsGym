using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Tipo de movimientos es la plantilla sobre la cual se hacen los movimientos. El tipo indica si se trata de debe o un haber,

namespace PrototipoGym.Clases
{
    public class TipoMovmiento
    {
        private string detalle;
        private int id;
        private bool tipo; //false (egreso) true (ingreso)
        private bool estado;

        public TipoMovmiento(string detalle, int id, bool tipo, bool estado)
        {
            this.detalle = detalle;
            this.id = id;
            this.tipo = tipo;
            this.estado = estado;
        }
        //Get
        public int getId() { return id; }
        public string getDetalle() { return detalle; }
        public bool getTipoBool() { return tipo; }

        public bool getEstado() { return estado; }

        //Set
        public void setDetalle(string detalle) { this.detalle = detalle; }
        public void setTipo(bool tipo) { this.tipo = tipo; }

        public void setEstado(bool estado) { this.estado = estado; }



    }
}
