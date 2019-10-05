using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ConsoleApp1
{
    enum Def                //App settings
    {
        MaxHotTrack = 20,   //count hot steps of hero
        PrincessBlink = 1,  //princess is blink cycle on every hero's step 0/1 on/off
        AmbassDexAdd = 50,  //value to inc dexterity if object in ambass
        FieldStartX = 5,
        FieldStartY = 3
    };
    enum MenuType { Main, Difficulty, Exit, Victory }
    
    enum UpdateState { None, DifficultyMenu, GoToLoop, Continue, MainMenu, ExitMenu, VictoryMenu, Exit }
   
    enum FieldSize 
    { 
        width = 30,
        height = 15
    }

    class Program
    {
        static void Main(string[] args)
        {
            MenuType menuType = MenuType.Difficulty;
            Field field = null;
            UpdateState updateState = 0;
           
            while (true)
            {
                Menu menu = new Menu(menuType);
                
                if (menuType == MenuType.Difficulty)
                {
                    Rules.currentRule = menu.Run();
                    updateState = UpdateState.MainMenu;
                }
                else
                if (menuType == MenuType.Main)
                {
                    string heroClass = menu.Run();
                    Rule rule = Rules.GetTamplateRule();

                    rule.objectsInfo.ForEach((ObjectsInfo objectsInfo) => {
                        
                        if (objectsInfo.objectsType.IndexOf("hero") != -1) 
                            objectsInfo.objectsType = heroClass; 
                    });

                    field = new Field(rule.fieldSize);
                    Recruter.Init(field);    
                    
                    foreach(var i in rule.objectsInfo)
                    {
                        WorkerBase worker = Recruter.RecrutWorker(i);
                        field.GiveMeObject(worker);
                    }
                    updateState = UpdateState.GoToLoop;
                }
                else
                if (menuType == MenuType.Exit)
                {
                    string behavior = menu.Run();

                    if (behavior == "continue")
                        updateState = UpdateState.GoToLoop;

                    else
                    if (behavior == "exit_to_main_menu")
                       updateState = UpdateState.DifficultyMenu;

                    else
                    if (behavior == "exit")
                       break;
                    
                    Console.Clear();
                }
                else
                if (menuType == MenuType.Victory)
                {
                    menu.Run();
                    updateState = UpdateState.DifficultyMenu;
                }

                while (true)
                {
                    if (updateState != UpdateState.Continue && updateState != UpdateState.GoToLoop)
                        break;
                    //TO DO additional game mechanics
                    
                    field.Render();
                    updateState = field.Update();
                }
               
                if (updateState == UpdateState.ExitMenu)
                    menuType = MenuType.Exit;

                else
                if (updateState == UpdateState.DifficultyMenu)
                    menuType = MenuType.Difficulty;

                else
                if (updateState == UpdateState.MainMenu)
                    menuType = MenuType.Main;

                else
                if (updateState == UpdateState.VictoryMenu)
                    menuType = MenuType.Victory;

                else
                if (updateState == UpdateState.Exit)
                    break;
            }
        }
    }
}
