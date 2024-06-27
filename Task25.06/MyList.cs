using System.Collections;

namespace ConsoleApp17;

public class MyList : IEnumerable
{
    public int[] arr;

    public MyList()
    {
        arr = new int[0];
    }

    public IEnumerator GetEnumerator()
    {
        foreach (var item in arr)
        {
            yield return item;
        }
    }

    public int this[int index]
    {
        get => arr[index];
        set => arr[index] = value;
    }
    public void Add(int num)
    {
        Array.Resize(ref arr, arr.Length + 1);
        arr[arr.Length - 1] = num;
    }
    public bool Contains(int num)
    {
        foreach (int i in arr)
        {
            if (i == num)
            {
                return true;
            }
        }
        return false;
    }


    public int IndexOf(int num)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == num)
            {
                return i;
            }
        }
        return -1;
    }

    public void Remove(int number)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == number)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                Array.Resize(ref arr, arr.Length - 1);
                break;
            }
        }
    }

    public void Reverse()
    {
        int temp = 0;
        for (int i = 0; i < arr.Length / 2; i++)
        {
            temp = arr[i];
            arr[i] = arr[arr.Length - 1 - i];
            arr[arr.Length - i - 1] = temp;
        }
    }
}
