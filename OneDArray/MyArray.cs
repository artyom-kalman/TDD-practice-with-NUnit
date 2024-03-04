namespace MyArray;

public class OneDArray
{
    private int[] array;
    public int Length
    {
        get => array.Length;
    }

    public int this[int i]
    {
        get => array[i];
        set => array[i] = value;
    }

    public OneDArray(int length)
    {
        array = new int[length];
    }

    public OneDArray(int[] values)
    {
        array = values;
    }

    public int PositiveElementsSum()
    {
        var sum = 0;
        var secondMaxIndex = SecondMaxIndex();

        for (int i = secondMaxIndex; i < Length; i++) 
        {
            sum += (array[i] > 0) 
                ? array[i] 
                : 0;
        }
        return sum;
    }

    private int SecondMaxIndex()
    {
        int[] copyArray = new int[Length];
        Array.Copy(array, copyArray, Length);

        var firstMaxIndex = FirstMaxIndex();
        copyArray[firstMaxIndex] = int.MinValue;

        var secondMaxValue = copyArray.Max();
        return Array.FindIndex(copyArray, element => element == secondMaxValue);
    }

    private int FirstMaxIndex()
    {
        var maxValue = array[0];
        var maxIndex = 0;

        for (int i = 1; i < Length; i++)
        {
            if (maxValue == array[i])
            {
                maxValue = array[i];
                maxIndex = i;
            }
        }
        return maxIndex;
    }

}
