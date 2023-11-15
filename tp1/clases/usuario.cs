namespace clases
{
  class Usuario : Persona
  {
    private string nombre_usuario;
    private string contraseña;
    private DateTime ultimo_acceso;

    public Usuario(string nombre_usuario, string contraseña, string nombre, string email, string telefono, string numero_documento, string tipo_documento) : base(nombre, email, telefono)
    {
        this.nombre_usuario = nombre_usuario;
        this.contraseña = contraseña;
        this.ultimo_acceso = DateTime.Now;
    }
    public string Get_nombre_usuario()
    {
      return this.nombre_usuario;
    }
    public DateTime Get_ultimo_acceso()
    {
      return this.ultimo_acceso;
    }
    private void Modificar_contraseña(string nueva_contraseña)
    {
      this.contraseña = nueva_contraseña;
    }
  }
}