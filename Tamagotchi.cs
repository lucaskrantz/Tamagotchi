public class Tamagotchi
{
    private bool isAlive;
    private int boredom;
    private int hungry = 0;
    public string name;
    private Random generator;
    private List<string> words = new List<string>();
    public Tamagotchi()
    {
        generator = new Random();
        isAlive = true;
    }

    public void Feed()
    {
        hungry -= 3;

        if (hungry < 0)
        {
            hungry = 0;
        }
    }

    public void Talk()
    {

    }

    public void Teach()
    {

    }

    public void Tick()
    {
        hungry++;

        if (hungry > 10)
        {
            isAlive = false;
        }
    }

    public void PrintStats()
    {
        Console.WriteLine($"{hungry} hunger");
    }

    public bool GetAlive()
    {
        return isAlive;
    }

    private void ReduceBoredom()
    {

    }
}
