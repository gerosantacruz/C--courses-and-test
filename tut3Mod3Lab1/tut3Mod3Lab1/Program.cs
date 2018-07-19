using System;
using System.Collections;

namespace tut3Mod3Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList myArrList = new ArrayList();

            //myArrList.Add("Fist item");
            //myArrList.Add(3);
            //myArrList.Add(4.5);

            //foreach (object obj in myArrList)
            //{
            //    Console.WriteLine(obj.ToString());
            //}

            //myArrList.Add("First item");
            //myArrList.Add("Third item");
            //myArrList.Add("Second item");

            //myArrList.Sort();
            //int itemIndex = myArrList.IndexOf("Third item");

            //foreach (object obj in myArrList)
            //{
            //    Console.WriteLine(obj.ToString());
            //}

            //Console.WriteLine();
            //Console.WriteLine($"Third item is at index {itemIndex}");


            //Create a new hash table-

            Hashtable openWith = new Hashtable();

            //Add some elements to the hash table. there are not duplicate keys, but some values are duplicates.

            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            //the add method throws an exception if the new key is
            //already in the hash table

            try
            {
                openWith.Add("txt", "window.exe");
            }
            catch
            {
                Console.WriteLine("An element with key = \"txt\" already exists.");

            }

            //the Item property is th deafault property, so you
            //can omit its name when accessing elements.
            Console.WriteLine("For key = \"rtf\", value = {0}.", openWith["rtf"]);

            //the dafault item property can be used to change the value
            //associated with a key.
            openWith["rtf"] = "window.exe";
            Console.WriteLine("For key \"rtf\", value = {0}", openWith["rtf"]);

            //ContainsKey can be used to test keys before inserting them

            if (!openWith.ContainsKey("ht"))
            {
                openWith.Add("ht", "hypertrm.exe");
                Console.WriteLine("Value added for key = \"ht\" ; {0}", openWith["ht"]);

            }

            //When you use foreach to enumerate hast table elements
            //the elements are retrieved as KeyValuePair objects.
            Console.WriteLine();
            foreach(DictionaryEntry de in openWith)
            {
                Console.WriteLine("key = {0}, Value = {1}", de.Key, de.Value);
            }
        }
    }
}
