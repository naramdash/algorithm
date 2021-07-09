from functools import reduce


def solve(init: int, rate: float, year: int):
    return reduce(lambda acc, cur: acc * cur, [(100 + rate)/100] * year, init)


user_input = input()
input_segments = user_input.split(" ")
init, rate, year = int(input_segments[0]), float(
    input_segments[1]), int(input_segments[2])
repayment = solve(init, rate, year)
print(format(repayment, ".2f"))
