import math


def solve(numbers_count: int, block_size: int):
    return math.ceil((numbers_count - 1) / (block_size - 1))


user_input_1 = input()
user_input_2 = input()

(numbers_count, block_size) = map(int, user_input_1.split(" "))
numbers = map(int, user_input_2)
result = solve(numbers_count, block_size)
print(result)
