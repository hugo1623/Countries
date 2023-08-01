namespace Countries.Models.Name;
using Countries.Models.Currencies;
using Countries.Models.Languages;
using Countries.Models.Departamentos;
using Countries.Models.Provincias;
using Countries.Models.Distritos;

public class Censo
{
    public Name Name { get; set; }

    public Currencies Currencies { get; set; }
    public Languages Languages { get; set; }
    public List<Departamentos> Departamentos { get; set; }
    public List<Provincias> Provincias { get; set; }

    public List<Distritos> Distritos { get; set; }
}
