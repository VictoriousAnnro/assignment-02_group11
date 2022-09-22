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

      var expectedResult = new List<Wizard>();
      expectedResult.Add(new Wizard ("Grand Vizier Jafar","Aladdin", 1992, "Walt Disney"));
      expectedResult.Add(new Wizard ("Shang Tsung","Mortal Kombat", 1995, "Paul W.S. Anderson"));
      expectedResult.Add(new Wizard ("Willow Ufgood","Willow", 1998, "Nigel Wooll"));
      expectedResult.Add(new Wizard ("Sauron","The Fellowship of the Ring", 1954, "J.R.R. Tolkien"));
      expectedResult.Add(new Wizard ("Alberforth Dumbledore","Harry Potter", 1995, "J. K. Rowling"));
      expectedResult.Add(new Wizard ("Severus Snape","Harry Potter", 1995, "J. K. Rowling"));
      expectedResult.Add(new Wizard ("Sirius Black","Harry Potter", 1995, "J. K. Rowling"));
      expectedResult.Add(new Wizard ("Darth Fake","Star Wars", 2000, "George Lucas"));
      expectedResult.Add(new Wizard ("Darth Vader","Star Wars", 1977, "George Lucas"));
      expectedResult.Add(new Wizard ("Obi-Wan Kenobi","Star Wars", 1977, "George Lucas"));
      expectedResult.Add(new Wizard ("Merlin","The Sword in the Stone", 1963, "Bill Peet"));

      Assert.Equal(expectedResult, list);
    }
}