# Exploratory Testing Notes

I use exploratory testing while developing my game to see how different features behave in real use.

I don't follow only predefined test cases. I also try different things, combine actions and check situations that might cause problems.

## Session 1 — Building and Resources

**Area:** Building, resources and building placement
**Goal:** Check if buildings can be selected and placed correctly and if resources work as expected.

### What I checked

* Opening the building menu
* Selecting different buildings
* Moving the building preview around the map
* Placing buildings
* Trying to place a building in an occupied area
* Trying to place one building on another
* Checking the building position after placement
* Checking the amount of wood before and after building
* Checking if the correct amount of wood is shown in the UI
* Clicking on already built buildings

### Findings

While testing the building system, I found a few problems:

* A building could appear too high above the ground after being placed.
* It was possible to place a building on top of another building.
* The UI could show `0` wood even when the `ResourceManager` contained wood.
* Clicking a building could show the wrong information or sometimes nothing happened.

I investigated these problems and fixed them during development.

## Session 2 — Lumberjack

**Area:** Lumberjack and wood production
**Goal:** Check if the lumberjack produces wood correctly over time.

### What I checked

* Building a lumberjack
* Checking the amount of wood before production
* Waiting for a production cycle
* Checking if wood is added
* Waiting for several production cycles
* Checking if production continues

### Observations

I mainly checked if the lumberjack starts working correctly and if the amount of wood increases after each production cycle.

## Session 3 — Map Movement

**Area:** Map controls
**Goal:** Check if I can move around the map using different controls.

### What I checked

* Moving the map with W, A, S and D
* Moving the map with the mouse
* Moving in different directions
* Changing direction while moving
* Moving around the map for a longer time

### Observations

I checked if the map responds correctly to the controls and if it moves in the direction I expect.

## What I learned

Exploratory testing helped me find problems that I would not necessarily find by following individual test cases.

It was also useful for checking how different parts of the game work together, for example:

* building placement and collision detection
* building placement and resources
* building selection and UI
* lumberjack and resource management

I will continue using exploratory testing as I add new features to the game.
