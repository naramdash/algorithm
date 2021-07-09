from typing import Dict
from functools import reduce


def get_smallest_prime_factor(number: int, start: int):
    for i in range(start, number):
        if number % i == 0:
            return i
    return number


def recurse(prime_factor_dict: Dict[int, int], dividend: int, start_prime_factor_dict: int):
    if dividend == 1:
        return reduce(lambda acc, cur: acc * (cur[1] + 1), prime_factor_dict.items(), 1)

    prime_factor = get_smallest_prime_factor(dividend, start_prime_factor_dict)
    if prime_factor in prime_factor_dict:
        prime_factor_dict[prime_factor] += 1
    else:
        prime_factor_dict[prime_factor] = 1
    return recurse(prime_factor_dict, dividend // prime_factor, prime_factor)


def get_aliquot_count(number: int):
    if number == 1:
        return 1

    prime_factor_dict = {}
    dividend = number
    start_prime_factor_dict = 2
    return recurse(prime_factor_dict, dividend, start_prime_factor_dict)


def solve(one_based_index: int):
    return "yes" if get_aliquot_count(one_based_index) % 2 == 1 else "no"


user_input = input()
result = solve(int(user_input))
print(result)
