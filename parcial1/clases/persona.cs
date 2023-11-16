namespace clases
{
  class Persona
  {
    public string nombre;
    public string apellido;
    public string tipo_doc;
    public string numero_doc;
    public string tipo_iva;
    public int cuit;
    public string email;
    public string telefono;
    public DateTime fecha_nacimiento;
    public string direccion;
    public Localidad localidad;

    public Persona(string nombre, string apellido, string numero_doc)
    {
      this.nombre = nombre;
      this.apellido = apellido;
      this.numero_doc = numero_doc;
    }
    public Persona(string nombre, string apellido, string numero_doc, Localidad localidad)
    {
      this.nombre = nombre;
      this.apellido = apellido;
      this.numero_doc = numero_doc;
      this.localidad = localidad;
    }

    public string GetNombreCompleto()
    {
      return this.nombre + " " + this.apellido;
    }
    public int Get_edad()
    {
      DateTime fecha_actual = DateTime.Now;
      int edad = fecha_actual.Year - this.fecha_nacimiento.Year;
      return edad;
    }
    public void SetFechaNacimiento(DateTime fecha)
    {
      this.fecha_nacimiento = fecha;
    }
    public void SetDireccion(string dato)
    {
      this.direccion = dato;
    }
    public void SetCuit(int numero)
    {
      this.cuit = numero;
    }
    public int GetCuit()
    {
      return this.cuit;
    }
  }
}