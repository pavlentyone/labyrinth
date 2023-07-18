using System;

namespace Heroes;

public abstract class Hero
{
  public abstract int LightPower { get; }
  public abstract int Lives { get; }
  public abstract char Character { get; }
}