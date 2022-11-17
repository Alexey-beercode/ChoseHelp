class Programm
{
    static void Main()
    {
        AppContext db = new AppContext();
        Speciality speciality = new Speciality() { Name = "Lesha",FreeValue= 0, };
        db.Add(speciality);
        db.SaveChanges();
        var specialities = db.Specialities.ToList();
        foreach (var VARIABLE in specialities)
        {
            Console.WriteLine(VARIABLE.Name);
        }
    }
}
