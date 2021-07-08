def main():
    """Print Sum of multiple of 3 or 5 from 1 to input"""
    user_input: str = input()
    end_of_range = int(user_input)
    sum = 0

    for number in range(3, end_of_range + 1):
        if number % 3 == 0 or number % 5 == 0:
            sum += number

    print(sum)


main()
