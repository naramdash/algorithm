def solve(end_of_range: int):
    for number in range(end_of_range, 0, -1):
        yield ''.join(['*' for i in range(number)])


user_input = input()
lines = solve(int(user_input))

for line in lines:
    print(line)
