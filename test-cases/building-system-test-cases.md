# Building System Test Cases

This test suite covers the main building functionality in the game, including building selection, placement, resource requirements, building costs and interactions between different building types.

The tests are based on the current implementation of the building system and will be updated as new building features are added.

---

## TC-BUILD-001 — Open the Building Menu

**Priority:** High

**Type:** Functional

### Steps

1. Start the game and enter the game world.
2. Click the hammer icon.
3. Check the building menu.

### Expected Result

* The building menu opens.
* Available building options are displayed.
* The player can select a building to place.

---

## TC-BUILD-002 — Select a House

**Priority:** High

**Type:** Functional

### Steps

1. Open the building menu.
2. Click the house option.
3. Move the cursor over the game world.

### Expected Result

* The house is selected for building.
* A house preview appears.
* The preview follows the cursor.

---

## TC-BUILD-003 — Place a House in a Valid Location

**Priority:** High

**Type:** Functional

### Preconditions

* The player has enough wood to build a house.

### Steps

1. Open the building menu.
2. Select the house.
3. Move the house preview to a suitable location.
4. Click to place the house.

### Expected Result

* The house is placed at the selected location.
* The house remains in the game world.
* The required amount of wood is deducted from the player's resources.

---

## TC-BUILD-004 — Try to Build a House Without Enough Wood

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
* The player is informed that there is not enough wood, if this feedback is implemented.

---

## TC-BUILD-005 — Build a Lumberjack

**Priority:** High

**Type:** Functional

### Preconditions

* The player has enough wood to build a lumberjack.

### Steps

1. Open the building menu.
2. Select the lumberjack.
3. Choose a suitable location.
4. Place the lumberjack.

### Expected Result

* The lumberjack is placed at the selected location.
* The required amount of wood is deducted.
* The lumberjack starts working.

---

## TC-BUILD-006 — Switch Between Building Types

**Priority:** High

**Type:** Functional

### Steps

1. Open the building menu.
2. Select the house.
3. Move the house preview over the game world.
4. Select the lumberjack.
5. Move the cursor over the game world.

### Expected Result

* The selected building changes from the house to the lumberjack.
* The house preview is replaced by the lumberjack preview.
* The house is not placed automatically when the building selection is changed.

---

## TC-BUILD-007 — Prevent Building on an Occupied Location

**Priority:** High

**Type:** Negative / Functional

### Preconditions

* A building has already been placed in the game world.

### Steps

1. Open the building menu.
2. Select another building.
3. Move the building preview over an occupied location.
4. Try to place the building.

### Expected Result

* The new building cannot be placed on top of an existing building.
* The existing building remains unchanged.
* No resources are deducted for the unsuccessful placement.

---

## TC-BUILD-008 — Build Multiple Buildings

**Priority:** Medium

**Type:** Functional

### Preconditions

* The player has enough wood to build more than one building.

### Steps

1. Build a house in a valid location.
2. Select the lumberjack.
3. Choose another valid location.
4. Place the lumberjack.

### Expected Result

* Both buildings are placed successfully.
* The buildings remain in their selected locations.
* The correct amount of wood is deducted after each successful build.

---

## TC-BUILD-009 — Try to Place a Building When Wood Reaches Zero

**Priority:** High

**Type:** Negative / Functional

### Preconditions

* The player has no wood available.

### Steps

1. Open the building menu.
2. Select a building.
3. Choose a valid location.
4. Try to place the building.

### Expected Result

* The building is not placed.
* The player's wood remains at zero.
* No building is created.

---

## TC-BUILD-010 — Building Preview Follows the Cursor

**Priority:** Medium

**Type:** Functional

### Steps

1. Open the building menu.
2. Select a building.
3. Move the cursor to different locations on the map.

### Expected Result

* The building preview follows the cursor.
* The preview remains visible while the building is selected.
* The preview does not move independently of the cursor.

---

## TC-BUILD-011 — Place a Building After Moving Around the Map

**Priority:** Medium

**Type:** Functional

### Preconditions

* The player has enough wood to build a building.

### Steps

1. Select a building.
2. Move around different parts of the map.
3. Move the building preview to a valid location.
4. Place the building.

### Expected Result

* The building can be placed correctly after moving around the map.
* The building appears at the selected location.
* The correct amount of wood is deducted.

---

## TC-BUILD-012 — Change Building Selection When There Is Not Enough Wood

**Priority:** High

**Type:** Negative / Functional

### Preconditions

* The player does not have enough wood to place the currently selected building.

### Steps

1. Open the building menu.
2. Select a building that the player cannot currently afford.
3. Choose another building from the building menu.

### Expected Result

* The selected building changes.
* The previously selected building is not placed automatically.
* No wood is deducted.
* The new building can be placed only after meeting its resource requirements.

---

## TC-BUILD-013 — Verify Wood Is Deducted Only After Successful Placement

**Priority:** High

**Type:** Functional

### Preconditions

* The player has enough wood to build a building.

### Steps

1. Note the current amount of wood.
2. Select a building.
3. Move the building preview around the map without placing it.
4. Check the wood amount.
5. Place the building in a valid location.
6. Check the wood amount again.

### Expected Result

* Moving the building preview does not change the amount of wood.
* Wood is deducted only after the building is successfully placed.
* The deducted amount matches the building's cost.

---

## TC-BUILD-014 — Cancel or Exit Building Placement

**Priority:** Medium

**Type:** Functional

### Steps

1. Open the building menu.
2. Select a building.
3. Move the building preview over the map.
4. Exit the building placement mode using the available game control.

### Expected Result

* The building preview is removed.
* No building is created.
* No resources are deducted.

---

## TC-BUILD-015 — Build a Building After Gaining Enough Wood

**Priority:** Medium

**Type:** Functional

### Preconditions

* The player initially does not have enough wood to build the selected building.

### Steps

1. Select the building.
2. Try to place it.
3. Gain enough wood through the available resource system.
4. Try to place the building again.

### Expected Result

* The first placement attempt is unsuccessful.
* No wood is deducted after the unsuccessful attempt.
* After gaining enough wood, the building can be placed successfully.
* The correct amount of wood is deducted after successful placement.
