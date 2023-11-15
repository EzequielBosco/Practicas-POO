namespace clases
{
  class Camara
  {
    private int codigo;
    private string marca;
    private string modelo;
    private string ubicacion;
    private bool estado;
    private double precio;
    private int resolucion;
    public Camara(int codigo, string marca, string modelo, string ubicacion, double precio, int resolucion)
    {
      this.codigo = codigo;
      this.marca = marca;
      this.modelo = modelo;
      this.ubicacion = ubicacion;
      this.precio = precio;
      this.resolucion = resolucion;
      this.estado = false;
    }
    public string Get_modelo()
    {
      return this.modelo;
    }
    public string Get_ubicacion()
    {
      return this.ubicacion;
    }
    public string Get_estado()
    {
      if (this.estado == true) {
        return "Camara vigilando";
      } else {
        return "Camara apagada";
      }
    }
    public void Activar_grabacion()
    {
      this.estado = true;
    }
    public void Desactivar_grabacion()
    {
      this.estado = false;
    }
  }
}