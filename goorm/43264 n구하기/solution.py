from itertools import count


def solve(sum: int):
    for i in count(1):
        sum -= i
        if sum <= 0:
            return i


user_input = input()
number = solve(int(user_input))
print(number)
