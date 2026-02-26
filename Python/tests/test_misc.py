import unittest

from algorithms.code_challenge import longest_substring_without_repeating_characters
from algorithms.hourglass import hourglass_sum
from algorithms.moving_total import MovingTotal


class MiscAlgorithmTests(unittest.TestCase):
    def test_longest_substring_without_repeating_characters(self):
        self.assertEqual(longest_substring_without_repeating_characters("abcabcbb"), 3)
        self.assertEqual(longest_substring_without_repeating_characters("bbbbb"), 1)

    def test_hourglass_sum(self):
        matrix = [
            [1, 1, 1, 0, 0, 0],
            [0, 1, 0, 0, 0, 0],
            [1, 1, 1, 0, 0, 0],
            [0, 0, 2, 4, 4, 0],
            [0, 0, 0, 2, 0, 0],
            [0, 0, 1, 2, 4, 0],
        ]
        self.assertEqual(hourglass_sum(matrix), 19)

    def test_moving_total(self):
        moving_total = MovingTotal()
        moving_total.append([1, 2, 3, 4])
        self.assertTrue(moving_total.contains(6))
        self.assertTrue(moving_total.contains(9))
        self.assertFalse(moving_total.contains(7))


if __name__ == "__main__":
    unittest.main()
