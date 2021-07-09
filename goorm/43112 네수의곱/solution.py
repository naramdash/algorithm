def mul(n1, n2):
    return n1 * n2


def solve(ns):
    return mul(mul(ns[0], ns[1]), mul(ns[2], ns[3]))


user_input = input()
numbers = list(map(int, user_input.split(" ")))
multipled = solve(numbers)
print(multipled)
