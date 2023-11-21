using System.Collections;
using System.Drawing.Imaging;
using System.Drawing;
using System;
using System.Windows;


namespace mineswwep
{

  class Brain
  {
    
    public SortedList fslist = new();

    public Brain(string first_color)
    {


      Console.WriteLine("ne");
    }
    
  }


    


  class Program
  {

    
    // public SupportedOSPlatformAttribute (string platformName);
  
    static void Main(string[] args)

    {
      


      static Bitmap CaptureScreen()
    {
        // Create a bitmap object to hold the screenshot
        Bitmap screenshot = new(1920, 1080);

        // Create a graphics object from the bitmap
        using (Graphics g = Graphics.FromImage(screenshot))
        {
            // Copy the screen to the bitmap
            g.CopyFromScreen(0, 0, 0, 0, screenshot.Size);
        }

        return screenshot;
    }

    static Color GetPixelColor(Bitmap screenshot, int x, int y)
    {
        // Get the color of the specified pixel
        return screenshot.GetPixel(x, y);
    }
      Brain minesweeper_brain = new("*hexcode*");






    
      
      
      
    }
  }

}