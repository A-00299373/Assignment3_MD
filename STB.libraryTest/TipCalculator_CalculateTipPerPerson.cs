using STB.library;

namespace STB.libraryTest;

[TestClass]
public class TipCalculator_CalculateTipPerPerson
{
    [TestMethod]
    public void CalculateTipPerPerson_Method_Receives_Only_One_Person_And_Should_Return_Correct_Calculated_Tip()
    {
        TipCalculator tipCalculator = new TipCalculator();

        var ret = tipCalculator.CalculateTipPerPerson(100m, 1, 15f);

        Assert.AreEqual(15m, ret);
    }

    [TestMethod]
    public void CalculateTipPerPerson_Method_Receives_Multiple_Persons_And_Should_Return_Correct_Calculated_Tip()
    {
        TipCalculator tipCalculator = new TipCalculator();

        var ret = tipCalculator.CalculateTipPerPerson(375m, 4, 15f);

        Assert.AreEqual(14.0625m, ret);
    }

    [TestMethod]
    public void CalculateTipPerPerson_Method_Receives_Zero_TipPercentage_And_Should_Return_Zero_Tip()
    {
        TipCalculator tipCalculator = new TipCalculator();

        var ret = tipCalculator.CalculateTipPerPerson(426m, 7, 0f);

        Assert.AreEqual(0m, ret);
    }
}
