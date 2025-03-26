    using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Framework
{
    [Key]
    public int Id { get; set; }

    [MaxLength(100)]
    public string Nume { get; set; }

    public virtual ICollection<Algoritm> Algoritmi { get; set; }

    public Framework()
    {
        Algoritmi = new HashSet<Algoritm>();
    }
}
