# Features
<h2 align="center">

<span>Automatically tracks the required fish for achievements.</span>
<br>
<img src="./resources/UI.png" width="500" style="padding-top: 15px;"/>

<br>

<span>Tracks the current time on the spectral current.</span>
<br>
<img src="./resources/Spectral_Counter.png" width="500" style="padding-top: 15px;"/>

<br>

<span>Resets the spectral fish count when entering a new zone.</span>
<br>
<img src="./resources/Spectral_Reset.png" width="500" style="padding-top: 15px;"/>
</h2>

<br>

# Limitations and Bugs
* These triggers do use C# code. The code is used to calculate the current route. If you're worried about the code you can review it yourself in the [TriggernometryOceanFishing.cs](https://github.com/austinglines42/TriggernometryOceanFishing/blob/v1.0.1/TriggernometryOceanFishing.cs) file. (I'm planning to remove in the future but at the current moment it simplifies the process a lot)
* Does not track players more than 20 yalms away.
* Does not track blue fish.

<br>

# How to Install
## Method 1: Remote trigger
1. Right click on "Remote triggers" then select "Add" then "Repository".
2. You can put anything for "Repository Name" and for "Address" you put: `https://raw.githubusercontent.com/austinglines42/TriggernometryOceanFishing/main/TriggernometryOceanFishing.xml`
3. Make sure to check "Allow triggers to execute scripts". It is safe to use but you can read more about it in the Limitations and Bugs section.
4. (Optional): In the updates tab you can have my script auto update when there's an update by enabling "Enable repository auto-update". At the current moment I'm updating the repository a lot, so daily updates are recommended.

<br>

## Method 2: Importing
1. Download the newest XML file from the [releases page](https://github.com/austinglines42/TriggernometryOceanFishing/releases).
2. Within Triggernometry select the folder you would like to import it into. Then click the "Import" button within the Triggernometry tab.
3. Select "Load from file or URI" then select the file that you downloaded, then click "Next >".
4. It will give you a warning about arbitrary code execution. Just click Import. It is safe to use but you can read more about it in the Limitations and Bugs section.
5. It is not working and ready to go! Happy Fishing!

<br>

# Contact Me
Best way to contact me is through discord: Aubis2#1355