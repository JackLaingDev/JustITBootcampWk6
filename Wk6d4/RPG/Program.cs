namespace RPG;

class Player
{
    // Private 
    private List<Item> _inventory;
    private int[] _stats;
    private string _name;

    // Public
    public Player(string name)
    {
        this._inventory = new List<Item>();
        this._stats = new int[4];
        this._name = name;

        this._stats[0] = 100;                         // Health
        this._stats[1] = 100;                         // Mana
        this._stats[2] = 14;                          // Attack
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
    public void pickUpItem(Item item)
    {
        _inventory.Add(item);
    }

    public void dropItem(Item item)
    {
        _inventory.Remove(item);
    }

    public List<Item> getInventory()
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

    public void upgradeMana(int mana)
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

    public bool hasDied()
    {
        if (_stats[0] < 0)
        {
            return true;
        }
        return false;
    }
}

class Enemy
{

    private List<string> _inventory;
    private int[] _stats;
    private string _name;

    // Public
    public Enemy(string name, int health, int mana, int attack, int defense)
    {
        this._inventory = new List<string>();
        this._stats = new int[4];
        this._name = name;

        this._stats[0] = health;                           // Health
        this._stats[1] = mana;                             // Mana
        this._stats[2] = attack;                           // Attack
        this._stats[3] = defense;                          // Defense
    }

    public string getName()
    {
        return _name;
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

    // Mana
    public void useMana(int mana)
    {
        _stats[1] -= mana;
    }

    public int getMana()
    {
        return _stats[1];
    }

    // Attack
    public int getAttack()
    {
        return _stats[2];
    }

    // Defense
    public int getDefense()
    {
        return _stats[3];
    }

    public bool hasDied()
    {
        if (_stats[0] < 0)
        {
            return true;
        }
        return false;
    }
}

class Item
{
    private string _name;
    private int _value;
    private int _stat;

    public Item(string name, int value, int stat)
    {
        this._name = name;
        this._value = value;
        this._stat = stat;
    }

    public string getName()
    {
        return _name;
    }

    public int getValue()
    {
        return _value;
    }

    public int getStat()
    {
        return _stat;
    }
}

class Game
{
    // Private
    private Player _player;
    private int _turn;
    private string[] _menuOptions;
    private bool _isRunning = false;
    private List<Enemy> _enemies;
    private List<Item> _items;

    // Public
    public Game(Player player)
    {
        this._player = player;
        this._menuOptions = new string[] { "Open Inventory", "View Stats", "Fight", "Exit" };
        this._turn = 0;

        // Add more enemies here
        this._enemies = new List<Enemy>
        {
            new Enemy("Ugnius", 50, 50, 12, 15),
            new Enemy("Dercio", 75, 75, 14, 18),
            new Enemy("Luke", 100, 100, 18, 23),
            new Enemy("Yusuf",125, 125, 22, 29),
            new Enemy("Max", 150, 150, 28, 35)
        };

        // Add more items here, NOTE: you must also add items functionality in useItem, use stat to make more effects.
        this._items = new List<Item>
        {
            new Item("Health Potion", 25, 0),
            new Item("Mana Potion", 25, 1),
            new Item("Attack Upgrade", 4, 2),
            new Item("Defense Upgrade", 7, 3)
        };
    }

    // RUN
    public void run()
    {
        _isRunning = true;
        Console.WriteLine("To navigate menus, enter the number of your desired option!");
        while (_isRunning)
        {
            displayHUD();
        }
    }

    // EXIT
    public void exit()
    {
        _isRunning = false;
        Console.WriteLine("You are now exiting the game, goodbye!");
    }

    // HUD
    public void displayHUD()
    {
        Console.WriteLine("========HUD========");
        for (int i = 0; i < _menuOptions.Count(); i++)
        {
            Console.WriteLine($"{i + 1}. {_menuOptions[i]}");
        }
        hudInput();
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
                    // View stats
                    viewStats();
                    break;
                case 3:
                    // Fight
                    fight();
                    break;
                case 4:
                    // Exit
                    exit();
                    break;

            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Please only enter a number to choose your option!: {ex.Message}");
        }
    }
    
    // STATS
    public void viewStats()
    {
        Console.WriteLine("=======STATS=======");
        Console.WriteLine($"Health: {_player.getHealth()}");
        Console.WriteLine($"Mana: {_player.getMana()}");
        Console.WriteLine($"Attack: {_player.getAttack()}");
        Console.WriteLine($"Defense: {_player.getDefense()}");
    }

