def amount_of_369(number: int):
    stringfied = str(number)

    count = 0
    for char in stringfied:
        if "3" in char or "6" in char or "9" in char:
            count += 1
    return count


def solve(end_of_range: int):
    clap_count = 0
    for number in range(1, end_of_range):
        clap_count += amount_of_369(number)
    return clap_count


user_input = input()
clap_count = solve(int(user_input))
print(clap_count)
