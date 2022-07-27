public class Celulares : Dispositivos
{
    public string funcionalidad;
    public string HardwareAdicional;

    public Celulares(string IMEI, string marca, string modelo, string SistemaOperativo, string funcionalidad, string HardwareAdicional) : base(IMEI, marca, modelo, SistemaOperativo)
    {
        this.HardwareAdicional = HardwareAdicional;
        this.funcionalidad = funcionalidad;
    }
    public override void MostrarDetalles()
    {
        Console.WriteLine("Especificaciones del Dispositivo: ");
        Console.WriteLine("IMEI: " + IMEI);
        Console.WriteLine("Marca: " + marca);
        Console.WriteLine("Modelo: " + modelo);
        Console.WriteLine("Sistema Operativo: " + SistemaOperativo);
        Console.WriteLine("Funcianalidades: "+ funcionalidad);
        Console.WriteLine("Hardware adicional dejado por el cliente : "+ funcionalidad);
    }
}