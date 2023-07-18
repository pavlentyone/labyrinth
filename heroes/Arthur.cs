using System;

namespace Heroes;

public sealed class Arthur : Hero
{
  public override int LightPower => 3;
  public override int Lives => 3;
  public override char Character => '&';
}