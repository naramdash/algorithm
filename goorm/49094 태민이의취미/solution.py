def solve(end_of_range: int):
    # return sum(map(lambda x: x*x*x, range(1, end_of_range + 1))) % 1000000007
    return (((end_of_range * (end_of_range + 1)) ** 2) // 4) % 1000000007


user_input = input()
sum_of_volumes = solve(int(user_input))
print(sum_of_volumes)
