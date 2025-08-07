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
    private string[] _menuOptions;
    private bool _isRunning = false;

    // Public
    public Game(Player player)
    {
        this._player = player;
        this._menuOptions = new string[] { "Open Inventory", "Use an Item", "View Stats", "Fight", "Exit" };
    }

    public void run()
    {
        _isRunning = true;
        Console.WriteLine("To navigate menus, enter the number of your desired option!");
        while (_isRunning)
        {
            displayHUD();
        }
    }

    public void displayHUD()
    {
        Console.WriteLine("========HUD========");
        for (int i = 0; i < _menuOptions.Count(); i++)
        {
            Console.WriteLine($"{i + 1}. {_menuOptions[i]}");
        }
        hudInput();
    }

    public void exit()
    {
        _isRunning = false;
        Console.WriteLine("You are now exiting the game, goodbye!");
    }

    public void viewStats()
    {
        Console.WriteLine("=======STATS=======");
        Console.WriteLine($"Health: {_player.getHealth()}");
        Console.WriteLine($"Mana: {_player.getMana()}");
        Console.WriteLine($"Attack: {_player.getAttack()}");
        Console.WriteLine($"Defense: {_player.getDefense()}");
    }

    public void openInventory()
    {
        Console.WriteLine("=====INVENTORY=====");
        List<string> inventory = _player.getInventory();
        if (inventory.Count() == 0)
        {
            Console.WriteLine("You have no Items in your inventory");
        }
        else
        {
            for (int i = 0; i < _menuOptions.Count(); i++)
            {
                Console.WriteLine($"{i + 1}. {inventory[i]}");
            } 
        }

    }

    public void hudInput()
    {
        try
        {
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Open Inventory
                    openInventory();
                    break;
                case 2:
                    // Use an Item
                    break;
                case 3:
                    // View stats
                    viewStats();
                    break;
                case 4:
                    // Fight
                    break;
                case 5:
                    // Exit
                    exit();
                    break;

            }
        }
        catch(FormatException ex)
        {
            Console.WriteLine($"Please only enter a number to choose your option!: {ex.Message}");
        }
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
