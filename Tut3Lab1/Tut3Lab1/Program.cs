using System;
using System.Collections;

namespace Tut3Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList myArrList = new ArrayList();

            //myArrList.Add("First Item");
            //myArrList.Add(3);
            //myArrList.Add(4.5);

            //foreach (object obj in myArrList)
            //{
            //    Console.WriteLine(obj.ToString());
            //}

            ArrayList myArrList = new ArrayList();
            myArrList.Add("First Item");
            myArrList.Add("Third Item");
            myArrList.Add("Second Item");

            myArrList.Sort();
            int itemIndex = myArrList.IndexOf("Third Item");

            foreach (object obj in myArrList)
            {
                Console.WriteLine(obj.ToString());
            }
            Console.WriteLine();
            Console.WriteLine($"Third Item is at index {itemIndex}.");

            // Create a new hash table.
            //
            Hashtable openWith = new Hashtable();

            // Add some elements to the hash table. There are no 
            // duplicate keys, but some of the values are duplicates.
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            // The Add method throws an exception if the new key is 
            // already in the hash table.
            try
            {
                openWith.Add("txt", "winword.exe");
            }
            catch
            {
                Console.WriteLine("An element with Key = \"txt\" already exists.");
            }

            // The Item property is the default property, so you 
            // can omit its name when accessing elements. 
            Console.WriteLine("For key = \"rtf\", value = {0}.", openWith["rtf"]);

            // If a key does not exist, setting the default Item property
            // for that key adds a new key/value pair.
            openWith["doc"] = "winword.exe";

            // ContainsKey can be used to test keys before inserting 
            // them.
            if (!openWith.ContainsKey("ht"))
            {
                openWith.Add("ht", "hypertrm.exe");
                Console.WriteLine("Value added for key = \"ht\": {0}", openWith["ht"]);
            }

            // When you use foreach to enumerate hash table elements,
            // the elements are retrieved as KeyValuePair objects.
            Console.WriteLine();
            foreach (DictionaryEntry de in openWith)
            {
                Console.WriteLine("Key = {0}, Value = {1}", de.Key, de.Value);
            }
        }
    }
}
