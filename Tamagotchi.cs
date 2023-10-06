public class Tamagotchi
{
    private bool isAlive;
    private int boredom;
    private int hungry;
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

    }

    public void Talk()
    {

    }

    public void Teach()
    {

    }

    public void Tick()
    {

    }

    public void PrintStats()
    {

    }

    public bool GetAlive()
    {
        return true;
    }

    private void ReduceBoredom()
    {

    }
}
