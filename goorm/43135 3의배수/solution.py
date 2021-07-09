def solve(end_of_range: int):
    for number in range(1, end_of_range + 1):
        if number % 3 == 0:
            yield "X"
        else:
            yield str(number)


user_input = input()
outputs = solve(int(user_input))
print(*outputs, end=" ")
