# Day 3: Perfectly Spherical Houses in a Vacuum

> Puzzle: https://adventofcode.com/2015/day/3

## 1. Understanding the problem

Santa moves on an infinite grid following `^ v < >`. Part 1: how many houses get at least one present? Part 2: Santa and Robo-Santa take turns following the instructions - how many houses now?

## 2. First thoughts

_What did I notice straight away? Which data structure or technique came to mind, and why?_

## 3. Approach

### Part 1

Map each character to a `Direction` enum. Track the current `(x, y)` position and record every visited position in a dictionary keyed by coordinates, starting with `(0, 0)`. The answer is the number of distinct keys (`GetTotalHouseInteractor`).

### Part 2

Keep two positions (Santa and Robot) and flip a `santaTurn` flag after each move so they alternate; both write into the same visited set (`PartTwoGetTotalHouseInteractor`).

## 4. Design decisions

- `Mappers/DirectionMapper` converts characters to the `Direction` enum and rejects invalid input.
- A dictionary of coordinates handles the infinite grid without allocating a fixed-size array.

## 5. Testing

_Which examples/edge cases I tested and what the tests caught._

## 6. Struggles & mistakes

_Where I got stuck, wrong answers, bugs, and how I got past them._

## 7. Complexity

- Time: `O(n)`
- Space: `O(h)` where `h` is the number of distinct houses visited

## 8. What I learned / would do differently

-
