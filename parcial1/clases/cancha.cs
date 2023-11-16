namespace clases
{
  class Cancha
  {
    private int numero;
    private string tipo;

    public Cancha(int numero)
    {
      this.numero = numero;
    }
    public Cancha(int numero, string tipo)
    {
      this.numero = numero;
      this.tipo = tipo;
    }

    public int GetNumero()
    {
      return this.numero;
    }
    public void SetTipo(string tipo)
    {
      this.tipo = tipo;
    }
    public string GetTipo()
    {
      return this.tipo;
    }
  }
}