def solve(base: int, height: int):
    return base * height / 2


user_input = input()
(base, height) = map(int, user_input.split(" "))
area = solve(base, height)
print(format(area, ".1f"))
