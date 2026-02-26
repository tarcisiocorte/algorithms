from __future__ import annotations


def factorial(number: int) -> int:
    if number <= 1:
        return 1
    return number * factorial(number - 1)


def print_generic_base(number: int, base_value: int) -> str:
    conversion = "0123456789ABCDEF"

    def _convert(value: int) -> str:
        digit = value % base_value
        value = value // base_value
        if value != 0:
            return _convert(value) + conversion[digit]
        return conversion[digit]

    return _convert(number)


def get_greatest_common_divisor(number_a: int, number_b: int) -> int:
    if number_a < number_b:
        return get_greatest_common_divisor(number_b, number_a)
    if number_a % number_b == 0:
        return number_b
    return get_greatest_common_divisor(number_b, number_a % number_b)


def execute_recursive_tower_of_hanoi(
    number: int, source: str, distance: str, temp: str
) -> list[str]:
    moves: list[str] = []

    def _solve(n: int, src: str, dst: str, aux: str) -> None:
        if n < 1:
            return
        _solve(n - 1, src, aux, dst)
        moves.append(f"Move {n} disk from peg {src} to peg {dst}")
        _solve(n - 1, aux, dst, src)

    _solve(number, source, distance, temp)
    return moves
