

------------------------------------------------------------------------------
								My Data Stuff                    
------------------------------------------------------------------------------

------------
Contents:
------------
1. Overview 

2.1 SEA - Data from SEA server

2.1. US - Data from US server

3. Tools

3.1 Tools\Extraction - Program to Extract Pak Files

3.1.1 Instructions

3.2 Tools\Decryption - Program to Decrypt CSV Files

3.3 Tools\L2RPacketReader - Program to Sniff L2R Packets

3.3.1 Instructions

3.3.2 Data Sniffed

3.3.3 Command Line Options

3.4 Tools\Lin2.txt - General Information on Pactch Servers

4. SourceFiles

4.1 SourceFiles\decrypt\ - Source to the decrypt program

4.2 SourceFiles\L2RPacketReader\ - source to the packet sniffer.

5.0 Codex - Latest Codex Sheets URLS




------------
1. Overview:
------------
This zip contains both the csv files I use to get my data about the game and 
the tools I use to pull the data from the client. In addition to this text 
file there are three base folders included. 



------------
2.1. SEA:
------------
This contains the csv data from the 358 client patch for the SEA version of 
the game that contain data that is not normally part of the client. Most of 
the additional data included in worthless but Npc.csv has drop information 
that when used in conjunction with data from ItemDrop.csv can give you the 
drop rates for items. Since this data is from SEA and from a future version of
the game it does not match perfectly with our servers. Neither does the 
ItemBox.csv, which can be use to figure out the chances of getting items from 
a box. 

Here is how to figure out drop rates from the SEA files. The drop rates in the
NPC.csv are just #/10,000 chance for an item to drop from an item group.
The item groups are located in the ItemDrop.csv and you can calculate which 
item you get from a drop group by dividing each item's drop rate in a group by
the sum of all the items in that drop group.
To calculate the chances of ItemBoxes you do a similar thing. You take the 
individual drop rates of items in a group and divide them by the sum of the 
drop rates in a group.




------------
2.2. US:
------------
This folder contains the latest csv data files for the US server as of 2/24/18
I refer to this patch as patch 56. The files include all sorts of random 
information that I use to pull out useful information from. Unlike the SEA 
folder There is no way to figure out drop rates for the US files. 
However, there is plenty of other useful information that can be obtained from
these files.

The US version includes 11 different translation of in game strings. I have 
only included English however the pak files contain a folder for each of the 
11 languages you can select in the game.



------------
3. Tools:
------------
Here are the two tools I use to get the csv files from the client and an 
additional text file.



------------
3.1 Tools\Extraction:
------------
The program I use to extract the files from pak files that contain the 
individual files is called quickbms version 0.8.3. It gets updated every few 
months and additional updates can be downloaded from the following link if it 
ever stops working:
http://aluigi.altervista.org/quickbms.htm

There is a possibility that that they will start to encrypt the pak files. 
Currently the pak files on the US Dev update server are encrypted and I can 
not access them. If the encryption comes to the live servers it is likely 
someone will post a new bms script that will be able to decrypt them.


------------
3.1.1 Instructions:
------------

1. Obtain a pak file to open. You can get them from your android emulator, 
   phone or download them directly from the server. The file in android is 
   located at:
     /data/data/com.netmarble.lin2ws/app_sandbox/data.pak
2. Open the quickbms.exe
   If you get the message that "Windows protected your PC look for the words 
   "More info" and click it. A option to Run anyway will appear. Click that to
   open the program and this pop up will not appear again.
2. Next, select the BMS script Lineage_2_Revolution.bms. It is in the same
   folder as the the program.
3. Select the pak file you want to open.
4. Select the folder where you want the files to be extracted.



------------
3.2 Tools\Decryption:
------------
This is a tool that I created to decrypt the csv files to make them readable. 
All you need to do is drag the encrypted files on to the decrypt.exe 
executable and a folder will be created in the same location as the csv files 
named "Decrypted" containing the decrypted csv files. Depending on file
structure you should be able to drag 300 csv files onto the file at the same 
time to be decrypted.



------------
3.3 Tools\L2RPacketReader:
------------

This is the packet sniffer I created for L2R. It runs on Windows machines and 
requires you run the game through an emulator. If you are running more than 
one client at a time it can cause it to break. 

