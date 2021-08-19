using System;

class MainClass {
  static void Main() 
  {
    Character hero = new Character("Héracles", 100, 20, 5);

    Character monster = new Character("Nemean Lion", 100, 20, 5);

    while (hero.lifePoint > 0 && monster.lifePoint > 0)
    {    
      Console.WriteLine(hero.name + " has " + hero.Attack(hero, monster) + " lifepoints since " + monster.name + " has attacked !\n\n" + monster.name + " has " + monster.Attack(monster, hero) + " lifepoints since " + hero.name + " counter-attacked !");

      if (hero.IsAlive() == true)
      {
        Console.WriteLine("\n" + hero.name + " is still alive !\n");
      }
      else
      {
        Console.WriteLine("\n" + monster.name + " has defeated " + hero.name + " !");
      }

      if (monster.IsAlive() == false)
      {
        Console.WriteLine("\n\n" + hero.name + " won the fight !");
      }
    }
  }
}
