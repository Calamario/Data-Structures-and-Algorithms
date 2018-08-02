# Quick Sort
Time: O(n log(n))
Space: O(h)

Quick sort, sorts an array by taking a pivot and partitioning the rest,
through recursion. Partistioning takes a LB and RB
and LB keeps moving until it meets a value larger
than the pivot. The RB moves left looking for values
less than the pivot. Once it does it swaps. And once
the bounds cross we swap back the pivot and recursivly do 
the same for left and right.

