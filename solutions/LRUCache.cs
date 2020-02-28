using System;
using System.Collections.Generic;
using System.Linq;
namespace InterviewPreparation
{
    // In Progress.......
    public class LRUCache {
        private LinkedList<KeyValuePair<int, int>> order = new LinkedList<KeyValuePair<int, int>>();

        //private SortedDictionary<int, int> order = new SortedDictionary<int, int>();
        private Dictionary<int, LinkedListNode<KeyValuePair<int, int>>> cache = new Dictionary<int, LinkedListNode<KeyValuePair<int, int>>>();
        private int capacity;
        private int length = 0;
        public LRUCache(int capacity) {
            this.capacity = capacity;    
        }
        
        public int Get(int key) {
            if (cache.ContainsKey(key))
            {
                // return cache[key].Value.
                
                // return cache[key].Value.Value;
            }
            return -1;
        }
        
        public void Put(int key, int value) {
            if (cache.ContainsKey(key))
            {
                // cache[key] = value;
            }
            else
            {
                if (length == capacity)
                {
                    removeLeastRecent();
                }
                else
                {
                    length++;
                }
                // cache.Add(key, value);
                //order.Add(key, 0);
            }
        }

        private void removeLeastRecent()
        {
            //var key = order.Keys.First();
            // cache.Remove(key);
            //order.Remove(key);
        }

        public class ListNode 
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}