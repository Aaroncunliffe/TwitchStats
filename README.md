# TwitchStats
A simple C# desktop application to interact with the twitch.tv api

## Features:
Once a channel name is entered, it parses and displays the results in a UI, 
#### Useful channel information such as:
* Channel creation date
* Mature
* Partnered
* Followers
* Unique viewers


#### Useful stream information such as:
* Current Viewers
* Delay
* When the current active stream started
* Stream uptime
* Current stream thumbnail

Also dynamically graphs channel viewers over time whilst the program is running.

![twitchstats](https://github.com/Aaroncunliffe/TwitchStats/blob/master/twitchstats.png?raw=true)

## Usage:
In both mainForm.cs and chatForm.cs string ClientID needs to be replaced with a valid client id, an account can be made at https://dev.twitch.tv/

### Learning Outcomes:
1. Interacting with an API
2. Visual C#
3. Drawing graphs with C#

Uses https://github.com/JamesNK/Newtonsoft.Json to parse the json results
