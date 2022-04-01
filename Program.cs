using System;
using FiguresLR1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LR2
{
    class Program
    {
        static void Main(string[] args)
        {
            var figuresList = new List<BaseFigure>();
            while (true)
            {
                int choice = ChooseAction();

                if (choice == 0)  // Exit
                    break;
                else if (choice == 1) //Add
                {
                    int figureChoice = ChooseFigure();
                    performAdding(figureChoice, figuresList);
                }
                else if (choice == 2) //Delete
                {
                    DeleteFigureByID(figuresList);
                    Console.ReadLine();
                }
                else if (choice == 3) //Print
                {
                    printFigureByID(figuresList);
                    Console.ReadLine();
                }
                else if (choice == 4) //Change Coordinates
                {
                    changeFigureByID(figuresList);
                    Console.ReadLine();
                }
                else if (choice == 5) //Show figures
                {
                    PrintAllFigures(figuresList);
                    Console.ReadLine();
                }

            }
        }

        static int ChooseAction()
        {
           Console.Clear();
            Console.WriteLine("Choose an action: ");
            Console.WriteLine("1 - Add new figure"); 
            Console.WriteLine("2 - Delete figure by id"); 
            Console.WriteLine("3 - Print figure by id"); 
            Console.WriteLine("4 - Change coordinates of figure by id"); 
            Console.WriteLine("5 - Print all figures");
            Console.WriteLine("0 - Exit\n");
            Console.Write("=> ");

            return int.Parse(Console.ReadLine());
        }

        static int ChooseFigure()
        {
            Console.Clear();
            Console.WriteLine("Choose a figure: ");
            Console.WriteLine("1 - Ellipse");
            Console.WriteLine("2 - Circle");
            Console.WriteLine("3 - Quadrangle");
            Console.WriteLine("4 - Parallelogram");
            Console.WriteLine("5 - Rectangle");
            Console.WriteLine("6 - Rhombus");
            Console.WriteLine("7 - Triangle\n");
            Console.WriteLine("0 - Back\n");
            Console.Write("=> ");

            return int.Parse(Console.ReadLine());

        }

       static void performAdding(int id, List<BaseFigure> figuresList)
        {
            switch (id)
            {
                // Back
                case 0:
                    break;
                case 1:
                    BaseFigure figure = new Ellipse();
                    figure.changeAllCoordinatesConsole();
                    figuresList.Add(figure);
                    break;
                case 2:
                    figure = new Circle();
                    figure.changeAllCoordinatesConsole();
                    figuresList.Add(figure);
                    break;
                case 3:
                    figure = new Quadrangle();
                    figure.changeAllCoordinatesConsole();
                    figuresList.Add(figure);
                    break;
                case 4:
                    figure = new Parallelogram();
                    figure.changeAllCoordinatesConsole();
                    figuresList.Add(figure);
                    break;
                case 5:
                    figure = new Rectangle();
                    figure.changeAllCoordinatesConsole();
                    figuresList.Add(figure);
                    break;
                case 6:
                    figure = new Rhombus();
                    figure.changeAllCoordinatesConsole();
                    figuresList.Add(figure);
                    break;
                case 7:
                    figure = new Triangle();
                    figure.changeAllCoordinatesConsole();
                    figuresList.Add(figure);
                    break;
                default:
                    Console.WriteLine("Action does not exist. Please, type an existing one.");
                    Console.ReadLine();
                    break;
            }
        }
        static void PrintAllFigures(List<BaseFigure> figuresList)
        {
            Console.Clear();
            foreach (var figure in figuresList)
            {
                Console.Write($"{figure.ID}: ");
                figure.ShowFigure();
            }
        }

        static void DeleteFigureByID(List<BaseFigure> figuresList)
        {
            PrintAllFigures(figuresList);
            Console.Write("=> ");
            int id = int.Parse(Console.ReadLine());
            int index = 0;
            foreach (var figure in figuresList)
            {
                if (figure.ID == id)
                {
                    figuresList.RemoveAt(index);
                    Console.WriteLine("Figure was deleted successfully.");
                    return;
                }
                index++;
            }
            Console.WriteLine("Figure with that index does not exist.");
   
            return;
        }
        static void printFigureByID(List<BaseFigure> figuresList)
        {
            PrintAllFigures(figuresList);
            Console.Write("=> ");
            int id = int.Parse(Console.ReadLine());
            int index = 0;
            foreach (var figure in figuresList)
            {
                if (figure.ID == id)
                {
                    figuresList[index].ShowFigure();
                    return;
                }
                index++;
            }
            Console.WriteLine("Figure with that index does not exist.");

            return;
        }

        static void changeFigureByID(List<BaseFigure> figuresList)
        {
            PrintAllFigures(figuresList);
            Console.Write("=> ");
            int id = int.Parse(Console.ReadLine());
            int index = 0;
            foreach (var figure in figuresList)
            {
                if (figure.ID == id)
                {
                    figure.changeAllCoordinatesConsole();
                    return;
                }
                index++;
            }
            Console.WriteLine("Figure with that index does not exist.");

            return;
        }


    }
}
