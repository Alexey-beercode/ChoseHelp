class Programm
{
    static void Main()
    {
        AppContext db = new AppContext();
        var specialities = db.Specialities.ToList();
        foreach (var VARIABLE in specialities)
        {
            Console.WriteLine(VARIABLE.Name);
        }
    }
}
