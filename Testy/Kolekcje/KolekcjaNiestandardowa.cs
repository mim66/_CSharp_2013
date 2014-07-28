using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kolekcje
{
   class KolekcjaNiestandardowa
   {
      // Definiowanie kolekcji niestandardowej

      // Możesz zdefiniować kolekcję implementując interfejs IEnumerable<T> lub IEnumerable. Aby uzyskać więcej informacji, 
      // zobacz Wyliczanie kolekcji, Porady: uzyskiwanie dostępu do klasy kolekcji za pomocą instrukcji foreach (Przewodnik programowania w języku C#), and .

      // Chociaż można zdefiniować kolekcję niestandardową, to zazwyczaj lepiej jest użyć zamiast tego kolekcje, które są zawarte w.NET Framework, 
      // które są opisane w Typy kolekcji wcześniej w tym temacie.

      // W poniższym przykładzie zdefiniowano klasę kolekcji niestandardowej o nazwie AllColors. 
      // Ta klasa implementuje interfejs IEnumerable który wymaga, żeby metoda GetEnumerator została implementowana.

      // Metoda GetEnumerator zwraca wystąpienie klasy ColorEnumerator. ColorEnumerator implementuje IEnumerator interfejs, 
      // który wymaga, żeby Current pwłaściwośc, MoveNext metoda i Reset metoda była wdrożona. 

      public void ListColors() {
         var colors = new AllColors();

         foreach (Color theColor in colors) {
            Console.Write(theColor.Name + " ");
         }
         Console.WriteLine();
         // Output: red blue green
      }


      // Collection class.
      public class AllColors : System.Collections.IEnumerable
      {
         Color[] _colors = {
           new Color() { Name = "red" },
           new Color() { Name = "blue" },
           new Color() { Name = "green" }
         };

         public System.Collections.IEnumerator GetEnumerator() {
            return new ColorEnumerator(_colors);

            // Instead of creating a custom enumerator, you could
            // use the GetEnumerator of the array.
            //return _colors.GetEnumerator();
         }

         // Custom enumerator.
         private class ColorEnumerator : System.Collections.IEnumerator
         {
            private Color[] _colors;
            private int _position = -1;

            public ColorEnumerator(Color[] colors) {
               _colors = colors;
            }

            object System.Collections.IEnumerator.Current {
               get {
                  return _colors[_position];
               }
            }

            bool System.Collections.IEnumerator.MoveNext() {
               _position++;
               return (_position < _colors.Length);
            }

            void System.Collections.IEnumerator.Reset() {
               _position = -1;
            }
         }
      }

      // Element class.
      public class Color
      {
         public string Name { get; set; }
      }


   }
}
