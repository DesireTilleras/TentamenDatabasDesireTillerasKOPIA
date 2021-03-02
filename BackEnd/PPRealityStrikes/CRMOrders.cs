using System;
using System.Collections.Generic;
using System.Text;

namespace HemtentaDesireDatabaserPragueParking
{
    class CRMOrders
    {
        // När en flytt gjorts i systemet, så skapas en arbetsorder.
        // Finns CurrentOrders och OrderHistory i Databasen.
        // När en flytt gjorts i systemet så skapas ett sms till parkeringsanställd. (Bättre med app)
        // Ordern läggs i databasen och när den är slutförd, så läggs den i historiken.
        // När ordern är lagd så "reserveras" nya platsen direkt. 
        // Den gamla platsen för fordonet är upptagen tills att validering är klar. 
        // När den anställde slutför ordern i appen, så görs flytten skarpt i databasen. 
        // Finns också ett menyval "Working-Orders" i systemet    


        private void Connection()
        {
            // Koppling till externt system. 
            // När en flytt är gjord i systemet (PragueParking 3.0), så ska det bli ett event. 
            // Detta eventet skapar en ny order till den anställde i appen
            // När den anställde klarmarkerar ordern i appen, så läggs ordern i "OrderHistory" i databasen. 
        }

        public event EventHandler MoveOrdered;
        // Event som gör att ordern läggs i databasen under "CurrentOrders"

        public event EventHandler MoveDone;
        // Event som gör att ordern läggs i databasen under "OrderHistory"
    }
}
