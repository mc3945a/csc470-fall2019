Marc Cohen final game document

Markdown
-------------


Gameplay:
 The game I will make will be a racing game.   The game will start with a title screen, where the player will choose from one of 3 difficulties,  easy, medium, or hard.   The difference between the difficulties will be discussed later.    The player will see a countdown from 3, and the race will start.  From here, the player will be able to control a car and accelerate it using the space key, and the left and right arrow key.   The camera will be slightly above and behind the player,  so that you are always looking at the back of the car at the angle that the car is pointing.  To go faster,  the user can press the spacebar to ignite the cars engine.   I am thinking that there will be a bar at the top or side of the screen that if full at the start,  and goes down whenever the user presses the space bar for a certain amount of time.  There will be a recharge time on the bar to ensure the player isn't just speed boosting the engine the whole time.  Another option is using a health bar for another feature of the game that will be kept track of, like player health. 

As far as the challenge or point of the game,  I haven’t really decided what the goal of the game could be,  but the idea I’m leaning on is having a CPU car player race against the player.  
Option 1:
This CPU player would follow the same gameplay as the user, but the challenge would lie in figuring out how to make the CPU play the game automatically (boost on it's own,  turn on it's own, etc.)  I’m not sure how difficult it is to achieve this in code,  however I assume you might just assign random variables for the CPU as far as the turning and boosting goes, to give the impression that a real human is controlling the CPU car.  I’m sure this is similar to when i created objects that chase an enemy player,  I had to give each of them a min and max speed that randomly fluctuated throughout the game, to make sure they wouldn’t all just bunch together.  However, it would be hard to assign values to when the CPU boosts and how it turns on the race track all as it races against the player,  and so if this is too advanced I will have to figure out a new idea for the game besides having  CPU controlled car. 
Option 2: 
The player will be an ambulance, and the concept of the game will be to race to the hospital before the patient dies.   If I choose this option,  I’ll make a health bar be the patients health,  and make it slowly decrease over time.   As the player controls their ambulance through the race track, or street, maybe they will be able to collect gems to slightly restore the patients health.   If the health bar reaches zero,  the player loses, and if they reach the hospital in time, they win.   This option gives the game a concept for which I can work around better,  and have a theme where I can find ambulance and hospital poly figures,  or a siren audio in game. 

Input:
As far as user input,  I don’t think the player will be clicking or interacting with any UI objects with their mouse, aside from the game start menu where the player chooses a difficulty and presses the start button.   The extent of the actual gameplay will just be pressing space to accelerate,  and using the left and right arrow key to change direction.  
Visual Style:
I will plan to make the game look like a traditional racing game,  with the camera being behind the car,  and the road or “race track” being a path of a small width over a very long distance of road.   I will use the texture and landscape tools Unity offers to create a terrain around the road to give it a more realistic visual look.  What I haven’t figured out completely is the physics that the player car will have.   Maybe it will drive on a road with fences around it and not be able to go beyond the actual track inside the fences,  or maybe there won’t be any borders around the road,  and the player will just slow down when the car goes off road.  The walls or fences around the road will probably be easier to deal with as it pertains to the physics and rigged body of the car,  in order to get the most realistic feel for a racing game. 

Audio Style:
Whenever the player hits the space bar to accelerate the car,  there should be an audio cue that sounds like a car engine.   Maybe if a player turns too quickly while going too fast,  there will be an audio cue of tires screeching,  but that might be difficult to implement.   If I choose the option of the ambulance themed game,  there will be a constant siren going on in the background during the game,  and this, along with the car engine audio cue should make the game feel good from an audio standpoint.   If I choose to put a fence or wall bordering the road,  then maybe there can be a crash audio cue whenever the player car collides with the wall. 

Story Theme:
The more I plan the game out,  the more I think that choosing option 2 of having the player be an ambulance that must rush a patient to the hospital in a certain amount of time will be the best idea to implement.  This gives me a theme and less ambiguity as far as what the final game might look like,  and will make it easier to implement things during the process, like health gems to pick up on the road.    On the start screen,  instead of difficulty,  maybe there will be options like “fever”,  “broken bones” and “deathly ill”,  where each level of medical condition severity refers to the difficulty of the game,  example: for the “deathly ill” option,  the amount of time that the player needs to reach the hospital in order to win is lower than the “fever” option.   The siren noise in the background,  the ambulance car poly object,  and the hospital at the end of the road and game should give the game a good theme I can work around to be stimulating enough for somebody playing. 

Low Bar:
The lowest bar that this project could reach is basically all of option 2 being implemented.   A user controlling a car (ambulance google poly object)  that must race through a long patch of road (with a landscape and unpredictable turns) in a certain amount of time before the game ends.  There will be 2 difficulties in the lowest bar to choose from in the Start screen.   I think that the low bar should definitely still have health gems that the player can drive into and pick up,  that in turn regenerates the patient heath in a health bar on screen.  For the low bar,  there will be a wall surrounding the road that acts as a boundary and prevents the player from driving off road. 

High Bar:
The High bar will be essentially the same concept and game design as the low bar, except with extra features.  For example,  maybe there will be two different kinds of health gems that regenerate a different percentage of the patients health bar.    As well as putting a timer on the screen in the low bar,  I could also put a distance measure that shows the distance the player is currently from the hospital,  so they are able to manage their time better.   For the high bar,  I also might make an off road feature that slows down the player when they go off road and maybe even bump the car up and down.  This should be difficult to implement in the physics area though.   Another, different option for the high bar would be creating the game in option 1,  which features a CPU controlled car that races the user.  Option 2, while slightly less complicated, has a better theme and so I will probably end up doing option 2, regardless of which bar I reach. 

Timeline:

11/ 20/ 19:  Have a basic car controller with a road-  an incomplete road path with an gameobject or poly car object that can be controlled by accelerating with the space bar,  and moves left and right.  

11/24/19:  Make the health bar for the patients health appear randomly along the course of the road,  smooth out any driving mechanics and road structure.

11/30/19:  Make the health bar decrease over time,  and sightly increase when the player runs into a health gem.   Create a timer UI object that counts down.

12/5/19:  Implement the start screen.   Apply proper timer adjustments depending on which “difficulty” the player selects in the start screen.   Create a UI text for when player loses or wins.  
Implement audio.  Create a “3,2,1” countdown at beginning of game.

12/12/19:  Work out final bugs and kinks in game,  create a trailer, make screenshots, a description, and a website for the game. 
