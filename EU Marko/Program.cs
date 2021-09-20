using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EU_Marko
{
  class Program
  {
    static List<Data> eu = new List<Data>();
    static void Main(string[] args)
    {
      ElsoFeladat();
      MasodikFeladat();
      HarmadikFeladat();
      NegyedikFeladat();
      OtodikFeladat();
      HatodikFeladat();
      HetedikFeladat();
      NyolcadikFeladat();
      Console.ReadLine();
    }

    private static void NyolcadikFeladat()
    {
      Dictionary<int, int> vmi = new Dictionary<int, int>()
      {
        {1995, 0 },
        {1958, 0 },
        {2007, 0 },
        {2004, 0 },
        {1973, 0 },
        {1981, 0 },
        {2013, 0 },
        {1986, 0 }
      };
      foreach (var e in eu)
      {
        
      }
    }

    private static void HetedikFeladat()
    {
      Console.WriteLine("7. feladat: Legutoljára csatlakozott ország: ");
    }

    private static void HatodikFeladat()
    {
      Console.WriteLine("6. feladat: {0} volt a csatlakozás");
    }

    private static void OtodikFeladat()
    {
      Console.WriteLine("5. feladat: Magyarország csatlakozásának dátuma: ");
    }

    private static void NegyedikFeladat()
    {
      int csatlak = 2007;
      foreach (var e in eu)
      {
        for (int i = 0; i < csatlak; i++)
        {

        }
      }
    }

    private static void HarmadikFeladat()
    {
      Console.WriteLine($"3. feladat: EU tagállamainak száma: {eu.Count}");
    }

    private static void MasodikFeladat()
    {
      Console.WriteLine("2. feladat: adatok beolvasása");
      StreamReader olv = new StreamReader("EUcsatlakozas.txt");
      olv.ReadLine();
      while (!olv.EndOfStream)
      {
        string[] a = olv.ReadLine().Split('.');
        eu.Add(new Data(a[0], int.Parse(a[1])));
      }
      olv.Close();
    }

    private static void ElsoFeladat()
    {
     //Kész!
    }
  }
}
