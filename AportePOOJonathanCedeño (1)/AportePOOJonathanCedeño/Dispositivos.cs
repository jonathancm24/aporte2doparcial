public abstract class Dispositivos
{
    public string IMEI;
     public string marca;
     public string modelo;
     public string SistemaOperativo;

    public Dispositivos(string  IMEI, string marca, string modelo, string SistemaOperativo)
    {
        this.IMEI =  IMEI;
        this.marca = marca;
        this.modelo = modelo;
        this.SistemaOperativo = SistemaOperativo;
    }
    public abstract void MostrarDetalles();
    
}