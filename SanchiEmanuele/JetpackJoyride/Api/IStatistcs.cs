namespace SanchiEmanuele.JetpackJoyride.Api;

/// <summary>
/// A basic interface to modelize game' statistics
/// </summary>
public interface IStatistcs
{
    public Dictionary<String, int> Statistics { get; }
    
    /// <summary>
    /// A method to get the value of the statistics passed by parameter
    /// </summary>
    /// <param name="name">The name of statitsics to get the value</param>
    /// <returns>The value of specified statistic</returns>
    int GetValue(String name);
    
    /// <summary>
    /// A method to set the value of a statistic
    /// </summary>
    /// <param name="name">The name of the statistic</param>
    /// <param name="value">The value of the statistic</param>
    void SetValue(String name, int value);

    /// <summary>
    /// A method to increment by 1 the value of a specified statistic
    /// </summary>
    /// <param name="name">The name of the statistic</param>
    void Increment(String name);

    /// <summary>
    /// A method to increment a specified statistic by a valued passed by parameter
    /// </summary>
    /// <param name="name">The name of the statistic</param>
    /// <param name="value">The value to add on the statistic</param>
    void Increment(String name, int value);

    /// <summary>
    /// A method to add a new statistic
    /// </summary>
    /// <param name="name">The name of the statistic</param>
    /// <param name="value">The value of the statistic</param>
    void AddStatistic(String name, int value);

    /// <summary>
    /// A method to set all the statistics
    /// </summary>
    /// <param name="stats">A dictionary of statistics</param>
    void SetAll(Dictionary<String, int> stats);

    /// <summary>
    /// A method to update general statistics with statistic of just ended run
    /// </summary>
    /// <param name="runStats">The stats of just ended run</param>
    void UpdateGeneralStats(Dictionary<string, int> runStats);
}