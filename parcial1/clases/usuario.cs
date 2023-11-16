namespace clases
{
  class Usuario
  {
    private string usuario;
    private string contraseña;
    private DateTime fecha_alta;
    private DateTime ultimo_acceso;

    public Usuario(string usuario, string contraseña)
    {
      this.usuario = usuario;
      this.contraseña = contraseña;
      this.fecha_alta = DateTime.Now;
      this.ultimo_acceso = DateTime.Now;
    }
    // sobrecarga
    public Usuario(string usuario, string contraseña, string email, string telefono)
    {
      this.usuario = usuario;
      this.contraseña = contraseña;
      this.fecha_alta = DateTime.Now;
      this.ultimo_acceso = DateTime.Now;
    }

    public string GetNombreUsuario()
    {
      return this.usuario;
    }
    public DateTime GetUltimoAcceso()
    {
      return this.ultimo_acceso;
    }
    public DateTime GetFechaAlta()
    {
      return this.fecha_alta;
    }
    private void ModificarContraseña(string nueva_contraseña)
    {
      this.contraseña = nueva_contraseña;
    }
  }
}