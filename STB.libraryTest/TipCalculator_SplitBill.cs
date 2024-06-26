using STB.library;

namespace STB.libraryTest;

[TestClass]
public class TipCalculator_SplitBill
{
    [TestMethod]
    public void SplitBill_Method_Receives_Total_Amount_Of_Bill_By_Number_of_People_And_Should_Return_Split_Amount()
    {
        TipCalculator tipCalculator = new TipCalculator();

        var ret = tipCalculator.SplitBill(1000, 10);

        Assert.AreEqual(100, ret);
    }

    [TestMethod]
    public void SplitBill_Method_Receives_Total_Amount_Of_Bill_By_One_Person_And_Should_Return_The_Total_Amount_Of_Bill()
    {
        TipCalculator tipCalculator = new TipCalculator();

        var ret = tipCalculator.SplitBill(845, 1);

        Assert.AreEqual(845, ret);
    }

    [TestMethod]
    public void SplitBill_Method_Receives_Total_Amount_Of_Bill_Zero_And_Should_Return_Exception()
    {
        TipCalculator tipCalculator = new TipCalculator();
        
        Assert.ThrowsException<DivideByZeroException>(() => tipCalculator.SplitBill(58, 0));
    }
}