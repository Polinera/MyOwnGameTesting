# ResourceManager — Unity Edit Mode Test

This folder contains a small automated test for the `ResourceManager` script from my Unity game project.

The goal is to check that adding wood correctly updates the amount of wood stored by the game.

## Test

**`AddWood_IncreasesWoodAmount`**

The test:

1. Creates a `ResourceManager` instance.
2. Adds 10 wood.
3. Checks that the stored amount of wood is `10`.

### Expected result

The wood amount should increase by the value passed to `AddWood()`.

### Result

**Passed** ✅

The test was run in Unity Test Runner using **Edit Mode**.

## Why Edit Mode?

This test checks the logic of the `ResourceManager` without loading the game scene. This makes it quick to run and useful for catching problems in the resource management logic early.

### Test evidence

The screenshot below shows the test result in Unity Test Runner.
