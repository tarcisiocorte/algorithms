import unittest

from algorithms.dynamic_programming import (
    dynamic_array,
    get_nth_ugly_number,
    get_nth_ugly_number_by_recursive,
    is_ugly_number,
)


class DynamicProgrammingTests(unittest.TestCase):
    def test_dynamic_array(self):
        queries = [
            [1, 0, 5],
            [1, 1, 7],
            [1, 0, 3],
            [2, 1, 0],
            [2, 1, 1],
        ]
        self.assertEqual(dynamic_array(2, queries), [7, 3])

    def test_get_nth_ugly_number(self):
        self.assertEqual(get_nth_ugly_number(10), 12)
        self.assertEqual(get_nth_ugly_number_by_recursive(10), 12)

    def test_is_ugly_number(self):
        self.assertEqual(is_ugly_number(6), 1)
        self.assertEqual(is_ugly_number(14), 0)


if __name__ == "__main__":
    unittest.main()
