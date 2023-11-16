namespace clases
{
  class Permiso
  {
    private Usuario usuario;
    private Modulo modulo;
    private int categoria;

    public Permiso(Usuario usuario, Modulo modulo, int categoria)
    {
        this.usuario = usuario;
        this.modulo = modulo;
        this.categoria = categoria;
    }

    public int GetCategoria()
    {
      return this.categoria;
    }
    public Usuario GetNombreUsuario()
    {
      return this.usuario;
    }
  }
}