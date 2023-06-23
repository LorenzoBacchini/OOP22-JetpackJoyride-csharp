using BacchiniLorenzo.JetpackJoyride.Api;
using BacchiniLorenzo.JetpackJoyride.Impl;

namespace BacchiniLorenzoTest;

/// <summary>
/// Class to test the MoneyPatternLoader and the class Money.
/// @author lorenzo.bacchini4@studio.unibo.it
/// </summary>

[TestClass]

public class MoneyPatternTest
{
    private const int FileNumber = 1;
    private readonly IMoneyPatternLoader _moneyPatternLoader = new MoneyPatternLoaderImpl(FileNumber);
    
    [TestMethod]
    
    public void TestMoneyPatternLoader()
    { 
        const int index = 0;
        const int moneyListSize = 28;
        List<Money> moneyList = _moneyPatternLoader.GetMoneyPattern();
        Assert.AreEqual(moneyListSize, moneyList.Count());
        Assert.AreEqual(2330d, moneyList.RemoveAt(index).Pos().GetX());
        Assert.AreEqual(2285d, moneyList.RemoveAt(index).Pos().GetX());
        Assert.AreEqual(2248d, moneyList.RemoveAt(index).Pos().GetX());

        //Removing all elements except the last one
        while (moneyList.Count > 1)
        { 
            moneyList.RemoveAt(index);
        }
        
        //Check also the last element of the file
        Assert.AreEqual(2566d, moneyList.RemoveAt(index).Pos().GetX());
    }
}