// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Ue3_209910
{
    /// <summary>
    /// This is the main programm for the Ue3_209910 project.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// This is the main entry point of the application.
        /// </summary>
        private static void Main()
        {
            Console.SetWindowSize(200, 200);
            // Console.SetBufferSize(120, 40);
            Console.CursorVisible = false;
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=== Shape Renderer ===");
            Console.WriteLine("F1-F5: Bestimmte Figuren, F6: Zufällige Figur, ESC: Beenden");
            Console.ResetColor();

            // create and start inputHandler
            InputHandler inputHandler = new InputHandler();
            inputHandler.Run();

            // After ending
            Console.ResetColor();
            Console.Clear();
            Console.CursorVisible = true;
            Console.WriteLine("Programm beendet. Auf Wiedersehen!");
        }
    }
}
