using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HemtentaDesireDatabaserPragueParking
{    
    public class TextMessageHelper
    {
        
        // Metod som frågar om fordon som stått mellan 24h - 25h. Denna frågar varje timma.
        // När klockan slår hel timme, så "raisas" ett event.
        // Denna metoden kommer använda sig av en funktion som sparar ner till filformat och skickas
        // till det externa programmet via connection-metoden.

        public event EventHandler everyHour;

        public void OnUpdateEveryHour()
        {
            everyHour?.Invoke(this, new EventArgs());
        }

        public void Clock()
        {
            OnUpdateEveryHour();
            // Eventet retunrerar när klockan slår hel timma. 
        }


        private void Connection(List<string> listOfVehicles24)
        {
            // Gör om Listan till strängar
            // Listan sparas i en fil Write(Info, "Reminder.xml")
            
            // string Connectionstring  = (Write(info, "Reminder.xml")) ???????
        }       

        public void Reminder24H(object sender, EventArgs e)
        {        

            // Frågar databasen om vilka fordon som stått 24h
            // telefonnummer m.m.
            // sparar infon i en lista

            Connection(listOfVehicles24h);
        }
        static async Task Execute() //sms tjänst
        {
            Customer customer = new Customer();
            var apiKey = Environment.GetEnvironmentVariable("NAME_OF_THE_ENVIRONMENT_VARIABLE_FOR_YOUR_SENDGRID_KEY");
            var client = new SendGridClient(apiKey);
            var from = new Telephonenumber("555-12345678", "PragueParking");
            var subject = "Reminder Parking";
            var to = new Telephonenumber($"{customer.TelephoneNumber}", $"{customer.FirstName} {customer.LastName}");
            var plainTextContent = "You have parked for 24 hours";
            var htmlContent = "<strong>Please check out the vehicle</strong>";
            var msg = TextMessageHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }

        private static object CreateSingleEmail(Telephonenumber from, Telephonenumber to, string subject, string plainTextContent, string htmlContent)
        {
            throw new NotImplementedException();
        }
    }

}

