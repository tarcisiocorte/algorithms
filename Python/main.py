from algorithms.code_challenge import longest_substring_without_repeating_characters


def execute_longest_substring_without_repeating_characters() -> None:
    text = "abcabcbb"
    result = longest_substring_without_repeating_characters(text)
    print(f"The longest substring without repeating characters is {result}")


if __name__ == "__main__":
    execute_longest_substring_without_repeating_characters()
