from __future__ import annotations


def hourglass_sum(arr: list[list[int]]) -> int:
    if len(arr) < 3 or any(len(row) < 3 for row in arr):
        return 0

    best = -10**9
    for i in range(len(arr) - 2):
        for j in range(len(arr[i]) - 2):
            current = (
                arr[i][j]
                + arr[i][j + 1]
                + arr[i][j + 2]
                + arr[i + 1][j + 1]
                + arr[i + 2][j]
                + arr[i + 2][j + 1]
                + arr[i + 2][j + 2]
            )
            best = max(best, current)
    return best
