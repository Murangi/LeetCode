public class LRUCache {

    private readonly int capacity;
    private readonly Dictionary<int, LinkedListNode<(int key, int value)>> cacheMap;
    private readonly LinkedList<(int key, int value)> usageList;

    public LRUCache(int capacity)
    {
        this.capacity = capacity;
        this.cacheMap = new Dictionary<int, LinkedListNode<(int key, int value)>>(capacity);
        this.usageList = new LinkedList<(int key, int value)>();
    }

    public int Get(int key)
    {
        if (!cacheMap.TryGetValue(key, out var node))
            return -1;

        // Move accessed node to front (most recently used)
        usageList.Remove(node);
        usageList.AddFirst(node);

        return node.Value.value;
    }

    public void Put(int key, int value)
    {
        if (cacheMap.TryGetValue(key, out var node))
        {
            // Update value and move to front
            usageList.Remove(node);
        }
        else if (cacheMap.Count == capacity)
        {
            // Remove least recently used
            var lruNode = usageList.Last;
            cacheMap.Remove(lruNode.Value.key);
            usageList.RemoveLast();
        }

        var newNode = new LinkedListNode<(int key, int value)>((key, value));
        usageList.AddFirst(newNode);
        cacheMap[key] = newNode;
    }
}


/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */