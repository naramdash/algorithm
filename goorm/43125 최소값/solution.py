def solve(numbers):
    return min(numbers)


user_input_1 = input()
user_input_2 = input()

numbers = map(int, user_input_2.split(" "))
minimum = solve(numbers)
print(minimum)
