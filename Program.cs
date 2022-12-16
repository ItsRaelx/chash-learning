
namespace project
{
  public class Hero
  {
    public string Name;
    private int Strength;
    private int Dexterity;
    private int Intelligence;

    private void Init(int strength = 5, int dexterity = 5, int intelligence = 5)
    {
      this.Strength = strength;
      this.Dexterity = dexterity;
      this.Intelligence = intelligence;
    }

    public int GetStrength() { return this.Strength; }
    public int GetDexterity() { return this.Dexterity; }
    public int GetIntelligence() { return this.Intelligence; }

    public Hero(string name, string myclass)
    {
      this.Name = name;
      switch(myclass)
      {
        case "warior": Init(8, 5, 2); break;
        case "assassin": Init(3, 8, 4); break;
        case "sorcerer": Init(4, 2, 9); break;
        default: Init(); break;
      }
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Hero hero = new Hero("Edward Białykij", "sorcerer");
      Console.WriteLine(hero.Name + " Str:{0} Dex:{1} Int:{2}",
                        hero.GetStrength(),
                        hero.GetDexterity(),
                        hero.GetIntelligence()
                        );
    }
  }
}