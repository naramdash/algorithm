def solve(a: int, b: int):
    return a + b


user_input = input()
(a, b) = map(int, user_input.split(" "))
result = solve(a, b)
print(result)
