# Space Vulture

## Play the Game
**Unity Play Link:** https://play.unity.com/en/games/ccf3a793-8eb5-44e1-89e0-54275d17c038/cosmic-horror-adventure

**Documentation Link:** https://docs.google.com/document/d/1xEnDghxJFQbVsEMf7Mnj5pz0h4aeiM8_mdEgCY3ZgwE/edit?tab=t.0](https://docs.google.com/document/d/1fOUTgfqh_URxuYcPrZn-i_Q0iTngJMA1tSDQ2ppPiU8/edit?tab=t.0

## Game Overview
In 1976 Will Crowther created the game Colossal Cave Adventure, also known as Adventure. This was one of the first text-based games ever created, and it pioneered the genre of "adventure" games.

In 2024 I created Cosmic Horror, using the functionality of Adventure for my final project in CS 151 at Willamette University. I created my own story to go with it, choosing a Sci-Fi Horror theme instead of the original fantasy one.

Space Vulture was created to turn my version of adventure from a text-based implementation to a 2D one. The game is focused on exploration and learning things about your environment, rather than combat like many modern games.


### Controls
- WASD to move up/down/left/right
- E to interact with your environment
- TAB to open the inventory menu
- ESC to pause the game

### How to Play
Welcome to Space Vulture! You are a lone scavenger exploring an abandoned freighter in hopes of finding a wealth of credits, though it is rumored that this ship met a deadly fate. This place is said to be perilous, the perfect opportunity for a daring explorer like you to loot. It's important to remember that freighter passages turn a lot, and that leaving a room to the north does not guarantee entering the next from the south, although it often works out that way. You'd best make yourself a map as you go along.

Follow the link to the Unity Play website, hit play, and live out your space-scavenging dreams!

### Completion Status

- [X] Player Movement
- [X] Doorways Move Player
- [X] Collectable Objects
- [X] Basic Sprites
- [X] Doorways Require Objects
- [X] Entire Map Created
- [X] Player Animations
- [X] Inventory Menu Appears
- [X] Inventory Menu Populates with Items
- [X] Inventory Menu Looks Good
- [X] Objects have Credit Values
- [X] Display Player's Current Income
- [X] Starting Story
- [X] Pause Menu Created
- [X] Pause Menu Buttons: Resume, View Controls, Restart
- [X] Audio
- [X] Story Culmination
- [X] Many Sprites Done


## Development Info

### Known Bugs
- Probably Something

### Technical Details
- Unity Version 6000.2.14f1
- Packages/Plugins used:
  - Cinemachine
  - WebGL
  - UIToolkit/UIBuilder

### Credits
Credits
- Implementation:
  - Partially Followed Tutorial for Inventory UI: 
    - https://github.com/Yecats/GameDevTutorials/tree/master/tutorials/Unity/Create-an-Inventory-UI-with%20UI-Toolkit
- Audio
  - Background Music: Scifi Loops Pack 1 by Christopher Baklid
    - https://assetstore.unity.com/packages/audio/music/electronic/scifi-loops-pack-1-25686
  - Sound Effects: Vehicle - Essentials by Nox_Sound
    - https://assetstore.unity.com/packages/audio/sound-fx/transportation/vehicle-essentials-194951#content
- Visual
  - All visual assets created by me with the software Aseprite
- Collaborators
  - Professor: Lucas Cordova
  - TA: Teo Mendoza


## Reflection
**Successes**:
- Creating the Interactable abstract class went very well. I understood how it should be created from the beginning, and implemented it well enough to easily extend into three other classes. It would also be easy to extend again into more classes for future extensions.
- The tilemap structure for organizing my floor, walls, and cosmetics worked really well for updating the collision settings or updating my sprites throughout the process. I could change setting or sprite names and see the changes reflected throughout the map without having to backtrack on previous work.
- In general, my prefabs were easy to create and slightly edit to get things exactly how I wanted. 

**Challenges**: 
- Getting the Inventory UI to display the Item Slots was difficult, as it was deleting the slots entirely each time I set the parent container active/inactive.
- Getting the inventory boxes to populate with Item sprites also took a lot of trial and error. The error ended up being that I wasn’t clearing the list of inventory slots before adding new ones.
- Creating my own visual assets took a ton of time. While I do love doing this part it greatly increases the effort I am putting into the game.
- Getting things to render in the order I needed them was difficult once there were 6 Tilemaps and multiple classes of objects. It took lots of time for trial and error, but wasn’t super difficult to figure out in the end.

**Learning Outcomes**:
- I feel a lot more confident in creating more complicated internal game systems now. Before I was keeping everything very simple, but the classes I made for this project forced me out of my comfort zone.
This project helped me think a lot about how I should structure my code in general to make it the most clear it can be. Changing how things were attributed, or what objects were children of each other, gave me a lot of insight into software design in general.


## Future Development Aspirations
- I would like to add a combat aspect to the game after the player reaches the ship's bridge. I think it would be fun to give them two options like I did in my text-based version. The bridge activates the ship's security robots and the player can either sneak past or fight through them to reach their ship and escape. While the time constraints of this project didn't let me accomplish this much, I hope to in the future.
- I think the next “level” would be exploring the last port the freighter stopped at before being abandoned in space.
- Making some improvements to the visual environment would be great, I feel like a lot of it looks very similar right now. I would want to add more variation in general, but especially in the walls and the freighter vs Vulture environments.
- Adding a way to store player data between sessions would be great. I think that would take storing their inventory and location in a json, and reading that in when the game first loads.
