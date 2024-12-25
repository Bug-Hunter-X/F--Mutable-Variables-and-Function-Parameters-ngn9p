# F# Mutability and Function Parameters

This example demonstrates a common issue in F# related to mutability and how functions handle mutable variables passed as parameters.  The `add` function calculates the sum correctly initially, but subsequent modifications to `x` and `y` don't affect the result when `add` is called again. This is because F# functions generally work with copies of values, not direct references unless explicitly designed to do so.

**Bug:** The `add` function does not reflect changes made to `x` and `y` after its initial call. 

**Solution:** The solution demonstrates how to correctly handle mutable variables when the function needs to interact with the original values rather than copies.