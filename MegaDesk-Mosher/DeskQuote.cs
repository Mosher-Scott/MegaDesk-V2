using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;


namespace MegaDesk_Mosher
{
    class DeskQuote
    {
        public string clientFirstName { get; set; }
        public string clientLastName { get; set; }
        public string submitDate { get; set; }
        public double quoteTotal { get; set; }

        public const string SAVEDQUOTEFILE = "savedQuotes.json";  // Since this won't change
        public const string RUSHORDERPRICEFILE = "rushOrderPrices.txt";

        // Create an empty desk object to be used
        public Desk userDesk;

        // Create an empty list to hold all of the DeskQuotes
        public static List<DeskQuote> listOfQuotes = new List<DeskQuote>();

        // Default constructor
        public DeskQuote() { }

        // Constructor with values
        public DeskQuote(string quoteFirstName, string quoteLastName, string quoteDate, double deskQuoteTotal, Desk quoteDesk)
        {

            clientFirstName = quoteFirstName;
            clientLastName = quoteLastName;
            submitDate = quoteDate;
            quoteTotal = deskQuoteTotal;
            userDesk = quoteDesk;
        }

        // This will read values from the savedQuotes file into the list listOfQuotes
        public static void readSavedQuotesFiles()
        {

            if (File.Exists(SAVEDQUOTEFILE))
            {
                // Read the file.
                string json = File.ReadAllText(SAVEDQUOTEFILE);

                listOfQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(json);
            }

        }

        // Checks if the rushorderprice file exists or not.  If it doesn't, then this will create it.
        public static void checkIfRushorderPriceExists()
        {
            if (!File.Exists(RUSHORDERPRICEFILE))
            {
                string prices = "60\n70\n80\n40\n50\n60\n30\n35\n40";

                using (StreamWriter textFile = new StreamWriter(RUSHORDERPRICEFILE, false))
                {
                    textFile.WriteLine(prices);
                }
            }
        }

        public void convertListToJson()
        {
            // Convert the object to a json string, indented
            var output = JsonConvert.SerializeObject(listOfQuotes, Formatting.Indented);

            // Specify a text file to write the data to.  Uses the costant variable in MainMenu.cs
            string quoteTextFile = SAVEDQUOTEFILE;

            // Write the objects to a file.  Use true to append the file, false to overwrite it
            using (StreamWriter textFile = new StreamWriter(quoteTextFile, false))
            {
                textFile.WriteLine(output);
            }
        }

        //Get Rush Order
        //TODO: figure out file
        public int[,] GetRushOrder()
        {
            try
            {
                string path = RUSHORDERPRICEFILE;
                string[] orderPrices = File.ReadAllLines(path);
                int[,] rushOrderGrid = new int[3, 3];

                //outer loop for rows, inner for columns
                int x = 0;
                int i;
                int j = 0;
                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        int output = int.Parse(orderPrices[x]);
                        rushOrderGrid[i, j] = output;
                        //MessageBox.Show("Test:" + i + ", " + j + " " + rushOrderGrid[i,j]);
                        x++;
                    }

                }
                return rushOrderGrid;
            }

            catch (FileNotFoundException)
            {

                MessageBox.Show("Error. File containing rush order prices not found.");
                throw;
            }

        }

    }



}