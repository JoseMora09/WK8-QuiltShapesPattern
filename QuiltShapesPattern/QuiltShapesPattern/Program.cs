using System;
using System.Collections.Generic;

namespace QuiltShapesPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool keepPlaying = true;
            string color;
            int side1;
            int side2;
            int side3;
            string player1;

            List<Shapes> shapeList = new List<Shapes>();

            while (keepPlaying)
            {

            Console.WriteLine("Lets Play Pick A Shape!");
            player1 = Console.ReadLine();

            Console.WriteLine("Choose a letter to the corresponding shape");
            Console.WriteLine("T - Triangle");
            Console.WriteLine("S - Square");
            Console.WriteLine("R - Rectangle");
            Console.WriteLine("L - List shapes");
            Console.WriteLine("E - Exit");
            player1 = Console.ReadLine();

                switch (player1)
                {
                    case "T":
                        Console.WriteLine("You chose Triangle");
                        Console.WriteLine("Pick whatever color your heart desires");
                        color= Console.ReadLine();
                        Console.WriteLine("Enter side 1 lenght");
                        side1 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Enter side 2 lenght");
                        side2 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Enter side 3 lenght");
                        side3 = Int32.Parse(Console.ReadLine());
                        Triangle Tri = new Triangle(color, side1, side2, side3);
                        Console.WriteLine("Thank you for playing");
                        shapeList.Add(Tri);
                        Tri.ShapesArea();
                        break;

                    case "R":
                        Console.WriteLine("You chose Rectangle");
                        Console.WriteLine("Pick whatever color your heart desires");
                        color = Console.ReadLine();
                        Console.WriteLine("Enter side 1 lenght");
                        side1 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Enter side 2 lenght");
                        side2 = Int32.Parse(Console.ReadLine());
                        Rectangle Rec = new Rectangle(color, side1, side2);
                        Console.WriteLine("Thank you for playing");
                        shapeList.Add(Rec);
                        Rec.ShapesArea();
                        break;

                    case "S":
                        Console.WriteLine("You chose Square");
                        Console.WriteLine("Pick whatever color your heart desires");
                        color = Console.ReadLine();
                        Console.WriteLine("Enter side 1 lenght");
                        side1 = Int32.Parse(Console.ReadLine());
                        Square Sq = new Square(color, side1);
                        Console.WriteLine("Thank you for playing");
                        shapeList.Add(Sq);
                        Sq.ShapesArea();
                        break;

                    case "L":
                        Console.WriteLine("Shapes you have selected -");
                        foreach (var shapes in shapeList)
                        {
                            Console.WriteLine($"{shapes.Color} {shapes.Name} with area {shapes.ShapesArea()}. ");
                            
                        }
                        break;

                    case "E":
                        Console.WriteLine("Closing");
                        keepPlaying = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;

                    
                }

            

            }


        }
    }
}
