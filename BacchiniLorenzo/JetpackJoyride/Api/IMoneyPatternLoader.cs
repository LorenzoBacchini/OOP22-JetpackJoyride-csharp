using System.Collections.Generic;
using BacchiniLorenzo.JetpackJoyride.Impl;

namespace BacchiniLorenzo.JetpackJoyride.Api;

/// <summary>
/// Interface to load money pattern from file.
/// @author lorenzo.bacchini4@studio.unibo.it
/// </summary>
public interface IMoneyPatternLoader
{   
    /// <summary>
    /// Method to get the money pattern from file.
    /// </summary>
    /// <returns>
    /// an array list of Money
    /// </returns>
    List<Money> GetMoneyPattern();
}