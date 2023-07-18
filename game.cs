using System;
using Heroes;
using Levels;
using System.Collections.Generic;
using System.Diagnostics;

namespace Labyrinth;

public sealed class Game
{
  public void Start(){
    var hero = ChooseHero();
    var level = ChooseLevel();

    Play(hero, level);
  }

  public Hero ChooseHero()
  {
    Hero hero = null;

    Console.WriteLine(@"
    Choose your hero: 
    1. Arthur");

    do 
    {

    int.TryParse(Console.ReadKey().KeyChar.ToString().AsSpan(), out int choise);

    switch(choise)
    {
      case 1:
        hero = new Arthur();
        break;
      default:
        break;
    }

    } while(hero is null);

    return hero;
  }

  public Level ChooseLevel()
  {
    return new Level1();
  }

  public void Play(Hero hero, Level level)
  {
    var under = ' ';

    var map = level.GetMap();
    var character = hero.Character;

    var x = level.StartRow;
    var y = level.StartColumn;



    map[y][x] = character;

    int deltaX;
    int deltaY;
    char newUnder;

    Console.Clear();
    level.DisplayMap(map);
    Console.WriteLine();

    do{

      deltaX = 0;
      deltaY = 0;
      newUnder = under;
    
  
    var key = Console.ReadKey();

    switch(key.Key){
      case ConsoleKey.UpArrow:
        deltaY = -1;
        break;
      case ConsoleKey.DownArrow:
        deltaY = +1;
        break;
      case ConsoleKey.RightArrow:
        deltaX = +1;
        break;
      case ConsoleKey.LeftArrow:
        deltaX = -1;
        break;
      default:
        break;
    }

    newUnder = map[y + deltaY][x + deltaX];

    switch(newUnder)
    {
      case 'f':
      case ' ':
        map[y][x] = under;
        under = newUnder;
        map[y + deltaY][x + deltaX] = character;
        x = x + deltaX;
        y = y + deltaY;
        break;
      case '█':
      default:
        break;
    }


    
    Console.Clear();
    level.DisplayMap(map);
    Console.WriteLine();
    
    } while(under != 'f');
  }

}