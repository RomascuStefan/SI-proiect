using SI_proiect;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Algoritm
{
    [Key]
    public int Id { get; set; }

    [MaxLength(50)]
    public string Nume { get; set; }

    public bool Simetric { get; set; }

    public int FrameworkId { get; set; }

    [ForeignKey("FrameworkId")]
    public virtual Framework Framework { get; set; }

    public int LungimeCheie { get; set; }

    public virtual ICollection<FisierAlgoritm> FisierAlgoritmi { get; set; }

    public Algoritm()
    {
        FisierAlgoritmi = new HashSet<FisierAlgoritm>();
    }
}
