namespace DesignHashMap;

internal class Program
{
    static void Main(string[] args)
    {
        MyHashMap hashMap = new MyHashMap();

        hashMap.Put(1, 1);
        hashMap.Put(2, 2);
        Console.WriteLine(hashMap.Get(1)); // output: 1
        Console.WriteLine(hashMap.Get(2)); // output: 2
        Console.WriteLine(hashMap.Get(3)); // output: -1
        hashMap.Put(2, 1);
        Console.WriteLine(hashMap.Get(2)); // output: 1
        hashMap.Remove(2);
        Console.WriteLine(hashMap.Get(2)); // output: -1
    }
}


public class MyHashMap
{
    private List<(int key, int value)>[] buckets;
    private int size;
    public MyHashMap()
    {
        size = 769;
        buckets = new List<(int key, int value)>[size];

        for (int i = 0; i < size; i++)
        {
            buckets[i] = new List<(int key, int value)>();
        }
    }

    public void Put(int key, int value)
    {
        var index = GetBucketIndex(key);

        var bucket = buckets[index];

        for (int i = 0; i < bucket.Count; i++)
        {
            if (bucket[i].key == key)
            {
                bucket[i] = (key, value);
                return;
            }
        }

        bucket.Add((key, value));
    }

    public int Get(int key)
    {
        var index = GetBucketIndex(key);

        var bucket = buckets[index];

        foreach (var kv in bucket)
        {
            if (kv.key == key)
                return kv.value;
        }

        return -1;
    }

    public void Remove(int key)
    {
        var index = GetBucketIndex(key);

        var bucket = buckets[index];

        for (int i = 0; i < bucket.Count; i++)
        {
            if (bucket[i].key == key)
            {
                bucket.RemoveAt(i);
                return;
            }
        }
    }

    private int GetBucketIndex(int key)
    {
        return key % size;
    }
}