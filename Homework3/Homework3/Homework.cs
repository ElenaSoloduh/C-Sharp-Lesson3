using System;
using System.Collections.Generic;

namespace Homework3
{
    class Homework
    {
        public void GetCentralElementFromMatrix(int[,] matrixOfIntegers)
        {
            /*print to console the central element from matrixOfIntegers, if not exist print: "This matrix doesn't have a central element"
             * |   input           | result             |
             * |-------------------|--------------------|
             * | {                 |                    |
             * |  { 1,   3,  5},   |    The central     |
             * |  {-1, 100, 11},   |  element is 100    |
             * |  { 2,  15, 44}    |                    |
             * |  }                |                    |
             * |----------------------------------------|
             * |{                  |                    |
             * | { 1,  6, 21,  8 },| This matrix doesn't|
             * | { 5, -4,  5,  7 },| have a central     |
             * | {77,  5,  0, 74 } |  element           |
             * | }                 |                    |
             * ------------------------------------------
             *    
             */
            int rows = matrixOfIntegers.GetLength(0);
            int columns = matrixOfIntegers.GetLength(1);

            if (rows % 2 != 0 && columns % 2 != 0)
            {
                Console.WriteLine(matrixOfIntegers[rows / 2, columns / 2]);
            }
            else
            {
                Console.WriteLine("This matrix doesn't have a central element");
            }

        }
        public void GetSummOfDiagonalsElements(int[,] matrixOfIntegers)
        {
            /*print to console the central element from matrixOfIntegers, if not exist print: "This matrix doesn't have a central element"
             * |   input           | result              |
             * |-------------------|---------------------|
             * | {                 |                     |
             * |  { 1,   3,  5},   | First diagonal: 145 |
             * |  {-1, 100, 11},   | Second diagonal: 107|
             * |  { 2,  15, 44}    |                     |
             * |  }                |                     |
             * |-----------------------------------------|
             * |{                  |                     |
             * | { 1,  6, 21,  8 },| This matrix doesn't |
             * | { 5, -4,  5,  7 },| have a diagonals    |
             * | {77,  5,  0, 74 } |                     |
             * | }                 |                     |
             * ------------------------------------------
             *    
             */
            int rows = matrixOfIntegers.GetLength(0);
            int columns = matrixOfIntegers.GetLength(1);
            int sum1 = 0;
            int sum2 = 0;

            if (rows == columns)
            {
                for (int i = 0; i < rows; i++)
                {
                    sum1 += matrixOfIntegers[i, i];
                    sum2 += matrixOfIntegers[i, columns - 1 - i];
                }
                Console.WriteLine("First diagonal: " + sum1);
                Console.WriteLine("Second diagonal: " + sum2);
            }
            else
            {
                Console.WriteLine("This matrix doesn't have a diagonal");
            }
            

        }
        public void StarPrinter(int triangleHight)
        {
            /* Write a programm that will print a triagle of stars  with hight = triangleHight
             *  Example: triangleHight = 3;
             *  Result:   *
             *           * *
             *          * * * 
             */
            for (int i = 0; i < triangleHight; i++)
            {
                for (int j = triangleHight - 1; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = i; k >= 0; k--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            } 

        }
        public void SortList(IList<int> listOfNumbers)
        {
            //Print to console elements of  listOfNumbers in ascending order
            //Method 1
            List<int> sortedList = (List<int>)listOfNumbers;
            sortedList.Sort();
            for (int i = 0; i < sortedList.Count; i++)
            {
                Console.Write(sortedList[i] + " ");
            }
            Console.WriteLine();

            //Method 2
            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                for (int j = i; j < listOfNumbers.Count; j++)
                {
                    if (listOfNumbers[i] > listOfNumbers[j])
                    {
                        int a = listOfNumbers[i];
                        listOfNumbers[i] = listOfNumbers[j];
                        listOfNumbers[j] = a;
                    }
                }
            }

            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                Console.Write(listOfNumbers[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Homework homework = new Homework();
            IList<int> list = new List<int>() { -5, 8, -7, 0, 44, 121, -7 };
            int[,] matrix = new int[3, 3] {
                { 1,   3,  5},
                { 2, 3, 5},
                {100, 56 , -54} };
            int[,] matrix2 = new int[3, 4] {
                { 1,   3,  5,   6},
                { 2,   3,  5,  78},
                {100, 56 , -54, 6} };

            homework.GetCentralElementFromMatrix(matrix);
            homework.GetCentralElementFromMatrix(matrix2);
            homework.GetSummOfDiagonalsElements(matrix);
            homework.GetSummOfDiagonalsElements(matrix2);
            homework.StarPrinter(5);
            homework.SortList(list);

            //Generic collections homework
            //List
            List<int> numberList = new List<int>();
            numberList.Add(5);
            numberList.Add(3);
            numberList.Add(8);
            homework.PrintList(numberList);

            numberList.Insert(1, 2); //Insert new items
            numberList.Insert(3, 12);
            homework.PrintList(numberList);

            numberList.Sort();  //Sort ASC
            homework.PrintList(numberList);

            numberList.Reverse(); //Sort DESC
            homework.PrintList(numberList);

            int value = 12; 
            if (numberList.Contains(value))
            {
                Console.WriteLine("List is up to date");
            }
            else
            {
                numberList.Add(value);
                homework.PrintList(numberList);
            }

            numberList.Remove(3);
            homework.PrintList(numberList);

            int index = numberList.IndexOf(12);
            if (index == -1)
            {
                Console.WriteLine("Element doesn`t exist in the list");
            }
            else
            {
                numberList.RemoveAt(index);
                homework.PrintList(numberList);
            }

            //Dictionary
            Dictionary<int, string> zoo = new Dictionary<int, string>();
            zoo.Add(1, "giraffe");
            zoo.Add(2, "elephant");
            zoo.Add(3, "lion");
            zoo.Add(4, "monkey");
            homework.PrintDictionary(zoo);

            var result = zoo.TryAdd(3, "tiger");
            if (result)
            {
                Console.WriteLine("Value was added");
            }
            else
            {
                Console.WriteLine("Value can not be added");
            }
            homework.PrintDictionary(zoo);

            string animal = "wolf";
            if (zoo.ContainsValue(animal))
            {
                Console.WriteLine("Zoo has this animal");
            }
            else
            {
                List<int> keys = new List<int>(zoo.Keys);
                keys.Sort();
                zoo.Add(keys[keys.Count - 1] + 1, animal);
                homework.PrintDictionary(zoo);
            }

            zoo.Remove(1);
            homework.PrintDictionary(zoo);

            //Stack (LIFO) 
            Stack<string> cars = new Stack<string>();
            cars.Push("volvo");
            cars.Push("toyota");
            cars.Push("dacia");
            cars.Push("renault");
            cars.Push("audi");
            homework.PrintStack(cars);

            Console.WriteLine(cars.Peek());
            homework.PrintStack(cars);
            Console.WriteLine(cars.Pop());
            homework.PrintStack(cars);

            //Queue (FIFO)
            Queue<string> cities = new Queue<string>();
            cities.Enqueue("chisinau");
            cities.Enqueue("balti");
            cities.Enqueue("nisporeni");
            cities.Enqueue("leova");
            homework.PrintQueue(cities);

            Console.WriteLine(cities.Peek());
            homework.PrintQueue(cities);
            Console.WriteLine(cities.Dequeue());
            homework.PrintQueue(cities);

            //Hashset
            HashSet<string> names = new HashSet<string>();
            names.Add("John");
            names.Add("Mike");
            names.Add("James");
            names.Add("Peter");
            homework.PrintHashSet(names);
        }

        private void PrintHashSet(HashSet<string> names)
        {
            foreach (var item in names)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        private void PrintQueue(Queue<string> cities)
        {
            foreach (var item in cities)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        private void PrintStack(Stack<string> cars)
        {
            foreach (var item in cars)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        private void PrintDictionary(Dictionary<int, string> zoo)
        {
            foreach (var item in zoo)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }

        private void PrintList(List<int> numberList)
        {
            foreach (int i in numberList)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

    }
}
