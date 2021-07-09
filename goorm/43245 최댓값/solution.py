from typing import List


def solve(numbers: List[int]):
    maximum = max(numbers)
    index = numbers.index(maximum)
    return (maximum, index)


_ = input()
user_input = input()
numbers = list(map(int, user_input.split(" ")))
(maximum, index) = solve(numbers)
print(maximum, index + 1)
