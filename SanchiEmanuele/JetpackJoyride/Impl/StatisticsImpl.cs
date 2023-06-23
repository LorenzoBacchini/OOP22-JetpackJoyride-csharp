using SanchiEmanuele.JetpackJoyride.Api;

namespace SanchiEmanuele.JetpackJoyride.Impl;

public class StatisticsImpl : IStatistcs
{
    
    public Dictionary<string, int> Statistics { get; private set; }
    public StatisticsImpl()
    {
        Statistics = new Dictionary<string, int>();
    }

    public int GetValue(string name)
    {
        return Statistics[name];
    }

    public void SetValue(string name, int value)
    {
        Statistics[name] = value;
    }

    public void Increment(string name)
    {
        Statistics[name] = Statistics[name] + 1;
    }

    public void Increment(string name, int value)
    {
        Statistics[name] = Statistics[name] + value;
    }

    public void AddStatistic(string name, int value)
    {
        Statistics.Add(name, value);
    }

    public void SetAll(Dictionary<string, int> stats)
    {
        Statistics = stats;
    }

    public void UpdateGeneralStats(Dictionary<string, int> runStats)
    {
        foreach (string name in runStats.Keys)
        {
            this.Increment(name, runStats[name]);
        }

        if (runStats["GRABBED_MONEY"] > Statistics["GRABBED_MONEY"])
        {
            this.SetValue("MAX_MONEY", runStats["GRABBED_MONEY"]);
        }

        if (runStats["TOTAL_METERS"] > Statistics["MAX_METERS"])
        {
            this.SetValue("MAX_METERS", runStats["TOTAL_METERS"]);
        }

        this.Increment("ACTUAL_MONEY", runStats["GRABBED_MONEY"]);
    }
}