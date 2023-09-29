public class Reserva
{
    public int ID { get; set; }
    public int ClienteID { get; set; }
    public int CanchaID { get; set; }
    public string TipoReserva { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFin { get; set; }
}