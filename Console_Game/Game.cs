using System;
namespace ConsoleGame
{
  class Game : SuperGame
  {
    public new static void UpdatePosition(string Key, out int X, out int Y)
    {
      // Sets X and Y variables to avoid errors
    X = 0;
    Y = 0;
      switch (Key) // Detects what key the user pressed through the switch and adjusts the Y and X axis accordingly
      {
        case "LeftArrow":
          X = -1;
          Y = 0;
          break;
        case "RightArrow":
          X = 1;
          Y = 0;
        break;
        case "DownArrow":
          X = 0;
          Y = 1;
        break;
        case "UpArrow":
          X = 0;
          Y = -1;
          break;
        case "A":
          X = -1;
          Y = 0;
          break;
        case "D":
          X = 1;
          Y = 0;
          break;
        case "S":
          X = 0;
          Y = 1;
          break;
        case "W":
          X = 0;
          Y = -1;
          break;
      }
    }
    public new static char UpdateCursor(string keyPressed)
    {
      // Sets direction variable to a placeholder variable to avoid no value error.
      char direction = 'o';
      switch (keyPressed)
      {
        case "DownArrow":
        direction = 'v';
        break;
        case "UpArrow":
        direction = '^';
        break;
        case "LeftArrow":
        direction = '<';
        break;
        case "RightArrow":
        direction = '>';
        break;
        case "A":
          direction = '<';
          break;
        case "D":
          direction = '>';
          break;
        case "S":
          direction = 'v';
          break;
        case "W":
          direction = '^';
          break;
      }
      return direction;
    }

    public new static int KeepInBounds(int dimension, int max)
    {
      if (dimension >= max)
      {
        return 0;
      } 
      else if (dimension < 0)
      {
        return max - 1;
      }
      else
      {
        return dimension;
      }
    }


    public new static bool DidScore(int charX, int charY, int FruitX, int FruitY)
    {
      if(charX == FruitX){ // Checks if the player is on the same X coordinate of the fruit
        if(charY == FruitY){ // Then checks if the player is on the same Y coordiante of the fruit
        return true;
        }
        else { // If x or y doesn't match the fruit, do not add score
          return false;
        }
      }
      else{
        return false;
      }
    }
  }
}
