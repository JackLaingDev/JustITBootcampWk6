namespace RPG;

class Player
{
    // Private 
    private List<string> _inventory;
    private int[] _stats;
    private string _name;

    // Public
    public Player(string name)
    {
        this._inventory = new List<string>();
        this._stats = new int[4];
        this._name = name;

        this._stats[0] = 100;                         // Health
        this._stats[1] = 100;                         // Mana
        this._stats[2] = 12;                          // Attack
        this._stats[3] = 17;                          // Defense
    }


    // Getters and Setters
    public void setName(string name)
    {
        this._name = name;
    }

    public string getName()
    {
        return _name;
    }

    public void pickUpItem(string item)
    {
        this._inventory.Add(item);
    }

    public void takeDamage(int damage)
    {
        this._stats[0] -= damage;
    }

    public void heal(int health)
    {
        this._stats[0] += health;
    }

    public int getHealth()
    {
        return this._stats[0];
    }

    public int getMana()
    {
        return this._stats[1];
    }

    public int getAttack()
    {
        return this._stats[2];
    }
    
     public int getDefense()
    {
        return this._stats[3];    
    }
}

class Game
{
    // Private
    private Player player;
    private int turn;

    // Public
    public Game()
    {
        
    }
}

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Jack");
        Console.WriteLine(player.getHealth());
    }
}
