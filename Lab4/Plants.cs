using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Plants
    {
        public int height = 9;
        

        
    }

    public enum FlowerType { Садовые, Лесные, Полевые }
    public enum FlowerColour { Синий, Розовый, Красный, Оранжевый, Белый }
    public class Flowers : Plants
    {
        public int petalCount = 0;
        public FlowerColour colour = FlowerColour.Синий;
        public FlowerType type = FlowerType.Полевые;

       
        
        
    }

    public class Bush : Plants
    {
        public bool withFlower = true;
        public int branchCount = 0;

       
        
    }

    public enum TreeType { Хвойное, Листовые }
    public class Tree : Plants
    {
        public int radius = 0;
        public TreeType type = TreeType.Листовые;

       
        
    }
}