using System;


namespace week5_2_exercize
{
    class Program
    {
        static void Main(string[] args)
        {
            _2DPoint p1 = new _2DPoint(3,4);
            _3DPoint p2 = new _3DPoint(6,2,8);

            _2DPoint p3 = new _2DPoint(3,4);

            Console.WriteLine("is p1 equals to p3 ? {0}", p1.Equals(p3));
            
            Console.WriteLine("p1 = {0}", p1);
            Console.WriteLine("p2 = {0}", p2);

        }
    }

    class _2DPoint : Object
    {
        public int x;
        public int y;

        public _2DPoint(int initialX, int initialY){
            this.x = initialX;
            this.y = initialY;
        }

        override 
        public string ToString(){
            string s = String.Format("({0}, {1})", x, y);
            return s;
        }
        
    }

    class _3DPoint : _2DPoint
    {
        public int z;

        public _3DPoint(int initialX, int initialY, int initialZ) : base(initialX, initialY)
        {
            
            this.z = initialZ;
        }

        override 
        public string ToString(){
            string s = String.Format("({0}, {1}, {2})", x, y, z);
            return s;
        }
    }
}
