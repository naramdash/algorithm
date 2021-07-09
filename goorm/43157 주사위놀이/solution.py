def solve(number: int):
    pairs = []
    breakpoint = (number // 2) + 1
    for dice1 in range(1, 6 + 1):
        if dice1 >= breakpoint:
            return sorted(pairs, key=lambda dices: dices[0])
        dice2 = number - dice1
        if dice2 <= 6:
            pairs.append((dice1, dice2))
            breakpoint = dice2 - 1
            if dice2 != dice1:
                pairs.append((dice2, dice1))


user_input = input()
pairs = solve(int(user_input))
for pair in pairs:
    print(pair[0], pair[1])
