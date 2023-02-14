namespace Calculator.Tests;

public class CalculatorTests : TestContext
{
    private const string NUM1ELEMENT_ID = "num1Input";
    private const string NUM2ELEMENT_ID = "num2Input";
    private const string RESULTINPUT_ID = "resultInput";
    private const string ADDBUTTON_ID = "addButton";
    private const string SUBTRACTBUTTON_ID = "subtractButton";
    private const string DIVIDEBUTTON_ID = "divideButton";
    private const string MULTIPLYBUTTON_ID = "multiplyButton";
    private const string NTHPOWERBUTTON_ID = "nthPowerButton";
    private const string MODULUSBUTTON_ID = "modulusButton";
    private const string LOGARITHMBUTTON_ID = "logButton";

    private AngleSharp.Dom.IElement GetHtmlElement(IRenderedComponent<BlazorDemo.Pages.Calculator> calculatorComponent,
                                                   string htmlType,
                                                   string cssId)
    {
        return calculatorComponent.FindAll(htmlType).First(x => x.Id == cssId);
    }

    private IRenderedComponent<BlazorDemo.Pages.Calculator> InitializeFieldInputs(int firstInput,
                                                                                  int secondInput)
    
    {
        var calculatorComponent = RenderComponent<BlazorDemo.Pages.Calculator>();
        var num1Element = GetHtmlElement(calculatorComponent, "input", NUM1ELEMENT_ID);
        num1Element.Change(firstInput);
        calculatorComponent.Render();
        var num2Element = GetHtmlElement(calculatorComponent, "input", NUM2ELEMENT_ID);
        num2Element.Change(secondInput);
        calculatorComponent.Render();
        return calculatorComponent;
    }

    private IRenderedComponent<BlazorDemo.Pages.Calculator> InitializeFirstInput(int firstInput)
    {
        var calculatorComponent = RenderComponent<BlazorDemo.Pages.Calculator>();
        var num1Element = GetHtmlElement(calculatorComponent, "input", NUM1ELEMENT_ID);
        num1Element.Change(firstInput);
        calculatorComponent.Render();
        return calculatorComponent;
    }

    private void AssertFieldInputs(int firstInput,
                                   int secondInput,
                                   string expectedResult,
                                   IRenderedComponent<BlazorDemo.Pages.Calculator> calculatorComponent)
    {
        GetHtmlElement(calculatorComponent, "input", NUM1ELEMENT_ID)
                    .MarkupMatches($"<input id=\"num1Input\" placeholder=\"Enter First Number\" value=\"{firstInput}\" >");
        GetHtmlElement(calculatorComponent, "input", NUM2ELEMENT_ID)
            .MarkupMatches($"<input id=\"num2Input\" placeholder=\"Enter Second Number\" value=\"{secondInput}\" >");
        GetHtmlElement(calculatorComponent, "input", RESULTINPUT_ID)
            .MarkupMatches($"<input id=\"resultInput\" readonly=\"\" value=\"{expectedResult}\" >");
    }

    private void AssertSingleFieldInputAndResult(int firstInput,
                                                 string expectedResult,
                                                 IRenderedComponent<BlazorDemo.Pages.Calculator> calculatorComponent)
    {
        GetHtmlElement(calculatorComponent, "input", NUM1ELEMENT_ID)
                    .MarkupMatches($"<input id=\"num1Input\" placeholder=\"Enter First Number\" value=\"{firstInput}\" >");
        GetHtmlElement(calculatorComponent, "input", RESULTINPUT_ID)
            .MarkupMatches($"<input id=\"resultInput\" readonly=\"\" value=\"{expectedResult}\" >");
    }

    [Theory]
    [Trait("Category", "ExistingFeature")]
    [InlineData(42, 34, "76")]
    [InlineData(23405, 45436, "68841")]
    [InlineData(-42, 42, "0")]
    public void Add_Test(int firstInput, int secondInput, string expectedResult)
    {
        // Arrange
        IRenderedComponent<BlazorDemo.Pages.Calculator> calculatorComponent = InitializeFieldInputs(firstInput, secondInput);
        var addButton = GetHtmlElement(calculatorComponent, "button", ADDBUTTON_ID);

        // Act
        addButton.Click();

        // Assert
        calculatorComponent.Render();
        AssertFieldInputs(firstInput, secondInput, expectedResult, calculatorComponent);
    }

    

