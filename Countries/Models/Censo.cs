namespace Countries.Models.Name;
using Countries.Models.Currencies;
using Countries.Models.Languages;
using Countries.Models.Departamentos;

public class Censo
{
    public Name Name { get; set; }

    public Currencies Currencies { get; set; }
    public Languages Languages { get; set; }
    public List<Departamentos> Departamentos { get; set; }
    //public List<string> Languages { get; set; }
}