The sniffer is completely passive, you start it, open the menus in the game 
that you want data from and then return to the sniffer and press enter to 
analyze the packets. It does not interfere with the the network traffic at 
all and does not send out any data. It only sniffs what it sent to and from 
the client.
It is not possible for it to be detected by the client running inside an emulator.
This is because the emulation happens inside a sandbox and can not access the
memory of the computer that is not directly used by the emulator.

The sniffer throws out readable data in two different folders. The "output" 
folder has fies that I have specifically made to be imported into Excel or 
Google Sheets with only the pertinent information displayed. The files in the 
"data" folder will contain all data I can pull from the packets that are 
parsed including parts I have not figured out yet. 

The "logs" folder contains log files that I use when I am working on the 
format of packets. It logs information on the packets as they come in and when
it analyzes the packets it will list the data type of each packet that was 
successfully decrypted.

The sniffer can currently output: 
	Every item in your inventory.
	Every person that hit a clan boss.
	Every donation made to the guild.
	The member details of any guild.
	Details from the guild info page.
	Details from the guild ranking page
	Codex information.

It also gives useless information like every skill/attack used by anyone else 
while it was running. It does not get information on your own attacks, just 
your skills. It also provides the x/y/z coordinates of where both players and 
npcs moved while the program is running. None of this includes names just 
unique player IDs.


------------
3.3.1 Instructions:
------------

1. Have a single instance of L2R running in an emulator.
2. Run the L2RPacketReader.exe
3. If you have more than one network adapter you will need to select which 
    network adapter will be used to listen for packets.
	  If you only have one network adapter it should skip this step.
	  If the network adapter you picked does not pick up any packets, try a 
	  different adapter.
3. Open the menus in game corresponding with the data you want to pull.
	For your inventory, guild donations, guild member details, guild 
	information, guild rankings, and codex information just open the 
	corresponding menus inside of the game.
	For the listing of every person that hit a clan boss have the program 
	running before the last hit on a boss happened and the results page is 
	displayed in game.
4. Once you have collected the information you want go back to the packet 
   sniffer and press enter to begin the decryption and analyzing of the 
   packets.
5. The program should automatically close after it has finished parsing the 
   packets. Navigate to the the output folder to find csv files containing the
   information you have sniffed.


------------
3.3.2 Data Sniffed:
------------
Inventory.csv - Items unique id, when it was looted, enchant level, items name
  items level, items current exp, amount of item, if liked, if bound, item 
  options on s grade+ items, soul crystals in each item, limit break level, 
  limit break add bonus, ability level, ability add bonus.

ClanDungeonResults.csv - Time it took to kill, number of players that hit boss
  items gained, name of every player that hit the boss and the percentage of 
  damage they did to boss.

DetailedGuildInfo.csv - Guild id, rank, name, leader, level, exp as a number, 
  exp as a percentage, reputation, combat power, current adena on hand , 
  current proof of blood on hand , current red star stones on hand, number of 
  members, members that checked in yesterday, members that checked in today, 
  fortress information, if it requires approval to join, the level requirement, 
  the public introduction, the private notice. 
	You will get this information for any guild that you pull up their info 
	page for.
	
GuildMemberList.csv - Clan ID, Clan name*, Member count, Each players id, name
  level, cp, role in clan, class, if they are online or how long they have been
  offline for, their current contribution number, their total contribution 
  number, if they have checked in today, the amount of rewards they have 
  obtained this week, the map they currently are on(this information is not 
  shared for your own clan members, only other clans which seems backwards), 
  and their introduction. 
    *The Clan name is not given from this menu so a vlookup is generated that
	will pull the clan name if you have imported the DetailedGuildInfo.csv to
	the same spreadsheet as you import this csv.

GuildRankings.csv - Clan Ranking, name, leader, level, exp, reputation, member
  count, combat power, wins, loses, draws, player level requirement, if they 
  require approval to join, and the clan intro.

ClanRecords.txt - Clan record information displayed like it is shown in game. 
  Clan buffs and some otehr things will appear as numbers and not as their 
  names.
ClanDonations.txt - Clan donation information displayed like it is shown in
  the game.
