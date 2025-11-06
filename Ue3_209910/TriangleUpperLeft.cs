// <copyright file="TriangleUpperLeft.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Ue3_209910
{
    /// <summary>
    /// Defines the triangle shape with the right angle at the upper left corner.
    /// </summary>
    public class TriangleUpperLeft : Triangle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TriangleUpperLeft"/> class.
        /// </summary>
        /// <param name="symbol">Represents the symbol for drawing the triangle.</param>
        /// <param name="foregroundColor">Represents the foregroundColor for the triangle.</param>
        /// <param name="backgroundColor">Represents the backgroundColor for the triangle.</param>
        /// <param name="originX">Represents the X Coordinate (Starting point) of the triangle.</param>
        /// <param name="originY">Represents the Y Coordinate (Starting point) of the triangle.</param>
        /// <param name="height">Represent the height of the triangle.</param>
        public TriangleUpperLeft(int height, char symbol, ConsoleColor foregroundColor, ConsoleColor backgroundColor, int originX, int originY)
            : base(height, symbol, foregroundColor, backgroundColor, originX, originY)
        {
        }

        /// <summary>
        /// This method renders the triangleUpperLeft to the console.
        /// </summary>
        public override void Render()
        {
            ShapeRenderer shapeRenderer = new ShapeRenderer();

            shapeRenderer.Draw(this);

            Console.ResetColor();
        }
    }
}