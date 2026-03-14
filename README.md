# 2D Platformer Example

![Unity](https://img.shields.io/badge/Engine-Unity-black?logo=unity)
![C#](https://img.shields.io/badge/Language-C%23-239120?logo=c-sharp)
![Platform](https://img.shields.io/badge/Platform-PC%20%7C%20Mobile-blue)
![Status](https://img.shields.io/badge/Status-Prototype-orange)

A small **Unity 2D platformer prototype** demonstrating a complete gameplay loop:

**Main Menu → Gameplay Level → Level Completion Screen**

The goal of this project was to build a minimal but structured platformer while keeping the systems modular and easy to extend.

---

# Features

### Core Gameplay

* 2D platformer movement
* Double jump system
* Collectible coins and gems
* Particle effects for footsteps and landing
* Kill zones with respawn system

### UI Flow

* Main Menu
* Gameplay Level
* Level Completion Screen
* Fade-in / fade-out scene transitions

### Input Support

* Keyboard controls (PC)
* Mobile UI controls

---

# Gameplay Loop

```
Main Menu
   ↓
Start Level
   ↓
Collect Coins
   ↓
Reach Exit
   ↓
Level Complete Screen
```

The completion screen shows how many coins were collected out of the total available in the level.

---

# Controls

### PC

| Key                 | Action           |
| ------------------- | ---------------- |
| A / D or Arrow Keys | Move             |
| Space               | Jump             |
| Mouse Click         | Shoot (optional) |

### Mobile

On-screen buttons control:

* movement
* jump
* shooting

Mobile controls can be toggled in the `PlayerController` script.

---

# Project Structure

```
Assets
 ├── Scenes
 │   ├── MainMenu
 │   └── Level1
 │
 ├── Scripts
 │   ├── Events.cs
 │   ├── ExitTrigger.cs
 │   ├── GameManager.cs
 │   ├── PlayerController.cs
 │   ├── UIManager.cs
 │   └── pickup.cs
```

---

# Core Systems

## Player Controller

Handles player movement and abilities:

* Rigidbody2D physics
* Ground detection using raycasts
* Jump and double jump logic
* Sprite flipping
* Animation control
* Impact particle effects

---

## Game Manager

Acts as the central controller for gameplay systems:

* Tracks collected coins and gems
* Handles player death and respawn
* Calculates total pickups in a level
* Displays the level completion UI

---

## Pickup System

Supports multiple pickup types:

```
coin
gem
health
```

When a player collects a pickup:

1. Counter increases in `GameManager`
2. Visual effect spawns
3. Pickup object is destroyed

---

## Level Exit System

The exit trigger detects when the player reaches the end of the level.

Flow:

```
Player touches exit trigger
↓
Screen fades to black
↓
GameManager triggers completion
↓
Level Complete UI appears
```

---

# Scene Management

Menu buttons use a simple scene navigation script:

* **Scene 0** → Main Menu
* **Scene 1** → Gameplay Level

Handled through the `Events` script.

---

# Built With

* Unity Engine
* C#
* Unity UI System
* TextMeshPro
* Unity Physics2D

---
