namespace clases
{
  class Empleado : Persona
  {
    private string cuit;
    private string cargo;
    private int salario;
    private DateTime fecha_contratacion;

    public Empleado(string cuit, string cargo, int salario, DateTime fecha_contratacion, string nombre, string apellido, DateTime fecha_nacimiento, string email, string numero_documento, string tipo_documento, string telefono, string direccion) : base(nombre, email, telefono)
    {
        this.cuit = cuit;
        this.cargo = cargo;
        this.salario = salario;
        this.fecha_contratacion = fecha_contratacion;
    }

    public DateTime Get_fecha_contratación()
    {
      return this.fecha_contratacion;
    }

    public int Get_salario()
    {
        return this.salario;
    }
    public int Horas_trabajadas()
    {
        DateTime fecha_actual = DateTime.Now;
        int horas_trabajadas = 8 * (fecha_actual.DayOfYear - fecha_contratacion.DayOfYear);
        return horas_trabajadas;
    }
  }
}