using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Generisk klass, viktigt att kunna, kan ta in vilken typ av variabel som helst, man skulle kunna generalisera graphics base
//men alla variabler måste vara IEnumerable alltså att det går att räkna med skrivs T : IEnumerable, gör att man kan använda int och annat också
//Skulle dock behöva skriva om vissa funktioner i graphics base som inte fungerar då de inte vet vilken typ av variabel det är än
//Används ofta för effektiviseringar, mindre kod att skriva
public class GenericSort<T> where T : IComparable
{
    public void Sort(T[] array)
    {
        //Loopar igenom arrayen för att sortera, gör på samma sätt som bubblesort men från andra hållet
        for(int i = 0; i < array.Length-1; i++)
        {
            for(int j = i+1; j < array.Length; j++)
            {
                if (array[i].CompareTo(array[j]) > 0)
                {
                    //'var' kan användas istället för T men 'var' används sällan då det gör koden otydlig för att man inte vet vilken
                    //typ av variabel det är men här spelar det ingen roll då klassen tar in vilken typ av variabel som helst så 
                    //länge den går att jämföras och då sorteras
                    T temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
    }
}