    [Theory]
    [Trait("Category", "ExistingFeature")]
    [InlineData(372, 42, "330")]
    [InlineData(4363, 3242, "1121")]
    [InlineData(-42, 42, "-84")]
    public void Subtract_Test(int firstInput, int secondInput, string expectedResult)
    {
        // Arrange
        IRenderedComponent<BlazorDemo.Pages.Calculator> calculatorComponent = InitializeFieldInputs(firstInput, secondInput);
        var subtractButton = GetHtmlElement(calculatorComponent, "button", SUBTRACTBUTTON_ID);

        // Act
        subtractButton.Click();

        // Assert
        calculatorComponent.Render();
        AssertFieldInputs(firstInput, secondInput, expectedResult, calculatorComponent);
    }

    [Theory]
    [Trait("Category", "ExistingFeature")]
    [InlineData(372, 42, "15624")]
    [InlineData(4363, 3242, "14144846")]
    [InlineData(-42, 42, "-1764")]
    public void Multiply_Test(int firstInput, int secondInput, string expectedResult)
    {
        // Arrange
        IRenderedComponent<BlazorDemo.Pages.Calculator> calculatorComponent = InitializeFieldInputs(firstInput, secondInput);
        var multiplyButton = GetHtmlElement(calculatorComponent, "button", MULTIPLYBUTTON_ID);

        // Act
        multiplyButton.Click();

        // Assert
        calculatorComponent.Render();
        AssertFieldInputs(firstInput, secondInput, expectedResult, calculatorComponent);
    }

    [Theory]
    [Trait("Category", "ExistingFeature")]
    [InlineData(372, 42, "8,857142857142858")]
    [InlineData(4363, 3242, "1,3457742134484887")]
    [InlineData(-42, 42, "-1")]
    public void Division_Test(int firstInput, int secondInput, string expectedResult)
    {
        // Arrange
        IRenderedComponent<BlazorDemo.Pages.Calculator> calculatorComponent = InitializeFieldInputs(firstInput, secondInput);
        var divideButton = GetHtmlElement(calculatorComponent, "button", DIVIDEBUTTON_ID);

        // Act
        divideButton.Click();

        // Assert
        calculatorComponent.Render();
        AssertFieldInputs(firstInput, secondInput, expectedResult, calculatorComponent);
    }

    [Theory]
    [Trait("Category", "NewFeature")]
    [InlineData(13, 4, "28561")]
    [InlineData(-42, 3, "-74088")]
    [InlineData(10432, -3, "8,808404798583246E-13")]
    public void Nth_Power_Test(int firstInput, int secondInput, string expectedResult)
    {
        // Arrange
        var calculatorComponent = InitializeFieldInputs(firstInput, secondInput);
        var nthPowerButton = GetHtmlElement(calculatorComponent, "button", NTHPOWERBUTTON_ID);

        // Act
        nthPowerButton.Click();

        // Assert
        calculatorComponent.Render();
        AssertFieldInputs(firstInput, secondInput, expectedResult, calculatorComponent);
    }

    [Theory]
    [Trait("Category", "NewFeature")]
    [InlineData(13, 4, "1")]
    [InlineData(-42, 3, "-0")]
    [InlineData(10432, -3, "1")]
    public void Modulus_Test(int firstInput, int secondInput, string expectedResult)
    {
        // Arrange
        var calculatorComponent = InitializeFieldInputs(firstInput, secondInput);
        var modulusButton = GetHtmlElement(calculatorComponent, "button", MODULUSBUTTON_ID);

        // Act
        modulusButton.Click();

        // Assert
        calculatorComponent.Render();
        AssertFieldInputs(firstInput, secondInput, expectedResult, calculatorComponent);
    }

    [Theory]
    [Trait("Category", "NewFeature")]
    [InlineData(10, "1")]
    [InlineData(1000000, "6")]
    [InlineData(34562346, "7,538603213560188")]
    public void Logarithm_Test(int input, string expectedResult)
    {
        // Arrange
        var calculatorComponent = InitializeFirstInput(input);
        var logarithmButton = GetHtmlElement(calculatorComponent, "button", LOGARITHMBUTTON_ID);

        // Act
        logarithmButton.Click();

        // Assert
        calculatorComponent.Render();
        AssertSingleFieldInputAndResult(input, expectedResult, calculatorComponent);
    }
}