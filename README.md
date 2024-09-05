# Project README

## 1. Big O Notation

### Insertion Sort

- **Time Complexity:**
  - **Worst Case:** O(n^2) (e.g., when the list is sorted in reverse order)
  - **Best Case:** O(n) (e.g., when the list is already sorted)
  - **Average Case:** O(n^2) (e.g., for a randomly ordered list)
- **Space Complexity:** O(1) (Uses a constant amount of extra space)

### Reverse Linked List

- **Time Complexity:** O(n) (Each node is visited once)
- **Space Complexity:** O(1) (Uses a constant amount of extra space)

## 2. Sorting Algorithms

### Quick Sort

- **Description:** Quick Sort is a sorting algorithm that selects a "pivot" element and partitions the array into elements less than and greater than the pivot. It then recursively sorts the sub-arrays.
- **Performance:**
  - **Average Case:** O(n log n)
  - **Worst Case:** O(n^2) (e.g., if the pivot is always the smallest or largest element)

### Bubble Sort

- **Description:** Bubble Sort repeatedly steps through the list, compares adjacent elements, and swaps them if they are in the wrong order. This continues until the list is sorted.
- **Performance:**
  - **Worst Case:** O(n^2) (e.g., when the list is in reverse order)
  - **Best Case:** O(n) (e.g., when the list is already sorted)

### Insertion Sort

- **Description:** Insertion Sort builds the sorted list one item at a time by inserting each item into its correct position within the sorted portion of the list.
- **Performance:**
  - **Worst Case:** O(n^2) (e.g., when the list is in reverse order)
  - **Best Case:** O(n) (e.g., when the list is already sorted)

## 3. Dijkstra's Algorithm

- **Description:** Dijkstra's Algorithm finds the shortest path from a starting node to all other nodes in a graph with non-negative weights.
- **Applications:**
  1. **GPS Navigation:** Helps find the shortest route on a map from your location to your destination.
  2. **Network Routing:** Determines the quickest path for data packets to travel through a network.

**How It Works:**
1. Start at the source node and set its distance to zero.
2. Update the distances to neighboring nodes.
3. Continue until all nodes have been processed.
