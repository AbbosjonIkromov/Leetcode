namespace DesignHashSet;

internal class Program
{
    static void Main(string[] args)
    {
        MyHashSet hashSet = new MyHashSet();

        hashSet.Add(1);
        hashSet.Add(2);

        Console.WriteLine(hashSet.Contains(1)); // output: true
        Console.WriteLine(hashSet.Contains(3)); // output: false

        hashSet.Add(2);
        Console.WriteLine(hashSet.Contains(2)); // output: true

        hashSet.Remove(2);

        Console.WriteLine(hashSet.Contains(2)); // output: false
    }
}



public class MyHashSet
{
    private List<int>[] buckets;
    private int size;

    public MyHashSet()
    {
        size = 769;
        buckets = new List<int>[size];

        for (int i = 0; i < size; i++)
        {
            buckets[i] = new List<int>();
        }
    }

    private int GetBucketIndex(int key)
    {
        return key % size;
    }

    public void Add(int key)
    {
        int index = GetBucketIndex(key);

        var bucket = buckets[index];

        if (!bucket.Contains(key))
        {
            bucket.Add(key);
        }
    }

    public void Remove(int key)
    {
        int index = GetBucketIndex(key);

        var bucket = buckets[index];

        if (bucket.Contains(key))
        {
            bucket.Remove(key);
        }
    }

    public bool Contains(int key)
    {
        int index = GetBucketIndex(key);

        var bucket = buckets[index];

        return bucket.Contains(key);
    }
}