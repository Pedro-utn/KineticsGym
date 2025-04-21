using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI;
using PrototipoGym.Clases;
using PrototipoGym.DataBase;

namespace PrototipoGym.GestoresDeClase
{
    public class gestorTipoMovmientos
    {
        private List<TipoMovmiento> tiposMovmientos;
        private DatabaseHelper dbHelper;

        public gestorTipoMovmientos(DatabaseHelper dbHelper) { 
            tiposMovmientos = new List<TipoMovmiento>();
            this.dbHelper = dbHelper;
        }

        public void addTipo(TipoMovmiento tipoMovmiento)
        {
            tiposMovmientos.Add(tipoMovmiento);
        }

        public TipoMovmiento validarExistenciaTipoMov(string nombre, bool impacto)
        {
            foreach (TipoMovmiento tipoMov in tiposMovmientos ) 
            {
                if (tipoMov.getDetalle() == nombre)
                {
                    return tipoMov;
                }
            }
            // En el caso de que no exista el tipoMov se crea
            TipoMovmiento tipoMovNuevo = new TipoMovmiento(nombre,dbHelper.GetLastId("tipomovimiento", "idtipoMovimiento"),impacto,true);
            this.addTipo(tipoMovNuevo);
            dbHelper.insertarTipoMovimiento(tipoMovNuevo);
            return tipoMovNuevo;
        }

        public TipoMovmiento getTipoMov(int id)
        {
            foreach (TipoMovmiento tipoMov in tiposMovmientos) 
            {
                if (tipoMov.getId() == id) 
                {
                    return tipoMov;
                }
            }
            MessageBox.Show($"No se encontro id compatible con el tipoMovimiento a buscar: {id}");
            return null;
        }
        public List<TipoMovmiento> getTipoMovmientosList()
        {
            return tiposMovmientos;
        }


    }


}
