# Vanguard

Vanguard is an ambitious, Titanfall-inspired, arena multiplayer game built in [Unity](https://unity.com/) using the [Mirror Multiplayer Framework](https://github.com/vis2k/Mirror).  Vanguard is still very nacent, but we are moving quickly to make it fun and playable as soon as possible.

# Free and Open-Source

Vanguard is free and open-source!

We wanted to make a game that would allow us to relive the exciting, fast-paced battles that we have come to love, with the freedom of guaranteed longevity and source-code access.

# How can I play?

We don't have any official builds released yet, so if you want to test the game you'll have to run it from within the Unity Engine (sorry!  We'll have a build soon!).  In order to do so:

1. Download or clone the repo
2. Open the root of the repo in the [Unity Hub](https://unity3d.com/get-unity/download?_gl=1*1tvp0xz*_ga*OTkxODcxMzkyLjE2MjgyMzE5OTQ.*_ga_1S78EFL1W5*MTYyODQwOTY5OC40LjAuMTYyODQwOTY5OC42MA..&_ga=2.13935924.260475146.1628369466-991871392.1628231994).  The project will give you an error while opening, citing compilation errors
3. Open the project in safe mode, then add the [Mirror Unity Asset Package](https://assetstore.unity.com/packages/tools/network/mirror-129321).  The asset package is free, but they have not published a UPM package so it still must be installed manually (DevOps contributions for automation welcome!)
4. Once the import for Mirror has finished, you can exit safe mode and open the project
4. Download the [Discord Sdk](https://dl-game-sdk.discordapp.net/2.5.6/discord_game_sdk.zip)
5. Make a folder called plugins under asset folder
6. Copy lib/x86_64 into the plugins folder
7. Make a folder called DiscordGameSdk
8. Copy contents of the csharp folder to the DiscordGameSdk folder 
9. Click ParrelSync->Clones Manager in the toolbar at the top of the window
10. Click "Add new clone".  This will create an exact clone of the project on your machine, and will keep it in sync as you make changes to the main project.  This allows you to test multiplayer in the editor without having to "Build & Run" after every change.  You will only make changes in the main project, not the clones.  If you try to save a change in a clone you will get an error message.
11. Once the cloning process is done, click "Open in New Editor" to open the clone
12. Press play to connect to the dedicated server or press host to host a server of your own
13. If you host a server you can connect to it in the other editor by writing "localhost" to the ip address part and pressing play
14. Done!

# How do I Contribute?

Check out our CONTRIBUTING.md for details on how you can contribute to the project, as a programmer, artist, writer, translator, or even as a player!
