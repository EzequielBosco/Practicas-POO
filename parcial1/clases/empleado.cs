namespace clases
{
  class Empleado : Persona
  {
    private DateTime fecha_ingreso;
    private Usuario usuario;
    private string cargo;
    private int salario;

    public Empleado(string nombre, string apellido, string numero_doc, Usuario usuario) : base(nombre, apellido, numero_doc)
    {
      this.fecha_ingreso = DateTime.Now;
    }
    
    // sobrecarga
    public Empleado(string cargo, int salario, DateTime fecha_ingreso, string nombre, string apellido, Usuario usuario, string numero_doc, string tipo_doc, int cuit) : base(nombre, apellido, numero_doc)
    {
      this.cargo = cargo;
      this.salario = salario;
      this.fecha_ingreso = DateTime.Now;
    }

    public int ObtenerAntiguedad()
    {
      int años_antiguedad = DateTime.Now.Year - fecha_ingreso.Year;
      return años_antiguedad;
    }
    public DateTime GetFechaFontratación()
    {
      return this.fecha_ingreso;
    }

    public int Get_salario()
    {
      return this.salario;
    }
    public int Horas_trabajadas()
    {
      DateTime fecha_actual = DateTime.Now;
      int horas_trabajadas = 8 * (fecha_actual.DayOfYear - fecha_ingreso.DayOfYear);
      return horas_trabajadas;
    }
  }
}