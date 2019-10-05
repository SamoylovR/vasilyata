using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MenuItem
    {
        private string returnValue;
        private string itemValue;

        public MenuItem(string returnValue, string itemValue)
        {
            this.returnValue = returnValue;
            this.itemValue = itemValue;
        }

        public string GetReturnValue()
        {
            return returnValue;
        }

        public string GetItemValue()
        {
            return itemValue;
        }
    }

    static class MenuBuilder
    {
        static private Dictionary<MenuType, List<MenuItem>> menuWareHouse = new Dictionary<MenuType, List<MenuItem>>()
        {
            { 
                MenuType.Difficulty, new List<MenuItem>()
                {
                    new MenuItem("difficulty_menu_caption", "select your difficulty\n\n"), 
                    new MenuItem("easy", "easy difficulty"),
                    new MenuItem("norm", "norm difficulty"),
                    new MenuItem("hard", "hard difficulty"),
                } 
            },
            { 
                MenuType.Main, new List<MenuItem>()
                {
                    new MenuItem("main_menu_caption", "select your class hero\n\n"),
                    new MenuItem("hero_tank", "hero is tank, HP - 150, DEX - 30"),
                    new MenuItem("hero_norm", "hero is norm, HP - 100, DEX - 50"),
                    new MenuItem("hero_lucky", "hero is lucky,  HP - 50, DEX - 70"),
                } 
            },
            { 
                MenuType.Exit, new List<MenuItem>() 
                {
                    new MenuItem("exit_menu_caption", "select your choice\n\n"),
                    new MenuItem("continue", "continue playing"),
                    new MenuItem("exit_to_main_menu", "exit to main menu"),
                    new MenuItem("exit", "application exit"),
                } 
            },
            {
                MenuType.Victory, new List<MenuItem>()
                {
                    new MenuItem("victory_caption", "You won"),
                    new MenuItem("continue", "continue"),
                }
            }
        };
        static public List<MenuItem> Create(MenuType type)
        {
            return menuWareHouse.ContainsKey(type) ? menuWareHouse[type] : menuWareHouse[MenuType.Exit];
        }
    }
}
