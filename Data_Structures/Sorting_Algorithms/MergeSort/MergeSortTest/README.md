# Merge
Time: O(n log(n))
Space: O(log(n))

Insertion Sort takes in an unsorted array and return 
a sorted one. It starts by splitting the array into
equal halves until only one unit remains in the array,
compares the value with its other half and sorts them.
As the halves get larger the front of the array is
compared to the other half's front value. This is 
recursively done until the array is reconstructed.

![mergesort](../../../../assets/mergesort_visual.jpg)
