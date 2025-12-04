# Space Vulture

## Play the Game
**Unity Play Link:** https://play.unity.com/en/games/ccf3a793-8eb5-44e1-89e0-54275d17c038/cosmic-horror-adventure

**Progress Notebook Link:** https://docs.google.com/document/d/1xEnDghxJFQbVsEMf7Mnj5pz0h4aeiM8_mdEgCY3ZgwE/edit?tab=t.0

## Game Overview
In 1976 Will Crowther created the game Colossal Cave Adventure, also known as Adventure. This was one of the first text-based games ever created, and it pioneered the genre of "adventure" games.

In 2024 I re-created the functionality of this game for her final project in CS 151 at Willamette University. I also created my own story to go with it, chosing a Sci-Fi Horror theme instead of the original fantasy one.

Now, I am working on turning my version of this game from a text-based implementation to a 2D one. The game is focused on exploration and learning things about your environment, rather than combat like many modern games. 

### Controls
- Use WASD to move up/down/left/right
- Use E to interact with your environment
- Use TAB to open the inventory menu
- Use ESC to pause the game

### How to Play
Welcome to Space Vulture! You are a lone scavenger exploring an abandoned freighter in hopes of finding a wealth of credits, though it is rumored that this ship met a deadly fate.
This place is said to be perilous, the perfect opportunity for a daring explorer like you to loot. 
It's important to remember that freighter passages turn a lot, and that leaving a room to the north does not guarantee entering the next from the south, although it often works out that way. 
You'd best make yourself a map as you go along.

### Completion Status

Base:

- [X] Player Movement
- [X] Doorways Move Player
- [X] Collectable Objects
- [X] Doorways Require Objects
- [X] Entire Map Created
- [X] Player Animations
- [X] Inventory Menu Appears
- [ ] Objects have Credit Values
- [ ] Display Player's Current Income
- [ ] Inventory Menu Populates with Items
- [ ] Starting Story
- [ ] Pause Menu
- [ ] Artwork
- [ ] Sounds

## Development Info

### Known Bugs
- 

### Technical Details
- Unity Version 6000.2.14f1
- Packages/Plugins used:
  - Cinemachine
  - WebGL
  - UIToolkit/UIBuilder

### Credits
- Implementation:
  - Followed Tutorial for Inventory UI: https://github.com/Yecats/GameDevTutorials/tree/master/tutorials/Unity/Create-an-Inventory-UI-with%20UI-Toolkit
- Audio
  - TBD
- Visual
  - All visual assets created by me with the software Aseprite

## Reflection
**Successes**:

**Challenges**: 
- Getting the Inventory UI to display the Item Slots, for some reason every time after the first time I toggle it on or off it doesn't appear.
- Creating my own assets. While I do love doing this part is greatly increases the effort I am putting in to the game.

**Learning Outcomes**:
- I feel a lot more confident in creating more complicated internal game systems now. Before I was keeping everything very simple, but the Items and Doors especially in this project forced me out of my comfort zone.
- 

## Future Development Aspirations
- I would like to add a combat aspect to the game after the player reaches the ship's bridge. I think it would be fun to give them two options like I did in my text-based version. The bridge activates the ship's security robots and the player can either sneak past or fight through them to reach their ship and escape. While the time constraints of this project didn't let me acomplish this much, I hope to in the future.
- Making some improvements to the visual environment would be great, I feel like a lot of it looks very similar right now.
