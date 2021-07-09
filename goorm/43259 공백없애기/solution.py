def solve(input: str):
    return list(filter(lambda x: x != " ", input))


user_input = input()
filtered = solve(user_input)
print("".join(filtered))
