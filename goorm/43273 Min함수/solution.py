def solve(numbers):
    return min(numbers)


user_input = input()

numbers = map(int, user_input.split(" "))
minimum = solve(numbers)
print(minimum)
