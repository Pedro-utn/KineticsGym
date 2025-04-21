using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrototipoGym.Clases;
using PrototipoGym.Pantallas;

namespace PrototipoGym.GestoresDeClase
{
    public class gestorCliente
    {
        private List<Cliente> clientes;

        public gestorCliente() { 
            clientes = new List<Cliente>();
        }

        public Cliente getCliente(int id) 
        {
            foreach (Cliente cliente in clientes)
            {
                if (cliente.getId() == id)
                {
                    return cliente;
                }
            }
            return null;
            
        }
        public void cargarCliente(Cliente cliente) {
            clientes.Add(cliente);
        }

        public int getLastID_MasUno()
        {
            if (clientes.Count == 0) 
            {
                return 1;
            
            }
            else
            {
                return (clientes.Count) + 1;
            }
        }

        public void messegeShowClientes() {
            foreach (Cliente cliente in clientes)
            {
                MessageBox.Show(cliente.ToString());
            }
        }

        public List<String> getAllClientesString()
        {
            List<string> clientesString = new List<string>();
            foreach (Cliente cliente in clientes)
            {
                clientesString.Add(cliente.getId() + "   " + cliente.getNombre() + "   " + cliente.getEstado());
            }
            return clientesString;
        }
        public List<Cliente> getClienteList() {  return clientes; }

        public void eliminateCliente(int id)
        {
            for (int i = 0; i < clientes.Count; i++)
            {
                if (clientes[i].getId() == id)
                {
                    clientes.RemoveAt(i);
                    break; // Salir del bucle después de eliminar el cliente
                }
            }
        }



        public  string ClienteYaExiste( string nombreBuscado, int umbral = 80)
        {
            string normalizadoBuscado = NormalizarNombre(nombreBuscado);

            string mejorCoincidencia = null;
            int mejorPuntaje = 0;

            foreach (var cliente in clientes)
            {
                string nombreCliente = cliente.getNombre();
                if (string.IsNullOrWhiteSpace(nombreCliente)) continue;

                string normalizadoCliente = NormalizarNombre(nombreCliente);

                int distancia = Levenshtein(normalizadoBuscado, normalizadoCliente);
                int maxLen = Math.Max(normalizadoBuscado.Length, normalizadoCliente.Length);
                int porcentajeSimilitud = 100 - (distancia * 100 / maxLen);

                if (porcentajeSimilitud >= umbral && porcentajeSimilitud > mejorPuntaje)
                {
                    mejorPuntaje = porcentajeSimilitud;
                    mejorCoincidencia = nombreCliente;
                }
            }

            return mejorCoincidencia;
        }

        private static string NormalizarNombre(string nombre)
        {
            string sinTildes = nombre.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();
            foreach (char c in sinTildes)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != System.Globalization.UnicodeCategory.NonSpacingMark)
                    sb.Append(c);
            }

            string limpio = sb.ToString().ToLower();
            limpio = Regex.Replace(limpio, @"[^a-z\s]", ""); // Elimina comas, puntos, etc.
            var palabrasOrdenadas = limpio.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                          .OrderBy(p => p);
            return string.Join(" ", palabrasOrdenadas);
        }

        // Método Levenshtein básico
        private static int Levenshtein(string s, string t)
        {
            int[,] d = new int[s.Length + 1, t.Length + 1];

            for (int i = 0; i <= s.Length; i++) d[i, 0] = i;
            for (int j = 0; j <= t.Length; j++) d[0, j] = j;

            for (int i = 1; i <= s.Length; i++)
            {
                for (int j = 1; j <= t.Length; j++)
                {
                    int costo = s[i - 1] == t[j - 1] ? 0 : 1;
                    d[i, j] = Math.Min(
                        Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                        d[i - 1, j - 1] + costo
                    );
                }
            }

            return d[s.Length, t.Length];
        }

    }
}
