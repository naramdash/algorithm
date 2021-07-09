def solve(number: int):
    aliquots = []
    max_range = number
    for i in range(1, number + 1):
        if i >= max_range:
            return sum(aliquots)
        if number % i == 0:
            max_range = number // i
            aliquots.append(i)
            if max_range != i:
                aliquots.append(max_range)
    return sum(aliquots)


user_input = input()
sum = solve(int(user_input))
print(sum)
