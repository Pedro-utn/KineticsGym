using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoGym.Clases
{
    public class Plan
    {
    public string nombre { get; set; }
    public bool estado { get; set; }
    public string descripcion { get; set; }
    public float monto { get; set; }
    public int idPlan { get; set; }

        public Plan(string nombre, bool estado, string descripcion, string monto, int idPlan)
        {
            this.nombre = nombre;
            this.estado = estado;
            this.descripcion = descripcion;
            this.monto = float.Parse(monto);
            this.idPlan = idPlan;
        }

        public int getIdPlan() {
            return idPlan;
        }
        public string getNombrePlan() {
            return nombre;
        }
        public string getDescription() {
            return descripcion;
        }
        public bool getEstado() {
            return estado;
        }
        public float getCuota() {
            return monto;
        }

        public void setNombre(string nombre) {this.nombre = nombre;}
        public void setCuota(float cuota) { this.monto = cuota; }

        public void setDescripcion(string descripcion) { this.descripcion = descripcion; }

        public void setEstado (bool estado) { this.estado = estado;}
        public override string ToString() 
        {
            return nombre;
                
                
        }


    }
}
