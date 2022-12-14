using System;
using Microsoft.VisualBasic;
using cse21005.Game.Casting;

namespace cse21005.Game
{
    /// <summary>
    /// <para>A holder for constants used throughout the program.</para>
    /// <para>
    /// The responsibility of Constants is to hold values for box size, colors, etc. 
    /// </para>
    /// </summary>
    public class Constants
    {
        public static int COLUMNS = 40;
        public static int ROWS = 20;
        public static int CELL_SIZE = 15;
        public static int MAX_X = 900;
        public static int MAX_Y = 600;

        public static int FRAME_RATE = 15;
        public static int FONT_SIZE = 15;
        public static string CAPTION = "Snake";
        public static int BIKER_LENGTH = 1;

        public static Color RED = new Color(255, 0, 0);
        public static Color WHITE = new Color(255, 255, 255);
        public static Color YELLOW = new Color(255, 255, 0);
        public static Color GREEN = new Color(0, 255, 0);
        public static Color BLUE = new Color(0, 0, 255);
        public static Color PURPLE = new Color(128, 0, 128);
    }
}

