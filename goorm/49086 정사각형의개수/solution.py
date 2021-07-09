def solve(length: int):
    return length * (length + 1) * (2 * length + 1) // 6


user_input = input()
square_count = solve(int(user_input))
print(square_count)
