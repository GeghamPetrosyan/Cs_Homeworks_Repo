﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometry;
using Graphics;

namespace Project_Run_Point

{
    internal class Grafics
    {
       public static void Main()
        { 
            Point point_1_obj = new Point { X=0,Y=0};
            Point point_2_obj = new Point { X = 55, Y = 50 };
            Line line_obj=new Line(point_1_obj,point_2_obj);  
            
           // ConsoleColor consoleColor_obj=new ConsoleColor();

            ColoredLine obj=new ColoredLine(line_obj,(ConsoleColor)11);
            obj.DrawLine();
           
Console.Read();

        }
    }
}
