# SimpleECS
A very simple ECS system in C#


## What is an Entity Component System?
Let's assume you've written a game.  Imagine you've split your game logic into several well-defined classes, e.g. a movement class, a collision class, a drawing class.  Let's call them "systems".  Each has a specific and obvious role.  Also imagine that your game has a bunch of "things" that make up the game, such as the player's avatar, power-ups, bullets etc...  Let's call them "entities".

Each entity is basically a collection of data, and depending on what data it has, it can be handled by one or more systems.  For example, if it has "bounding box" data, it can be handled by the Collision System.  If it has image data, it can be drawn by the drawing system.

Your game then works by cycling through specific systems that are required to run each game loop, e.g. Player Input System, then the Movement System, then the Drawing System.  Each system then "processes" all the entities that apply to it, e.g. draw all the entities which have image data.  Systems may well send messages to other systems as-and-when required.  For example, your Collision System may send a message to your Score System if a player's bullet hits an alien.

And that's it!

The advantage of this is that it's very easy to pinpoint which bit of code is doing something.  If there's a problem with the animation, it will probably be in the Animation System.  If there's a bug with collisions, it will probably be in Collision System.  If you need to implement explosions, create an Explosion System.

Designing a game now becomes a task of defining your systems based on what your game is.  Once you have clearly defined and scoped systems, the rest is (almost) easy!


## Credits
Developed by Stephen Carlyle-Smith - stephen.carlylesmith@googlemail.com


## Licence
BasicECS has an MIT licence.## Support
Feel free to email me at stephen.carlylesmith@googlemail.com with any questions.

