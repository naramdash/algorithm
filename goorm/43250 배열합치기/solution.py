from typing import Deque, List
from collections import deque


def recurse(a_deque: Deque[int], b_deque: Deque[int], acc: List[int]):
    if len(a_deque) == 0:
        return acc + list(b_deque)
    elif len(b_deque) == 0:
        return acc + list(a_deque)
    else:
        a, b = a_deque[0], b_deque[0]
        if a < b:
            acc.append(a_deque.popleft())
        else:
            acc.append(b_deque.popleft())
        return recurse(a_deque, b_deque, acc)


def solve(a_numbers: List[int], b_numbers: List[int]):
    return recurse(deque(a_numbers), deque(b_numbers), [])


user_input_1 = input()
user_input_2 = input()
user_input_3 = input()

(a_len, b_len) = map(int, user_input_1.split(" "))
a_numbers = map(int, user_input_2.split(" "))
b_numbers = map(int, user_input_3.split(" "))

result = solve(a_numbers, b_numbers)
print(*result, end=" ")
