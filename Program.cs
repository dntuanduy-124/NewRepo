using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;

public class IntArray
{
    private int[] arr;

   
    public IntArray()
    {
        Random random = new Random();
        int k = random.Next(1, 201);
        arr = new int[k];
        for (int i = 0; i < k; i++)
        {
            arr[i] = random.Next(1, 201);
        }
    }

    public IntArray(int k)
    {
        Random random = new Random();
        arr = new int[k];
        for (int i = 0; i < k; i++)
        {
            arr[i] = random.Next(1, 201);
        }
    }

    public IntArray(int[] a)
    {
        arr = a.ToArray();
    }

    public IntArray(IntArray obj)
    {
        arr = new int[obj.Length];
        for (int i = 0; i < obj.Length; i++)
        {
            arr[i] = obj[i];
        }
    }

    
    public int this[int index]
    {
        get { return arr[index]; }
        set { arr[index] = value; }
    }

  
    public int Length
    {
        get { return arr.Length; }
    }

    public int[] Copy()
    {
        return arr.ToArray();
    }

    public void Print()
    {
        Console.WriteLine(string.Join(", ", arr));
    }

    public int SequentialSearch(int x)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
                return i;
        }
        return -1;
    }

    public int BinarySearch(int x)
    {
        Array.Sort(arr);
        int left = 0;
        int right = arr.Length - 1;
        int comparisons = 0;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == x)
                return mid;

            if (arr[mid] < x)
                left = mid + 1;
            else
                right = mid - 1;

            comparisons++;
        }

        return -1;
    }

    public int FindMaxPosition()
    {
        int max = arr.Max();
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (arr[i] == max)
                return i;
        }
        return -1;
    }

    public void RemoveFirstOccurrence(int x)
    {
        int index = SequentialSearch(x);
        if (index != -1)
        {
            arr = arr.Where((val, idx) => idx != index).ToArray();
        }
    }

    public void InsertAfterMax(int x)
    {
        int maxIndex = FindMaxPosition();
        if (maxIndex != -1)
        {
            int[] newArray = new int[arr.Length + 1];
            for (int i = 0; i <= maxIndex; i++)
            {
                newArray[i] = arr[i];
            }
            newArray[maxIndex + 1] = x;
            for (int i = maxIndex + 2; i < newArray.Length; i++)
            {
                newArray[i] = arr[i - 1];
            }
            arr = newArray;
        }
    }
}
public void hoanvi(ref int a, ref int b)
{
    int tam = a;
    a = b;
    b = tam;

}
public void InterchangeSort()
{
    int n = Array.Lenght;
    for (int i = 0; i < n; i++)
    {
        for (int j = i + 1; j < n; j++)
        {
            if (Array[i] > Array[j])
            {
                hoanvi(ref Array[i], ref Array[j]);
            }
        }
    }
}
public void InsertionSort()
{
    for (int i = 1; i < Array.Lenght; i++)
    {
        int temp = Array[i];
        int j = i - 1;
        while (j >= 0 && Array[j]> temp)
        {
            Array[j + 1] = Array[j];
            j--;
        }
        Arr[j + 1] = temp
    }
}
public void BubbleSort()
{
    for (int i = 0; i < arr.Lenght - 1; i++)
    {
        for (int j = 0; j < Arr.Lenght - i - 1; j++)
        {
            if (Arr[j] > arr[j + 1])
            {
                int temp = Arr[j];
                arr[j] = Arr[j + 1];
                Arr[j + 1] = temp 
            }
        }
    }
}
public void SelectionSort()
{
    int n = Arr.Lenght;
    for (int i =0; i < n - 1; i++)
    {
        int minIndex = i;
        for (int j = i + 1; j < n; j++)
        {
            if (arr[j] < arr[minIndex])
            {
                minIndex = j;
            }
        }
        int temp = arr[i];
        Arr[i] = Arr[minIndex];
        Arr[minIndex] = temp;
    }

}
public void QuickSort()
{
    if (left < right)
    {
        int pivot = Arr[(left + right) / 2];
        int i = left;
        int j = right;
        while (i <= j)
        {
            while (Arr[i] < pivot)
            {
                i++;
            }
            while
            {
                j--;
            }
            if (i <= j)
            {
                int temp = Arr[i];
                arr[j] = Arr[j];
                Arr[j] = temp;
                i++;
                j--;
            }    
        }

    }
}
public void shellSort()
{
    int n = Arr.Lenght;
    int gap = n / 2;
    while (gap > 0)
    {
        for (int i = gap; i < n; i++)
        {
            int temp = Arr[i];
            int j = i;
            while (j >= gap && Arr[j - gap] > temp)
            {
                Arr[j] = Arr[j - gap];
                j -= gap;
            }
            Arr[j] = temp;
        }
        gap /= 2;
    }
}
public void ShakerSort()
{
    int left = 0;
    int right = Array.Lenght - 1;
    while (left < right)
    {
        for (int i = left; i < right; i++)
        {
            if (Array[i] > Array[i + 1])
            {
                int temp = Array[i];
                Array[i] = Array[i + 1];
                Array[i + 1] = temp;
            }
        }
        right--;
        for (int i = right; i > left; i++)
        {
            if (Array[i] < Array[i - 1])
            {
                int temp = Array[i];
                Array[i] = Array[i - 1];
                Array[i - 1] = temp;
            }
        }
        left++;
    }
}
public void MergeSort()
{
    if (arr.Lenght <= 1)
        return;
    int mid = Arr.Lenght / 2;
    int[] left = Arr.Getrange(0, mid);
    int[] right = Arr.Getrange(mid, Arr.Lenght - mid);
    MergeSort(left);
    MergeSort(right);
    Merge(Arr, left, right);

}
class Program
{
    static void TestInterchangeSort(IntArray obj)
    {
        //Copy ojb sang objTam để sắp xếp
        IntArray objTam = new IntArray(obj);
        Console.WriteLine("\n>>Mang ban dau:");
        objTam.Xuat();
        objTam.InterchangeSort();
        Console.WriteLine("\n>>Interchange Sort:");
        objTam.Xuat();
    }
    static void TestInsertionSort(IntArray obj)
    {
        //Copy ojb sang objTam để sắp xếp
        IntArray objTam = new IntArray(obj);
        Console.WriteLine("\n>>Mang ban dau:");
        objTam.Xuat();
        2 / 2
    objTam.InsertionSort();
        Console.WriteLine("\n>>Insertion Sort:");
        objTam.Xuat();
    }
    //Test những phương pháp sắp xếp khác
    static void Main(string[] args)
    {
        IntArray obj = new IntArray(10);
        TestInterchangeSort(obj);
        TestInsertionSort(obj);
        //Tương tự cho những phương pháp khác
    }
}