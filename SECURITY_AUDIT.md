# Security Audit Report

## Scope

- Repository: `exercise-generator`
- Audit type: Manual static review of source code and project configuration
- Focus: Input handling, denial-of-service vectors, mutable state exposure, randomness usage, and dependency posture

## Findings

### 1) Unbounded recursion in input flow (High)

**Previous behavior:** Invalid user input called `input.Start()` recursively, with no return after recursion. A user could repeatedly submit invalid input and eventually trigger stack exhaustion, crashing the app.

**Impact:** Local denial of service.

**Resolution:** Replaced recursion with a loop-based validation flow and explicit return only when a valid value is received.

### 2) Null/EOF handling caused crash or stuck states (Medium)

**Previous behavior:** `Console.ReadLine()` can return `null` (e.g. EOF). The original code could still execute `character.ToUpper()` after invalid input flow, causing `NullReferenceException`. In non-interactive input streams, EOF handling could also leave the process stuck in repeated prompts.

**Impact:** Crash or unusable runtime behavior (local DoS).

**Resolution:** Added explicit `null` handling to exit gracefully, plus `string.IsNullOrWhiteSpace` validation and normalization via `Trim().ToUpperInvariant()`.

### 3) Predictable random output pattern risk (Low)

**Previous behavior:** `new Random()` was created inside tight loops. Rapid calls can reuse seed timing, resulting in repeated outputs.

**Impact:** Predictability and reduced randomness quality.

**Resolution:** Switched to `Random.Shared` for process-wide pseudo-random sampling.

### 4) Public mutable collections exposed (Low)

**Previous behavior:** Workout lists were exposed as public mutable `List<string>` fields.

**Impact:** Unexpected runtime mutation by future callers could alter program behavior.

**Resolution:** Replaced public mutable fields with `IReadOnlyList<string>` properties.

### 5) Missing defensive validation in business logic (Low)

**Previous behavior:** `Logic.WorkOut` accepted arbitrary strings and would default to the hard workout list for any non-`A` input.

**Impact:** Unexpected behavior if method is called directly from another class with invalid input.

**Resolution:** Added explicit argument validation and fail-fast behavior for invalid choices.

## Additional Notes

- No external packages were introduced; dependency surface remains minimal.
- This CLI tool has no network or file I/O attack surface in current implementation.

## Recommendations

1. Add automated unit tests for input validation and workout generation boundaries.
2. Consider using `RandomNumberGenerator` only if cryptographic-grade randomness is ever required.
3. Add a CI build/test workflow to prevent regressions in input safety handling.
