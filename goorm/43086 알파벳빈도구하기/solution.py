from functools import reduce
from string import ascii_lowercase


def solve(sentence: str):
    empty_dict = {c: 0 for c in ascii_lowercase}
    for c in sentence:
        lowered_c = c.lower()
        if lowered_c in ascii_lowercase:
            empty_dict[lowered_c] = empty_dict[lowered_c] + 1
    return sorted(empty_dict.items(), key=lambda item: item[0])


user_input = input()
frequencies = solve(user_input)
for f in frequencies:
    print(f[0], ":", f[1])
