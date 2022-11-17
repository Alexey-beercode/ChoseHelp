public class Speciality
{
    public enum Subjects
    {
        Programming = 0,
        Chemistry,
        Physics,
        Math,
        Medicine,
        MechanicalEngineering,
        ForeignLanguages,
        Economy,
        Robotics,
        Management,
        Biology,
        RadioElectronics,
        InternationalRelationships,
        Art,
        Marketing,
        History,
        Philosophy,
        Pedagogy,
        Jurisprudence
    }

    public int? Id { get; set; }
    public string? Name { get; set; }
    public int? FreeValue { get; set; }
    public int? PayValue { get; set; }
    public string? University { get; set; }
    public Subjects? Subject { get; set; }
    public string? Link { get; set; }

    public static List<Speciality> Finder(int? maxValue, int? minValue, Subjects? subject, bool freePay)
    {
        AppContext db = new AppContext();
        List<Speciality> list = new List<Speciality>();
        var specialties = db.Specialities.ToList();
        foreach (var speciality in specialties)
        {
            if (freePay)
            {
                if (speciality.FreeValue >= minValue && speciality.FreeValue <= maxValue)
                {
                    if (speciality.Subject == subject)
                        list.Add(speciality);
                }
            }
            else if (speciality.PayValue >= minValue && speciality.PayValue <= maxValue)
            {
                if (speciality.Subject == subject)
                    list.Add(speciality);
            }
        }
        return list;
    }
}