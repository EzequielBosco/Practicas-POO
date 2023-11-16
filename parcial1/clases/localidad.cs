namespace clases
{
  class Localidad
  {
    private string nombre;
    private string codigo_postal;
    private string provincia;

    public Localidad(string nombre, string codigo_postal)
    {
      this.nombre = nombre;
      this.codigo_postal = codigo_postal;
      this.provincia = provincia;
    }

    public string GetNombre()
    {
      return this.nombre;
    }
      public string GetProvincia()
    {
      return this.provincia;
    }
    public void SetProvincia(string provincia)
    {
      this.provincia = provincia;
    }
  }
}