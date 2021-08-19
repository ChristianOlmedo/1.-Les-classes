using System;

class Character {

  public string name;
  public int lifePoint;
  public int attack;
  public int defense;
  Random rd = new Random();

  public Character(string aName, int aLifePoint, int aAttack, int aDefense)
  {
    name = aName;
    lifePoint = aLifePoint;
    attack =  aAttack;
    defense = aDefense;
  }

  public bool IsAlive()
  {
    if (lifePoint > 0)
    {
      return true;
    }
    return false;
  }

  public int Attack(Character a, Character b)
  {
    if (a.lifePoint <= 0)
    {
      return a.lifePoint = 0;
    }
    else 
    {
      return a.lifePoint = (a.lifePoint) - (b.rd.Next(attack - 5,attack + 5) - a.defense);
    }
  }
}