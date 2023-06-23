using SanchiEmanuele.JetpackJoyride.Api;

namespace SanchiEmanuele.JetpackJoyride.Impl;

using System.Threading;

public class SliderImpl : ISlider
{
    public int Pos { get; private set; }
    private bool _stop;
    private readonly int _limit;
    private const int Stopmillis = 25;
    private readonly Thread _agent;

    public SliderImpl(int limit)
    {
        this._limit = limit;
        _agent = new Thread(new ThreadStart(this.UpdatePos));
    }
    private void UpdatePos()
    {
        while (!_stop)
        {
            if (this.Pos < this._limit)
            {
                this.Pos += 10;
                Thread.Sleep(Stopmillis);
            }
            else
            {
                this.ResetPos();
            }
        }

    }

    public void ResetPos()
    {
        this.Pos = 0;
    }

    public void Run()
    {
        _agent.Start();
    }

    public void Interrupt()
    {
        this._stop = true;
    }
}