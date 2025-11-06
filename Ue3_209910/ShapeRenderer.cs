// <copyright file="ShapeRenderer.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Ue3_209910
{
    /// <summary>
    /// This class is responsible for rendering different shapes to the console.
    /// </summary>
    public class ShapeRenderer : ShapeHandler
    {
        /// <summary>
        /// This method draws a rectangle shape to the console.
        /// </summary>
        /// <param name="rectangle">Represents the Shape rectangle to draw it on the console.</param>
        public void Draw(Rectangle rectangle)
        {
            for (int row = 0; row < rectangle.Height; row++)
            {
                Console.SetCursorPosition(rectangle.OriginX, rectangle.OriginY + row);
                for (int col = 0; col < rectangle.Width; col++)
                {
                    Console.ForegroundColor = rectangle.ForegroundColor;
                    Console.BackgroundColor = rectangle.BackgroundColor;
                    Console.Write(rectangle.Symbol);
                }
            }
        }

        /// <summary>
        /// This method draws a triangle shape with the right angle at the upper left corner to the console.
        /// </summary>
        /// <param name="triangleUpperLeft">Represents the triangleUpperLeft shape.</param>
        public void Draw(TriangleUpperLeft triangleUpperLeft)
        {
            for (int row = 0; row < triangleUpperLeft.Height; row++)
            {
                Console.SetCursorPosition(triangleUpperLeft.OriginX, triangleUpperLeft.OriginY + row);
                for (int col = 0; col <= row; col++)
                {
                    Console.ForegroundColor = triangleUpperLeft.ForegroundColor;
                    Console.BackgroundColor = triangleUpperLeft.BackgroundColor;
                    Console.Write(triangleUpperLeft.Symbol);
                }
            }
        }

        /// <summary>
        /// This method draws a triangle shape with the right angle at the upper right corner to the console.
        /// </summary>
        /// <param name="triangleUpperRight">Represents the triangleUpperRight shape.</param>
        public void Draw(TriangleUpperRight triangleUpperRight)
        {
            for (int row = 0; row < triangleUpperRight.Height; row++)
            {
                Console.SetCursorPosition(triangleUpperRight.OriginX + triangleUpperRight.Height - row, triangleUpperRight.OriginY + row);
                for (int col = 0; col <= row; col++)
                {
                    Console.ForegroundColor = triangleUpperRight.ForegroundColor;
                    Console.BackgroundColor = triangleUpperRight.BackgroundColor;
                    Console.Write(triangleUpperRight.Symbol);
                }
            }
        }

        /// <summary>
        /// This method draws a triangle shape with the right angle at the lower right corner to the console.
        /// </summary>
        /// <param name="triangleLowerRight">Represents the triangleLowerRight shape.</param>
        public void Draw(TriangleLowerRight triangleLowerRight)
        {
            for (int row = 0; row < triangleLowerRight.Height; row++)
            {
                Console.SetCursorPosition(triangleLowerRight.OriginX + row, triangleLowerRight.OriginY + row);
                for (int col = 0; col < triangleLowerRight.Height - row; col++)
                {
                    Console.ForegroundColor = triangleLowerRight.ForegroundColor;
                    Console.BackgroundColor = triangleLowerRight.BackgroundColor;
                    Console.Write(triangleLowerRight.Symbol);
                }
            }
        }

        /// <summary>
        /// This method draws a triangle shape with the right angle at the lower left corner to the console.
        /// </summary>
        /// <param name="triangleLowerLeft">Represents the triangleLowerLeft shape.</param>
        public void Draw(TriangleLowerLeft triangleLowerLeft)
        {
            for (int row = 0; row < triangleLowerLeft.Height; row++)
            {
                Console.SetCursorPosition(triangleLowerLeft.OriginX, triangleLowerLeft.OriginY + row);
                for (int col = 0; col < triangleLowerLeft.Height - row; col++)
                {
                    Console.ForegroundColor = triangleLowerLeft.ForegroundColor;
                    Console.BackgroundColor = triangleLowerLeft.BackgroundColor;
                    Console.Write(triangleLowerLeft.Symbol);
                }
            }
        }

        /// <summary>
        /// This method draws all shapes to the console.
        /// </summary>
        public void DrawRandom()
        {
            throw new System.NotImplementedException();
        }
    }
}