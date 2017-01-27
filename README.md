# D&D 5e Combat Tracker
A D&amp;D 5e Combat Tracker made using Windows Forms


##What does it do?
This program allows you to track your combat in Dungeons and Dragons 5e. It is created for fellow DM's so you can speed up your combat and not make your players wait a couple minutes before you are finally ready to begin. 

You can add/modify/delete characters/monsters that are in combat, set their name, initiative, HP/Max HP/Temp HP, conditions and death saving throws. You can use the "Reduce HP" input to automatically adjust the HP of a character so you don't have to do the math.

You are able to see the current character's details and also who's up next. This is useful because you can tell the upcoming player (If the upcoming character is a PC, of course) that his/her turn is after the current one and thus the character can start preparing.

##What does it look like?
*Images will be added soon.*

##Roadmap

Right now the code is quite ugly. I created this project for fun and for some friends. I want to improve the code and add the following features:

* Save/Import/Export characters
  * This would be useful if you, for example, want to save your PC's and use them again on a later date. If you load this program on a different computer then you would just be able to import a certain file and all the characters would be loaded instantly. You could also create characters like a Goblin so you can easily add those to the Tracker.
* Use WPF or a better "pattern" in WinForms so the code would be a lot better.
  * Right now the code is a mess, and it needs a lot of improvement. A pattern like MVC, MVVM or something like that would improve the codebase a lot.
* Create a manual for this software.
  * I could maybe use the wiki or create a PDF about how to use this program so it would be more user friendly
* Allow users to prioritize characters with the same initiative
* Allow the user to change character names
  * Right now, if you create a character and want to change its name, a new character will be added with that name. Being able to change the name would be a nice feature.
* Let the user roll initiative quicker
  * I prefer rolling things like stats and initiative with real dice, but if you want to speed up the process of combat, it'd be nice to be able to click on a button which would roll the initiative for you.
* Keyboard shortcuts
  * Allow the user to set keybinds so he can perform actions such as editing specific fields or pressing the "Next" button with just a press of a button on the keyboard.
  
All other upcoming features/bugfixes can be seen in the [Issues](https://github.com/sander1095/DnDCombatTracker/issues) Tab


##Contribute
If you want to contribute, make sure to create a pull request and tell me what you added/changed. Also, if you worked on an Issue, make sure to include that.

If you spot a bug or something that doesn't work correctly, create an issue or find a way to contact me :)

##License
This project is licensed with the [MIT License](https://github.com/sander1095/DnDCombatTracker/blob/master/LICENSE)


