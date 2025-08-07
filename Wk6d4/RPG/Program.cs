namespace RPG;

class Player
{
    // Private 
    private List<string> _items;
    private int[] _stats;
    private string _name;

    // Public
    public Player(string name)
    {
        this._items = new List<string>();
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
        this._items.Add(item);
    }

    public void takeDamage(int damage)
    {
        this._stats[0] -= damage;
    }

    public void heal(int health)
    {
        this._stats[0] += health;
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
        Console.WriteLine("Hello, World!");
    }
}
