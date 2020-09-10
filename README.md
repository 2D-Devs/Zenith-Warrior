# Zenith Warrior
Authors: *Lami Beach, Michael Refvem, Andrew Smith*

This is a Unity game with a 2D, top-down, RPG environment. 
The object of this game is to navigate your player through an unforgiving landscape that is smothered with ruthless enemies. 
Once all enemies are defeated, a 'final boss' will appear that is even more lethal than all other enemies and must be defeated. 
Only then can the game be completed. 

---

### Controls

Movements | PC | Xbox Controller
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

1. Download Zip File
- [Windows](https://github.com/2D-Devs/Zenith-Warrior/raw/development/Downloads/Windows.zip)
- [MacOS](https://github.com/2D-Devs/Zenith-Warrior/raw/development/Downloads/Mac.app.zip)
- [Linux]()

2. Decompress the zip file
3. Navigate to folder with your corresponding OS (Mac, Windows, Linux)
4. Run `Zenith-Warrior.exe`

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
- Unity
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
![Database Schema](https://i.imgur.com/BK6IGJr.png)

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
1.6: Added intro - 9/10/2020

1.5: Added boss feature - 9/9/2020

1.4: Added attack systems - 9/8/2020

1.3: Added enemies - 9/8/2020

1.2: Added 8 bit music - 9/8/2020

1.1: Added hero and tile mapping - 9/7/2020

---

### Resources:

Brackeys 2D animation tutorials - https://www.youtube.com/watch?v=on9nwbZngyw&list=PLPV2KyIb3jR6TFcFuzI2bB7TMNIIBpKMQ
Unity Editor / Assets - https://unity.com/


