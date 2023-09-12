using System;
using System.Drawing;   

class ColorDetectionProgram
{
    static void Main()
    {
        Point position = new Point(100, 100); // Position to check color
        Bitmap screenshot = CaptureScreen(); // Capture the screen as a Bitmap
        
        Color color = GetColorAtPosition(screenshot, position); // Get color at the specified position
        Console.WriteLine($"Color at position ({position.X}, {position.Y}): {color}");

        screenshot.Dispose(); // Dispose of the captured screenshot
    }

    static Bitmap CaptureScreen()
    {
        // Capture the screen and return it as a Bitmap
        Rectangle screenBounds = Screen.PrimaryScreen.Bounds;
        Bitmap screenshot = new Bitmap(screenBounds.Width, screenBounds.Height);

        using (Graphics graphics = Graphics.FromImage(screenshot))
        {
            graphics.CopyFromScreen(screenBounds.Location, Point.Empty, screenBounds.Size);
        }

        return screenshot;
    }

    static Color GetColorAtPosition(Bitmap bitmap, Point position)
    {
        if (position.X >= 0 && position.X < bitmap.Width && position.Y >= 0 && position.Y < bitmap.Height)
        {
            // Get the color of the pixel at the specified position
            return bitmap.GetPixel(position.X, position.Y);
        }
        else
        {
            return Color.Black; // Default color if position is outside bounds
        }
    }
}
