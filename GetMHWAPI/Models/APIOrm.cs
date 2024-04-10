using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMHWAPI.Models
{
    class APIOrm
    {
        public static string Insert(Items item)
        {
            string message = "";

            try
            {
                Orm.bd.Items.Add(item); // Agrega el item a la colección Items en tu contexto de base de datos
                message = Orm.MySaveChanges(); // Guarda los cambios en la base de datos

                return message;
            }
            catch (Exception ex)
            {
                return $"Error al insertar el item {item.name}: {ex.Message}";
            }
        }
    }
}
