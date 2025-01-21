# Battle Vehicles Card Game

This project is a card game developed using C# and Windows Forms. The game is designed to help students understand and implement object-oriented programming (OOP) principles in a practical and engaging way.

## Project Description

The **Battle Vehicles Card Game** is a turn-based card game where a player competes against the computer. The game involves three categories of battle vehicles: air, land, and sea, with additional subcategories within each type. Players strategize by selecting cards, and the computer selects its cards randomly. Each card has attributes such as durability, level points, and class-based attack advantages.

### Key Features

1. **Categories and Subcategories**:
   - Air: Plane, UAV (SİHA)
   - Land: Howitzer, Missile System (KFS)
   - Sea: Frigate, Fast Intervention Craft (SİDA)

2. **Gameplay Mechanics**:
   - Players and the computer each start with 6 cards.
   - Players manually select 3 cards per turn; the computer selects randomly.
   - Each card has specific strengths and weaknesses based on its type.
   - Additional cards (UAV, SİDA, KFS) become available when a player reaches a certain level (e.g., 20 points).
   - Turns continue until:
     - One player's cards are exhausted.
     - The set number of rounds (e.g., 5) is completed.

3. **Scoring**:
   - Cards gain points based on attacks and eliminations.
   - The winner is determined by the highest total score or remaining card durability in case of a tie.

4. **Dynamic Rules**:
   - Players cannot choose the same card twice in the same turn unless all cards have been used.
   - Each card type has specific attack bonuses against certain categories.

5. **Object-Oriented Structure**:
   - Encapsulation, inheritance, polymorphism, and abstraction are implemented throughout.

### Visual Features
- Interactive Windows Forms interface.
- Dynamic visual updates to reflect gameplay status.
- Game actions such as card selection and attacks are animated for better user experience.



## Usage Instructions

1. Launch the application.
2. Choose your initial set of cards from the categories (Air, Land, Sea).
3. Start the game and select three cards per turn.
4. Observe the computer's random selection and the battle results.
5. Continue playing until one of the win conditions is met.

## Project Structure

- **`Classes`**: Contains the abstract classes and their subclasses representing vehicles.
  - `Vehicle.cs`: Abstract class for common attributes like durability, level points, and attack mechanics.
  - Subclasses: `Air.cs`, `Land.cs`, `Sea.cs`, and their respective subcategories.
- **`Player.cs`**: Defines player attributes and methods for card selection and scoring.
- **`Game.cs`**: Core game logic and turn-based mechanics.
- **`MainForm.cs`**: Windows Forms interface implementation.

## Object-Oriented Principles Used

- **Encapsulation**: All attributes are private or protected and accessible via properties.
- **Inheritance**: Subclasses inherit common behaviors from abstract parent classes.
- **Polymorphism**: Overridden methods for specialized behaviors in subclasses.
- **Abstraction**: Abstract classes define the structure and enforce rules for subclasses.


start screen
![image](https://github.com/user-attachments/assets/379a4778-5897-4ed1-9a2d-a3f632db239e)

battle
![image](https://github.com/user-attachments/assets/ae84e602-dcb6-463a-9761-b7169b4a89cc)




