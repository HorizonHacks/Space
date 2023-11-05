BE CAREFUL WITH THE CONNECTIONS, YOU HAVE TO MAKE THE BUTTONS AND INPUTS ON YOUR OWN
## Inspiration
### After doing several HTML and Python projects**
- Still wanting to do a computer science project, but with objects, not just consoles.
- Already did a very basic tutorial in Unity and found it interesting, wanted to try again. 
- Interest in space, wanting to create comparisons to better understand space.
## What it does
1. Speed - Adjustable speed with speed of light given.
2. Size - Two adjustable planets in radius.
3. Orbits - Circular orbit around each planet, also uses speed as input.
4. Free Movement - Camera can move in all axes and rotate.
## How we built it
###Platform and General Setup
#### Planning + Asset Hunting
1. Going for a space theme with planets.
2. Thinking about equations for circular orbit.
3. Finding space-related assets to download and import for the sky and planets (asteroids came later).
###Unity
####Setup
1. Important space-related assets, making the skybox.
2. Creating 3D Game Objects: Adding two spheres to serve as planets, asteroids, and a line to keep track of the two planets. 
3. Creating UIs: Adding a pair of orbit buttons and radius text boxes, as well as one distance and one speed text box.
####Coding
1. Scripts (Part 1): Making individual scripts for the camera, planets, and asteroids.
2. Event Triggers/Input: Creating event triggers for the orbit buttons and InputFields for the text boxes, which were connected to the planet and camera scripts.
3. Scripts (Part 2): Incorporating camera movement, speed, and radius to create orbits. A script for one planet contained the distance information and radius, and the initial planet used radius to change the size and gap between the planets.
4. Testing and Cleaning: Tested the inputs on the first planet, then applied them to the other. Abstracting the code: using more variables and finalizing inputs.
5. Finalizing + Extra Touches: Creating additional scripts for the asteroids to rotate, making adjustments to equations, and adding instructions and a key.
## Challenges we ran into
### Unity Itself
- Crashed Twice and resultantly lost progress.
- Heavy battery consumption, limited my workspaces to areas near outlets.
- Errors clogged the console, sometimes annoying to get useful information.
### Coding
- Finding the right equations for the circular orbit, I accidentally used derivates of the orbit instead of basic trigonometry and lost a lot of time because of it.
- Took very long for little progress: not very complicated code, but it took longer than expected.
## Accomplishments that we're proud of
### Ascetics
- Nice assets, asteroids added an extra appeal to the look.
### Organization
- Although the buttons are not very abstract, they are organized in a logical way and all work as expected. The controls are cohesive as well.
## What we learned
### Inspector in Unity
1. Better understanding of event triggers.
2. Knowing better how to connect something to code.
3. Using the inspector to better monitor positioning.
### C#
1. How to add inputs directly from scripts.
2. Transform: learning how to rotate, change size, and change the position of an object.
3. Syntax: learning the types of variables and functions, math, and concatenation.
### Ascetics
- Using skyboxes
### Dedication
- Working on a single project for many hours this weekend helped improve my mental and physical endurance.
## What's next for Basic Space-Themed Visualization
1. Built-in Stopwatch: A stopwatch that measures time elapsed between distances covered.
2. Better Buttons/UI: Buttons that end the function when clicked again and that don't overlap. Condensing and simplifying the interface, as well as improving its overall style.
3. Option to add any number of planets.
4. Elliptical instead of circular orbits.
5. Fitting project to any screen.
