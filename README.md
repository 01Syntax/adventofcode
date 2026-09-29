# Advent of Code Practice

This repository contains my solutions to the Advent of Code programming challenges, written in C# (.NET), along with a write-up of how I tackled each puzzle.

## Repository Layout

```
adventofcode/
  README.md                         - you are here
  docs/
    THOUGHT_PROCESS_TEMPLATE.md     - copy this into each new day
  2015/
    Shared/                         - AoC.Shared: code reused across days (e.g. FileReader)
    Day-01/
      THOUGHT_PROCESS.md            - how I approached the problem
      <PuzzleName>/                 - console app: Program.cs, App.cs, logic, DataSource/
      <PuzzleName>.Tests/           - xUnit tests + MockData/
    Day-02/
    ...
  2016/
  ...
```

### Inside a day

| Folder | Purpose |
|---|---|
| `Interactors/` / `Logic/` | The code that actually solves each part |
| `Parsers/`, `Mappers/` | Turn raw puzzle input into models |
| `Helpers/` | Small reusable pieces of logic |
| `Interfaces/` | Abstractions so everything can be injected and tested |
| `Models/` | Records, enums and other data types |
| `DataSource/` | My puzzle input |
| `*.Tests/MockData/` | Example inputs from the puzzle description used in tests |

## Thought Process

Every solved day has a `THOUGHT_PROCESS.md` that explains how I got to the solution, not just what the code does:

1. **Understanding the problem**: the puzzle in my own words
2. **First thoughts**: initial ideas and which data structures came to mind
3. **Approach**: how Part 1 and Part 2 are solved
4. **Design decisions**: how and why the code is structured the way it is
5. **Testing**: examples and edge cases
6. **Struggles & mistakes**: where I got stuck and how I got past it
7. **Complexity**: time and space
8. **What I learned / would do differently**

To start a new day, copy [`docs/THOUGHT_PROCESS_TEMPLATE.md`](docs/THOUGHT_PROCESS_TEMPLATE.md) into the day's folder as `THOUGHT_PROCESS.md`.

## Progress

### 2015

| Day | Puzzle | Part 1 | Part 2 | Thought Process |
|---|---|---|---|---|
| 01 | [Not Quite Lisp](https://adventofcode.com/2015/day/1) | Done | Done | [Read](2015/Day-01/THOUGHT_PROCESS.md) |
| 02 | [I Was Told There Would Be No Math](https://adventofcode.com/2015/day/2) | Done | Done | [Read](2015/Day-02/THOUGHT_PROCESS.md) |
| 03 | [Perfectly Spherical Houses in a Vacuum](https://adventofcode.com/2015/day/3) | Done | Done | [Read](2015/Day-03/THOUGHT_PROCESS.md) |
| 04 | [The Ideal Stocking Stuffer](https://adventofcode.com/2015/day/4) | Done | Done | [Read](2015/Day-04/THOUGHT_PROCESS.md) |
| 05 | [Doesn't He Have Intern-Elves For This?](https://adventofcode.com/2015/day/5) | Done | Done | [Read](2015/Day-05/THOUGHT_PROCESS.md) |
| 06 | [Probably a Fire Hazard](https://adventofcode.com/2015/day/6) | Done | Not started | [Read](2015/Day-06/THOUGHT_PROCESS.md) |

## Running a Solution

```bash
cd 2015/Day-01/NotQuiteLisp
dotnet run

# run the tests
cd ../NotQuiteLisp.Tests
dotnet test
```

## Workflow

1. Read the daily puzzle on the Advent of Code website.
2. Write down my understanding and first ideas in `THOUGHT_PROCESS.md`.
3. Solve the problem using Visual Studio Code or Visual Studio, writing tests against the puzzle examples.
4. Test and refine the algorithm until it produces the correct result.
5. Submit the answer on the Advent of Code website.
6. Finish the thought process write-up (struggles, lessons learned) and commit.

## Goals

- Improve problem-solving and algorithmic thinking.
- Practice writing clean and efficient code.
- Learn new programming techniques.
- Track my progress across Advent of Code challenges and years.
