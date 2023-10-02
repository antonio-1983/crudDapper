
using MySql.Data.MySqlClient;
using Dapper;
using MySqlX.XDevAPI.Common;

namespace DAOUsuario

{
    public class DAOUsuarios
    {
        string connection = @"Server=localhost; Database=ejercicioDapper; Uid=root;";
        string sqlUsuarios = "select Id,Nombre,Edad from Usuarios Where Activo=1;";
        string sqlId = "select Id, Nombre, Edad from Usuarios where Id = @Id;";
        string sqlInsert = "insert into Usuarios (Nombre,Edad) values (@Nombre,@Edad);";
        string sqlDelete = "update Usuarios set Activo = 0 where id=@id;";

        public DAOUsuarios()
        {

        }

        public List<Usuario> ObtenerUsuarios()
        {
            using (var db = new MySqlConnection(connection))
            {
                List<Usuario> result = new List<Usuario>();
                result= (List<Usuario>)db.Query<Usuario>(sqlUsuarios);
                return result;
            }
            
        }

        public Usuario ObtenerUsuario(int id)
        {
            using (var db = new MySqlConnection(connection))
            {
               Usuario result = new Usuario();
                result = db.QueryFirstOrDefault<Usuario>(sqlId, new { Id = 1 });
                return result;
            }
        }

        public void InsertarUsuario(string nombre, int edad) 
        {
            using (var db = new MySqlConnection(connection))
            {
                
               var result = db.Execute(sqlInsert, new { nombre, edad });

            }
            
        }

        public void EliminarUsuario(int id)
        {
            using (var db = new MySqlConnection(connection))
            {

                var result = db.Execute(sqlDelete, new { id });

            }

        }
    }
}