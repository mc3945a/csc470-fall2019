Marc Cohen micro design document game03

Markdown
-------------

For my game03 concept,  I was thinking of creating a type of shooter game that shoots at
incoming projectiles of different types.  The user will be able to control the direction and angle that
a bullet will be fired,  with the goal being to destroy incoming projectiles.   There will be a few
types of projectiles,  with the difference being in the speed of the projectile, and the amount of damage
it inflicts on the user.  There will be a health bar at the top of the screen that decreases everytime a projectile hits the user at the bottom of the screen.  The amount of damage will dependent on the type of projectile.  The user can either choose to shoot regular bullets that destroy the projectile,  or you can click on a second button on the screen that allows the user to shoot a bomb that clears the entire screen of projectiles.   This bomb will use up x% of your health bar.   Every x seconds,  x% of your health bar is restored. 
The point of the game is to destroy the incoming projectiles to prevent them from lowering your health to zero, where you lose the game.  The amount of time the user lasts will be present at the end of every game as a score.   The skill in the game should come from the user balancing when to use what type of attack (shoot, bomb), along with the sequential restoring of the health bar, and the speed and damage inflicted by the projectiles will make it difficult to maintain this balance for a long period of time. 
For this game,  I will need to implement several features in the code to help distinguish the different types of damage and speed inflicted by the 2 types of projectiles.  The game will implement random spawning of different types of projectiles into the game area and have a health bar that changes based on real time actions of whats happening in the game.  There will be game objects that need to behave a certain way depending on what type of different game object it interacts with. 