namespace LeedCode.HashMap_HashSet;

public class LRUCache
{
    private readonly int capacity;
    private readonly Dictionary<int, LinkedListNode<CacheItem>> cacheMap;
    private readonly LinkedList<CacheItem> cacheList;

    public LRUCache(int capacity)
    {
        this.capacity = capacity;
        cacheMap = new Dictionary<int, LinkedListNode<CacheItem>>(capacity);
        cacheList = new LinkedList<CacheItem>();
    }

    public int Get(int key)
    {
        if (cacheMap.TryGetValue(key, out LinkedListNode<CacheItem>? node) && node != null)
        {
            cacheList.Remove(node);
            cacheList.AddFirst(node);

            return node.Value.Value;
        }
        return -1;
    }

    public void Put(int key, int value)
    {
        if (cacheMap.TryGetValue(key, out LinkedListNode<CacheItem>? node) && node != null)
        {
            node.Value.Value = value;

            cacheList.Remove(node);
            cacheList.AddFirst(node);
        }
        else
        {
            if (cacheList.Count >= capacity)
            {
                LinkedListNode<CacheItem>? lastNode = cacheList.Last;
                if (lastNode != null)
                {

                    cacheMap.Remove(lastNode.Value.Key);
                    cacheList.RemoveLast();
                }
            }
            LinkedListNode<CacheItem> newNode = new LinkedListNode<CacheItem>(new CacheItem(key, value));
            cacheMap.Add(key, newNode);
            cacheList.AddFirst(newNode);
        }
    }

    private class CacheItem
    {
        public int Key { get; }
        public int Value { get; set; }
        public CacheItem(int key, int value)
        {
            Key = key;
            Value = value;
        }
    }
}

