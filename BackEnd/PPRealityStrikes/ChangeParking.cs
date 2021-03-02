using System;
using System.Collections.Generic;
using System.Text;

namespace HemtentaDesireDatabaserPragueParking
{
    class ExtendParking
    {
        // Metoder som alter table i befintlig databas gällande parkeringsplatser.
        // Finns en funktion i frontEnd som frågar användaren storlek och mängd parkeringsplatser 

        private void ParkingExtender(int amountSpots, int size)
        {
            // Alter table drop constraint... bla bla.. 
            // Vi lägger till så många spots som skall utökas och storlek. 
        }
        private void ParkingDelete()
        {
            // Återställer ??? (hur?)
            // If spot 101-150 is size == 0. Delete spots from parkingspots where spotsid >=101. 
            // Alter table Parkingspots constraint 0-100
        }
    }
}
