using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ConsoleApp1
{
    class Object
    {
        protected Field field;
        public string name { get; set; } = "";
        public int healthPoint { get; set; } = 0;
        public int armor { get; set; } = 0;
        public int accuracy { get; set; } = 0;
        public int dexterity { get; set; } = 0;
        public int attackPoint { get; set; } = 0;
        public bool kia {get; set; } = false;
        protected ConsoleColor color = ConsoleColor.Black;
        protected int timer = 0;
        protected int timerCountDownValue = 0;
        protected bool bIsBlincked = false;
        public bool bInAmbush { get; set; } = false;
        public Point position { get; set; } 
        public bool bIsExternalRender = true;
        public bool bIsExternalUpdate = true;
        public bool bIsVisible { get; set; } = false;

        public Object() { }
        
        public Object(Object obj, Field field)
        {
            this.field = field;
            name = obj.name;
            healthPoint = obj.healthPoint;
            armor = obj.armor;
            accuracy = obj.accuracy;
            dexterity = obj.dexterity;
            attackPoint = obj.attackPoint;
            bInAmbush = obj.bInAmbush;
        }
        public Object(string name, int healthPoint, int armor, int accuracy, int dexterity, int attackPoint, bool bInAmbush)
        {
        this.name = name;
        this.healthPoint = healthPoint;
        this.armor = armor;
        this.accuracy = accuracy;
        this.dexterity = dexterity;
        this.attackPoint = attackPoint;
        this.bInAmbush = bInAmbush;
        }
        public virtual Point Respawn(Point position) 
        {
            return position;
        }
        public virtual void Attack(Object otherSubject) { }
        public virtual void Update() { }
        public virtual void Render(Point position) { }
      }

    class Enemy : Object { }
   
    class TrapJun : Enemy
    {
        public bool bIsWorked { get; set; } = false;
        public TrapJun(Object subject, Field field)
        {
            color = ConsoleColor.Gray;
            this.field = field;
            timer = field.GetNextRandom(7);
            name = subject.name;
            healthPoint = subject.healthPoint;
            armor = subject.armor;
            accuracy = subject.accuracy;
            dexterity = subject.dexterity;
            attackPoint = subject.attackPoint;
            bInAmbush = subject.bInAmbush;
            bIsVisible = false;
        }

        public override Point Respawn(Point position)
        {
            return new Point(field.GetNextRandom(position.X), field.GetNextRandom(position.Y));
        }

        public override void Attack(Object otherSubject)
        {

        }

        public override void Update()
        {
            if (kia)
                color = ConsoleColor.DarkGray;
        }

        public override void Render(Point offset)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(offset.X + position.X, offset.Y + position.Y);
            Console.Write("T");
        }
    }

    class TrapMid : Enemy
    {
        public bool bIsWorked { get; set; } = false;
        public TrapMid(Object subject, Field field)
        {
            color = ConsoleColor.Gray;
            this.field = field;
            name = subject.name;
            healthPoint = subject.healthPoint;
            armor = subject.armor;
            accuracy = subject.accuracy;
            dexterity = subject.dexterity;
            attackPoint = subject.attackPoint;
            bInAmbush = subject.bInAmbush;
            bIsVisible = false;
        }
        public override Point Respawn(Point position)
        {
            return new Point(field.GetNextRandom(position.X), field.GetNextRandom(position.Y));
        }

        public override void Attack(Object otherSubject)
        {

        }
        public override void Update()
        {
            if (kia)
                color = ConsoleColor.DarkGray;
        }

        public override void Render(Point offset)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(offset.X + position.X, offset.Y + position.Y);
            Console.Write("T");
        }
    }

    class TrapSen : Enemy
    {
        public bool bIsWorked { get; set; } = false;
        public TrapSen(Object subject, Field field)
        {

            color = ConsoleColor.Gray;
            this.field = field;
            name = subject.name;
            healthPoint = subject.healthPoint;
            armor = subject.armor;
            accuracy = subject.accuracy;
            dexterity = subject.dexterity;
            attackPoint = subject.attackPoint;
            bInAmbush = subject.bInAmbush;
            bIsVisible = false;
        }
        public override Point Respawn(Point position)
        {
            return new Point(field.GetNextRandom(position.X), field.GetNextRandom(position.Y));
        }

        public override void Attack(Object otherSubject)
        {

        }
        public override void Update()
        {
            if (kia)
                color = ConsoleColor.DarkGray;
        }

        public override void Render(Point offset)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(offset.X + position.X, offset.Y + position.Y);
            Console.Write("T");
        }
    }

    class Ally : Object
    {

    }
    class Princess : Ally
    {
        public bool bIsFind { get; set; } = false;
        public Princess(Object subject, Field field)
        {
            if ((int)Def.PrincessBlink == 1)
                bIsBlincked = true;
                        
            color = ConsoleColor.Yellow;
            this.field = field;
            timerCountDownValue = 2;
            timer = field.GetNextRandom(2);
            name = subject.name;
            healthPoint = subject.healthPoint;
            armor = subject.armor;
            accuracy = subject.accuracy;
            dexterity = subject.dexterity;
            attackPoint = subject.attackPoint;
            bInAmbush = subject.bInAmbush;
            bIsVisible = true;
        }
        public override Point Respawn(Point position)
        {
            return new Point(field.GetNextRandom(2) * --position.X, field.GetNextRandom(2) * --position.Y);
        }
        public override void Attack(Object otherSubject) { }
        public override void Update()
        {
            if (bIsBlincked && timer > 0)
            {
                if (timer == 1)
                    color = ConsoleColor.Green;

                timer--; 
            }
            else
            {
                timer = timerCountDownValue;
                color = ConsoleColor.Yellow;
            }
        }

        public override void Render(Point offset)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(offset.X + position.X, offset.Y + position.Y);
            Console.Write("P");
        }
    }

    class Hero : Ally
    {
        

        public Hero(Object subject, Field field)
        {
            color = ConsoleColor.Cyan;
            this.field = field;
            name = subject.name;
            healthPoint = subject.healthPoint;
            armor = subject.armor;
            accuracy = subject.accuracy;
            dexterity = subject.dexterity;
            attackPoint = subject.attackPoint;
            bInAmbush = subject.bInAmbush;
            bIsVisible = true;
        }
        public override Point Respawn(Point position)
        {
            return new Point(field.GetNextRandom(2) * --position.X, field.GetNextRandom(2) * --position.Y);
        }

        public override void Attack(Object obj)
        {
            string rttiBase = obj.GetType().BaseType.Name.ToString();
            string rttiSelf = obj.GetType().Name.ToString();

            if (rttiBase == "Enemy")
            {
                obj.bIsVisible = true;
                obj.Render(field.startPosition);
                field.Battle(this, obj);
            }
            else if (rttiBase == "Ally")
            {
                //TO DO additional func be cont
                if (rttiSelf == "Princess")
                {
                    field.console.addMessage(new GameConsoleString("hero - Вот мы и встретились", ConsoleColor.Yellow));
                    Console.ReadKey();
                    Console.Clear();
                    field.RequestMenu(MenuType.Victory);
                }
            }
        }

        public override void Update()
        {
            ConsoleKey key = Console.ReadKey().Key;
            Point testPosition = new Point(position.X, position.Y);
            if (key == ConsoleKey.UpArrow && position.Y > 0)
                testPosition = new Point(position.X, position.Y - 1);

            else if (key == ConsoleKey.DownArrow && position.Y < field.size.Y - 1)
                testPosition = new Point(position.X, position.Y + 1);

            else if (key == ConsoleKey.LeftArrow && position.X > 0)
                testPosition = new Point(position.X - 1, position.Y);

            else if (key == ConsoleKey.RightArrow && position.X < field.size.X - 1)
                testPosition = new Point(position.X + 1, position.Y);
            else if (key == ConsoleKey.Escape)
                field.RequestMenu(MenuType.Exit);
            
            if (testPosition != position)
            {
                if (field.TestObjectFromCell(testPosition))
                {
                    Attack(field.GetObjectFromCell(testPosition));
                }

                field.TrakedCell(this);
                field.MoveToCell(this, testPosition);
            }
        }

        public override void Render(Point offset)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(offset.X + position.X, offset.Y + position.Y);
            Console.Write("H");
            Console.SetCursorPosition(field.startPosition.X, field.startPosition.Y + field.size.Y + 2);
            Console.WriteLine("HP - [{0}]   ", healthPoint);
        }
    }
}

