namespace lab07;
using ac = Dongvat.Anco;
using at = Dongvat.AnThit;
class Program
    {
        static void Main(String[] arys)
        {
            ac.Bo bo = new ac.Bo();
            bo.ID = 1;
            bo.Name = "bo01";
            bo.Weight = 02;

        Console.WriteLine("id: " + bo.ID + "\nname: " + bo.Name + "\nWeight: " + bo.Weight);
        Console.WriteLine("..................................................................");
        Console.WriteLine("..................................................................");
        at.Casau cs = new at.Casau();
            cs.ID = 2;
            cs.Name = "cs02";
            cs.Weight = 03;
        Console.WriteLine("id: " + cs.ID + "\nname: " + cs.Name + "\nWeight: " + cs.Weight);
    }
    }

