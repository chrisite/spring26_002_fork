# ICE 2/16/2026 - Logan Bachman & Chris Wilmoth

---

## *The solution must initiate a missile launch when the user clicks the right mouse button.*

### Happy Path

**Pre-Condition**  
The game is running with no active missiles on the board.

**Action**  
user clicks right mouse button.

**Post-Condition**  
missile appears and moves through grid

---

### UnHappy Path

**Pre-Condition**  
The game is running with no active missiles on the board.

**Action**  
User presses the up arrow to deploy missile

**Post-Condition**  
no new missiles are deployed.

---

## *The solution must limit the number of active missiles on the screen to no more than five (5) at any given time. (an “active missile” is any missile currently being displayed on the screen)*

**Pre-Condition**  
The game is running with no active missiles on the board.

**Action**  
the user presses the right mouse button 6 times to deploy 6 missiles.

**Post-Condition**  
5 missiles appear on the board, but the 6th right click has no effect.

---

## *The solution must remove the missile from being active if it goes off the screen.*

**Pre-Condition**  
Game is running with no active missiles on grid.

**Action**  
User presses right-click to deploy missile

**Post-Condition**  
When missile crosses out of screen, no longer in active missile list.

---

## *Launch ship when no active ships.*

### Happy Path

**Pre-Condition**  
No active ships on grid

**Action**  
Game refreshes

**Post-Condition**  
new ship enters grid

---

### Un-Happy Path

**Pre-Condition**  
1 ship active on grid

**Action**  
game refreshes

**Post-Condition**  
no new ships enter grid
