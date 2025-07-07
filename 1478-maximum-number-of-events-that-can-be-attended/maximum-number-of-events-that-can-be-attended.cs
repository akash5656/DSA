public class Solution {
    public int MaxEvents(int[][] events) {
        Array.Sort(events, (a, b) => a[0].CompareTo(b[0])); // sort by start day

        int day = 0, i = 0, attended = 0;
        int n = events.Length;

        // Min-heap based on event end days
        var minHeap = new PriorityQueue<int, int>();

        // Determine the last possible day
        int lastDay = events.Max(e => e[1]);

        for (day = 1; day <= lastDay; day++) {
            // Add all events that start today
            while (i < n && events[i][0] == day) {
                minHeap.Enqueue(events[i][1], events[i][1]); // enqueue by end day
                i++;
            }

            // Remove events that have already ended before today
            while (minHeap.Count > 0 && minHeap.Peek() < day) {
                minHeap.Dequeue();
            }

            // Attend the event that ends earliest (greedy)
            if (minHeap.Count > 0) {
                minHeap.Dequeue();
                attended++;
            }
        }

        return attended;
    }
}