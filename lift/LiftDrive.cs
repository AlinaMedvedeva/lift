using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace lift
{
    class LiftDrive
    {
        double firstFloorY;
        public LiftDrive(double StartY)
        {
            firstFloorY = StartY;
        }

        public double toDrive(double LiftY, int floor)
        {
            if(LiftY != firstFloorY - (80*(floor - 1)))
            {
                double FloorY = firstFloorY - (80 * (floor - 1));
                return LiftY - FloorY;
            }
            return 0;
        }
    }
}
