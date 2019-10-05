using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class Recruter
    {
        static string heroNames = "hero_tank" + "hero_norm" + "hero_lucky";
        
        static Field field;
        static public WorkerBase RecrutWorker(ObjectsInfo objectsInfo) 
        {
            if (heroNames.IndexOf(objectsInfo.objectsType) != -1)
                return new WorkerHero(Properties.Get(objectsInfo.objectsType), field);
            
            else
                if (objectsInfo.objectsType == "princess")
                return new WorkerPrincess(Properties.Get(objectsInfo.objectsType), field);

            else
                if (objectsInfo.objectsType == "trap_jun")
                return new WorkerTrapJun(Properties.Get(objectsInfo.objectsType), field, objectsInfo.nCount);

            else
                if (objectsInfo.objectsType == "trap_mid")
                return new WorkerTrapMid(Properties.Get(objectsInfo.objectsType), field, objectsInfo.nCount);

            else
                if (objectsInfo.objectsType == "trap_sen")
                return new WorkerTrapSen(Properties.Get(objectsInfo.objectsType), field, objectsInfo.nCount);

            return null;
        } 

        public static void Init(Field field)
        {
            Recruter.field = field; 
        }
    }

    abstract class WorkerBase
    {
        protected Object propertie = null;
        protected int nCount = 0;
        protected Field field;
        public abstract Object Create();

        protected WorkerBase()
        {
            
        }
        protected WorkerBase(Object propertie, int nCount = 0)
        {
            this.propertie = propertie;
            this.nCount = nCount;
        }
        public int GetCount() { return nCount; }
    }
    class WorkerHero : WorkerBase
    {
        public override Object Create()
        {
            return new Hero(propertie, field);
        }

        public WorkerHero(Object propertie, Field field, int nCount = 0) : base(propertie, nCount)
        {
            this.field = field;
        }

    }
    class WorkerTrapJun : WorkerBase
    {
        public override Object Create()
        {
            return new TrapJun(propertie, field);
        }

        public WorkerTrapJun(Object propertie, Field field, int nCount = 0) : base(propertie, nCount)
        {
            this.field = field;
        }
    }
    class WorkerTrapMid : WorkerBase
    {
        public override Object Create()
        {
            return new TrapMid(propertie, field);
        }

        public WorkerTrapMid(Object propertie, Field field, int nCount = 0) : base(propertie, nCount)
        {
            this.field = field;
        }
    }
    class WorkerTrapSen : WorkerBase
    {
        public override Object Create()
        {
            return new TrapSen(propertie, field);
        }

        public WorkerTrapSen(Object propertie, Field field, int nCount = 0) : base(propertie, nCount)
        {
            this.field = field;
        }
    }
    class WorkerPrincess : WorkerBase
    {
        public override Object Create()
        {
            return new Princess(propertie, field);
        }

        public WorkerPrincess(Object propertie, Field field, int nCount = 0) : base(propertie, nCount)
        {
            this.field = field;
        }
    }
}
