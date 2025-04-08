using Builder;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var director = new CharacterDirector();

        var hero = director.CreateHero(new HeroBuilder());
        var enemy = director.CreateEnemy(new EnemyBuilder());

        Console.WriteLine("Hero:");
        hero.Print();

        Console.WriteLine("Enemy:");
        enemy.Print();
    }
}
