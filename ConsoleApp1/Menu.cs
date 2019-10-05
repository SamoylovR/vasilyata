using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    class Menu
    {
        List<MenuItem> menu;
        int selectItemMenu = 1;
        
        public Menu(MenuType Type) 
        {
            menu = MenuBuilder.Create(Type);
        }
        public string Run()
        {
            int selectedItem = 1;
            int row = 5;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.SetCursorPosition((Console.BufferWidth - menu[0].GetItemValue().Length) / 2, row);
                Console.WriteLine(menu[0].GetItemValue());
                Console.BackgroundColor = ConsoleColor.Black;

                for (int i = 1; i < menu.Count(); i++)
                {
                    Console.ForegroundColor = selectedItem == i ? ConsoleColor.Green : ConsoleColor.Gray;
                    Console.SetCursorPosition((Console.BufferWidth - menu[i].GetItemValue().Length) / 2, row + 2 + i);
                    Console.WriteLine(menu[i].GetItemValue());
                }

                ConsoleKey key = Console.ReadKey().Key;

                if (key == ConsoleKey.UpArrow && selectedItem > 1)
                    selectedItem--;
                
                else if (key == ConsoleKey.DownArrow && selectedItem < menu.Count - 1)
                    selectedItem++;
                
                else if (key == ConsoleKey.Enter)
                    break;

                //Console.Clear();
            }

            return menu[selectedItem].GetReturnValue();
        }
    }
}
