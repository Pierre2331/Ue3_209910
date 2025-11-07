// <copyright file="Coordinates.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Ue3_209910
{
    /// <summary>
    /// This class is used for get or sets the Coordinates of a shape.
    /// </summary>
    public class Coordinates
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinates"/> class.
        /// </summary>
        /// <param name="x">Represents the X coordinate.</param>
        /// <param name="y">Represents the Y coordinate.</param>
        public Coordinates(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Gets or Sets the property X.
        /// </summary>
        public int X
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or Sets the property Y.
        /// </summary>
        public int Y
        {
            get;
            set;
        }
    }
}