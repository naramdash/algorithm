def solve(team_count: int):
    sum = 0
    for number in range(1, team_count):
        sum += number
    return sum


user_input = input()
game_count = solve(int(user_input))
print(game_count)
