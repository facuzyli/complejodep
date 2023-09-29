public class PermisoCompuesto
{
    public int ID { get; set; }
    public string Nombre { get; set; }
    public List<PermisoCompuesto> SubPermisos { get; set; }
}