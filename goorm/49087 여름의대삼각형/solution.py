def solve(x1, x2, x3, y1, y2, y3):
    slope1to2 = abs((y2 - y1) / (x2 - x1))
    slope2to3 = abs((y3 - y2) / (x3 - x2))

    if slope1to2 == slope2to3:
        return 0

    return round(abs((x1 * y2 + x2 * y3 + x3 * y1) - (x2 * y1 + x3 * y2 + x1*y3)) / 2, 2)


user_input_1 = input()
user_input_2 = input()
user_input_3 = input()

(x1, y1) = map(int, user_input_1.split(" "))
(x2, y2) = map(int, user_input_2.split(" "))
(x3, y3) = map(int, user_input_3.split(" "))

area = solve(x1, x2, x3, y1, y2, y3)
print(format(area, ".2f"))
