using System;

///<summary>Modifiers for nokenmon</summary>
public enum Modifier
{
	///<summary>it be weak</summary>
	Weak,
	///<summary>it be BASED</summary>
	Base,
	///<summary>it strong like man who fights bear in wood</summary>
	Strong
}
///<summary> it calculate modifiers</summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

class Player
{
    private string name;
    private float maxHp;
    public float hp;

    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0)
        {
                maxHp = 100f;
                Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
        {
            this.maxHp = maxHp;
        }
        this.name = name;
        this.hp = this.maxHp;
    }

    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }
	public delegate void CalculateHealth(float h);
    public void TakeDamage(float damage)
	{
        float temph = this.hp;
		if (damage > 0)
		{
			Console.WriteLine($"{this.name} takes {damage} damage!");
			temph -= damage;
		}
		else
		{
			Console.WriteLine($"{this.name} takes 0 damage!");
		}
        ValidateHP(temph);
	}
	public void HealDamage(float heal)
	{
        float temph = this.hp;
		if (heal > 0)
		{
			Console.WriteLine($"{this.name} heals {heal} HP!");
			temph += heal;
		}
		else
		{
			Console.WriteLine($"{this.name} heals 0 HP!");
		}
        ValidateHP(temph);
    }
    public void ValidateHP(float newHp)
	{
		if (newHp < 0)
		{
			this.hp = 0;
		}
		else if (newHp > this.maxHp)
		{
			this.hp = this.maxHp;
		}
		else
		{
			this.hp = newHp;
		}
    }
		public float ApplyModifier(float baseValue, Modifier modifier)
	{
		if (modifier == Modifier.Weak)
		{
			return (baseValue / 2);
		}
		else if (modifier == Modifier.Base)
		{
			return (baseValue);
		}
		else
		{
			return (baseValue * 1.5f);
		}
	}
}