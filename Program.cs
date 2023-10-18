using DAOUsuario;
using EjercicioDapperCRUD;
using Ninject;
using System;

 IKernel kernel;
DAOUsuarios BDUsuario = new DAOUsuarios();
List<Usuario> usuarios = new List<Usuario>();
List<Usuario> usuariosActualizados = new List<Usuario>();

kernel= new StandardKernel(new NinjectDAOs());


UsuariosManager listadoUsuarios = kernel.Get<UsuariosManager>();

usuarios = BDUsuario.ObtenerUsuarios();
Console.WriteLine("Lista de usuarios");
foreach (var usuario in usuarios)
{
    Console.WriteLine(usuario.Id + " " + usuario.Nombre + " " + usuario.Edad);
}

Usuario usuario1 = new Usuario();
usuario1 = BDUsuario.ObtenerUsuario(1);
Console.WriteLine("Usuario 1");
Console.WriteLine(usuario1.Id + " " + usuario1.Nombre + " " + usuario1.Edad);
Console.WriteLine("INSERTANDO A NOMBRE = PRUEBA1 Y EDAD = 12");
BDUsuario.InsertarUsuario("Prueba1", 12);
usuarios = BDUsuario.ObtenerUsuarios();
Console.WriteLine("Lista de usuarios ACTUALIZADA");
foreach (var usuario in usuarios)
{
    Console.WriteLine(usuario.Id + " " + usuario.Nombre + " " + usuario.Edad);
}

BDUsuario.EliminarUsuario(1);
usuariosActualizados= BDUsuario.ObtenerUsuarios();
Console.WriteLine("Lista de usuarios ACTUALIZADA con eliminacion logica");
foreach (var usuario in usuariosActualizados)
{
    Console.WriteLine(usuario.Id + " " + usuario.Nombre + " " + usuario.Edad);
}
Console.WriteLine(" "+listadoUsuarios.ObtenerListadoDeUsuarios());