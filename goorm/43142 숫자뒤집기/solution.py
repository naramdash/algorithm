def solve(number_in_str: str):
    return int("".join(list(reversed(number_in_str))))


user_input = input()
result = solve(user_input)
print(result)
