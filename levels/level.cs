using System;

namespace Levels;

public abstract class Level
{
  public abstract char[][] GetMap();

  public abstract int StartRow { get; }
  public abstract int StartColumn { get; }

  public void DisplayMap(char[][] map){
    for(var y = 0; y < map.Length; y++)
      for(var x = 0; x < map[y].Length; x++)
        Console.Write(map[y][x]);
  }
}