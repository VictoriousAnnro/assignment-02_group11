namespace Assignment2.Tests;

public class QueriesTests
{
    [Fact]
    public void Get_Wizards_Created_By_Rowling_Return_3()
    {
      var wizardsByRowling = Queries.GetWizardsByCreator(WizardCollection.Create(), "Rowling");
      Assert.Equal(3, wizardsByRowling.Count());
    }

    [Fact]
    public void Get_First_Sith_Lord_Year_Returns_1977() {
      var firstSithLordYear = Queries.GetFirstSithLord(WizardCollection.Create());
      Assert.Equal(1977, firstSithLordYear);
    }

    [Fact]
    public void Get_Harry_Potter_Wizards_Return_3_tuples() {
      var harryPotterWizards = Queries.GetWizardsNameAndYearFromHarryPotter(WizardCollection.Create());

      var expectedResult = new List<(string, int?)>();
      expectedResult.Add(("Sirius Black", 1995));
      expectedResult.Add(("Alberforth Dumbledore", 1995));
      expectedResult.Add(("Severus Snape", 1995));

      Assert.Equal(expectedResult, harryPotterWizards);    
    }

    [Fact]
    public void Get_Grouped_Wizards_List() {
      var list = Queries.GetGroupedWizardList(WizardCollection.Create());
    }
}
