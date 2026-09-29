# Day 4: The Ideal Stocking Stuffer

> Puzzle: https://adventofcode.com/2015/day/4

## 1. Understanding the problem

Find the lowest positive number which, appended to the secret key, produces an MD5 hash (in hex) starting with five zeros (Part 1) or six zeros (Part 2).

## 2. First thoughts

_What did I notice straight away? Which data structure or technique came to mind, and why?_

## 3. Approach

### Part 1

Brute force: start at 0, build `secretKey + number`, hash it with MD5, convert to lowercase hex and check whether it starts with `00000`. Increment until it matches (`GetLowestNumberInteractor`).

### Part 2

Same loop, just check for six leading zeros (`000000`).

## 4. Design decisions

- `MdManager` creates the MD5 instance and `GenerateHashHelper` turns input into a hex string, so hashing can be mocked in tests.

## 5. Testing

_Which examples/edge cases I tested and what the tests caught._

## 6. Struggles & mistakes

_Where I got stuck, wrong answers, bugs, and how I got past them._

## 7. Complexity

- Time: `O(k)` hashes where `k` is the answer
- Space: `O(1)`

## 8. What I learned / would do differently

-