ClanDonations.csv - Time, name of donator, ammount donated, and what was 
  donated as a table.

Codex.txt - This file is not easily readable. It is generated to be pasted 
  into your personal copy of this Google Sheet. A black copy of which is
  located here:
https://docs.google.com/spreadsheets/d/11qO8jxBhc2sD0bkjpHc56l2DgtR80C8W47WFV8XLFfo/edit?usp=sharing
  This allows you to update your codex sheet in just a few minutes by doing 
  the following:
	Open the txt file.
	Select all and copy.
	Open the codex sheet to the codex tab.
	Select the cell highlighted in yellow. This is the cell for Black Fang 
	  Level 1, ie, Cell H4.
	Paste the data in.

	
------------
3.3.3 Command Line Options:
------------
If you run the L2PacketReader.exe from a command line or create a batch file
to run it there are several command line options that can be used.

Correct usage: L2RPacketReader.exe -(option) "(value)"

Standalone Options
-h: Displays help on command line options.
-c: Saves Capture files between executions.
    Decrypted Capture files will still be deleted.
-l: Saves Log files between executions.
-d: Saves Data files between executions.
-a: Reanalyzes the packets previously captured.

Options That Require Values
-i #: Sets which device to listen for packets to capture.
-f \"filter\": Sets a custom filter for the packets using winPCap's filtering.
               default filter value is "port 12000 and len > 60"



------------
3.4 Tools\Lin2.txt:
------------
This txt file that includes my notes on the update servers. This allows me to 
download the patch files out of the game so I do not need to copy the pak file
from android every time there is an update. The URLs do change with updates 
but they are simple to update. I will explain the first few lines of the 
document which pertain to the US servers.

US Config - This url is the config file the server send to you each time you 
log in. You will notice that the last directory before the config.json file is
a series of numbers. This is the version of the game. 
	1_02_10 = 1.02.10
Any time the game gets a good play update these number need to be changed for 
this and the next two files.

US List - This url is a listing of every patch available for download. It is a
space delimited file. The columns are:
  Number, File Name, First Byte, Last byte, Checksum.
The last byte is also the file's size. We are currently on number 56. Often 
before an update gets pushed live it will appear on this list but be commented 
out by two back slashes. This can be seen right now with update 57 and 58.

US QA2List - This is the pak list used to be used by the Quality Assurance 
server. It is the same as the one above and pulls pak files from the same 
server location. I do not currently know the right version for the QA server.

US Pak - This is a full url that will download the next patch, 41, when it
becomes available. Just replace the file name Version_00000041_ETC1.pak with 
the name from the list files above to download any other patch.

US FullLst - The game doesn't make new players download every patch. Every 
once an a wile they public a pak file that has all the patches up to that 
point. This is list of latest cumulative pak file.

US FullPak - This is just the URL to the last full pak file. The full packs 
are kept in the same directory as the individual update pak files.
  
The next two url's are a bit more tricky. I have not been able to find a 
listing of patches for them which makes it difficult to know when they have 
been updated.

USDEV Pak - this url contains patch files for the US Dev server. Up until last
week the only pak file on it dealt with the US Christmas Event. Now there are 
more pak files on it but they are encrypted. Without a version of Lineage 2 
Revolution that can decrypt these files I can not crack the decryption.

US QA Pak - this url contains patches for a QA build of the game that is 
different from the current build we use for the live servers. Pak 00000016 
enabled Giran on the QA server and 00000017 is a patch for the Giran build. 
This may or may not be used anymore.
  
  
  
------------
4. SourceFiles:
------------
This is the source code for the two programs that I made for l2r. They are 
both coded in C# and compiled in Microsoft Visual Studio 2017. If you have 
VS17 you can compile the programs yourself and alter them as you wish.



------------
4.1 SourceFiles\decrypt:
------------

The encryption for csv files is done using a very simple Triple DES 
encryption. The encryption key is "Netmarbl". The first 8 bytes of each file 
is encrypted using the first 8 letters of each filename, this called the 
initialization vector. There are exceptions to this and the program handles 
them using an array listing the exceptions by file name and their custom IV. 
If any decrypted file has anything weird going on with the first 8 letters 
then it either needs a custom IV to decrypt them correctly or needs the custom
IV already in the program deleted. 



