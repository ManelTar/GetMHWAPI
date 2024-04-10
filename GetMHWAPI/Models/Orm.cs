using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMHWAPI.Models
{
    class Orm
    {
        public static APIMHWEntities bd = new APIMHWEntities();
        public static String MissatgeError(SqlException sqlException)
        {
            String missatge = "";


            switch (sqlException.Number)
            {
                case 2:
                    missatge = "El servidor no està operatiu.";
                    break;
                case 547:
                    missatge = "El registre té dades relacionades.";
                    break;
                case 2601:
                    missatge = "Registre duplicat.";
                    break;
                case 2627:
                    missatge = "Registre duplicat.";
                    break;
                case 4060:
                    missatge = "No es pot obrir la base de dades.";
                    break;
                case 18456:
                    missatge = "Error a l'iniciar la sessió.";
                    break;
                default:
                    missatge = sqlException.Number + " - " + sqlException.Message;
                    break;

            }
            return missatge;

        }

        public static String MySaveChanges()
        {
            String missatge = "";
            try
            {
                //añade los cambios a la BD
                Orm.bd.SaveChanges();
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    SqlException sqlException = (SqlException)ex.InnerException.InnerException;
                    //nos copiamos la funcion de anteriores actividades
                    missatge = Orm.MissatgeError(sqlException);
                }
                else
                {
                    //IMPORTANTE: a veces no guarda bien los cambios y da otro tipo de error 
                    //Si reiniciamos el proyecto ya nos funciona bien
                    missatge = ex.Message;
                }

                //IMPORTANTE: si hacemos una operacion y da error y lugo hacemos otra
                //al hacer el SaveChanges da error porque intenta hacer las dos
                //El SaveChanges ejecuta siempre todo lo pendiente, debemos cerrar la
                //transaccion cada vez haciendo un rollback
                //No existe un metodo como el commit, de modo que utilizamos un metodo nuestro
                RejectChanges();
            }
            return missatge;
        }

        public static void RejectChanges()
        {
            //Con el ChangeTracker miramos que cosas se han cambiado en las entradas
            //en el Entity Framework
            //Cada vez que hacemos un cambio se regustra un estado (Addes, Deleted)
            //Recorremos todas las acciones y de las que nos pueden dar error
            //le cambiaremos el estado
            foreach (DbEntityEntry item in bd.ChangeTracker.Entries())
            {
                switch (item.State)
                {
                    case System.Data.Entity.EntityState.Detached:
                        break;
                    case System.Data.Entity.EntityState.Unchanged:
                        break;
                    case System.Data.Entity.EntityState.Added: //cuando tenemos un insert
                        item.State = System.Data.Entity.EntityState.Detached; //lo quitamos
                        break;
                    case System.Data.Entity.EntityState.Deleted: //cuando es un delete
                        item.Reload(); //recargamos lo que ya habia en la bd, de modo que el borrado vovlera a aparecer
                        break;
                    case System.Data.Entity.EntityState.Modified: //cuando hacemos un update
                        item.State = System.Data.Entity.EntityState.Detached; //lo quitamos
                        // item.State = System.Data.Entity.EntityState.Unchanged; //lo quitamos y recuperara lo que había anteriormente
                        break;
                    default:
                        break;
                }
            }
        }
    }

}