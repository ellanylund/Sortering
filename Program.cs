using System.Diagnostics;

class program
{
    static void Main()
    {
        //Different variables we can sort using the generic class 
        GenericSort<int> intSorter = new();
        GenericSort<string> stringSorter = new();
        GenericSort<float> floatSorter = new();
        GenericSort<double> doubleSorter = new();
        GenericSort<char> charSorter = new();

        
        //Amount of numbers to sort
        int[] ints = new int[10000];

        //makes the numbers in the arrays random so we don't have to type them all out
        Random random = new();
        Stopwatch sw = new();
        for(int i = 0; i < ints.Length; i++)
        {
            ints[i] = random.Next(1000000);
            //Console.WriteLine(ints[i]);
        }

        //used to show how long it takes for each sorting method to sort all of the number
        //bubblesort is about four times faster than the first sorting system we did
        //bubblesort is sometimes slower than the other sorting system when it comes to smaller amounts of numbers
        //The default sorting system that we can call upon in c# is a lot more optimized than the ones we did

        //Both insertion sorting and bubblesort are comparison based sorting systems meaning they compare the variables in the array
        //in order to sort it

        //First sorting system (ints2 = ints is just so we have two copies of the array so the comparison is equal)
        //This is called insertion sorting
        /*int[] ints2 = ints;
        sw.Start();
        sortArray(ints);
        sw.Stop();
        Console.WriteLine("Array sorted in: " + sw.Elapsed);

        //Bubblesorting system
        sw.Restart();
        bubbleSort(ints2);
        sw.Stop();
        Console.WriteLine("Bubblesort done in: " + sw.Elapsed);

        //C# default sorting system
        sw.Restart();
        Array.Sort(ints);
        sw.Stop();
        Console.WriteLine("Default sort done in: " + sw.Elapsed);

        //used to print out all the numbers in the sorted order
        //Console.WriteLine("Sorted:");
        for(int i = 0; i < ints.Length; i++)
        {
            Console.WriteLine(ints[i]);
        }*/


        //Using the generic sort:
        //Is the same as the bubblesort timewise as they are pretty much the same
        intSorter.Sort(ints);


    }

    //First sorting method
    //Sorts through the whole array each time, not very effective for bigger arrays but works well for smaller ones
    static void sortArray(int[] arr)
    {
        for (int j = 1; j < arr.Length; j++)
        {

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    var temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                }
            }
        }
    }

    //Effektivare vid sortering av stora arrays då den går från andra hållet och börjar med att flytta det största talet längst bak
    //Gör alltså att den inte behöver jämföra vissa tal då de redan är på rätt plats i arrayen
    static void bubbleSort(int[] arr)
    {
        for(int i = arr.Length-1; i > 0; i--)
        {
            for(int j = 0; j < i; j++)
            {
                if (arr[i] < arr[j])
                {
                    var temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                }
                
            }
        }
    }
    
}

//Research different sorting systems and practice using generic classes