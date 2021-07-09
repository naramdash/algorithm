import math


def solve(number: int):
    for i in range(2, math.ceil(math.sqrt(number))):
        if number % i == 0:
            return False
    return True


user_input = input()
answer = solve(int(user_input))
print("True" if answer else "False")
