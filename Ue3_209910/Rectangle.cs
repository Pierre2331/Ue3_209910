// <copyright file="Rectangle.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Ue3_209910
{
    /// <summary>
    /// Defines a rectangle shape with height and width properties.
    /// </summary>
    public class Rectangle : Shapes
    {
        private int height;
        private int width;

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="symbol">Represents the symbol for drawing the rectangle.</param>
        /// <param name="foregroundColor">Represents the foregroundColor for the rectangle.</param>
        /// <param name="backgroundColor">Represents the backgroundColor for the rectangle.</param>
        /// <param name="originX">Represents the X Coordinate (Starting point) of the rectangle.</param>
        /// <param name="originY">Represents the Y Coordinate (Starting point) of the rectangle.</param>
        /// <param name="height">Represent the height of the rectangle.</param>
        /// <param name="width">Represents the width of the rectangle.</param>
        public Rectangle(char symbol, ConsoleColor foregroundColor, ConsoleColor backgroundColor, int originX, int originY, int height, int width)
            : base(symbol, foregroundColor, backgroundColor, originX, originY)
        {
            this.Height = height;
            this.Width = width;
        }

        /// <summary>
        /// Gets the height of the rectangle.
        /// </summary>
        public int Height
        {
            get
            {
                return this.height;
            }

            protected set
            {
                this.height = value;
            }
        }

        /// <summary>
        /// Gets the width of the rectangle.
        /// </summary>
        public int Width
        {
            get
            {
                return this.width;
            }

            protected set
            {
                this.width = value;
            }
        }

        /// <summary>
        /// This method renders the rectangle to the console.
        /// </summary>
        public override void Render()
        {
            ShapeRenderer shapeRenderer = new ShapeRenderer();

            shapeRenderer.Draw(this);

            Console.ResetColor();
        }
    }
}