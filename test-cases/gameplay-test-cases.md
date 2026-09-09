# Gameplay Test Cases

## TC-001 — Open the Building Menu

**Priority:** High
**Type:** Functional

### Steps

1. Start the game and enter the game world.
2. Click the hammer icon.
3. Check the building menu.

### Expected Result

* The building menu opens.
* The house option is displayed.

---

## TC-002 — Select a House

**Priority:** High
**Type:** Functional

### Steps

1. Open the building menu.
2. Click the house option.
3. Move the cursor over the game world.

### Expected Result

* The house is selected for building.
* A preview of the house appears and follows the cursor.

---

## TC-003 — Build a House

**Priority:** High
**Type:** Functional

### Preconditions

* The player has enough wood to build a house.

### Steps

1. Open the building menu by clicking the hammer icon.
2. Select the house.
3. Move the house preview to a suitable location.
4. Click to place the house.

### Expected Result

* The house is built at the selected location.
* The house remains in the game world.
* The required amount of wood is deducted from the player's resources.

---

## TC-004 — Try to Build a House Without Enough Wood

**Priority:** High
**Type:** Negative / Functional

### Preconditions

* The player does not have enough wood to build a house.

### Steps

1. Open the building menu.
2. Select the house.
3. Choose a suitable location.
4. Try to place the house.

### Expected Result

* The house is not built.
* No wood is deducted.
* The player is informed that there is not enough wood.

## TC-005 — Build a Lumberjack

**Priority:** High
**Type:** Functional

### Steps

1. Open the building menu.
2. Select the lumberjack.
3. Choose a location.
4. Build the lumberjack.

### Expected Result

* The lumberjack is built in the chosen location.
* The required amount of wood is deducted.
* The lumberjack starts working.

---

## TC-006 — Check if the Lumberjack Produces Wood

**Priority:** High
**Type:** Functional

### Steps

1. Build a lumberjack.
2. Note the current amount of wood.
3. Wait for the lumberjack to finish one production cycle.
4. Check the amount of wood again.

### Expected Result

* Wood is added after the expected amount of time.
* The amount of wood increases by the correct amount.

---

## TC-007 — Check Lumberjack Production Over Time

**Priority:** Medium
**Type:** Functional

### Steps

1. Build a lumberjack.
2. Note the current amount of wood.
3. Wait for one production cycle.
4. Note the amount of wood.
5. Wait for another production cycle.

### Expected Result

* The lumberjack continues producing wood.
* Wood is added after each production cycle.
* The amount added is consistent with the expected production rate.

## TC-009 — Move the Map with WASD

**Priority:** Medium
**Type:** Functional

### Steps

1. Start the game.
2. Press **W**, **A**, **S** and **D**.
3. Check how the map moves.

### Expected Result

* The map moves in the expected direction when each key is pressed.
* All four directions work correctly.

---

## TC-010 — Move the Map with the Mouse

**Priority:** Medium
**Type:** Functional

### Steps

1. Start the game.
2. Use the mouse to move the map.
3. Try moving it in different directions.

### Expected Result

* The map moves smoothly in the direction I move the mouse.
* I can move around different parts of the map without any problems.

---

## TC-011 — Check Different Map Movement Directions

**Priority:** Medium
**Type:** Functional

### Steps

1. Move the map up, down, left and right using WASD.
2. Try moving the map in different directions with the mouse.
3. Move around the map for a while.

### Expected Result

* The map can be moved freely in all intended directions.
* The controls behave as expected.
* The map does not move on its own or in the wrong direction.
