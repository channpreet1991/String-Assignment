using System; //This will import the libraries
using System.Text;

class Program//This is the class proram
    {
        static void Main(string[] args)
        {
            //This is the set the Globalization Culture as en-US
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
 
            StringBuilder stringb = new StringBuilder(); //This will set the StringBuilder()
            
            //This is the THREE (3) String given, you can change the value of it
            stringb.Append("This is ");
            stringb.Append("the example ");
            stringb.Append("three string!");

            //This will print the before the stringbuilder contents
            Console.WriteLine("The stringbuilder contents: \n" + stringb.ToString());
 
            //this line convert stringbuilder characters to uppercase characters.
            string s = stringb.ToString().ToUpper();
 
            stringb.Clear();
            stringb.Append(s);
 
            //This will print the after the stringbuilder contents
            Console.WriteLine("\nThe stringbuilder contents uppercase:\n"+ stringb.ToString());
            Console.ReadLine();
        }
    }
}