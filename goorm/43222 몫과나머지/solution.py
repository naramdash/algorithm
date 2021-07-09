def solve(dividend: int, divisor: int):
    quotient = dividend // divisor
    remainder = dividend % divisor
    return (quotient, remainder)


user_input = input()
(dividend, divisor) = map(int, user_input.split(" "))
(quotient, remainder) = solve(dividend, divisor)
print(quotient, remainder)
