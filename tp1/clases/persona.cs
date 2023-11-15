namespace clases
{
  class Persona
  {
    public string nombre;
    public string apellido;
    public string email;
    public DateTime fecha_nacimiento;
    public string numero_documento;
    public string tipo_documento;
    public string telefono;
    public string direccion;

    public Persona(string nombre, string email, string telefono)
    {
        this.nombre = nombre;
        this.email = email;
        this.telefono = telefono;
    }

    public Persona(string nombre, string apellido, string email, DateTime fecha_nacimiento, string numero_documento, string tipo_documento, string telefono, string direccion) : this(nombre, email, telefono)
    {
        this.apellido = apellido;
        this.fecha_nacimiento = fecha_nacimiento;
        this.numero_documento = numero_documento;
        this.tipo_documento = tipo_documento;
        this.direccion = direccion;
    }
    public void Set_nombre_completo(string nombre, string apellido)
    {
      this.nombre = nombre;
      this.apellido = apellido;
    }
    public string Get_nombre_completo()
    {
      return this.nombre + " " + this.apellido;
    }

    public void Set_fecha_nacimiento(DateTime fecha)
    {
      this.fecha_nacimiento = fecha;
    }
    public int Get_edad()
    {
      DateTime fecha_actual = DateTime.Now;
      int edad = fecha_actual.Year - this.fecha_nacimiento.Year;
      return edad;
    }
  }
}