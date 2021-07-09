def solve(line: str):
    return len(list(filter(lambda x: x != "", line.split(" "))))


user_input = input()
count = solve(user_input)
print(count)
