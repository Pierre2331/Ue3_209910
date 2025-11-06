// <copyright file="InputHandler.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Ue3_209910
{
    /// <summary>
    /// This class is responsible for handling user input to create shapes.
    /// </summary>
    public class InputHandler
    {
        private readonly ShapeFactory factory = new ShapeFactory();

        /// <summary>
        /// This methods is used for input handling in the console.
        /// </summary>
        public void Run()
        {
            bool running = true;

            while (running)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.Escape:
                        running = false;
                        break;

                    case ConsoleKey.F1:
                        this.HandleShape(this.factory.CreateRectangle());
                        break;

                    case ConsoleKey.F2:
                        this.HandleShape(this.factory.CreateTriangleUpperRight());
                        break;

                    case ConsoleKey.F3:
                        this.HandleShape(this.factory.CreateTriangleUpperLeft());
                        break;

                    case ConsoleKey.F4:
                        this.HandleShape(this.factory.CreateTriangleLowerLeft());
                        break;

                    case ConsoleKey.F5:
                        this.HandleShape(this.factory.CreateTriangleLowerRight());
                        break;

                    case ConsoleKey.F6:
                        this.HandleShape(this.factory.CreateRandomShape());
                        break;
                }
            }
        }

        private void HandleShape(Shapes shape)
        {
            shape.Render();
        }
    }
}