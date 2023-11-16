namespace clases
{
  class Turno
  {
    private DateTime dia_hora;
    private Cancha cancha;
    private double precio;
    private Cliente cliente;
    private Empleado usuario_carga;
    private Empleado usuario_actualiza;
    private DateTime fecha_carga;
    private DateTime fecha_actualiza;

    public Turno(DateTime dia_hora, Cancha cancha, Cliente cliente)
    {
      this.dia_hora = dia_hora;
      this.cancha = cancha;
      this.cliente = cliente;
      this.fecha_carga = DateTime.Now;
    }
    public Turno(DateTime dia_hora, Cancha cancha, Cliente cliente, double precio)
    {
      this.dia_hora = dia_hora;
      this.cancha = cancha;
      this.precio = precio;
      this.fecha_carga = DateTime.Now;
    }

    public Cliente GetCliente()
    {
      return this.cliente;
    }
    public Cancha GetCancha()
    {
      return this.cancha;
    }
    public DateTime GetDiaHora()
    {
      return this.dia_hora;
    }
    public void SetUsuarioCarga(Empleado empleado)
    {
      this.usuario_carga = empleado;
    }

    public void SetUsuarioActualiza(Empleado empleado)
    {
      this.usuario_actualiza = empleado;
    }

    public Empleado GetUsuarioCarga()
    {
      return this.usuario_carga;
    }

    public Empleado GetUsuarioActualiza()
    {
      return this.usuario_actualiza;
    }
  }
}