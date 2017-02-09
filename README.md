# Octoslots for Splatoon 2.12.0

<p align="center">
  <img src="http://i.imgur.com/vpfeuJC.png" alt="Octoslots"/>
</p>

Octoslots is an alternative to Octohax that lets you poke Octoling gender clientside, so only you can see them.  This also allows you to play with Octolings and Inklings on the same map, as well as working Octotentacles!  In addition, you can sync up your games while playing with friends so that all genders are consistant for each player.

If you want to use the Splatoon font used for this tool, you can find it here:
http://fizzystack.web.fc2.com/paintball.html

##Requirements

+ Windows Vista or higher (Mac and Linux users, use Wine)
+ [.NET Framework 4.5.2](http://go.microsoft.com/fwlink/?LinkId=328843)
+ Wii U System Firmware 5.5.1 or below
+ Splatoon with version 2.12.0
+ TCPGecko + kernel from loadiine.ovh website, Dimok's [TCPGecko elf](http://wiiubru.com/appstore/#/app/TCPgecko), or [geckiine](https://gbatemp.net/threads/release-geckiine-tcpgecko-and-cafiine-combined.433057/)

##Usage

- Connect, choose the current game mode, and check off who you want as an Octoling while in the matchmaking screen. The names will update as they appear in-game only for ranked and turf modes. See known issues for details. Note that the tool must always remain connected for it to work.


##FAQ:

###What's the ban risk?

- A. This program was thouroughly tested, and should be 100% safe to use online. This is because this is something nintendo cannot detect.
     
###I'm not showing up as an Octoling offline, but I do online.  What's the problem?

- A. Your character will always default to the slot at the top of the list offline. To fix the issue, make sure the checkbox at the top is selected offline.
  
###Which versions of TCPGecko are supported?

- A. TCPGecko and Geckiine are fully supported. Codehandler support is implemented but is currently unable to connect to the console due to an unknown issue. Festool support is planned, but will not be implemented until a later release.
     
###Where's the Octoling ink tank?

- A. Unfortunately, the Octoling ink tank pokes clientside and other times serverside, so it's decided that the Octoling tank will be omitted from this release. We might try to find a safer way to poke the tank for each player clientside, but that might be happening anytime soon. If you want the Octoling ink tank, safe Octohax has the offsets for it in the script.  Sorry for the inconvenience.
  
###Will Octolings show up and crash in my plaza?
  
- A. No. When Nintendo fixed the issue with Octolings online, they also made it so that anyone with the Octoling gender is forced back to the Inkling girl. (They actually did something right for once! :O)

###The program keeps on crashing when I use it, how do I prevent this?

- A. Most of the known crashes that occur within this program has to do with failing to read the names in the game's memory. To stop this, just simply change the mode to **Idle**. This stops the program from reading the game's memory while you can still make other players appear as clientside Octolings.

##Known issues

- Squad Battle and Private battle ram addresses appear to be broken. They also have an issue where the name slot placements are inconsistant with what you see on the tool and the game.  Because of this, They're replaced with the mode *Classic Offsets*. It should be noted that the names will only update as as the screen fades out of the matchmaking screen, and to match up the boxes checked with what you see in the tool, not in-game.  We hope to fix these issues in a later release.

- Due to the way Octoslots works, Octolings show up as inklings in the menus. There is currently no solution to fix this.

- Octolings will load fine in Battle Dojo, however, due to an unknown bug, the game crashes while leaving this mode. Unfortunately, there is no way to fix this issue. 
  
##Credits

Most of the credit goes to Bkool999, the creator of the program, and implemented all the octoling hacks. The credits also goes to Yahya14 for the coding, and Seressa and OatmealDome for their Splat AIO 2 for the base of the program.

