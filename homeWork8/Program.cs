namespace homeWork8
{
    internal class Program
    {
        #region Pare
        //static void Main()
        //{
        //    Console.WriteLine("Iroduceti inceputul intervalului");
        //    int a = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Iroduceti sfarsitul intervalului");
        //    int b = int.Parse(Console.ReadLine());
        //    if (a < b)
        //    {
        //        for (int i = a; i <= b; i++)
        //        {
        //            if (i % 2 == 0)
        //            {
        //                Console.Write(i + " ");
        //            }
        //        }
        //    }
        //    else
        //    {
        //        for (int i = a; i >= b; i--)
        //        {
        //            if (i % 2 == 0)
        //            {
        //                Console.Write(i + " ");
        //            }
        //        }
        //    }
        //}
        #endregion

        #region ToZerro 
        //static void Main()
        //{
        //    Console.WriteLine("Introduceti numerele separate prin spatiu");
        //    var num = Console.ReadLine();
        //    double[] numere = Array.ConvertAll(num.Split(" "), double.Parse);
        //    int index = 0;
        //    bool contineZero = false;
        //    while (index < numere.Length)
        //    {
        //        if (numere[index] == 0)
        //        {
        //            contineZero = true;
        //            break;
        //        }
        //        index++;
        //    }
        //    if (contineZero)
        //        Console.WriteLine("Contine zero");
        //    else
        //        Console.WriteLine("Nu contine zero");
        //}
        #endregion

        #region Angajati
        //struct Persoana
        //{
        //    public string Nume;
        //    public int Varsta;
        //    public string Ocupatie;

        //    public Persoana(string nume, int varsta, string ocupatie)
        //    {
        //        Nume = nume;
        //        Varsta = varsta;
        //        Ocupatie = ocupatie;
        //    }
        //}

        //static void Main()
        //{
        //     List<Persoana> persoane = new List<Persoana>
        //     {
        //          new Persoana("Ion", 26, "Inginer"),
        //          new Persoana("Irina", 34, "Manager"),
        //          new Persoana("Cristina", 30, "Inginer"),
        //          new Persoana("Mihai", 41, "Profesor"),
        //          new Persoana("Elena", 27, "Manager")
        //     };

        //     Console.Write("Introdu ocupatia cautata: ");
        //     string ocupatieCautata = Console.ReadLine();
        //     Console.WriteLine($"\n Persoane cu ocupatia '{ocupatieCautata}':");
        //     bool gasit = false;

        //     foreach (Persoana persoana in persoane)
        //     {
        //         if (persoana.Ocupatie == ocupatieCautata)
        //         {
        //              Console.WriteLine($" {persoana.Nume}, {persoana.Varsta} ani");
        //              gasit = true;
        //         }
        //     } 
        //     if (!gasit)
        //        Console.WriteLine("Nu sunt persoane cu aceasta ocupatie.");
        //}
        #endregion

        #region PanaLa100
        //static void Main()
        //{
        //    for (int i = 1; i <= 100; i++)
        //        Console.Write(i+ " ");
        //}
        #endregion

    }
} 
