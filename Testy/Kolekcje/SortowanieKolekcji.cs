using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kolekcje
{
   class SortowanieKolekcji
   {

      //Sortowanie kolekcji

      // Poniżej przedstawiono przykładową procedurę sortowania zbioru. Przykład sortuje wystąpienia Car klasy, które są przechowywane w List<T>. 
      // Klasa Car implementuje IComparable<T> interfejs, który wymaga, aby metoda CompareTo była realizowana.

      // Każde wywołanie CompareTo metody tworzy pojedyncze porównanie, który jest używane do sortowania. Kod napisany przez użytkownika 
      // w metodzie CompareTo wraca wartość dla każdego porównania bieżącego obiektu z innym obiektem. Zwrócona wartość jest mniejsza niż zero, 
      // jeżeli bieżący obiekt jest mniejszy niż inny obiekt, większa niż zero, jeżeli bieżący obiekt jest większy niż inny obiekt, oraz zero, 
      // jeżeli są równe. Umożliwia to definiowanie w kodzie kryteriów dla większych niż, mniejszych niż i równych.

      // W metodzie ListCars instrukcja cars.Sort() sortuje listy. To wywołanie metody Sort z List<T> powoduje, 
      // że metoda CompareTo zostaje wywołana automatycznie dla obiektów Car w List. 
      
      public void ListCars() {
         var cars = new List<Car>
          {
              { new Car() { Name = "car1", Color = "blue",  Speed = 20}},
              { new Car() { Name = "car2", Color = "red",   Speed = 50}},
              { new Car() { Name = "car3", Color = "green", Speed = 10}},
              { new Car() { Name = "car4", Color = "blue",  Speed = 50}},
              { new Car() { Name = "car5", Color = "blue",  Speed = 30}},
              { new Car() { Name = "car6", Color = "red",   Speed = 60}},
              { new Car() { Name = "car7", Color = "green", Speed = 50}}
          };

         // Sort the cars by color alphabetically, and then by speed
         // in descending order.
         cars.Sort();

         // View all of the cars.
         foreach (Car thisCar in cars) {
            Console.WriteLine(" Car Color: {0}; Speed: {1}; Name: {2}", thisCar.Color.PadRight(5), thisCar.Speed.ToString(), thisCar.Name);
         }
         Console.WriteLine();

         // Output:
         //  blue  50 car4
         //  blue  30 car5
         //  blue  20 car1
         //  green 50 car7
         //  green 10 car3
         //  red   60 car6
         //  red   50 car2
      }

      public class Car : IComparable<Car>
      {
         public string  Name { get; set; }
         public int     Speed { get; set; }
         public string  Color { get; set; }

         public int CompareTo(Car other) {
            // A call to this method makes a single comparison that is
            // used for sorting.

            // Determine the relative order of the objects being compared.
            // Sort by color alphabetically, and then by speed in
            // descending order.

            // Compare the colors.
            int compare;
            compare = String.Compare(this.Color, other.Color, true);

            // If the colors are the same, compare the speeds.
            if (compare == 0) {
               compare = this.Speed.CompareTo(other.Speed);

               // Use descending order for speed.
               compare = -compare;
            }
            return compare;
         }
      }

   }
}
