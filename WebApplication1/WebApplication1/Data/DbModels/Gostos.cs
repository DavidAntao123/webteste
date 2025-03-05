using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data.DbModels;

[PrimaryKey(nameof(UtilizadorFk)]

public class Gostos
{
    
    public int Id { get; set; }
    
    public DateTime Data { get; set; }
    
    [ForeignKey(nameof(Utilizador)]
    public int UtilizadorFk { get; set; }
    public Utilizadores Utilizador { get; set; }
    
    [ForeignKey(nameof(Fotografia))]
    
    public int FotografiaFk { get; set; }
    public Fotografias Fotografia { get; set; }
    
    
}