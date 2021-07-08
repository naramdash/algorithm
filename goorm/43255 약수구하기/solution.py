def solve(input: int):
    for number in range(1, input + 1):
        if input % number == 0:
            yield number


user_input = input()
solution = solve(int(user_input))

for i in solution:
    print(i, end=" ")
