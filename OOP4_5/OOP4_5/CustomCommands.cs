using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OOP4_5
{
    public static class CustomCommands
    {
        static CustomCommands()
        {
            ColorRedCommand = new RoutedCommand("ColorRed", typeof(CustomCommands));
            ColorGreenCommand = new RoutedCommand("ColorGreen", typeof(CustomCommands));
            ColorBlackCommand = new RoutedCommand("ColorBlack", typeof(CustomCommands));
            ColorBlueCommand = new RoutedCommand("ColorBlue", typeof(CustomCommands));
            ColorYellowCommand = new RoutedCommand("ColorYellow", typeof(CustomCommands));

        }

        public static RoutedCommand ColorRed
        {
            get
            {
                return (ColorRedCommand);
            }
        }

        public static RoutedCommand ColorGreen
        {
            get
            {
                return (ColorGreenCommand);
            }
        }

        public static RoutedCommand ColorBlue
        {
            get
            {
                return (ColorBlueCommand);
            }
        }

        public static RoutedCommand ColorYellow
        {
            get
            {
                return (ColorYellowCommand);
            }
        }

        public static RoutedCommand ColorBlack
        {
            get
            {
                return (ColorBlackCommand);
            }
        }

        public static RoutedCommand ColorRedCommand;
        public static RoutedCommand ColorBlueCommand;
        public static RoutedCommand ColorGreenCommand;
        public static RoutedCommand ColorBlackCommand;
        public static RoutedCommand ColorYellowCommand;

    }
}
