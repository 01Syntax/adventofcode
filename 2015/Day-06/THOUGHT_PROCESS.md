# Day 6: Probably a Fire Hazard

> Puzzle: https://adventofcode.com/2015/day/6

## 1. Understanding the problem

A 1000x1000 grid of lights. Instructions like `turn on 0,0 through 999,999`, `turn off ...` and `toggle ...` apply to rectangles. Part 1: how many lights are lit at the end?

## 2. First thoughts

_What did I notice straight away? Which data structure or technique came to mind, and why?_

## 3. Approach

### Part 1

Split each instruction line into action + start/end coordinates (`ConvertTo2DArr`), map those into `Instruction` models (`InstructionMapper`, `ActionMapper`), then loop over every point in each rectangle, keeping lit lights in a `HashSet<(int x, int y)>`: add for on, remove for off, and remove-or-add for toggle (`GetLightsOnLogic`).

### Part 2

_Not done yet._

## 4. Design decisions

- Split into three projects: `ProbablyAFireHazard` (console app), `ProbablyAFireHazard.Logic` (parsing + logic), and tests - plus the shared `AoC.Shared` file reader.
- Parsing (text -> string array -> `Instruction`) is kept separate from the light logic.

## 5. Testing

_Which examples/edge cases I tested and what the tests caught._

## 6. Struggles & mistakes

_Where I got stuck, wrong answers, bugs, and how I got past them._

## 7. Complexity

- Time: `O(i * a)` where `a` is the area of each rectangle
- Space: `O(lit lights)`, up to 1,000,000

## 8. What I learned / would do differently

-
