# Day 5: Doesn't He Have Intern-Elves For This?

> Puzzle: https://adventofcode.com/2015/day/5

## 1. Understanding the problem

Classify each string as nice or naughty using a set of rules and count the nice ones. Part 2 replaces the rules completely.

## 2. First thoughts

_What did I notice straight away? Which data structure or technique came to mind, and why?_

## 3. Approach

### Part 1

A string is nice if it has at least 3 vowels, at least one double letter (`xx`), and none of `ab`, `cd`, `pq`, `xy`. Each rule is its own small method, combined in a `Where` filter (`GetNiceStringsHelper`).

### Part 2

New rules: a pair of letters that appears twice without overlapping (search for the pair again starting at `i + 2`), and a letter that repeats with exactly one letter between (`s[i] == s[i + 2]`) (`GetNiceStringsHelperPartTwo`).

## 4. Design decisions

- One helper per part holds the rules; interactors count the results.
- Each rule is a separate method so it can be reasoned about (and tested) on its own.

## 5. Testing

_Which examples/edge cases I tested and what the tests caught._

## 6. Struggles & mistakes

_Where I got stuck, wrong answers, bugs, and how I got past them._

## 7. Complexity

- Time: `O(n * m^2)` worst case for the pair search (`m` = string length), `O(n * m)` for the other rules
- Space: `O(n)` for the list of nice strings

## 8. What I learned / would do differently

-
