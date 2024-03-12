using System.Diagnostics.Metrics;

namespace DictionaryOverList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Country countryAus = new Country()
                {
                    Code = "AUS",
                    Name = "AUSTRALIA",
                    Capital = "Canberra"
                };
                Country countryInd = new Country()
                {
                    Code = "IND",
                    Name = "INDIA ",
                    Capital = "New Delhi"
                };
                Country countryUsa = new Country()
                {
                    Code = "USA",
                    Name = "UNITED STATES",
                    Capital = "Washington D.C."
                };
               
                
                //List<Country> listCountries = new List<Country>();
                //listCountries.Add(country1);
                //listCountries.Add(country2);
                //listCountries.Add(country3);
                //listCountries.Add(country4);
                //listCountries.Add(country5);
                Dictionary<string, Country> dictionaryCountries = new Dictionary<string, Country>();
                dictionaryCountries.Add(countryAus.Code, countryAus);
                dictionaryCountries.Add(countryInd.Code, countryInd);
                dictionaryCountries.Add(countryUsa.Code, countryUsa);
               
                string strUserChoice = string.Empty;
            do
            {
                Console.WriteLine("Please enter country code");
                string strCountryCode = Console.ReadLine().ToUpper();
                // Find() method of the list class loops thru each object in the list until a match is found. So, if we want to 
                // lookup a value using a key dictionary is better for performance over list. 
                // Country resultCountry = listCountries. Find(country => country.Code == strCountryCode);
                Country resultCountry = dictionaryCountries.ContainsKey(strCountryCode) ? dictionaryCountries[strCountryCode] : null;
                if (resultCountry == null)
                {
                    Console.WriteLine("The country code you entered does not exist");
                }
                else
                {
                    Console.WriteLine("Name = " + resultCountry.Name + " Captial =" + resultCountry.Capital);
                }
                do
                {
                    Console.WriteLine("Do you want to continue - YES or NO?");
                    strUserChoice = Console.ReadLine().ToUpper();
                }
                while (strUserChoice != "NO" && strUserChoice != "YES");
               }
            while (strUserChoice == "YES");
        }

    
        
    }
}