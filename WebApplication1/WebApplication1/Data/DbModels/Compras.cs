namespace WebApplication1.Data.DbModels;

public class Compras
{
    public int Id { get; set; }
    
    public DateTime data { get; set; }
    
    public EstadosCompras  Estado { get; set; }    
}

public enum EstadosCompras
{
    iniciada,
    paga,
    enviada,
    concluida
}