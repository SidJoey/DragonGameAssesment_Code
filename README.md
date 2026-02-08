# 🐉 Dragon Duel – Junior Game Developer Assessment

<img width="1920" height="1080" alt="Builds Screenshot 2026 02 08 - 22 59 51 64" src="https://github.com/user-attachments/assets/9a659067-20be-4189-afe7-7195354fa453" />

## Overview
Dragon Duel is a small 2.5D top-down combat prototype built in Unity.  
The project features a player-controlled dragon facing off against an AI-controlled dragon in a focused arena battle.

The goal of this project was to demonstrate foundational Unity skills, clean gameplay systems, animation-driven combat, basic AI behavior, and efficient development workflows.

---

## Core Features

### 🎮 Gameplay
- Player-controlled dragon with responsive WASD movement
- AI-controlled dragon using NavMesh-based movement and attack logic
- 2.5D top-down camera inspired by games like TFT / Dota Underlords

### ⚔️ Combat Mechanics
- **Fire Attack** – ranged projectile-based attack
- **Tail Attack** – melee attack using timed hitboxes
- **Fly Attack** – multi-stage airborne attack sequence (takeoff → attack → land)
- Animation-driven combat using animation events
- Combat lock & cooldown system to prevent input spamming

### 🧠 AI Behavior
- AI chases the player when out of range
- AI attacks when within range using cooldown-based decision making
- AI and player systems are fully decoupled and reusable

### 🧩 Systems & UI
- Health system with real-time HUD health bars
- Ability UI icons with visual cooldown feedback
- Main Menu scene
- Win, Lose, and Draw screens
- Full game loop with restart and main menu navigation

### 🔊 Audio
- Contextual sound effects for:
  - Fire attacks
  - Melee attacks
  - Death
  - UI button interactions

---

## Controls
- **W / A / S / D** – Move
- **Left Mouse Button** – Fire Attack
- **Right Mouse Button** – Tail Attack
- **Space** – Fly Attack

---

## Playable Build
A playable Windows build is available here:

👉 https://github.com/SidJoey/DragonDuelGame_Builds

Tested on Windows 10/11.

---

## Technical Highlights
- Clean separation of responsibilities (combat, AI, UI, game state)
- Centralized `BattleManager` controlling end-game logic
- Animation events used for:
  - Damage timing
  - Sound effects
  - Attack completion
- Simple, readable architecture designed for rapid iteration and extension

---

## AI Usage Note
AI tools (primarily ChatGPT) were used as a development assistant throughout this project to:

- Debug Unity- and Animator-related issues
- Reason about animation state machines and animation events
- Design clean combat flow (combat locking, cooldowns, attack commitment)
- Validate architectural decisions and best practices
- Speed up iteration by acting as a technical sounding board

All systems were implemented, reviewed, and integrated manually, with AI used as a productivity and learning aid rather than an automated solution.

---

## Possible Extensions (With More Time)
With additional development time, this prototype could be expanded into a more complete game by adding:

- Background music and audio mixing
- Additional dragon types with unique abilities
- Improved AI variety and behaviors
- Visual polish (VFX, camera shake, screen feedback)
- Mobile-friendly UI and Unity Input System integration
- Balancing and progression systems

The current architecture was intentionally designed to support these extensions with minimal refactoring.

---

## Unity Version
- Unity **2022.x (URP)**

---

## Notes
This project was scoped intentionally to prioritize gameplay clarity, system completeness, and clean implementation over excessive content or polish.


