def solve(year: int):
    if year % 400 == 0:
        return True
    elif year % 100 == 0:
        return False
    elif year % 4 == 0:
        return True
    else:
        return False


user_input = input()
answer = solve(int(user_input))
print("Leap Year" if answer else "Not Leap Year")