    // INVENTORY
    public void openInventory()
    {
        Console.WriteLine("=====INVENTORY=====");
        List<Item> inventory = _player.getInventory();
        if (inventory.Count() == 0)
        {
            Console.WriteLine("You have no Items in your inventory");
        }
        else
        {
            Console.WriteLine("Choose the Item you want to use!");
            for (int i = 0; i < inventory.Count(); i++)
            {
                Console.WriteLine($"{i + 1}. {inventory[i].getName()}");
            }
            inventoryInput();
        }

    }

    public void inventoryInput()
    {
        try
        {
            int choice = int.Parse(Console.ReadLine());
            int index = choice - 1;

            Item chosenItem = _player.getInventory()[index];
            useItem(chosenItem);
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Please only enter a number to choose your option!: {ex.Message}");
        }
    }

    public void useItem(Item item)
    {
        int stat = item.getStat();
        Console.WriteLine($"You have used {item.getName()}! Check stats to see its effect!");

        switch (stat)
        {
            case 0:
                _player.heal(item.getValue());
                break;
            case 1:
                _player.upgradeMana(item.getValue());
                break;
            case 2:
                _player.upgradeAttack(item.getValue());
                break;
            case 3:
                _player.upgradeDefense(item.getValue());
                break;
        }
        _player.dropItem(item);
    }

    // COMBAT
    public void fight()
    {
        Console.WriteLine("=======FIGHT=======");
        bool isFighting = true;

        if (_turn > _enemies.Count() - 1)
        {
            Console.WriteLine("You've beaten everyone, GG WP");
            return;
        }

        Enemy enemy = _enemies[_turn];

        Console.WriteLine($"{_player.getName()}, you have chosen to fight: {enemy.getName()}");

        Console.WriteLine($"======={_player.getName()}=======");
        Console.WriteLine($"Health: {_player.getHealth()}");
        Console.WriteLine($"Mana: {_player.getMana()}");
        Console.WriteLine($"Attack: {_player.getAttack()}");
        Console.WriteLine($"Defense: {_player.getDefense()}");

        Console.WriteLine("------------------------------");

        Console.WriteLine($"======={enemy.getName()}=======");
        Console.WriteLine($"Health: {enemy.getHealth()}");
        Console.WriteLine($"Mana: {enemy.getMana()}");
        Console.WriteLine($"Attack: {enemy.getAttack()}");
        Console.WriteLine($"Defense: {enemy.getDefense()}");

        Console.WriteLine("Do you wish to proceed? [y/n]");
        char answer = char.Parse(Console.ReadLine());

        if (answer == 'n')
        {
            return;
        }

        while (isFighting)
        {
            int playerDamage = _player.getAttack();
            int enemyDamage = enemy.getAttack();

            int playerDefense = _player.getDefense();
            int enemyDefense = enemy.getDefense();



            enemy.takeDamage(playerDamage);
            Console.WriteLine($"{_player.getName()} attacked! {enemy.getName()}'s health is now: {enemy.getHealth()}");
            Console.WriteLine("------------------");

            if (enemy.hasDied())
            {
                Console.WriteLine("====================");
                Console.WriteLine($"Congrats, you beat {enemy.getName()}");
                Console.WriteLine("====================");
                _turn++;
                giveRewards();
                return;
            }

            _player.takeDamage(enemyDamage);
            Console.WriteLine($"{enemy.getName()} attacked! {_player.getName()}'s health is now: {_player.getHealth()}");
            Console.WriteLine("------------------");

            if (_player.hasDied())
            {
                Console.WriteLine("====================");
                Console.WriteLine($"WOMP WOMP, you lost to {enemy.getName()}");
                Console.WriteLine("Now you have to restart ;)");
                Console.WriteLine("====================");
                _isRunning = false;
                return;
            }
        }
    }

    public void giveRewards()
    {
        Random rand = new Random();

        int amountOfItems = rand.Next(10);
        List<string> rewards = new List<string>();

        for (int i = 0; i < amountOfItems; i++)
        {
            int randomItemIndex = rand.Next(_items.Count());
            Item randomItem = _items[randomItemIndex];
            _player.pickUpItem(randomItem);
            rewards.Add(randomItem.getName());
        }
        Console.WriteLine($"Here are your rewards:\n {string.Join(", ", rewards)}");
    }
}

// MAIN
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
