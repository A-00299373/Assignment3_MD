namespace STB.library;

public class TipCalculator
{
    public decimal SplitBill(decimal amount, int NumberOfPeople)
    {
        var result = amount / NumberOfPeople;

        return result;
    }

    public Dictionary<string, decimal> CalculateEachPersonTips(Dictionary<string, decimal> IndividualMealCosts, float TipPercentage)
    {
        var result = new Dictionary<string, decimal>();

        foreach (var share in IndividualMealCosts)
        {
            decimal Tip = share.Value * (decimal)TipPercentage / 100;

            result.Add(share.Key, Tip);
        }
        return result;
    }

    public decimal CalculateTipPerPerson(decimal TotalAmountOfBill, int NumberOfPersons, float TipPercentage)
    {
        decimal TotalTip = TotalAmountOfBill * (decimal)TipPercentage / 100;

        var result = TotalTip / NumberOfPersons;

        return result;
    }
}
