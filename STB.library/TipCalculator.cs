namespace STB.library;

public class TipCalculator
{
    public decimal SplitBill(decimal amount, int NumberOfPeople)
    {
        var result = amount / NumberOfPeople;
        return result;
    }

    
}
