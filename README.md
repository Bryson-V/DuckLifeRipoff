DuckLife Ripoff 
=======================

 Overview:
 --------

This project consists of 2-3 mini-games, mimicking those found in Duck Life 4.  Each game will be 2D and consist of a player achieving a high score by living as long as possible, gaining  more points based on the number of obstacles cleared.  The game does not include a victory scene, as it revolves around how long the player lives.  A score is constantly counting on the top right corner, adding constantly due to time and not progress.  When the user loses in the game, the user is prompted with a menu, giving them their total score and number of obstacles passed.  This menu also allows the user to return to the menu screen where they can play a new game.  The main homepage contains an option for the player to choose which game they want to play.

Key Takeaways
--
Unity is very open in how it allows for users to have a variety of options in how the game is made.  Overall, it is easy for users to create new objects through the wide variety of documentations found online


Why did we make this game?
------

This Project was made with the goal of understanding unity better and some of the features included.  Although we used many built in features(Box2D, CircleCollider...) we are still missing many features that are commonly used, such as animations for characters.  However, we still feel that recreating the running minigames from Duck Life gave us an oportunity to use many of the basic features.


Download
----
Download link found here:
https://drive.google.com/file/d/1tA_AWNY9zESV4yXzB4WWzfUaUPYa2iJH/view?usp=sharing

Project Timelines
-----
The first 2 weeks were spent outside of Unity.  Before even starting to code, we wanted to create a full timeline for what we expect to accomplish abd by when.  From this point, we wanted to accomplish each game one by one.  Instead of working on each game in tandem, we wanted to work on each game until it functioned how we wanted, then move to a new game, only adding finishing touches at the end once we have time to clear our mind from the bias that comes from making work yourself.

Week 1-4 : Work on dropping game.
1. Create floors and player.  Allow the player to drop from gaps between platforms.
2. Move either camera down or platforms up.  When player goes offscreen on top, end the game
3. Create a respawning/infinite number of platforms.
To us, these were the three main goals in the first four weeks. We decided to deal with models and speed and even the scoring system later on, since we knew that it was not unique to this game.  We ended up finishing this early, which gave us time to prep for our next game, by writing code that was generic and only needed a few functions to track each game.

Week 5-8:  Work on dodging game
1. Create falling objects.
2. Game ends if player gets hit by object
3. Infinite falling objects with more per screen over time.
We chose to set our goals very standard since when we finish these goals early, it made us confident that we were able to not only accomplish something, but also that we were able to accomplish even harder goals, such as flashing animations for objects dropping.

Week 9-12:  Work on jumping game
1. Create horizontally moving objects
2. player must press a certain key to jump over
3. Infinitely spawning objects randomly using one of four jump heights necessary to clear.
 For our final game, we felt that this would be very easy.  As it turns out, most of the code became simpler as we not only knew what to do, but also were able to use some previous code and just fix parameters.

Rest of 9-12 (Likely 11-12)
1. Add Score system
2. Add death screen instead of freezing game.  Death screen leads to menu screen
3. Add images and models for objects
4. Add menu screen to let player choose which game to play
5. Add music to each screen/button press
Although we had many goals at this point, we felt confident to finish this, which we did.  Overall, we felt confident in our working ability and understood things much quicker than when we started

Week 13-14 Final two week sprint 
1. Have people [laytest game in order to fine tune speed of game/playability
2. Add more animations(Flashing colors, changing colors, effects on objects)
3. Make game run smoother (used to have frame drops at the start of some games)
4. Add instructions menu
5. Improve how fun jumping was (after coming back, game was clunky and didn't feel good)
