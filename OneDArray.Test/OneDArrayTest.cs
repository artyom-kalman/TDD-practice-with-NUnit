using NUnit.Framework;

namespace MyArray.Test;

public class OneDArrayTest
{
    [TestCase(10)]
    [TestCase(0)]
    public void LengthTest(int expectedLength)
    {
        var array = new OneDArray(expectedLength);

        var length = array.Length;

        Assert.That(length, Is.EqualTo(expectedLength));
    }

    [TestCase(-1)]
    [TestCase(-10)]
    public void LengthConstructorTestToFail(int length)
    {
        var actualExection = Assert.Throws<OverflowException>(() => new OneDArray(length));
    }

    [TestCase((int[])[1, 2, 3, 4, 5], 3, 10)]
    public void SetGetValueAtIndexTest(int[] values, int index, int expectedValue)
    {
        var array = new OneDArray(values);

        array[index] = expectedValue;

        Assert.That(array[index], Is.EqualTo(expectedValue));
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

        Assert.That(actualSum, Is.EqualTo(expectedSum));
    }
}