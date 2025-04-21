using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrototipoGym.Clases
{
    public class Cliente
    {
        // Atributos
        private int id;
        private string nombre { get; set; }
        private string telefono;
        private Plan planAsociado;
        private Cuenta cuentaAsociada;
        private bool estado;
        private DateTime fechaInscripcion;

        // Constructor
        public Cliente(int id, string nombre, string telefono, Plan planAsociado, Cuenta cuentaAsociada, bool estado, DateTime fechaInscripcion)
        {
            this.id = id;
            this.nombre = nombre;
            this.telefono = telefono;
            this.planAsociado = planAsociado;
            this.cuentaAsociada = cuentaAsociada;
            this.estado = estado;
            this.fechaInscripcion = fechaInscripcion;
        }

        // Método ToString sobreescrito
        public override string ToString()
        {
            return (
                $"Nombre del Cliente: {nombre ?? "N/A"} \n" +
                $"Número identificador: {id}\n" +
                $"Teléfono: {telefono ?? "N/A"}\n" +
                $"Plan: {planAsociado?.ToString() ?? "N/A"}\n" +
                $"Estado: {estado}\n" +
                $"Cuenta: {cuentaAsociada?.ToString() ?? "N/A"}\n"
            );
        }
        public int getId() {  return id; }
        public string getNombre() { return nombre; }
        public string getTelefono() {   return telefono; }
        public Plan getPlanAsociado() { return planAsociado; }
        public Cuenta getCuenta() { return cuentaAsociada; }

        public DateTime getFechaInscripcion() { return DateTime.Now; }

        public bool getEstado() { return estado; }

        public void setNombre(string nombre) { this.nombre = nombre; }

        public void setPlan(Plan plan) { this.planAsociado = plan; }

        public void setTelefono(string telefono) { this.telefono = telefono; }

        public void setEstado(bool estado) { this.estado = estado; }
    }



    // Clases Plan y Cuenta para ejemplo
   
}
