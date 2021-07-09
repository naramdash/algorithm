def calc_movement_from_amount(amount: int):
    return amount // 2 + amount % 2


def solve(jinu_amount_init, sunu_amount_init, day_after):
    jinu_amount = jinu_amount_init
    sunu_amount = sunu_amount_init

    for day in range(1, day_after + 1):
        if day % 2 == 1:
            movement = calc_movement_from_amount(jinu_amount)
            jinu_amount -= movement
            sunu_amount += movement
        else:
            movement = calc_movement_from_amount(sunu_amount)
            sunu_amount -= movement
            jinu_amount += movement

    return (jinu_amount, sunu_amount)


user_input_1 = input()
user_input_2 = input()

(jinu_amount_init, sunu_amount_init) = map(int, user_input_1.split(" "))
day_after = int(user_input_2)

(jinu_amount, sunu_amount) = solve(jinu_amount_init, sunu_amount_init, day_after)
print(jinu_amount, sunu_amount)
