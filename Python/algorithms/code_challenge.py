from __future__ import annotations


def longest_substring_without_repeating_characters(text: str) -> int:
    pointer_a = 0
    pointer_b = 0
    max_len = 0
    chars: set[str] = set()

    while pointer_b < len(text):
        if text[pointer_b] not in chars:
            chars.add(text[pointer_b])
            pointer_b += 1
            max_len = max(max_len, len(chars))
        else:
            chars.remove(text[pointer_a])
            pointer_a += 1
    return max_len
