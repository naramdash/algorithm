def sum_of_aliquots_without_self(number: int):
    aliquots = []
    max_range = number
    for i in range(1, number + 1):
        if i >= max_range:
            return sum(aliquots)
        if number % i == 0:
            max_range = number // i
            aliquots.append(i)
            if max_range != i and max_range != number:
                aliquots.append(max_range)
    return sum(aliquots)


def solve(start: int, end: int):
    return [i for i in range(start, end + 1) if sum_of_aliquots_without_self(i) == i]


user_input = input()
(start, end) = map(int, user_input.split(" "))
complete_numbers = solve(start, end)
print(" ".join(map(str, complete_numbers)), end=" ")
