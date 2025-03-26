using SI_proiect;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Performanta
{
    [Key]
    public int Id { get; set; }

    public int FisierAlgoritmId { get; set; }

    [ForeignKey("FisierAlgoritmId")]
    public virtual FisierAlgoritm FisierAlgoritm { get; set; }

    public float TimpCriptare { get; set; }
    public float TimpDecriptare { get; set; }
    public float Memorie { get; set; }
    public float Cpu { get; set; }
}
