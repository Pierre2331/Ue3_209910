// <copyright file="ShapeFactory.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Ue3_209910
{
    /// <summary>
    /// This class is responsible for creating shapes with random properties.
    /// </summary>
    public class ShapeFactory : ShapeHandler
    {
        private readonly Random random = new Random();

        /// <summary>
        /// This method creates and returns a rectangle with random properties.
        /// </summary>
        /// <returns>Rectangle.</returns>
        public Rectangle CreateRectangle()
        {
            int width = this.random.Next(3, 15);
            int height = this.random.Next(2, 10);
            int originX = this.random.Next(0, Math.Max(1, Console.WindowWidth - width));
            int originY = this.random.Next(0, Math.Max(1, Console.WindowHeight - height));

            char symbol = this.GetRandomChar();

            ConsoleColor foregroundColor = this.GetRandomColor();
            ConsoleColor backgroundColor = this.GetRandomColorDifferent(foregroundColor);

            return new Rectangle(symbol, foregroundColor, backgroundColor, originX, originY, height, width);
        }

        /// <summary>
        /// This method creates and returns a triangleUpperLeft with random properties.
        /// </summary>
        /// <returns>TriangleUpperLeft.</returns>
        public TriangleUpperLeft CreateTriangleUpperLeft()
        {
            int height = this.random.Next(2, 10);
            int originX = this.random.Next(0, Math.Max(1, Console.WindowWidth - height));
            int originY = this.random.Next(0, Math.Max(1, Console.WindowHeight - height));

            char symbol = this.GetRandomChar();

            ConsoleColor foregroundColor = this.GetRandomColor();
            ConsoleColor backgroundColor = this.GetRandomColorDifferent(foregroundColor);

            return new TriangleUpperLeft(height, symbol, foregroundColor, backgroundColor, originX, originY);
        }

        /// <summary>
        /// This method creates and returns a triangleUpperRight with random properties.
        /// </summary>
        /// <returns>TriangleUpperRight.</returns>
        public TriangleUpperRight CreateTriangleUpperRight()
        {
            int height = this.random.Next(2, 10);
            int originX = this.random.Next(0, Math.Max(1, Console.WindowWidth - height));
            int originY = this.random.Next(0, Math.Max(1, Console.WindowHeight - height));

            char symbol = this.GetRandomChar();

            ConsoleColor foregroundColor = this.GetRandomColor();
            ConsoleColor backgroundColor = this.GetRandomColorDifferent(foregroundColor);

            return new TriangleUpperRight(height, symbol, foregroundColor, backgroundColor, originX, originY);
        }

        /// <summary>
        /// This method creates and returns a triangleLowerLeft with random properties.
        /// </summary>
        /// <returns>TriangleLowerLeft.</returns>
        public TriangleLowerLeft CreateTriangleLowerLeft()
        {
            int height = this.random.Next(2, 10);
            int originX = this.random.Next(0, Math.Max(1, Console.WindowWidth - height));
            int originY = this.random.Next(0, Math.Max(1, Console.WindowHeight - height));

            char symbol = this.GetRandomChar();

            ConsoleColor foregroundColor = this.GetRandomColor();
            ConsoleColor backgroundColor = this.GetRandomColorDifferent(foregroundColor);

            return new TriangleLowerLeft(height, symbol, foregroundColor, backgroundColor, originX, originY);
        }

        /// <summary>
        /// This method creates and returns a triangleLowerRight with random properties.
        /// </summary>
        /// <returns>TriangleLowerRight.</returns>
        public TriangleLowerRight CreateTriangleLowerRight()
        {
            int height = this.random.Next(2, 10);
            int originX = this.random.Next(0, Math.Max(1, Console.WindowWidth - height));
            int originY = this.random.Next(0, Math.Max(1, Console.WindowHeight - height));

            char symbol = this.GetRandomChar();

            ConsoleColor foregroundColor = this.GetRandomColor();
            ConsoleColor backgroundColor = this.GetRandomColorDifferent(foregroundColor);

            return new TriangleLowerRight(height, symbol, foregroundColor, backgroundColor, originX, originY);
        }

        /*
        /// <summary>
        /// This method creates a random shape after pressing F6.
        /// </summary>
        /// <returns>A random shape.</returns>
        public Shapes CreateRandomShape()
        {
            int choice = this.random.Next(1, 6);

            switch (choice)
            {
                case 1:
                    return this.CreateRectangle();

                case 2:
                    return this.CreateTriangleLowerLeft();

                case 3:
                    return this.CreateTriangleLowerRight();

                case 4:
                    return this.CreateTriangleUpperLeft();

                case 5:
                    return this.CreateTriangleUpperRight();

                default:
                    return this.CreateRectangle();
            }
        }
        */

        /// <summary>
        /// This method creates a random shape after pressing the F6 button.
        /// </summary>
        /// <returns>A random shape.</returns>
        public Shapes CreateRandomShape()
        {
            var creators = new Func<Shapes>[]
            {
                this.CreateRectangle,
                this.CreateTriangleLowerLeft,
                this.CreateTriangleLowerRight,
                this.CreateTriangleUpperLeft,
                this.CreateTriangleUpperRight,
            };

            int index = this.random.Next(creators.Length);
            return creators[index]();
        }

        private char GetRandomChar()
        {
            const string chars = "*#@%$&~";
            return chars[this.random.Next(chars.Length)];
        }

        private ConsoleColor GetRandomColor()
        {
            return (ConsoleColor)this.random.Next(Enum.GetNames(typeof(ConsoleColor)).Length);
        }

        private ConsoleColor GetRandomColorDifferent(ConsoleColor foregroundColor)
        {
            ConsoleColor backgroundColor;
            do
            {
                backgroundColor = this.GetRandomColor();
            }
            while (backgroundColor == foregroundColor);
            return backgroundColor;
        }
    }
}