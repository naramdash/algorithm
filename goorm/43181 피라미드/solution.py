def solve(height: int):
    for i in range(1, height + 1):
        yield ''.join([" " for _ in range(height - i)]) + ''.join(["*" for _ in range(2*i - 1)])


user_input = input()
lines = solve(int(user_input))
for line in lines:
    print(line)
