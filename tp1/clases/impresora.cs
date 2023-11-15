namespace clases
{
  class Impresora
  {
    private int codigo;
    private string marca;
    private string modelo;
    private string tipo_impresion;
    private int nivel_tinta;
    private int resolucion_impresion;
    private int velocidad_impresion;
    private string color;
    private double precio;
    private bool estado;

    public Impresora(int codigo, string marca, string modelo, string tipo_impresion, string color, int nivel_tinta, int resolucion_impresion, int velocidad_impresion, double precio)
    {
      this.codigo = codigo;
      this.marca = marca;
      this.modelo = modelo;
      this.nivel_tinta = nivel_tinta;
      this.tipo_impresion = tipo_impresion;
      this.resolucion_impresion = resolucion_impresion;
      this.velocidad_impresion = velocidad_impresion;
      this.color = color;
      this.precio = precio;
      this.estado = false;
    }

    public string Get_modelo()
    {
      return this.modelo;
    }

    public string Get_estado()
    {
      if (this.estado == true) {
        return "La impresora está encendida";
      } else {
        return "La impresora se encuentra apagada";
      }
    }
    public void Encender()
    {
      estado = true;
    }

    public void Apagar()
    {
      estado = false;
    }
    public void Imprimir(string contenido)
    {
      Console.WriteLine("Imprimiendo documento: " + contenido);
    }
    public int Get_nivel_tinta()
    {
        return nivel_tinta;
    }
  }
}