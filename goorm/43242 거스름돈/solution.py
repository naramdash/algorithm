def solve(amount: int):
    remainder = 1000 - amount
    coin_500_count = remainder // 500
    coin_100_count = (remainder - coin_500_count * 500) // 100
    coin_50_count = (remainder - coin_500_count * 500 -
                     coin_100_count * 100) // 50
    coin_10_count = (remainder - coin_500_count * 500 -
                     coin_100_count * 100 - coin_50_count * 50) // 10
    return (coin_500_count, coin_100_count, coin_50_count, coin_10_count)


user_input = input()
(coin_500_count, coin_100_count, coin_50_count,
 coin_10_count) = solve(int(user_input))
print(coin_500_count, coin_100_count, coin_50_count, coin_10_count, end=" ")
