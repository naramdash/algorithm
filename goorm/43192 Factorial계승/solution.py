from functools import reduce


def solve(number: int):
    return reduce(lambda acc, cur: acc * cur, range(1, number + 1))


user_input = input()
result = solve(int(user_input))
print(result)
