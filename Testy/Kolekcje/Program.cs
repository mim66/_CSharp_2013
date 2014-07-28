using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kolekcje
{
   class Program
   {
      static void Main(string[] args) {

         string msg = "";

         #region Using a Simple Collection

         Console.WriteLine(" Create a list of strings with foreach");
         var salmons = new List<string>();
         salmons.Add("chinook");
         salmons.Add("coho");
         salmons.Add("pink");
         salmons.Add("sockeye");
         // Iterate through the list. 
         foreach (var salmon in salmons)         {
            Console.Write(" "+salmon);
         }
         Console.WriteLine();
         Console.WriteLine();
         // Output: chinook coho pink sockeye


         Console.WriteLine("Create a list of strings by using a collection initializer.  ");
         salmons = new List<string> { "chinook", "coho", "pink", "sockeye" };
         foreach (var salmon in salmons) {
            Console.Write(" " + salmon);
         }
         Console.WriteLine();
         Console.WriteLine();


         Console.WriteLine("Iterates through the elements of a collection by using For…Next instead of For Each.  ");
         salmons = new List<string> { "chinook", "coho", "pink", "sockeye" };
         for (var index = 0; index < salmons.Count; index++)  {
            Console.Write(" " + salmons[index]);
         }
         Console.WriteLine();
         Console.WriteLine();


         Console.WriteLine("Removes an element from the collection by specifying the object to remove.");
         salmons = new List<string> { "chinook", "coho", "pink", "sockeye" };
         // Remove an element from the list by specifying  the object.
         salmons.Remove("coho");
         foreach (var salmon in salmons) {
            Console.Write(" " + salmon);
         }
         Console.WriteLine();
         Console.WriteLine();


         Console.WriteLine("Removes elements from a generic list. Instead of a For Each statement, a For…Next (Visual Basic) or for (C#) statement that iterates in descending order is used. This is because the RemoveAt method causes elements after a removed element to have a lower index value.");
         var numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
         // Remove odd numbers. 
         for (var index = numbers.Count - 1; index >= 0; index--) {
            if (numbers[index] % 2 == 1) {
               // Remove the element by specifying  the zero-based index in the list.
               numbers.RemoveAt(index);
            }
         }
         // Iterate through the list.  A lambda expression is placed in the ForEach method of the List(T) object.
         numbers.ForEach(
             number => Console.Write(" " + number));
         // Output: 0 2 4 6 8
         Console.WriteLine();
         Console.WriteLine();

         IterateThroughList();
         Console.WriteLine();
         Console.WriteLine();

         #endregion


         //Rodzaje kolekcji
         
         // Wiele typowych kolekcji jest dostarczanych przez.NET Framework. Każdy typu kolekcji jest przeznaczony do określonego celu.
         // W tej sekcji opisano następujące grupy klas kolekcji:
         //
         //    System.Collections.Generic       klasy
         //
         //    System.Collections.Concurrent    klasy
         //
         //    System.Collections               klasy
         //
         //    Klasa Visual Basic Collection
         //


         Console.WriteLine("*  Implementacja par kluczy/wartości kolekcji ");

            Console.WriteLine();
            Console.WriteLine("Tworzy kolekcję Dictionary i wykonuje iteracje przez słownik za pomocą instrukcji For Each.");
            ImplementacjaParKluczWartosc gen = new ImplementacjaParKluczWartosc();
            gen.IterateThruDictionary();

            Console.WriteLine();
            msg = " W poniższym przykładzie użyto metody ContainsKey i właściwości Item property of Dictionary pozwalających szybko ";
            msg += "znaleźć element według klucza.. Właściwość Item umożliwia dostęp do elementu w kodzie elements kolekcji za pomocą elements(symbol)";
            msg += "w języku Visual Basic lub elements[symbol] w języku C#. ";
            Console.WriteLine(msg);
            gen.FindInDictionary("Ca");

            Console.WriteLine();
            Console.WriteLine("W poniższym przykładzie zamiast użyto metody TryGetValue pozwalającej szybko znaleźć element według klucza.");
            gen.FindInDictionary2("K");


         Console.WriteLine();
         Console.WriteLine();
         Console.WriteLine("*  Za pomocą LINQ do dostępu do kolekcji ");

            Console.WriteLine();
            msg = "LINQ (Language-Integrated Query) może służyć do uzyskiwania dostępu do kolekcji. ";
            msg += "Zapytania LINQ zapewniają filtrowanie, porządkowanie i możliwości grupowania. Aby uzyskać więcej informacji, ";
            msg += "zobacz Wprowadzenie do programu LINQ w Visual Basic lub Wprowadzenie do korzystania z LINQ w C#." + Environment.NewLine;
            Console.WriteLine(msg);

            Console.WriteLine();
            Console.WriteLine("Poniższy przykład wykonuje zapytanie LINQ na ogólnej List. Zapytanie LINQ zwraca inną kolekcję, która zawiera wyniki. ");
            LinqQuery c2 = new LinqQuery();
            c2.ShowLINQ();


         Console.WriteLine();
         Console.WriteLine();
         Console.WriteLine("*  Sortowanie kolekcji ");

         msg = "Poniżej przedstawiono przykładową procedurę sortowania zbioru. Przykład sortuje wystąpienia Car klasy, które są przechowywane w List<T>.";
         msg += "Klasa Car implementuje IComparable<T> interfejs, który wymaga, aby metoda CompareTo była realizowana." + Environment.NewLine;
         msg += "Każde wywołanie CompareTo metody tworzy pojedyncze porównanie, który jest używane do sortowania. Kod napisany przez użytkownika w ";
         msg += "metodzie CompareTo wraca wartość dla każdego porównania bieżącego obiektu z innym obiektem. Zwrócona wartość jest mniejsza niż zero, ";
         msg += "jeżeli bieżący obiekt jest mniejszy niż inny obiekt, większa niż zero, jeżeli bieżący obiekt jest większy niż inny obiekt, ";
         msg += "oraz zero, jeżeli są równe. Umożliwia to definiowanie w kodzie kryteriów dla większych niż, mniejszych niż i równych." + Environment.NewLine;

         msg += "W metodzie ListCars instrukcja cars.Sort() sortuje listy. To wywołanie metody Sort z List<T> powoduje, ";
         msg += "że metoda CompareTo zostaje wywołana automatycznie dla obiektów Car w List.";
         Console.WriteLine(msg);
         SortowanieKolekcji c3 = new SortowanieKolekcji();
         c3.ListCars();


         
         Console.WriteLine();
         Console.WriteLine();
         Console.WriteLine("*  Definiowanie kolekcji niestandardowej ");

         msg = "Możesz zdefiniować kolekcję implementując interfejs IEnumerable<T> lub IEnumerable. Aby uzyskać więcej informacji, ";
         msg += "zobacz Wyliczanie kolekcji, Porady: uzyskiwanie dostępu do klasy kolekcji za pomocą instrukcji foreach ";
         msg += "(Przewodnik programowania w języku C#), and .";

         msg += "Chociaż można zdefiniować kolekcję niestandardową, to zazwyczaj lepiej jest użyć zamiast tego kolekcje, ";
         msg += "które są zawarte w.NET Framework, które są opisane w Typy kolekcji wcześniej w tym temacie.";

         msg += "W poniższym przykładzie zdefiniowano klasę kolekcji niestandardowej o nazwie AllColors. ";
         msg += "Ta klasa implementuje interfejs IEnumerable który wymaga, żeby metoda GetEnumerator została implementowana.";

         msg += "Metoda GetEnumerator zwraca wystąpienie klasy ColorEnumerator. ColorEnumerator implementuje IEnumerator interfejs, ";
         msg += "który wymaga, żeby Current pwłaściwośc, MoveNext metoda i Reset metoda była wdrożona. ";

         msg += "że metoda CompareTo zostaje wywołana automatycznie dla obiektów Car w List.";
         Console.WriteLine(msg);
         KolekcjaNiestandardowa c4 = new KolekcjaNiestandardowa();
         c4.ListColors();


         Console.Read();
      }




      public static void IterateThroughList() {
         string msg = "For the type of elements in the List<T>, you can also define your own class. In the following example, the Galaxy class that is used by the List<T> is defined in the code.";
         Console.WriteLine(msg);

         var theGalaxies = new List<Galaxy> {
                     new Galaxy() { Name="Tadpole", MegaLightYears=400},
                     new Galaxy() { Name="Pinwheel", MegaLightYears=25},
                     new Galaxy() { Name="Milky Way", MegaLightYears=0},
                     new Galaxy() { Name="Andromeda", MegaLightYears=3}
                 };
         foreach (Galaxy theGalaxy in theGalaxies) {
            Console.WriteLine(theGalaxy.Name + "  " + theGalaxy.MegaLightYears);
         }
         // Output: 
         //  Tadpole  400 
         //  Pinwheel  25 
         //  Milky Way  0 
         //  Andromeda  3
      }

      public class Galaxy
      {
         public string Name { get; set; }
         public int MegaLightYears { get; set; }
      }


   }
}
