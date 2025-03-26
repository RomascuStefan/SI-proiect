using SI_proiect;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class FisierAlgoritm
{
    [Key]
    public int Id { get; set; }

    public int FisierId { get; set; }

    [ForeignKey("FisierId")]
    public virtual Fisier Fisier { get; set; }

    public int AlgoritmId { get; set; }

    [ForeignKey("AlgoritmId")]
    public virtual Algoritm Algoritm { get; set; }

    public virtual Chei Chei { get; set; }
    public virtual Performanta Performanta { get; set; }
}