------------
4.2 SourceFiles\L2RPacketReader:
------------

This program is done verily sloppily which is why the program runs so poorly. 
I have no real programing experience and most of this was done as I taught 
myself some basic C#. 

It uses two outside libraries. CSVHelper to read the CSV files and SharpPCap 
to do the packet sniffing. They are included with the source but I have not 
done any alterations to their code so they can be deleted and re-downloaded 
using NuGet. 

I have commented the source the best I can so it hopefully can be easily to 
understand at least what I was trying to do.

Packets that are received are encrypted using a simple 8 byte XOR. The
encryption key is 0xA7, 0x84, 0x20, 0xD0, 0xC9, 0x78, 0xB3, 0x9A.
Packets that are sent have some additional protect for the first 4 to 20 
bytes that I have no bothered to figure out. As such, the program can not 
decrypt or analyze any packets sent to the server.


The CSV folder has classes that are used to read the individual CSV files.
the CusENum folder contains classes that are used to look up values that do 
  not have a CSV file that corresponds with the information.
The Misc folder includes a single class that is used to convert seconds to 
  days, hours, minutes, and seconds.
The Parser folder is where all the parsers I have made are located.
	Handler.cs handles the identification of every packet and calls the
      parsers for packets that the program knows how to parse.
	The Parsers folder contains parsers that dump all the information 
	  contained in each packet to csv files in the data folder.
	The ReadableParsers folder  contains the parsers that dump only useful 
	  information in a more readable format as csv files to the output folder.
	  These csv files can be loaded into Google Sheets or excel to view the 
	  data easily.
All of the Packet ID's as of US version 1.02.10 are listed in the Handler.cs 
so someone with someone with some knowledge can easily track any other packet 
and work out how to parse it. 

------------
L2RPacketReader2
------------
L2RPacketReader2 is still in really rough form. Unlike the previous version 
this version of the packet reader will capture packets, decrypt, and parse 
them as they come in. It currently does not have any parsers written for it 
and the packet parsers written for the first one need to be modified for the
extra bytes at the start of each packet that this version currently uses.

It also has a few random errors. I have ran it for over an hour with no issues
but other times it crashes after only a few minutes.

------------
5.0 Codex Sheets:
------------
These are Google spreadsheets that I made to help optimize CP gained from
working on your codex individually and in a party.

------------
Individual Sheet
------------

Just make a copy of it and it will help you figure out which cores you should
be after to get the best CP gain. It also provides rough estimates for how 
many monsters you need to kill to complete a codex entry either in the field
or in summon stones and can adjust those numbers for both the whole clan buffs
and the clan potion buff.

The packet reader will provide output data that can be pasted into the sheet 
to update it automatically or you can do it by hand.

Just open the following link, then press "File" -> "Make a Copy...":
https://docs.google.com/spreadsheets/d/11qO8jxBhc2sD0bkjpHc56l2DgtR80C8W47WFV8XLFfo/edit?usp=sharing

SEA Server:
https://docs.google.com/spreadsheets/d/1X9wkcs71XNYQtk7wplsko9XDJUq73va8hggMeqOW7n4/edit?usp=sharing
US Server March Update:
https://docs.google.com/spreadsheets/d/1kfmV5pHdTaclbcwF9PC-MnFs4j7RWwg4zIrLwHuto0E/edit?usp=sharing


------------
Party Sheet
------------

This next sheet is for people that are working on their codex's together. It
requires that everyone in the party first has filled out the codex sheet 
above and has a share link for it.

Paste each of the share links into the spots allocated for them in the setup 
tab and the sheet will take care of the rest. It will now show data similar to
the data for the individual codex sheet but only for cores that everyone in 
the party needs.

Just open the following link, then press "File" -> "Make a Copy...":
https://docs.google.com/spreadsheets/d/1IsH6ZlXpXBmxMHU30WfgfFNrmp0o4aHFwal6QUYQD7M/edit?usp=sharing

US Server March Update:
https://docs.google.com/spreadsheets/d/1rUsLL2M86AtGLtDStkKOv5pgwpw0DbOmU90eIBhDWFI/edit?usp=sharing
