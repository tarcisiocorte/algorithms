import unittest

from algorithms.recursive import (
    execute_recursive_tower_of_hanoi,
    factorial,
    get_greatest_common_divisor,
    print_generic_base,
)


class RecursiveTests(unittest.TestCase):
    def test_factorial(self):
        self.assertEqual(factorial(5), 120)

    def test_greatest_common_divisor(self):
        self.assertEqual(get_greatest_common_divisor(54, 24), 6)

    def test_print_generic_base(self):
        self.assertEqual(print_generic_base(100, 10), "100")
        self.assertEqual(print_generic_base(255, 16), "FF")

    def test_tower_of_hanoi(self):
        moves = execute_recursive_tower_of_hanoi(2, "A", "C", "B")
        self.assertEqual(
            moves,
            [
                "Move 1 disk from peg A to peg B",
                "Move 2 disk from peg A to peg C",
                "Move 1 disk from peg B to peg C",
            ],
        )


if __name__ == "__main__":
    unittest.main()
