import unittest

from algorithms.arrays import (
    binary_search,
    binary_search_recursive,
    max_subarray_sum,
    permutations,
    reverse_array,
    sequential_search,
    sum_array,
    two_dimension_array_example,
    two_sum_with_dictionary,
)


class ArraysTests(unittest.TestCase):
    def test_sequential_search(self):
        self.assertEqual(sequential_search([1, 2, 3, 4], 3), 2)
        self.assertEqual(sequential_search([1, 2, 3, 4], 9), -1)

    def test_sum_array(self):
        self.assertEqual(sum_array([1, 2, 3, 4]), 10)

    def test_binary_search(self):
        array = [10, 12, 20, 28, 29, 45, 48, 50]
        self.assertEqual(binary_search(array, 29), 4)
        self.assertEqual(binary_search_recursive(array, 0, len(array) - 1, 45), 5)
        self.assertEqual(binary_search_recursive(array, 0, len(array) - 1, 19), -1)

    def test_max_subarray_sum(self):
        self.assertEqual(max_subarray_sum([-1, -2, 3, 4, -4, 6, -14, 8, 2]), 10)

    def test_reverse_array(self):
        values = [1, 2, 3, 4, 5]
        reverse_array(values, 1, 3)
        self.assertEqual(values, [1, 4, 3, 2, 5])

    def test_permutations(self):
        result = permutations([1, 2, 3])
        self.assertEqual(len(result), 6)

    def test_two_sum_with_dictionary(self):
        self.assertEqual(two_sum_with_dictionary([2, 7, 11, 15], 9), [0, 1])
        self.assertEqual(two_sum_with_dictionary([1], 3), [])

    def test_two_dimension_array_example(self):
        grid = two_dimension_array_example(2, 3)
        self.assertEqual(grid, [[0, 1, 2], [3, 4, 5]])


if __name__ == "__main__":
    unittest.main()
