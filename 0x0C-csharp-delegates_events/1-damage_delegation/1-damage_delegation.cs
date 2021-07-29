using System;

class Player
{
    private string name;
    private float maxHP;
    public float hp;

    public Player(string name = "Player", float maxHP = 100f)
    {
        if (maxHP <= 0)
        {
                maxHP = 100f;
                Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
        {
            this.maxHP = maxHP;
        }
        this.name = name;
        this.hp = this.maxHP;
    }

    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHP} health");
    }
    public delegate void CalculateHealth(float h);
    	public void TakeDamage(float damage)
	{
		if (damage > 0)
		{
			Console.WriteLine($"{this.name} takes {damage} damage!");
			this.hp -= damage;
		}
		else
		{
			Console.WriteLine($"{this.name} takes 0 damage!");
		}

	}
	public void HealDamage(float heal)
	{
		if (heal > 0)
		{
			Console.WriteLine($"{this.name} heals {heal} HP!");
			this.hp += heal;
		}
		else
		{
			Console.WriteLine($"{this.name} heals 0 HP!");
		}

    }
}