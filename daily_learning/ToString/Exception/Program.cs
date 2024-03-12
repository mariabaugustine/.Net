namespace ExceptionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // string path = @"C:\DotNet1\ExceptionExample";


                //  StreamReader streamreader = new StreamReader("SampleExample.txt");
                StreamReader streamreader = new StreamReader("sample1.txt");
                Console.WriteLine(streamreader.ReadToEnd());
            }
            catch(Exception ex ) 
            {
                Console.WriteLine(ex.Message);
            }
            //catch(FileNotFoundException ex) { } after the general exception it is not possible.beacuse all the exception re catched by previous catch
            
        }
    }
}