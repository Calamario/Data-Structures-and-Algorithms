# Radix Sort
Time: O(kn) where k is the number of digits
Space: O(n + k)

Radix sort is a stable sort that is potentially more efficient than comparison based
sort algorithms. It takes each digit of each value starting from the ones unit and 
places them in a list of 10 queues. Once all values are placed in the queue, it is then
placed back into the array. This continues until all digits have been sorted.

![quicksort](../../../assets/quicksort_visual.jpg)