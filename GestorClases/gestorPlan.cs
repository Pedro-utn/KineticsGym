using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrototipoGym.Clases;

namespace PrototipoGym.GestoresDeClase
{
    public class gestorPlan
    {
        private List<Plan> planes;

        public gestorPlan() {
            planes = new List<Plan>(); // Inicializa la lista de planes
        }

        public void cargarPlan(Plan planCargado)
        {
            planes.Add(planCargado);
        }


        public Plan getPlan(int identificador)
        {
            foreach (Plan plan in planes)
            {
                if (plan.getIdPlan() == identificador)
                {
                    return plan;
                }
            }
            MessageBox.Show("No se a encontrado un plan");
            return null;
        }
        public void showPlanes() {
            foreach (Plan plan in planes)
            {
                MessageBox.Show(plan.ToString());

            }
        }


        public List<String> getAllPlanes()
        {
            List<String> names = new List<String>();
            foreach(Plan plan in planes)
            {
                names.Add(plan.getIdPlan()+" "+plan.getNombrePlan()+"            "+plan.getCuota());
            }
            return names;
        }
        public List<Plan> getPlanList() { return planes; }
    }
}
