# cse21005
# Cycle-- totallynottron
Cycle is played according to the following rules.

* Players can move up, down, left and right...
    - Player one moves using the W, S, A and D keys.
    - Player two moves using the I, K, J and L keys.
* Each player's trail grows as they move.
* Players try to maneuver so the opponent collides with their trail.
* If a player collides with their opponent's trail...
    - A "game over" message is displayed in the middle of the screen.
    - The cycles turn white.
    - Players keep moving and turning but don't run into each other.

# Project Structure
The project files and folders are organized as follows:  
* Cast:
    - Actor
    - Cast
    - Color
    - Point
    - Biker
    - Powerups? use food code
        -extra life
        - superspeed
        - slow speed
        - invincibility(10 sec?)?? Perhaps not
    - Score?(keep track of who's winning and reset w/out running the code again)
        - or alternatively how long you've lasted
* Scripting
    - Script
    - Action
    - Controlactorsaction
    - Drawactorsaction
    - Handlecollisions
        - add a thing that kills you if you hit the wall
    - Moveactorsaction
* Services
    - KeyboardServices
    - VideoService
* Directing
    - Director
* Program
* Constants

# Getting Started:
Make sure you have dotnet 6.0 or newer installed on your machine. Open a terminal and browse to the project's root folder. Start the program by running the following commands:

dotnet add package raylib-cs 
dotnet build 
dotnet run

# Authors
- Dillon Leone
- Nathan Marble
- Andre Regino
- Justin Paystrup
- Madison Brown
- Emma Quackenbush

## To do:
- change biker colors 
- change biker start positions and directions
- collision with other biker
- just have a grand old time