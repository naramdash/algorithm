def solve(sentence: str, find_character: str):
    return len([None for character in sentence if character == find_character])


user_input_1 = input()
user_input_2 = input()
count = solve(user_input_1, user_input_2)
print(count)
