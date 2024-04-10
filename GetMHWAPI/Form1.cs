using GetMHWAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetMHWAPI
{
    public partial class FormAPI : Form
    {
        public FormAPI()
        {
            InitializeComponent();
        }

        private void buttonLlamar_Click(object sender, EventArgs e)
        {
            string apiUrl = "https://mhw-db.com/items";
            string mensaje = "";

            using (var httpClient = new HttpClient())
            {
                var response = httpClient.GetAsync(apiUrl).Result;
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = response.Content.ReadAsStringAsync().Result;
                    List<Items> items = JsonConvert.DeserializeObject<List<Items>>(jsonString);

                    // Ahora tienes la lista de items, puedes proceder a insertarlos en la base de datos.
                    foreach (var item in items)
                    {
                        mensaje = APIOrm.Insert(item); // Llama al método Insert para cada item
                    }

                    if (mensaje != "")
                    {
                        MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Items insertados correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Error al obtener datos de la API.");
                }
            }
        }
    }
}
