using System;
using System.Collections.Generic;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            _2DPoint p1 = new _2DPoint(3,4);
            _3DPoint p2 = new _3DPoint(6,2,8);

            Console.WriteLine("p1 = {0}", p1.ToString());
            Console.WriteLine("p2 = {0}", p2.ToString());

        }
    }


    public class _2DPoint
    {
        public int x;
        public int y;

        public _2DPoint(int initialX, int initialY){
            this.x = initialX;
            this.y = initialY;

        }
        public String ToString(){
            String s = String.Format("{0} , {1}", x, y);
            return s;
        }
    }
    public class _3DPoint : _2DPoint
    {
        public int z;
        public _3DPoint(int initialX, int initialY, int initialZ) : 
        base ( initialX, initialY){
            this.x = initialX;
            this.y = initialY;
            this.z = initialZ;
        }
    }
    
}