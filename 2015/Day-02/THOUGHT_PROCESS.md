# Day 2: I Was Told There Would Be No Math

> Puzzle: https://adventofcode.com/2015/day/2

| | Part 1 | Part 2 |
|---|---|---|
| Status | Done | Done |

## 1. Understanding the problem

Each line is a present's dimensions `LxWxH`. Part 1: total wrapping paper (surface area + the area of the smallest side). Part 2: total ribbon (smallest perimeter + volume for the bow).

## 2. First thoughts

_What did I notice straight away? Which data structure or technique came to mind, and why?_

## 3. Approach

### Part 1

Parse each line into a `Dimension`. For each present compute the three side areas, add `2*l*w + 2*w*h + 2*h*l`, plus the smallest area as slack, then sum everything (`CalculateSurfaceAreaInteractor`).

### Part 2

Sort the three sides; the two smallest give the ribbon `2*a + 2*b`, and the bow is the volume `a*b*c` (`CalculateRibbonFeetInteractor`).

## 4. Design decisions

- `Parsers/DimensionParser` turns raw text into `Dimension` models and throws clear `FormatException`s for malformed lines.
- The interactors only do the maths on already-parsed models, which keeps them easy to test.
- Tests use `MemberData` to feed many example presents.

## 5. Testing

_Which examples/edge cases I tested and what the tests caught._

## 6. Struggles & mistakes

_Where I got stuck, wrong answers, bugs, and how I got past them._

## 7. Complexity

- Time: `O(n)` - constant work per present
- Space: `O(n)` for the parsed dimensions

## 8. What I learned / would do differently

-
