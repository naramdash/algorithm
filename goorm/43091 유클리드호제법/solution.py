def solve(x: int, y: int):
    a = max(x, y)
    b = min(x, y)
    if b == 0:
        return a
    r = a % b
    return solve(b, r)


user_input = input()
(x, y) = map(int, user_input.split(" "))
result = solve(x, y)
print(result)
