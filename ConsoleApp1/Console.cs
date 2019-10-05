using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class GameConsoleString
	{
		public ConsoleColor color { get; set; } = ConsoleColor.White;
		public string msg { get; set; }
		public GameConsoleString(string msg, ConsoleColor color)
		{
			this.color = color;
			this.msg = msg;
		}

	}
    class GameConsole
    {
        List<GameConsoleString> log;
        int rows = 0;
        int col = 0;

        public GameConsole(int col)
        {
            log = new List<GameConsoleString>();
            this.col = col;
            rows = 20;
        }

        public void Render()
        {
			for (int i = 0; i < log.Count; i++)
			{
				Console.ForegroundColor = log[log.Count - i].color;
				Console.SetCursorPosition(col, rows - i);
				Console.WriteLine(log[log.Count - i].msg.PadRight(Console.BufferWidth - col), ' ');
			}
		}

        public void addMessage(GameConsoleString str)
        {
            log.Add(str);

            while(log.Count > rows)
                log.RemoveAt(0);

			Render();
		}
    }
}
