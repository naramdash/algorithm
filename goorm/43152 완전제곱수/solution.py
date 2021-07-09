from math import sqrt
from typing import List


def solve(numbers: List[int]):
    return len(list(filter(lambda number: sqrt(number).is_integer(), numbers)))


user_input = input()
user_inputs = []
for i in range(int(user_input)):
    user_inputs.append(input())

numbers = map(int, user_inputs)
answer = solve(numbers)
print(answer)
