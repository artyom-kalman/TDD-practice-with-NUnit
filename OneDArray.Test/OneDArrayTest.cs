using NUnit.Framework;

namespace MyArray.Test;

public class OneDArrayTest
{
    [TestCase(10)]
    public void LengthTest(int expectedLength)
    {
        var array = new OneDArray(expectedLength);

        var length = array.Length;

        Assert.That(length, Is.EqualTo(10));
    }

    [TestCase(5)]
    public void SetGetValueAtIndexTest(int expectedValue)
    {
        var array = new OneDArray(1);

        array[1] = expectedValue;

        Assert.That(array[1], Is.EqualTo(expectedValue));
    }

    [TestCase((int[])[1, 3, 5, 8, 4, 3], 15)]
    [TestCase((int[])[5, -6, 7, -8, 3, 1], 11)]
    [TestCase((int[])[0, 0, 0], 0)]
    [TestCase((int[])[1, 1, 1], 1)]
    [TestCase((int[])[6, 5, -5], 0)]
    public void PositiveElementsSumTest(int[] values, int expectedSum)
    {
        var array = new OneDArray(values);

        var actualSum = array.PositiveElementsSum();

        Assert.That(array[1], Is.EqualTo(expectedSum));
    }
}