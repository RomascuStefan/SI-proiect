using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Fisier
{
    [Key]
    public int Id { get; set; }

    [MaxLength(255)]
    public string Nume { get; set; }

    public long Dimensiune { get; set; }

    [MaxLength(64)]
    public string Hash { get; set; }

    [MaxLength(500)]
    public string CaleFisier { get; set; }

    public virtual ICollection<FisierAlgoritm> FisierAlgoritmi { get; set; }

    public Fisier()
    {
        FisierAlgoritmi = new HashSet<FisierAlgoritm>();
    }
}
