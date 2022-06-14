using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接水果
{
    public class Worker
    {
        public double posX=210, posY=560;
        public double speed = 2;
        public int w = 40, h=60;
    }
    public class Item
    {
        public static Random Random = new Random();
        public double PosX()
        {
            return Random.Next(0, 400);
        }
        public double PosY()
        {
            return Random.Next(0, 268);
        }
        public double posX = Random.Next((int)0, (int)400), posY = Random.Next((int)0, (int)268);
        public double speed = Random.NextDouble() + 1;
        public int w = 32, h = 32;
    }
}
