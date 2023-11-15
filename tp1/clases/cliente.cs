namespace clases
{
  class Cliente : Persona
  {
    private string genero;
    private DateTime primer_contacto;
    public Cliente(string genero, string nombre, string apellido, DateTime fecha_nacimiento, string email, string numero_documento, string tipo_documento, string telefono, string direccion) : base(nombre, email, telefono)
    {
      this.genero = genero;
    }

    public string Get_genero()
    {
      return this.genero;
    }
    public int Get_antiguedad()
    {
      int años_antiguedad = DateTime.Now.Year - primer_contacto.Year;
      return años_antiguedad;
    }
  }
}