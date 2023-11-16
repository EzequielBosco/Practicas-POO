namespace clases
{
  class Cliente : Persona
  {
    private DateTime fecha_alta;
    public Cliente(string nombre, string apellido, string numero_doc) : base(nombre, apellido, numero_doc)
    {
      this.fecha_alta = DateTime.Now;
    }

    public int GetAntiguedad()
    {
      int años_antiguedad = DateTime.Now.Year - fecha_alta.Year;
      return años_antiguedad;
    }
  }
}