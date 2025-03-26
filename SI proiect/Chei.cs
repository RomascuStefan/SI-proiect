using SI_proiect;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Chei
{
    [Key]
    public int Id { get; set; }

    public int FisierAlgoritmId { get; set; }

    [ForeignKey("FisierAlgoritmId")]
    public virtual FisierAlgoritm FisierAlgoritm { get; set; }

    public string CheieUnica { get; set; }
    public string CheiePublica { get; set; }
    public string CheiePrivata { get; set; }

    [MaxLength(64)]
    public string VI { get; set; }
}
