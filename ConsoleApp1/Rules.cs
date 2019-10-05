using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ConsoleApp1
{
    class ObjectsInfo
    {
        public string objectsType { get; set; }
        public int nCount { get; set; }

        public ObjectsInfo(string objectsType, int nCount)
        {
            this.objectsType = objectsType;
            this.nCount = nCount;
        }
    }
    class Rule
    {
        public Point fieldSize { get; }

        public List<ObjectsInfo> objectsInfo { get; set; }
        
        public Rule(Point fieldSize, int nTrapJun, int nTrapMid, int nTrapSen)
        {
            objectsInfo = new List<ObjectsInfo>();
            this.fieldSize = fieldSize;
            objectsInfo.Add(new ObjectsInfo("trap_jun", nTrapJun ));
            objectsInfo.Add(new ObjectsInfo("trap_mid", nTrapMid ));
            objectsInfo.Add(new ObjectsInfo("trap_sen", nTrapSen ));
            objectsInfo.Add(new ObjectsInfo("princess", 1 ));
            objectsInfo.Add(new ObjectsInfo("hero", 1 ));
        }
    }
    static class Rules
    {
        public static string currentRule { set;  get; }
        
        private static Dictionary<string, Rule> mapRules = new Dictionary<string, Rule>()
        {
            { "easy", new Rule(new Point(15, 10), 5, 5, 5)},
            { "norm", new Rule(new Point(30, 15), 10, 10, 10)},
            { "hard", new Rule(new Point(40, 20), 15, 15, 15)},
        };
        public static Rule GetTamplateRule()
        {
           return mapRules[currentRule];
        }

    }
}
