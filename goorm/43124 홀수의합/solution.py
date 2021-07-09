def solve(a: int, b: int):
    return sum([i for i in range(a, b + 1) if i % 2 == 1])


user_input = input()
(a, b) = map(int, user_input.split(" "))
result = solve(a, b)
print(result)
