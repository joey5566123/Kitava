using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Kitava.Library
{
    class Coordinate
    {
        private static Window.Rectangle WindwowRectangle;
        private static Point CoordinateIndex;

        public enum CoordinatesStatus : int
        {
            InventoryCoordinate = 0,
            CardChangeButtonCoordinate = 1,
            ChangeItemCoordinate = 2
        }

        public static Point InitialCoordinate(CoordinatesStatus Status)
        {
            WindwowRectangle = Window.ShowWindow();
            CoordinateConversion(Status);
            return CoordinateIndex;
        }

        private static void CoordinateConversion(CoordinatesStatus Status)
        {
            int TitleBarOffset = 30;
            int InventoryLeftOffset = 460;
            int InventoryTopOffset = 340;
            int CardChangeButtonLeftOffset = 225;
            int CardChangeButtonTopOffset = 413;
            int ChangeItemLeftOffset = 225;
            int ChangeItemTopOffset = 323;
            if (Window.IsFullscreen())
            {
                
            }
            else
            {
                switch (Status)
                {
                    case (CoordinatesStatus.InventoryCoordinate):
                        CoordinateIndex = new Point(WindwowRectangle.Left + InventoryLeftOffset, WindwowRectangle.Top + InventoryTopOffset + TitleBarOffset);
                        break;
                    case (CoordinatesStatus.CardChangeButtonCoordinate):
                        CoordinateIndex = new Point(WindwowRectangle.Left + CardChangeButtonLeftOffset, WindwowRectangle.Top + CardChangeButtonTopOffset + TitleBarOffset);
                        break;
                    case (CoordinatesStatus.ChangeItemCoordinate):
                        CoordinateIndex = new Point(WindwowRectangle.Left + ChangeItemLeftOffset, WindwowRectangle.Top + ChangeItemTopOffset + TitleBarOffset);
                        break;
                }
                
            }
        }
    }
}
