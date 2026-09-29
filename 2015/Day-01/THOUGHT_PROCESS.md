# Day 1: Not Quite Lisp

> Puzzle: https://adventofcode.com/2015/day/1

| | Part 1 | Part 2 |
|---|---|---|
| Status | Done | Done |

## 1. Understanding the problem

Santa follows a string of parentheses: `(` means go up one floor, `)` means go down one. Part 1: which floor does he end on? Part 2: at which (1-based) character position does he first enter the basement (floor -1)?

## 2. First thoughts

_What did I notice straight away? Which data structure or technique came to mind, and why?_

## 3. Approach

### Part 1

Read the input as one string and keep a counter: `+1` for `(`, `-1` for `)`. The final counter is the floor (`GetFloorsInteractor`).

### Part 2

Same loop, but check after every step whether the counter has dropped below 0 and return `i + 1` (the puzzle counts positions from 1) (`GetPositionOfCharacterInteractor`).

## 4. Design decisions

- `Interactors/` hold one interactor per part.
- File reading goes through the shared `IFileReader` so the logic can be tested with mock data (`MockData/floors.txt`).

## 5. Testing

_Which examples/edge cases I tested and what the tests caught._

## 6. Struggles & mistakes

_Where I got stuck, wrong answers, bugs, and how I got past them._

## 7. Complexity

- Time: `O(n)` - one pass over the input
- Space: `O(1)` beyond the input string

## 8. What I learned / would do differently

-
