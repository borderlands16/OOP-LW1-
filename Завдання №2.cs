using System;

public class Timer
{
    private int interval;
    private Action action;
    private System.Threading.Timer timer;

    public Timer(int interval, Action action)
    {
        this.interval = interval;
        this.action = action;
    }

    public void Start()
    {
        timer = new System.Threading.Timer(state =>
        {
            action();
        }, null, 0, interval * 1000);
    }

    public void Stop()
    {
        timer.Dispose();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Timer timer = new Timer(1, () => Console.WriteLine(DateTime.Now.ToString("mm:ss")));

        timer.Start();

        Console.ReadLine();

        timer.Stop();

        Console.WriteLine("Timer stopped.");
    }
}
