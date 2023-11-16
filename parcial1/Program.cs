using clases;

namespace Parcial1
{
  class Program
  {
    static void Main(string[] args)
    {

        Usuario Ezequiel = new Usuario("Ezequiel", "contraseña1");
        Modulo modulo1 = new Modulo("modulo1");
        Permiso permiso1 = new Permiso(Ezequiel, modulo1, 1);

        Console.WriteLine(permiso1.GetNombreUsuario());
        Console.WriteLine(permiso1.GetCategoria());

        Cancha cancha1 = new Cancha(1, "Tipo1");
        Cliente cliente1 = new Cliente("NombreCliente", "ApellidoCliente", "12345");
        Empleado empleado1 = new Empleado("Empleado1", "ApellidoEmpleado1", "12345", Ezequiel);

        Turno turno1 = new Turno(DateTime.Now, cancha1, cliente1);
        turno1.SetUsuarioCarga(empleado1);

        Console.WriteLine($"Turno para {turno1.GetCliente().GetNombreCompleto()} en la Cancha {turno1.GetCancha().GetNumero()}.");
        Console.WriteLine($"Cargado por: {turno1.GetUsuarioCarga().GetNombreCompleto()}.");
    }
  }
}