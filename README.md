# Zenith Warrior
Authors: *Lami Beach, Michael Refvem, Andrew Smith*

This is a Unity game with a 2D, top-down, RPG environment. 
The object of this game is to navigate your player through an unforgiving landscape that is smothered with rutheless enemies. 
Once all enemies are defeated, a 'final boss' will appear that is even more lethal than all other enemies and must be defeated. 
Only then can the game be completed. 

---

### Controls

Keys | PC | Xbox Controller
- | - | - 
Move left | A | L-joystick Left
Move Right | D | L-joystick Right
Move Up | W | L-joystick Up
Move Down | S | L-joystick Down
Sprint | Left Shift | 
Attack | Left Ctrl | A

---

### Visuals

---

### How to Play

Download Zip File
- <a href="Builds/Windows.Zip" download>Windows</a>
- MacOS

---

### Requirements

[Requirements](Requirements.md)

---



### User Stories

[User Stories](UserStories.md)

---




### Wireframes

[Wireframes](Wireframes.md)

---

### Story of Zenith Warrior
Zenith Warrior is a story about a man on a mission to slay enemies and a final boss. No one knows quite yet 
what made our fearless warrior embark on this journey. Enemies appeared in his land, and now he has no choice 
but to mess stuff up.

---

### Tools Used
Microsoft Visual Studio Community 2019 

- C#
- Unity Hub

---

### Recent Updates

---

### Usage

### Overview of game

### Playing Game

### Death

### Success






---
## Data Model
![Database Schema](https://i.imgur.com/EBOJIT1.png)

---
## Model Properties and Requirements

### Zenith Warrior - Character

| Parameter | Type | Required |
| --- | --- | --- |
| ID  | int | YES |
| UserName | str | YES |
|CurrentLocation| Nav|YES|


### Zenith Warrior - Enemy

| Parameter | Type | Required |
| --- | --- | --- |
| ID  | int | YES |
|Location| Nav|YES|


### Zenith Warrior - Location

| Parameter | Type | Required |
| --- | --- | --- |
| ID  | int | YES |
|EnemyInLocation| Enemies|YES|


### Zenith Warrior - User

| Parameter | Type | Required |
| --- | --- | --- |
| ID  | int | YES |
| UserName | str | YES |
|Role| role |YES|

### Change Log
1.6: 

1.5: 

1.4:  

1.3: 

1.2:

1.1: 

---

### Resources:



