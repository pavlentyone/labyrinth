using System;

namespace Levels;

public sealed class Level1 : Level
{
  public char[][] map = 
    new char[][]{
      "█████████████████████████\n".ToCharArray(),
      "█s█          █     █    █\n".ToCharArray(),
      "█ █ ████   █ █ █████  █ █\n".ToCharArray(),
      "█ █    █   █ █ █      █ █\n".ToCharArray(),
      "█ ██████   █ █ ██ █████ █\n".ToCharArray(),
      "█          █ █    █     █\n".ToCharArray(),
      "████████████ ██████ █████\n".ToCharArray(),
      "█                       █\n".ToCharArray(),
      "█ █████████████████████ █\n".ToCharArray(),
      "█ █          ████     █ █\n".ToCharArray(),
      "█f█   ██████      ███   █\n".ToCharArray(),
      "█████████████████████████\n".ToCharArray(),
    };
  

  public override char[][] GetMap() => map;

  public override int StartRow => 1;
  public override int StartColumn => 1;

  
}