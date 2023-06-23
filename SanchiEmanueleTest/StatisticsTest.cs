using SanchiEmanuele.JetpackJoyride.Api;
using SanchiEmanuele.JetpackJoyride.Impl;

namespace SanchiEmanueleTest;
using NUnit.Framework;

/// <summary>
/// Test for class StatisticsImpl
/// </summary>
public class StatisticsTests
{
    [SetUp]
    public void Setup()
    {
    }

    /// <summary>
    /// Test to check right increment of statistics objects
    /// </summary>
    [Test]
    public void StatisticsTest()
    {
        IStatistcs genStats = new StatisticsImpl();
        IStatistcs runStats = new StatisticsImpl();
        //inizialize some values
        genStats.AddStatistic("KILLED_NPC", 10);
        genStats.AddStatistic("DEATHS", 5);
        genStats.AddStatistic("ACTUAL_MONEY", 12);
        genStats.AddStatistic("GRABBED_OBJECTS", 0);
        genStats.AddStatistic("TOTAL_METERS", 100);
        genStats.AddStatistic("MAX_METERS", 0);
        genStats.AddStatistic("GRABBED_MONEY", 0);
        runStats.AddStatistic("TOTAL_METERS", 0);
        runStats.AddStatistic("GRABBED_OBJECTS", 0);
        runStats.AddStatistic("GRABBED_MONEY", 0);
        runStats.AddStatistic("KILLED_NPC", 0);
        
        //increment some value
        genStats.Increment("DEATHS", 3);
        genStats.Increment("KILLED_NPC", 10);
        genStats.Increment("DEATHS", 3);
        genStats.Increment("DEATHS", 3);
        runStats.Increment("GRABBED_MONEY", 10);
        runStats.Increment("TOTAL_METERS", 1200);
        runStats.Increment("KILLED_NPC", 6);
        
        //update genStats with runStats
        genStats.UpdateGeneralStats(runStats.Statistics);
        
        //check if genStats is updated with runstats values
        Assert.AreEqual(14, genStats.GetValue("DEATHS")); //started with 5 and increment 3 times by 3
        Assert.AreEqual(26, genStats.GetValue("KILLED_NPC")); //started with 10 and increment by 10 and 6
        Assert.AreEqual(1200, genStats.GetValue("MAX_METERS")); //started with 0 but made a run with 1200 of total meters so new record
        Assert.AreEqual(22, genStats.GetValue("ACTUAL_MONEY")); //started with 12 and increment by 10
    }
}