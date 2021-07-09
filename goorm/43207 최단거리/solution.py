from typing import List
from functools import reduce


def solve(positions: List[int]):
    sorted_positions = sorted(positions)
    distances_in_positions = reduce(lambda acc, cur: acc + [sorted_positions[cur] -
                                    sorted_positions[cur - 1]], range(1, len(sorted_positions)), [])
    return min(distances_in_positions)


user_input_1 = input()
user_input_2 = input()
positions = map(int, user_input_2.split(" "))
minimum = solve(positions)
print(minimum)
