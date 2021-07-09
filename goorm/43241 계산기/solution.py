def solve(operator: str, num1: int, num2: int):
    if operator == "+":
        return num1 + num2
    elif operator == "-":
        return num1 - num2
    elif operator == "*":
        return num1 * num2
    else:
        return num1 / num2


user_input = input()
(num1_in_str, operator, num2_in_str) = user_input.split(" ")
result = solve(operator, int(num1_in_str), int(num2_in_str))

if type(result) is int:
    print(result)
else:
    print(format(result, ".2f"))
