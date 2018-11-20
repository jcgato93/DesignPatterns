using System;
using System.Collections.Generic;
using Prototype.App.Shapes;

namespace Prototype.App
{
    class Program
    {
        static void Main(string[] args)
        {
           List<Shape> shapes = new List<Shape>();
           List<Shape> shapesCopy = new List<Shape>();

            Circle circle = new Circle(){
                x=10,
                y=20,
                radius=15
            };
            shapes.Add(circle);


            // Clone the first Circle and next add to the list
            Circle anotherCircle = (Circle) circle.clone();
            shapes.Add(anotherCircle);

            Rectangle rectangle = new Rectangle(){
                width=10,
                height=20                
            };
            shapes.Add(rectangle);

            // Clone and compare the lists
            cloneAndCompare(shapes,shapesCopy);
        }

        private static void cloneAndCompare(List<Shape> shapes, List<Shape> shapesCopy){
            
            foreach (var item in shapes)
            {
                shapesCopy.Add(item.clone());
            }

            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i] != shapesCopy[i])
                {
                    Console.WriteLine(i + ": Shapes are different objects, Good!");

                    if (shapes[i].Equals(shapesCopy[i]))
                    {
                        Console.WriteLine(i + ": And they are identical, Very good!!");
                    }
                    else
                    {
                        Console.WriteLine(i + ": But they are not identical, is bad :(");
                    }
                }else
                {
                    Console.Write(i + ": Shape objects are the same, so bad :(");
                }
            }
        }

    }
}
