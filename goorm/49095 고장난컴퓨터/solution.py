def solve(input_timestamps, retention_time):
    input_count_on_screen = 0
    last_input_timestamp = 0

    for input_timestamp in input_timestamps:
        if input_timestamp - last_input_timestamp > retention_time:
            input_count_on_screen = 0
        input_count_on_screen += 1
        last_input_timestamp = input_timestamp

    return input_count_on_screen


user_input_1 = input()
user_input_2 = input()

(input_count, retention_time) = list(map(int, user_input_1.split(" ")))
input_timestamps = map(int, user_input_2.split(" "))

left_count = solve(input_timestamps, retention_time)
print(left_count)
