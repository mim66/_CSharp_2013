using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kolekcje
{
   class ImplementacjaParKluczWartosc
   {

      /// Implementacja par kluczy/wartości kolekcji

      // Generyczna kolekcja Dictionary<TKey, TValue> umożliwia dostęp do elementów w kolekcji za pomocą klucza każdego elementu. 
      // Każdy dodatkem do słownika składa się z wartości i skojarzonego z nią klucza. Pobieranie wartości przy użyciu własnego klucza 
      // jest szybkie ponieważ klasa Dictionary jest implementowana jako tablica wartości funkcji mieszającej.

      // Poniższy przykład tworzy kolekcję Dictionary i wykonuje iteracje przez słownik za pomocą instrukcji For Each. 

      public void IterateThruDictionary() {

         Dictionary<string, Element> elements = BuildDictionary();
         foreach (KeyValuePair<string, Element> kvp in elements) {
            Element theElement = kvp.Value;
            Console.WriteLine("key: {0};   values: {1}", kvp.Key, theElement.Symbol + " " + theElement.Name + " " + theElement.AtomicNumber);
         }
      }

      private Dictionary<string, Element> BuildDictionary() {
         #region first way
         //var elements = new Dictionary<string, Element>();
         //AddToDictionary(elements, "K", "Potassium", 19);
         //AddToDictionary(elements, "Ca", "Calcium", 20);
         //AddToDictionary(elements, "Sc", "Scandium", 21);
         //AddToDictionary(elements, "Ti", "Titanium", 22);
         //return elements;
         #endregion

         #region second way
         return new Dictionary<string, Element>
         {
            {"K",    new Element() { Symbol="K", Name="Potassium", AtomicNumber=19}},            
            {"Ca",   new Element() { Symbol="Ca", Name="Calcium", AtomicNumber=20}},
            {"Sc",   new Element() { Symbol="Sc", Name="Scandium", AtomicNumber=21}},
            {"Ti",   new Element() { Symbol="Ti", Name="Titanium", AtomicNumber=22}}
         };
         #endregion
      }

      private void AddToDictionary(Dictionary<string, Element> elements, string symbol, string name, int atomicNumber) {
         Element theElement = new Element();
         theElement.Symbol = symbol;
         theElement.Name = name;
         theElement.AtomicNumber = atomicNumber;
         elements.Add(key: theElement.Symbol, value: theElement);
      }

      public class Element
      {
         public string Symbol { get; set; }
         public string Name { get; set; }
         public int AtomicNumber { get; set; }
      }



      // W poniższym przykładzie użyto metody ContainsKey i właściwości Item property of Dictionary pozwalających szybko znaleźć element według klucza.. 
      // Właściwość Item umożliwia dostęp do elementu w kodzie elements kolekcji za pomocą elements(symbol) w języku Visual Basic 
      // lub elements[symbol] w języku C#. 
      public void FindInDictionary(string symbol) {
         Dictionary<string, Element> elements = BuildDictionary();

         if (elements.ContainsKey(symbol) == false) {
            Console.WriteLine(symbol + " nie znaleziono");
         }
         else {
            Element theElement = elements[symbol];
            Console.WriteLine("znaleziono: " + theElement.Name);
         }
      }

      // W poniższym przykładzie zamiast użyto metody TryGetValue pozwalającej szybko znaleźć element według klucza.
      public void FindInDictionary2(string symbol) {
         Dictionary<string, Element> elements = BuildDictionary();

         Element theElement = null;
         if (elements.TryGetValue(symbol, out theElement) == false)
            Console.WriteLine(symbol + " nie znaleziono");
         else
            Console.WriteLine("znaleziono: " + theElement.Name);
      }
   }
}
