// <copyright file="Triangle.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Ue3_209910
{
    /// <summary>
    /// Defines the abstract base class for triangle shapes.
    /// </summary>
    public abstract class Triangle : Shapes
    {
        private int height;

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> class.
        /// </summary>
        /// <param name="symbol">Represents the symbol for drawing the triangle.</param>
        /// <param name="foregroundColor">Represents the foregroundColor for the triangle.</param>
        /// <param name="backgroundColor">Represents the backgroundColor for the triangle.</param>
        /// <param name="origin">Represents the Coordinates (Starting point) of the triangle.</param>
        /// <param name="height">Represent the height of the triangle.</param>
        public Triangle(int height, char symbol, ConsoleColor foregroundColor, ConsoleColor backgroundColor, Coordinates origin)
            : base(symbol, foregroundColor, backgroundColor, origin)
        {
            this.Height = height;
        }

        /// <summary>
        /// Gets the height of the triangle.
        /// </summary>
        public int Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                this.height = value;
            }
        }
    }
}