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

    public OneDArray(int[] array)
    {
        this.array = [];
    }

    public int PositiveElementsSum()
    {
        return -1;
    }
}
