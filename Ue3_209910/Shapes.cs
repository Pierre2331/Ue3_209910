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

        /// <summary>
        /// Initializes a new instance of the <see cref="Shapes"/> class.
        /// This is the constructor for the Shapes class.
        /// </summary>
        /// <param name="symbol">Represents the symbol for drawing a shape.</param>
        /// <param name="foregroundColor">Represents the foregroundColor for the shape.</param>
        /// <param name="backgroundColor">Represents the backgroundColor for the shape.</param>
        /// <param name="origin">Represents the Coordinates (Starting point) of a shape.</param>
        public Shapes(char symbol, ConsoleColor foregroundColor, ConsoleColor backgroundColor, Coordinates origin)
        {
            this.Symbol = symbol;
            this.ForegroundColor = foregroundColor;
            this.BackgroundColor = backgroundColor;
            this.Origin = origin;
        }

        /// <summary>
        /// Gets or sets the coordinates of a shape.
        /// </summary>
        public Coordinates Origin { get; protected set; }

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
        /// This is the abstract method for rendering different shapes.
        /// </summary>
        public abstract void Render();
    }
}