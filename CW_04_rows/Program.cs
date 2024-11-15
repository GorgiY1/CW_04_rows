using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_04_rows
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World!";
            char[] arrch = { 'H', 'e', 'l', 'l', 'o' };

            string str1 = new string(arrch);
            string str2 = new string(arrch,1,3);
            string str11 = new string('$',1000000);

            //Console.WriteLine(str2);

            //Console.WriteLine(string.Compare(str,str1));
            //Console.WriteLine(string.Compare(str,0, str1,0,3));

            //Console.WriteLine(string.Compare(str, str1));
            //int n1 = 3, n2 = 5;

            //string.Format("{0}+{1}={2}",n1,n2,n1+n2);

            //Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
            //Console.WriteLine($"{n1} + {n2} = {""n1 < n2")}");

            //Console.WriteLine(string.IsNullOrEmpty(str1));
            //str = "";
            //Console.WriteLine(string.IsNullOrEmpty(str1));
            //Console.WriteLine(string.IsNullOrWhiteSpace(str1));
            //str = " ";
            //Console.WriteLine(string.IsNullOrEmpty(str1));

            str2 = " Initializes a new instance of the System.String class to the value indicated";
            //string[] arr = str2.Split(' ');
            //string[] arr1 = str2.Split(new char[] { ' ', '.' },StringSplitOptions.RemoveEmptyEntries);

            //foreach (string item in arr1)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(string.Join("+",arr));

            //Console.WriteLine(str1.Contains("new"));
            //Console.WriteLine(str2.Contains("new"));

            //Console.WriteLine(str2.IndexOf('a'));
            //Console.WriteLine(str2.LastIndexOf("the"));

            //Console.WriteLine(str2.EndsWith("indicated"));
            //Console.WriteLine(str2.StartsWith("Initializes"));

            Console.WriteLine(str1.PadLeft(6, '#'));
            Console.WriteLine(str1.PadRight(8, '%'));

            Console.ReadKey();
        }
    }
}
