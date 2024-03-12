namespace Exceptione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader?streamReader=null;
            //StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader("sample.txt");
                Console.WriteLine(streamReader.ReadToEnd());
            }
            catch(FileNotFoundException ex)
            { 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //if(streamReader != null)
                //{
                //    streamReader.Close();
                    
                //}
                streamReader?.Close();
            }
        }
    }
}