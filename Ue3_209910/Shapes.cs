// <copyright file="Shapes.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Ue3_209910
{
    /// <summary>
    /// This is the abstract base class for different shapes with the properties Symbol, ForegroundColor, BackgroundColor, OriginX, and OriginY.
    /// </summary>
    public abstract class Shapes
    {
        private char symbol;
        private ConsoleColor foregroundColor;
        private ConsoleColor backgroundColor;
        private int originX;
        private int originY;

        /// <summary>
        /// Initializes a new instance of the <see cref="Shapes"/> class.
        /// This is the constructor for the Shapes class.
        /// </summary>
        /// <param name="symbol">Represents the symbol for drawing a shape.</param>
        /// <param name="foregroundColor">Represents the foregroundColor for the shape.</param>
        /// <param name="backgroundColor">Represents the backgroundColor for the shape.</param>
        /// <param name="originX">Represents the X Coordinate (Starting point) of a shape.</param>
        /// <param name="originY">Represents the Y Coordinate (Starting point) of a shape.</param>
        public Shapes(char symbol, ConsoleColor foregroundColor, ConsoleColor backgroundColor, int originX, int originY)
        {
            this.Symbol = symbol;
            this.ForegroundColor = foregroundColor;
            this.BackgroundColor = backgroundColor;
            this.OriginX = originX;
            this.OriginY = originY;
        }

        /// <summary>
        /// Gets the symbol used to represent the shape.
        /// </summary>
        public char Symbol
        {
            get
            {
                return this.symbol;
            }

            protected set
            {
                if (value.ToString().Length != 1)
                {
                    throw new ArgumentException("Symbol must be a single character.");
                }

                this.symbol = value;
            }
        }

        /// <summary>
        /// Gets the foreground color of the shape.
        /// </summary>
        public ConsoleColor ForegroundColor
        {
            get
            {
                return this.foregroundColor;
            }

            protected set
            {
                this.foregroundColor = value;
            }
        }

        /// <summary>
        /// Gets the background color of the shape.
        /// </summary>
        public ConsoleColor BackgroundColor
        {
            get
            {
                return this.backgroundColor;
            }

            protected set
            {
                this.backgroundColor = value;
            }
        }

        /// <summary>
        /// Gets the X coordinate of the shape's origin.
        /// </summary>
        public int OriginX
        {
            get
            {
                return this.originX;
            }

            protected set
            {
                this.originX = value;
            }
        }

        /// <summary>
        /// Gets the Y coordinate of the shape's origin.
        /// </summary>
        public int OriginY
        {
            get
            {
                return this.originY;
            }

            protected set
            {
                this.originY = value;
            }
        }

        /// <summary>
        /// This is the abstract method for rendering different shapes.
        /// </summary>
        public abstract void Render();
    }
}