using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HemtentaDesireDatabaserPragueParking
{
    // Information tas från databasen gällande kundinfo, fordonsinfo samt parkeringsinfo och pris. 
    // Skickas sedan till externt ekonomiprogram som i sin tur skickar fakturan till kunden. 

    class InvoiceProcessing
    {
        public static object MailHelper { get; private set; }

        // Metod för att prata med ekonomiprogrammet (connection)        

        // Metod för att prata med databasen och ParkingHistory, sparas i korrekt filformat, skickas till ekonomiprogrammet
        // i egen metod. 

        // Finns funktionalitet där faktureringsintervall är valt beroende på kunden. (ex. 30 dagar, tråd skickas
        // en viss tid på ett visst datum för att ta ut infon från ParkingHistory). 

        // CheckOut metoden (FrontEnd klassen) skall fråga kunden om den skall faktureras eller ej, alltså välja betalsätt.

        private void InvoiceInfo(string regnr)
        {
            // Ta ut info från ParkingsHistory
            // Regnr är kopplat till en kund. Kunden i databasen är kopplat till ett visst faktureringsvullkor
            // Faktueringsvillkoret bestämmer vilka datum som kunden skall faktureras för. 
            // Info: Kund, Adress, Belopp, datum
            // ToString() = Info variabel som skriver till en fil Write(Info,"Invoice.xml"). 
        }
        static async Task Execute() //ex om vi själva skickar invoices
        {
            var apiKey = Environment.GetEnvironmentVariable("NAME_OF_THE_ENVIRONMENT_VARIABLE_FOR_YOUR_SENDGRID_KEY");
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("pragueparking@bestparkinginprague.com", "Emil13årBarnarbete");
            var subject = "Here is your parking-invoice";
            var to = new EmailAddress("ferrari1961@hotmail.com", "Zslavick Kolovicc");
            var plainTextContent = "amount, parkingtime (Bifogad fil?)";
            var htmlContent = "<strong>amount to pay</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }

    }
}
