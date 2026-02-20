# Soul-Scape

## Overview
Soul-Scape is a 3D puzzle prototype where the player controls a robot capable of harnessing different souls, each granting unique abilities.
The player must use these powers to interact with the environment, solve room-based puzzles, and escape a series of test chambers.

This project was my first Unity experience and represents an early exploration of state-based gameplay, abilities, and puzzle logic.

---

## Gameplay Features
- Three distinct player states:
  - Player mode
  - Green soul (flight-based movement)
  - Blue soul (soul projection and object possession)
- Environmental puzzles built around ability usage
- Interactable fuse boxes linked to world animations
- Room-based progression through scene loading

---

## Technical Highlights

### Player States & Abilities
- Centralized state system controlling player behavior and input
- Separate control schemes and movement logic per state
- Ability acquisition through trigger colliders
- Clear separation between movement, interaction, and ability logic

### Environment & Puzzles
- Fuse box interaction system linked to environmental animations
- Environment actions triggered through puzzle completion
- Scene loader handling room transitions

---

## Controls

### Player Mode
- WASD – Move  
- Left Shift – Run  
- Space – Jump  
- E – Green soul  
- Q – Blue soul  
- Left Click – Interact with fuse boxes  

### Green Soul Mode
- WASD – Move  
- Left Shift – Move up  
- Left Ctrl – Move down  
- Left Click – Interact  

---

## Project Status
This project is functionally complete.

Given the knowledge gained since its creation, future improvements would focus on:
- Clearer interaction feedback (visual and audio cues)
- Raycast-based interaction instead of proximity-only triggers
- More readable puzzle affordances
- Expanded puzzle complexity using soul abilities
- Improved architecture and code organization

---

## How to Run
Playable build can be downloaded from my Itch page : https://themightychair.itch.io/soul-scape-1

---

## Built With
- Unity  
- C#  
