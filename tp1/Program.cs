using clases;

namespace tp1
{
  class Program
  {
    static void Main(string[] args)
    {
      Celular googlePixel6;
      googlePixel6 = new Celular(1526, "Google", "Pixel 6", "Android", "Blanco", 599);
      Console.WriteLine(googlePixel6.Get_modelo());
      googlePixel6.Encender();
      Console.WriteLine(googlePixel6.Get_estado());
      googlePixel6.Apagar();
      Console.WriteLine(googlePixel6.Get_estado());

      Impresora canon;
      canon = new Impresora(1682, "Canon", "Pixma", "Laser", "Negro", 50, 1080, 600, 699);
      Console.WriteLine(canon.Get_modelo());
      canon.Encender();
      Console.WriteLine(canon.Get_estado());
      canon.Imprimir("Documento");

      Camara gadnic;
      gadnic = new Camara(1682, "Garnic", "SX37", "Exterior", 80, 3840);
      Console.WriteLine(gadnic.Get_modelo());
      Console.WriteLine(gadnic.Get_ubicacion());
      gadnic.Get_estado();
      gadnic.Activar_grabacion();
      Console.WriteLine(gadnic.Get_estado());

      Empleado Mariano;
      Mariano = new Empleado("30354567823", "Seguridad", 300000, new DateTime(2023, 11, 7), "Mariano", "Plata", new DateTime(1985, 10, 5), "mariano@gmail.com", "36924020", "dni", "11894021", "Larralde 1762");
      Console.WriteLine(Mariano.Horas_trabajadas());

      Cliente Juan;
      Juan = new Cliente("Masculino", "Juan", "Pendola", new DateTime(2000, 11, 7), "juan@hotmail.com", "42850821", "dni", "1187409120", "La refalosa 167");
      Console.WriteLine(Juan.Get_genero());
      Console.WriteLine(Juan.Get_antiguedad());

      Usuario Sofia;
      Sofia = new Usuario("SofiMalore", "12345678", "Sofia", "sofi123@gmail.com", "15983712", "43527903", "dni");
      Console.WriteLine(Sofia.Get_nombre_usuario());
      Console.WriteLine(Sofia.Get_ultimo_acceso());

    }
  }
}
