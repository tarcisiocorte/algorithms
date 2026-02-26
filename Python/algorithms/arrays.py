from __future__ import annotations


def sequential_search(array: list[int], search_value: int) -> int:
    for i, value in enumerate(array):
        if value == search_value:
            return i
    return -1


def print_array_data(array: list[int]) -> None:
    for value in array:
        print(value)


def sum_array(array: list[int]) -> int:
    total = 0
    for value in array:
        total += value
    return total


def two_dimension_array_example(rows: int, cols: int) -> list[list[int]]:
    count = 0
    grid: list[list[int]] = []
    for _ in range(rows):
        row = []
        for _ in range(cols):
            row.append(count)
            count += 1
        grid.append(row)
    return grid


def binary_search(array: list[int], value: int) -> int:
    lower = 0
    higher = len(array) - 1
    while lower <= higher:
        middle = lower + (higher - lower) // 2
        if array[middle] == value:
            return middle
        if array[middle] < value:
            lower = middle + 1
        else:
            higher = middle - 1
    return -1


def binary_search_recursive(array: list[int], low: int, high: int, value: int) -> int:
    if low > high:
        return -1
    mid = low + (high - low) // 2
    if array[mid] == value:
        return mid
    if array[mid] < value:
        return binary_search_recursive(array, mid + 1, high, value)
    return binary_search_recursive(array, low, mid - 1, value)


def max_subarray_sum(array: list[int]) -> int:
    max_so_far = 0
    max_ending_here = 0
    for value in array:
        max_ending_here += value
        if max_ending_here < 0:
            max_ending_here = 0
        if max_so_far < max_ending_here:
            max_so_far = max_ending_here
    return max_so_far


def reverse_array(array: list[int], start: int, end: int) -> None:
    i = start
    j = end
    while i < j:
        array[i], array[j] = array[j], array[i]
        i += 1
        j -= 1


def permutations(array: list[int], init: int = 0) -> list[list[int]]:
    if init == len(array):
        return [array.copy()]

    result: list[list[int]] = []
    for i in range(init, len(array)):
        array[init], array[i] = array[i], array[init]
        result.extend(permutations(array, init + 1))
        array[init], array[i] = array[i], array[init]
    return result


def two_sum_with_dictionary(nums: list[int], target: int) -> list[int]:
    if len(nums) <= 1:
        return []
    lookup: dict[int, int] = {}
    for i, number in enumerate(nums):
        complement = target - number
        if complement in lookup:
            return [lookup[complement], i]
        if number not in lookup:
            lookup[number] = i
    return []
