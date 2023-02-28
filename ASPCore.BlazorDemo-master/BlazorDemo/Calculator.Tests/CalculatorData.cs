using System.Collections;

namespace Calculator.Tests
{
    public class CalculatorData : IEnumerable<object[]>
    {
    public static IEnumerable<object[]> GetCalculatorInputs(int param1)
    {
            System.Diagnostics.Debug.WriteLine(param1);
            var objects = new List<object[]>
        {
            new object[]
            {
                42,
                -42,
                "0"
            },
            new object[]
            {
                23405, 45436, "68841"
            },
        };
        return objects;
    }

        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                42,
                -42,
                "0"
            };

            yield return new object[]
            {
                23405,
                45436,
                "68841"
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}