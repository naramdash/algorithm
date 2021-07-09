from typing import List, Tuple
from enum import Enum
from itertools import count


class Direction(Enum):
    UP = 1
    RIGHT = 2
    DOWN = 3
    LEFT = 4


def get_next_direction(direction: Direction):
    if direction == Direction.RIGHT:
        return Direction.DOWN
    elif direction == Direction.DOWN:
        return Direction.LEFT
    elif direction == Direction.LEFT:
        return Direction.UP
    else:
        return Direction.RIGHT


def draw_line(map: List[List[str]], start_pos: Tuple[int, int], end_pos: Tuple[int, int], direction: Direction):
    (start_pos_y, start_pos_x) = start_pos
    (end_pos_y, end_pos_x) = end_pos
    if direction == Direction.RIGHT:
        for x in range(start_pos_x, end_pos_x + 1, 1):
            map[start_pos_y][x] = "#"
    elif direction == Direction.DOWN:
        for y in range(start_pos_y, end_pos_y + 1, 1):
            map[y][start_pos_x] = "#"
    elif direction == Direction.LEFT:
        for x in range(start_pos_x, end_pos_x - 1, -1):
            map[start_pos_y][x] = "#"
    else:
        for y in range(start_pos_y, end_pos_y - 1, -1):
            map[y][start_pos_x] = "#"


def get_end_position(start_pos: Tuple[int, int], direction: Direction, map: List[List[str]]):
    (start_pos_y, start_pos_x) = start_pos
    if direction == Direction.RIGHT:
        for pos_x in count(start_pos_x + 2, 1):
            if pos_x >= len(map):
                return (start_pos_y, len(map) - 1)
            if map[start_pos_y][pos_x] == "#":
                return (start_pos_y, pos_x - 2)
    elif direction == Direction.DOWN:
        for pos_y in count(start_pos_y + 2, 1):
            if pos_y >= len(map):
                return (len(map) - 1, start_pos_x)
            if map[pos_y][start_pos_x] == "#":
                return (pos_y - 2, start_pos_x)
    elif direction == Direction.LEFT:
        for pos_x in count(start_pos_x - 2, -1):
            if pos_x < 0:
                return (start_pos_y, 0)
            if map[start_pos_y][pos_x] == "#":
                return (start_pos_y, pos_x + 2)
    else:
        for pos_y in count(start_pos_y - 2, -1):
            if pos_y < 0:
                return (0, start_pos_x)
            if map[pos_y][start_pos_x] == "#":
                return (pos_y + 2, start_pos_x)


def recurse(map: List[List[str]], start_pos: Tuple[int, int], direction: Direction):
    end_pos = get_end_position(start_pos, direction, map)
    if start_pos == end_pos:
        return map

    draw_line(map, start_pos, end_pos, direction)
    return recurse(map, end_pos, get_next_direction(direction))


def solve(number: int):
    map = [[" " for _ in range(number)] for _ in range(number)]
    return recurse(map, (0, 0), Direction.RIGHT)


user_input = input()
lines = solve(int(user_input))
for line in lines:
    print(*line, end=" ")
