namespace clases
{
  class Celular
  {
    private int codigo;
    private string marca;
    private string modelo;
    private string sistemaOperativo;
    private string color;
    private double precio;
    private bool encendido;

    public Celular(int codigo, string marca, string modelo, string sistemaOperativo, string color, double precio)
    {
      this.codigo = codigo;
      this.marca = marca;
      this.modelo = modelo;
      this.sistemaOperativo = sistemaOperativo;
      this.color = color;
      this.precio = precio;
      this.encendido = false;
    }

    public string Get_modelo()
    {
      return this.modelo;
    }

    public string Get_estado()
    {
      if (this.encendido == true) {
        return "El celular está encendido";
      } else {
        return "El celular se encuentra apagado";
      }
    }
    public void Encender()
    {
      encendido = true;
    }

    public void Apagar()
    {
      encendido = false;
    }
  }
}