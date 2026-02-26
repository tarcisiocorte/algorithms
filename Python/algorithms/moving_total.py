from __future__ import annotations


class MovingTotal:
    def __init__(self) -> None:
        self.items: list[int] = []

    def append(self, values: list[int]) -> None:
        self.items.extend(values)

    def contains(self, total: int) -> bool:
        if len(self.items) < 3:
            return False

        for i in range(len(self.items) - 2):
            if self.items[i] + self.items[i + 1] + self.items[i + 2] == total:
                return True
        return False
