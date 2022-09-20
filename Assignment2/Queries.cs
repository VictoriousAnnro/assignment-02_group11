namespace Assignment2;

public class Queries
{
  public static IEnumerable<Wizard> GetWizardsByCreator(WizardCollection collection, string creator) {
    var wizardsQuery = 
      from w in collection
      where (w.Creator).Contains(creator)
      select w;
    return wizardsQuery.ToList();
  }

  public static int? GetFirstSithLord(WizardCollection collection) {
    var wizardsQuery =
      (from w in collection
      where (w.Name).Contains("Darth")
      select w).Min(w => w.Year);

    return wizardsQuery;
  }

  public static IEnumerable<(string, int?)> GetWizardsNameAndYearFromHarryPotter(WizardCollection collection) {
    var wizardsQuery = 
      from w in collection
      where (w.Medium).Contains("Harry Potter")
      select (w.Name, w.Year);

    return wizardsQuery;
  }

  public static IEnumerable<Wizard> GetGroupedWizardList(WizardCollection collection) {
    var wizardsQuery = 
      from w in collection
      orderby w.Creator descending
      group w by w.Creator;

    foreach(var group in wizardsQuery) {
      group.OrderBy(w => w.Name);
    }

    foreach(var group in wizardsQuery) {
      foreach (var w in group) {
        Console.WriteLine(w);
      }
    }

    return null;
  }

}
