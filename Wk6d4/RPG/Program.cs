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


    // Name
    public void setName(string name)
    {
        _name = name;
    }

    public string getName()
    {
        return _name;
    }

    // Inventory
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

    // Health
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

    // Mana
    public void useMana(int mana)
    {
        _stats[1] -= mana;
    }

    public void gainMana(int mana)
    {
        _stats[1] += mana;
    }

    public int getMana()
    {
        return _stats[1];
    }

    // Attack
    public void upgradeAttack(int attack)
    {
        _stats[2] += attack;
    }

    public int getAttack()
    {
        return _stats[2];
    }

    // Defense
    public void upgradeDefense(int defense)
    {
        _stats[3] += defense;
    }
    
     public int getDefense()
    {
        return _stats[3];
    }
}

class Game
{
    // Private
    private Player _player;
    private int _turn;

    // Public
    public Game(Player player)
    {
        this._player = player;
    }

    public void run()
    {
        
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("====================\n WELCOME TO MY RPG!\n====================");
            Console.WriteLine("To begin, please enter your name:");

            string name = Console.ReadLine();

            Player player = new Player(name);
            Game game = new Game(player);

            game.run();
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"You must only enter a string!: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Uh oh! Something went wrong: {ex.Message}");
        }
    }
}
