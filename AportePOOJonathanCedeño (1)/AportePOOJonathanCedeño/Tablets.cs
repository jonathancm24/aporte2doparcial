public class Tablets : Dispositivos
{
    public string Chip;
    public string Pais;

    public Tablets(string IMEI, string marca, string modelo, string SistemaOperativo, string Chip, string Pais) : base(IMEI, marca, modelo, SistemaOperativo)
    {
        this.Chip = Chip;
        this.Pais = Pais;
    }
    public override void MostrarDetalles()
    {
        Console.WriteLine("Especificaciones del Dispositivo: ");
        Console.WriteLine("IMEI: " + IMEI);
        Console.WriteLine("Marca: " + marca);
        Console.WriteLine("Modelo: " + modelo);
        Console.WriteLine("Sistema Operativo: " + SistemaOperativo);
        Console.WriteLine("Pais de fabricacion: "+ Pais);
        Console.WriteLine("Dispositivo con chip: "+ Chip);
    }
}