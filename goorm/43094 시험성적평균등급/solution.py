def solve(scores):
    """make average and grade from scores"""
    average = round(sum(scores) / len(scores), 2)
    grade = "F"
    if average >= 90:
        grade = "A"
    elif average >= 80:
        grade = "B"
    elif average >= 70:
        grade = "C"
    elif average >= 60:
        grade = "D"
    return (average, grade)


user_input = input()
scores = list(map(int, user_input.split(' ')))

(average, grade) = solve(scores)
print(format(average, ".2f"), grade, sep=" ")
