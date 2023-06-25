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
        Assert.AreEqual(330d, moneyList[index].Pos.GetX());
        moneyList.RemoveAt(index);
        Assert.AreEqual(285d, moneyList[index].Pos.GetX());
        moneyList.RemoveAt(index);
        Assert.AreEqual(248d, moneyList[index].Pos.GetX());
        moneyList.RemoveAt(index);

        //Removing all elements except the last one
        while (moneyList.Count > 1)
        { 
            moneyList.RemoveAt(index);
        }
        
        //Check also the last element of the file
        Assert.AreEqual(566d, moneyList[index].Pos.GetX());
    }
}