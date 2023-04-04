using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

    }
    #region task1
    //Task1
    //class Player
    //{
    //    public string Health { get; set; }

    //    public string mana { get; set; }

    //    public int inventory { get; set; }


    //    public void Attack()
    //    {
    //        Console.WriteLine();
    //    }

    //    public void UseItem()
    //    {
    //        Console.WriteLine();
    //    }
    //}
    #endregion
    #region task2
    //task2
    //class Character
    //{       
    //    public string Name { get; set; }
    //    public string Health { get; set; }
    //    public int Level { get; set; }
    //    public int mana { get; set; }
    //    public int inventory { get; set; }

    //}

    //class Player:Character
    //{
    //    public void IsPlayer()
    //    {
    //        Console.WriteLine();
    //    }

    //}

    //class Enemy:Character
    //{
    //    public void IsEnemy()
    //    {
    //        Console.WriteLine();
    //    }
    //}
    #endregion
    #region task3
    //class Character 
    //{
    //    public string Name { get; set; }
    //    public int Health { get; set; }
    //    public int Level { get; set; }
    //    public int Mana { get; set; }
    //    public int inventory { get; set; }


    //    public Character(int intHealth, int intMana)
    //    {
    //        Health = intHealth;
    //        Mana = intMana;
    //    }


    //    static void Player()
    //    {
    //        Console.WriteLine();
    //    }
    //}

    #endregion
    #region tesk4
    //task4
    //class Player
    //{
    //    private string Name { get; set; }
    //    private TreasureChest Chest { get; set; }

    //    public Player(string name)
    //    {
    //        Name = name;
    //        Chest = new TreasureChest();
    //    }

    //    public void OpenChest() => Chest.Open();

    //    private class TreasureChest
    //    {
    //        public void Open() => Console.WriteLine();
    //    }
    //}

    #endregion
    #region task5
    //abstract class Creature
    //{
    //    public int Health;
    //    public int Mana;
    //    public int Energy;
    //    public int AttackDamage;


    //    public Creature(int health, int mana, int energy, int attackDamage)
    //    {
    //        Health = health;
    //        Mana = mana;
    //        Energy = energy;
    //        AttackDamage = attackDamage;
    //    }

    //    public abstract void Move();
    //    public abstract void Attack();
    //    public abstract void Defend();
    //    public abstract void Flee();

    //}


    #endregion
    #region task6
    //abstract class Creature
    //{
    //    public int Health;
    //    public int Mana;
    //    public int Energy;
    //    public int AttackDamage;


    //    public Creature(int health, int mana, int energy, int attackDamage)
    //    {
    //        Health = health;
    //        Mana = mana;
    //        Energy = energy;
    //        AttackDamage = attackDamage;
    //    }
    //}

    //class Gobline
    //{
    //    public void Move()
    //    {
    //        Console.WriteLine();
    //    }
    //    public void Attack()
    //    {
    //        Console.WriteLine();
    //    }
    //    public void Defent()
    //    {
    //        Console.WriteLine();
    //    }
    //    public void Flee()
    //    {
    //        Console.WriteLine();
    //    }


    //}


    #endregion
    #region task7
    //public class Oyuncu
    //{
    //    public object[] Inventar;

    //    public void Ekle(object num)
    //    {
    //        if (num.GetType() == typeof(Silah) || num.GetType() == typeof(Iksir))
    //        {
    //            if (Inventar == null)
    //            {
    //                Inventar = new object[1];
                    
    //            }
    //            else
    //            {
    //                object[] temp = new object[Inventar.Length + 1];
                   
    //            }
    //            Console.WriteLine("Yuklendi!");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Brat yuklenmir");
    //        }
    //    }
    //}

    //public class Silah
    //{

    //}
    //public class Iksir
    //{

    //}
    #endregion
}
