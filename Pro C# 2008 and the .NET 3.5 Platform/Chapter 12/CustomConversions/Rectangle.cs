using System;
using System.Collections.Generic;
using System.Text;

namespace CustomConversions
{
  public struct Rectangle
  {
    // Public for ease of use; 
    // however, feel free to encapsulate with properties.  
    public int Width, Height;
    
    public Rectangle(int w, int h)
    {
      Width = w; Height = h;
    }
    public void Draw()
    {
      for (int i = 0; i < Height; i++)
      {
        for (int j = 0; j < Width; j++)
        {
          Console.Write("*");
        }
        Console.WriteLine();
      }
    }

    public override string ToString()
    {
      return string.Format("[Width = {0}; Height = {1}]",
        Width, Height);
    }

    public static implicit operator Rectangle(Square s)
    {
      Rectangle r;
      r.Height = s.Length;

      // Assume the length of the new Rectangle with 
      // (Length x 2)
      r.Width = s.Length * 2;
      return r;
    }
  }
}
