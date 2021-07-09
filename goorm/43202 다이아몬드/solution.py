def solve(number: int):
    top_lines = [" " * ((number // 2) - i) + "*" * (2 * i + 1)
                 for i in range(0, number // 2)]
    if number % 2 == 0:
        return top_lines + list(reversed(top_lines))
    else:
        middle_line = ["*" * number]
        return top_lines + middle_line + list(reversed(top_lines))


user_input = input()
lines = solve(int(user_input))
for line in lines:
    print(line)
