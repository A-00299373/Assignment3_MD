using STB.library;

namespace STB.libraryTest;

[TestClass]
public class TipCalculator_CalculateEachPersonTips
{
    [TestMethod]
    public void CalculateEachPersonTips_Method_Receives_Only_One_Person_And_Should_Return_Correct_Calculated_Tip()
    {
        TipCalculator tipCalculator = new TipCalculator();

        var IndividualMealCosts = new Dictionary<string, decimal> { { "Meet", 100m } };

        var actualTips = tipCalculator.CalculateEachPersonTips(IndividualMealCosts, 15f);

        var expectedTips = new Dictionary<string, decimal> { { "Meet", 15m } };

        CollectionAssert.AreEqual(expectedTips, actualTips);
    }

    [TestMethod]
    public void CalculateEachPersonTips_Method_Receives_More_Than_One_Person_And_Should_Return_Correct_Individual_Tip()
    {
        TipCalculator tipCalculator = new TipCalculator();

        var IndividualMealCosts = new Dictionary<string, decimal> { { "Meet", 187m }, { "Tarang", 140m }, { "Ayush", 745m } };

        var actualTips = tipCalculator.CalculateEachPersonTips(IndividualMealCosts, 10f);

        var expectedTips = new Dictionary<string, decimal> { { "Meet", 18.7m }, { "Tarang", 14m }, { "Ayush", 74.5m } };

        CollectionAssert.AreEqual(expectedTips, actualTips);
    }

    [TestMethod]
    public void CalculateEachPersonTips_Method_Receives_No_One_Wants_To_Give_Tip_Should_Return_Zero_Individual_Tip()
    {
        TipCalculator tipCalculator = new TipCalculator();

        var IndividualMealCosts = new Dictionary<string, decimal> { { "Meet", 748m }, { "Tarang", 121m } };

        var actualTips = tipCalculator.CalculateEachPersonTips(IndividualMealCosts, 0f);

        var expectedTips = new Dictionary<string, decimal> { { "Meet", 0m }, { "Tarang", 0m } };

        CollectionAssert.AreEqual(expectedTips, actualTips);
    }
}