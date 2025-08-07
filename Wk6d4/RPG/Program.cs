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
        _name = name;
    }

    public string getName()
    {
        return _name;
    }

    public void pickUpItem(string item)
    {
        _inventory.Add(item);
    }

    public void dropItem(string item)
    {
        _inventory.Remove(item);
    }

    public List<string> getInventory()
    {
        return _inventory;
    }

    public void takeDamage(int damage)
    {
        _stats[0] -= damage;
    }

    public void heal(int health)
    {
        _stats[0] += health;
    }

    public int getHealth()
    {
        return _stats[0];
    }

    public int getMana()
    {
        return _stats[1];
    }

    public int getAttack()
    {
        return _stats[2];
    }
    
     public int getDefense()
    {
        return _stats[3];    
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

    }
}
