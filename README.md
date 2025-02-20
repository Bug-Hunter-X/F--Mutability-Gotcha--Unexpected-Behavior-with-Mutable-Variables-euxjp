# F# Mutability Gotcha: Unexpected Behavior with Mutable Variables

This example demonstrates a potential issue in F# related to mutable variables and function calls.  When a function uses a mutable variable as input, modifying that variable *after* the function call may unexpectedly affect the outcome of the function call.

## The Problem

The `addOne` function seems straightforward; it adds one to its input. However, because the input `x` is mutable, changing its value *after* `y` is assigned impacts the `y` value unexpectedly. This behavior might not always be intuitive, especially for programmers coming from immutable language backgrounds.

## Solution

The solution involves avoiding mutable variables whenever possible, or explicitly cloning them if modification is essential.  Prefer immutable data structures when feasible for better predictability and avoiding side effects.