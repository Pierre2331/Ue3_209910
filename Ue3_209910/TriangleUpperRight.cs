// <copyright file="TriangleUpperRight.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Ue3_209910
{
    /// <summary>
    /// This class defines a triangle shape with the right angle at the upper right corner.
    /// </summary>
    public class TriangleUpperRight : Triangle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TriangleUpperRight"/> class.
        /// </summary>
        /// <param name="symbol">Represents the symbol for drawing the triangle.</param>
        /// <param name="foregroundColor">Represents the foregroundColor for the triangle.</param>
        /// <param name="backgroundColor">Represents the backgroundColor for the triangle.</param>
        /// <param name="originX">Represents the X Coordinate (Starting point) of the triangle.</param>
        /// <param name="originY">Represents the Y Coordinate (Starting point) of the triangle.</param>
        /// <param name="height">Represent the height of the triangle.</param>
        public TriangleUpperRight(int height, char symbol, ConsoleColor foregroundColor, ConsoleColor backgroundColor, Coordinates origin)
            : base(height, symbol, foregroundColor, backgroundColor, origin)
        {
        }

        /// <summary>
        /// This method renders the triangleUpperRight to the console.
        /// </summary>
        public override void Render()
        {
            ShapeRenderer shapeRenderer = new ShapeRenderer();

            shapeRenderer.Draw(this);

            Console.ResetColor();
        }
    }
}