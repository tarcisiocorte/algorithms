from __future__ import annotations


def dynamic_array(n: int, queries: list[list[int]]) -> list[int]:
    seq_list: list[list[int]] = [[] for _ in range(n)]
    result: list[int] = []
    last_answer = 0

    for query in queries:
        query_type, x = query[0], query[1]
        y = query[2] if len(query) > 2 else 0
        index = (x ^ last_answer) % n

        if query_type == 1:
            seq_list[index].append(y)
        elif query_type == 2 and seq_list[index]:
            index_array_two = y % len(seq_list[index])
            last_answer = seq_list[index][index_array_two]
            result.append(last_answer)

    return result


def get_nth_ugly_number(number: int) -> int:
    ugly_array = [0] * number
    ugly_array[0] = 1

    index2 = index3 = index5 = 0
    next_multiple_of2 = 2
    next_multiple_of3 = 3
    next_multiple_of5 = 5
    next_ugly_number = 1

    for i in range(1, number):
        next_ugly_number = min(next_multiple_of2, next_multiple_of3, next_multiple_of5)
        ugly_array[i] = next_ugly_number

        if next_ugly_number == next_multiple_of2:
            index2 += 1
            next_multiple_of2 = ugly_array[index2] * 2
        if next_ugly_number == next_multiple_of3:
            index3 += 1
            next_multiple_of3 = ugly_array[index3] * 3
        if next_ugly_number == next_multiple_of5:
            index5 += 1
            next_multiple_of5 = ugly_array[index5] * 5

    return next_ugly_number


def get_nth_ugly_number_by_recursive(n: int) -> int:
    i = 1
    count = 1
    while n > count:
        i += 1
        if is_ugly_number(i) == 1:
            count += 1
    return i


def max_divide(a_number: int, b_number: int) -> int:
    while a_number % b_number == 0:
        a_number = a_number // b_number
    return a_number


def is_ugly_number(number: int) -> int:
    number = max_divide(number, 2)
    number = max_divide(number, 3)
    number = max_divide(number, 5)
    return 1 if number == 1 else 0
