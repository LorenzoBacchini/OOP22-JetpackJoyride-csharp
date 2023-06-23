namespace SanchiEmanuele.JetpackJoyride.Api;

/// <summary>
/// Interface for classes to save statistics on preferences.
/// </summary>
public interface ISaves
{
    /// <summary>
    ///Method to get the value from preferences and save them into Dictionary in class Statistics.
    /// </summary>
    Dictionary<String, int> downloadSaves();

    ///<summary>
    ///Method to save new statistcs in preferences.
    /// <param name="stats">the dictionary to get value that has to be save</param>
    /// </summary>
    void uploadSaves(Dictionary<String, int> stats);
}