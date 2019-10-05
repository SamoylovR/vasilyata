using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ConsoleApp1
{
    class Cell
    {
        private Object obj = null;
        bool bIsFog = false;
        bool bIsVisited = false;
        
        public Object GetObject() { return obj; }
        public void SetObject(Object obj) { this.obj = obj; }

        public void MoveObject(Cell cell)
        {
            cell.SetObject(obj);
            obj = null;
        }


        public void SetFog(bool Val) { bIsFog = Val; }
        public bool IsFog() { return bIsFog; }
        public void setTracked(bool Val) { bIsVisited = Val; }
        public bool IsTracked() { return bIsVisited; }
    }

    class Field
    {
        private UpdateState state = UpdateState.None;
        private bool bIsHotTrack = false;
        private List<Cell> hotTrack = new List<Cell>();

        private Cell[,] field;

        private List<Object> subjectList = new List<Object>();
        public Point startPosition { get; set; }

        public GameConsole console { get; } = null;

        public Point size {get; set;}
        
        private int frame = 0;

        private Random random = new Random();

        public int GetNextRandom(int range)
        {
            return random.Next(range);
        }

        public Field(Point size) : this(size.X, size.Y)
        {
           
        }
        public Field(int x = (int)FieldSize.width, int y = (int)FieldSize.height)
        {
            if (Def.MaxHotTrack > 0 && (int)Def.MaxHotTrack < 50)
                bIsHotTrack = true;

            startPosition = new Point((int)Def.FieldStartX, (int)Def.FieldStartY);
			size = new Point(x, y);

			console = new GameConsole(startPosition.X + size.X + 2);

			field = new Cell[x, y];
            
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                    field[i, j] = new Cell();
        }

        public Object GetObjectFromCell(Point position)
        {
            //TO DO proverka
            return field[position.X, position.Y].GetObject();
        }
        public Object GetObjectFromCell(int x, int y)
        {
            return GetObjectFromCell(new Point(x, y));
        }

        public bool TestObjectFromCell(Point position)
        {
            //TO DO proverka
            return field[position.X, position.Y].GetObject() != null;
        }
        public bool TestObjectFromCell(int x, int y)
        {
            return TestObjectFromCell(new Point(x, y));
        }

        public void MoveToCell(Object obj, Point position)
        {
            field[obj.position.X, obj.position.Y].MoveObject(field[position.X, position.Y]);
            obj.position = position;
        }
        public void MoveToCell(Object obj, int x, int y)
        {
            MoveToCell(obj, new Point(x, y));
        }
        public void AddObject(Object objectChar)
        {
            subjectList.Add(objectChar);
            Point position;

            while (true)
            {
                position = objectChar.Respawn(size);

                if(field[position.X, position.Y].GetObject() == null)
                {
                    objectChar.position = position;
                    field[position.X, position.Y].SetObject(objectChar);
                    break;
                }
            }
        }

        public void GiveMeObject(WorkerBase worker)
        {
            int nCount = worker.GetCount();
            do
            {
                AddObject(worker.Create());
                nCount--;
            }
            while (nCount > 0);
        }

        public UpdateState Update()
        {
            state = UpdateState.Continue;
            foreach (var i in subjectList)
                if (i.bIsExternalUpdate)
                    i.Update();

            subjectList.RemoveAll((Object obj) => { return obj.kia; });

            return state;
        }
        public void Render()
        {
            Console.Clear();

			RenderField(startPosition);

			foreach (var i in subjectList)
                if(i.bIsExternalRender && i.bIsVisible)
                    i.Render(startPosition);

			console.Render();

			int enemyLeft = 0;
			subjectList.ForEach((Object obj) => {

				if (obj.GetType().BaseType.Name.ToString() == "Enemy")
					enemyLeft++;
			});
// 			Console.ForegroundColor = ConsoleColor.Green;
// 			Console.SetCursorPosition(10, 0);
//             Console.WriteLine("Enemy left - {0}", enemyLeft);
        }
        void RenderField(Point position)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            string str = "";
            str = str.PadRight(size.X + 2, '#');
            Console.SetCursorPosition(position.X - 1, position.Y - 1);
            Console.WriteLine(str);

            for (int i = 0; i < size.Y; i++)
            {
                string strCont = "#";
                for (int j = 0; j < size.X; j++)
                    if (field[j, i].IsTracked())
                        strCont += '.';

                    else
                        strCont += ' ';

                strCont = strCont.PadRight(size.X + 2, '#');
            
                Console.SetCursorPosition(position.X - 1, position.Y + i);
                Console.WriteLine(strCont);
            }

            Console.SetCursorPosition(position.X - 1, position.Y + size.Y);
            Console.WriteLine(str);
        }

        void RenderObjectParams(Point position, Object obj)
        {
            Console.SetCursorPosition(position.X + size.X, 1);
            Console.WriteLine("HP - [{0}]   ", obj.healthPoint);
            
        }

        public void Clear()
        {

        }

        public void RequestMenu(MenuType menu)
        {
            switch(menu)
            {
                case MenuType.Difficulty:
                    state = UpdateState.DifficultyMenu;
                    break;

                case MenuType.Main:
                    state = UpdateState.MainMenu;
                    break;

                case MenuType.Exit:
                    state = UpdateState.ExitMenu;
                    break;

                case MenuType.Victory:
                    state = UpdateState.VictoryMenu;
                    break;
            }
        }

        public void TrakedCell(Object obj)
        {
            field[obj.position.X, obj.position.Y].setTracked(true);

            if (bIsHotTrack)
            {
                hotTrack.Add(field[obj.position.X, obj.position.Y]);

                if (hotTrack.Count >= (int)Def.MaxHotTrack)
                {
                    hotTrack[0].setTracked(false);
                    hotTrack.RemoveAt(0);
                }
            }
        }

        int Chance(int value)
        {
            return random.Next(100) <= value ? 1 : 0;
        }

        public void Battle(Object attacker, Object defender)
        {
            bool bIsPass = (attacker.dexterity + (attacker.bInAmbush ? (int)Def.AmbassDexAdd : 0)) < 
                                        (defender.dexterity + (defender.bInAmbush ? (int)Def.AmbassDexAdd : 0));
            bool bIsBattle = true;
            bool bIsWinner = false;

            int chanceToHitAttacker = 100 - defender.dexterity;
            int chanceToHitDefender = 100 - attacker.dexterity;
			int attHits = 0;
			int defHits = 0;
            do
            {
                if (!bIsPass)
                {
					if (attacker.healthPoint > 0)
					{
						attHits = (attacker.attackPoint - defender.armor) * Chance(chanceToHitAttacker);
						defender.healthPoint -= attHits;
					}
					else
					{
						bIsBattle = false;
						attacker.kia = true;
						RenderObjectParams(startPosition, attacker);
					}
                }
				
				console.addMessage(new GameConsoleString("hero transmit " + attHits.ToString() + " damage to enemy", ConsoleColor.Green));
				Console.SetCursorPosition(0, 0);
				Console.ReadKey();

				if (defender.healthPoint > 0)
				{
					defHits = (defender.attackPoint - attacker.armor) * Chance(chanceToHitDefender);
					attacker.healthPoint -= defHits;
				}

				else
				{
					bIsBattle = false;
					defender.kia = true;
					bIsWinner = true;
				}

                bIsPass = false;

				console.addMessage(new GameConsoleString("enemy transmit " + defHits.ToString() + " damage to hero", ConsoleColor.Red));
				Console.SetCursorPosition(0, 0);
				Console.ReadKey();

            }
            while (bIsBattle);

			if (!bIsWinner)
			{
				console.addMessage(new GameConsoleString("hero win", ConsoleColor.Green));
				RequestMenu(MenuType.Difficulty);
			}

        }
    }
}
