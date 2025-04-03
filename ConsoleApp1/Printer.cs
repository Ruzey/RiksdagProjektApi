using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Printer
    {

        #region Menu
        public static void PrintMenu(Menu menu)
        {
            foreach (string menuOption in menu.MenuList)
            {
                if (menu.MenuList.IndexOf(menuOption) == menu.MenuSelect)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.WriteLine(menuOption);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
        #endregion

        #region Results
        public static void PrintResults(Temp temp)
        {
            foreach (var item in temp.personlista.person)
            {
                Console.WriteLine("\nNamn: " + item.tilltalsnamn + " " + item.efternamn);
                Console.WriteLine("Födelseår: " + item.fodd_ar);
                Console.WriteLine("Parti: " + item.parti);
            }
        }
        #endregion
    }
}
