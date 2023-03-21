using ClassLibrary;
using FluentAssertions;

namespace SpecFlowProject.Steps;

[Binding]
public class BasketStepDefinitions
{
    private readonly Basket _basket = new Basket();
    private Dictionary<string, decimal> _items;

    public BasketStepDefinitions()
    {
        _items = new Dictionary<string, decimal>();
    }
    
    [Given(@"I have an empty basket")]
    public void GivenIHaveAnEmptyBasket()
    {
        _basket.Items = new List<Item>();
    }
    
    [Given(@"the price of a/an ""(.*)"" is \$(.*)")]
    public void GivenThePriceOfAAnIs(string thing, decimal p1)
    {
        _items.Add(thing, p1);
    }

    [When(@"I add a ""(.*)"" to the basket")]
    public void WhenIAddAToTheBasket(string thing)
    {
        _basket.Add(new Item { Name = thing, Price = _items[thing] });
    }

    [Then(@"the total price of the basket contents should be \$(.*)")]
    public void ThenTheTotalPriceOfTheBasketContentsShouldBe(decimal p0)
    {
        _basket.Total.Should().Be(p0);
    }

    [Then(@"the total price of the ""(.*)"" in the basket should be \$(.*)")]
    public void ThenTheTotalPriceOfTheInTheBasketShouldBe(string thing, decimal p1)
    {
        _basket.TotalOfSpecificItemType(thing).Should().Be(p1);
    }
}