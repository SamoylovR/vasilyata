using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class Properties
    {
        private static Dictionary<string, Object> map = new Dictionary<string, Object>()
        {
            // id key               char name   HP  AR   AC   DX  AP  AMBUSH
            { "hero_tank",  new Object("tank", 150, 20,  40,  30,  75, false)},
            { "hero_norm",  new Object("norm", 100, 10,  60,  50,  50, false)},
            { "hero_lucky", new Object("luck",  50,  5,  80,  70,  30, false)},
            { "trap_jun",   new Object("jun",   10,  0, 100,  20,  30, true)},
            { "trap_mid",   new Object("mid",   30,  2, 100,  30,  30, true)},
            { "trap_sen",   new Object("sen",   50,  5, 100,  30,  30, true)},
            { "princess",   new Object("princ", 25,  0,  10, 100, 100, false)},
        };
                
        public static Object Get(string key)
        {
            if (map.Count == 0)
                return null;

            return map.ContainsKey(key) ? map[key] : null;
        }
    }
}
