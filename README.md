> NOTE: Unfortunately the dlls that controll the music pause/play were removed from Windows 10/11 through some update in the past.  
> If you happen to have an old unpatched windows (which you realy should not have - go update your system) this might still work.
> If you find a way (besids emulating a Keyboard) of controlling the pause/play directly - feel free to reach out to me or open a issue/PR

# CSGOMusicPlayer
The CSGOMusicPlayer is a Programm, which uses CSGOs GameStateIntegration and Microsoft Windows Media Control to pause your music when you need focus and play it when you have some spare time.

## What it does?
The CSGOMusicPlayer Stops your Music (e.g. Spotify, Youtube etc.) when you are in an active round and pauses it if you die, the round ends, the game ends or during freeztimes (e.g. Tactical timeouts

## Requirements:
- Windows 10 64bit (you can compile a 32bit version yourself too but honestly who has still a 32bit Windows version in 2021?)
- Counter-Strike: Global Offensive
- 3rd party music provider (e.g. WebBrowser/Spotify/etc.)

## How to set up?
- Find the directory in which you installed CSGO then go to the /csgo/cfg folder and copy and paste the [gamestate_integration_musicControl.cfg](https://github.com/MichaMican/CSGOMusicPlayer/blob/main/gamestate_integration_musicControl.cfg) into it.  
Note that this **is NOT a cheat** and it **will NOT get detected as such**. I'm using an [official interface (gamestate integration)] provided by the CSGO Developers
- Start a song (and pause it imediately if you want) in your 3rd party music provider (e.g. WebBrowser/Spotify/etc.)
- After that execute the Program (CSGOMusicPlayer.exe) and (re)start CSGO

## Where to get it?
You can download the latest precompiled binaries aswell as the gamestate integration config file for CSGO and the sourcecode from here the release section: https://github.com/MichaMican/CSGOMusicPlayer/releases/latest  
Obviously running "some weird .exe" that you downloaded from the web sounds a bit fishy. If you don't trust me: The sourcecode is available in this repo. Feel free to open it in Visual Studio (or another C# compiling ISE), inspect it and compile it yourself.


If you run into any issues or find any bugs, feel free to contact me:  
Discord: DerOta#1234
