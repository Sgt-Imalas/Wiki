# Rocket Platforms

Rocket Platforms mark the start of every rocket constructed. Rocketry Expanded adds two new rocket platforms, expanding on their functionality.<br>
Both newly added platforms feature shifted logic ports. This feature prevents logic wires not made from tungsten from getting melted by the rocket exhaust on launch.

## Rocket Platform (Vanilla)
All information about the normal rocket platform can be found in the [ONI Wiki](https://oxygennotincluded.fandom.com/wiki/Rocket_Platform).
### Logic port behaviour
Ports:<br>
<img width=400 src="../../../../img/buildings/platform_normal_logicports.png"><br>
ehavior:<br>

|Port|Type|How does this port work?|
| :---------- | :----: |:---------------------------- |
|Rocket Presence Port|Output|Is there is a rocket on the launchpad?<br>🟩 ⇾ Yes <br>🟥 ⇾ No|
|Rocket Flight Check Port|Output|Is Rocket is ready to take a roundtrip flight to its chosen destination?<br>🟩 ⇾ Yes <br>🟥 ⇾ No|
|Rocket Launch Port|Input|🟩 ⇾ the rocket will try to launch <br>🟥 ⇾ any launch attempts are canceled|

## Fortified Rocket Platform

|<font size="+1">Fortified Rocket Platform</font>|A platform from which rockets can be launched<br> and on which they can land. Fortified to withstand comets.|
| ----------: | :----------------------------------- |
| **Sprite** |<img src="../../../../img/buildings/bunker_pad.png"> |
| **Building-ID**|`RTB_BunkerLaunchPad`|
| [**Research**](https://oxygennotincluded.fandom.com/wiki/Research)  | Superheated Forging  |
| **Building Category**  | [Rocketry](https://oxygennotincluded.fandom.com/wiki/Rocketry_(Building))/Structural  |
| **Dimensions**  | 2x7 tiles |
| [**Decor**](https://oxygennotincluded.fandom.com/wiki/Decor)   | 0 |
| <font size="+1">**Materials**</font> |<!-- --> |
| [**Steel**](https://oxygennotincluded.fandom.com/wiki/Steel) |1200kg |

The Fortified Rocket Platform features the same logic ports as the normal Rocket Platform, however these are moved outside the rocket exhaust cone.</br>
This rocket platform is fortified. This makes it immune to meteor damage, and it blocks meteors from falling down further. It also blocks duplicants from walking in front of the platform, so keep it in mind when designing and building your base around it.

### Logic port behaviour
Ports:<br>
<img width=400 src="../../../../img/buildings/platform_bunker_logicports.png"><br>
Behaviour:<br>

|Port|Type|How does this port work?|
| :---------- | :----: |:---------------------------- |
|Rocket Presence Port|Output|Is there is a rocket on the launchpad?<br>🟩 ⇾ Yes <br>🟥 ⇾ No|
|Rocket Flight Check Port|Output|Is Rocket is ready to take a roundtrip flight to its chosen destination?<br>🟩 ⇾ Yes <br>🟥 ⇾ No|
|Rocket Launch Port|Input|🟩 ⇾ the rocket will try to launch <br>🟥 ⇾ any launch attempts are canceled|

## Fortified Rocket Platform

|<font size="+1">Advanced Rocket Platform</font>|A platform from which rockets can be launched<br> and on which they can land.Comes with shifted logic ports<br> and extra ribbon ports for more control over the rocket.|
| ----------: | :----------------------------------- |
| **Sprite** |<img src="../../../../img/buildings/adv_pad.png"> |
| **Building-ID**|`RTB_AdvancedLaunchPad`|
| [**Research**](https://oxygennotincluded.fandom.com/wiki/Research)  | Parallel Automation |
| **Building Category**  | [Rocketry](https://oxygennotincluded.fandom.com/wiki/Rocketry_(Building))/Structural  |
| **Dimensions**  | 2x7 tiles |
| [**Decor**](https://oxygennotincluded.fandom.com/wiki/Decor)   | 0 |
| <font size="+1">**Materials**</font> |<!-- --> |
| [**Refined Metals**](https://oxygennotincluded.fandom.com/wiki/Refined_Metal) |900kg |

The Advanced Rocket Platform features the same shift of logic ports as the Fortified Rocket Platform. Additionally, there is a ribbon output that outputs the state of the Launch Checklist.</br>The Rocket Launch Port is converted to a ribbon input that allows to override Cargo Manifest warnings for automated rockets.

### Logic port behaviour
Ports:<br>
<img width=400 src="../../../../img/buildings/platform_adv_logicports.png"><br>
Behaviour:<br>

|Port|Type|How does this port work?|
| :---------- | :----: |:---------------------------- |
|Rocket Presence Port|Output|Is there is a rocket on the launchpad?<br>🟩 ⇾ Yes <br>🟥 ⇾ No|
|Rocket Flight Check Port|Output|Is Rocket is ready to take a roundtrip flight to its chosen destination?<br>🟩 ⇾ Yes <br>🟥 ⇾ No|
|Flight Checklist Ribbon Port|Ribbon Output|Bit 1: Is the category "Flight Route" fulfilled?<br>🟩⬛⬛⬛ ⇾ Yes <br>🟥⬛⬛⬛ ⇾ No <br><br>Bit 2: Is the category "Rocket Construction" fulfilled?<br>⬛🟩⬛⬛ ⇾ Yes <br>⬛🟥⬛⬛ ⇾ No <br><br>Bit 3: Is the category "Cargo Manifest" fulfilled?<br>⬛⬛🟩⬛ ⇾ Yes <br>⬛⬛🟥⬛ ⇾ No <br><br>Bit 4: Is the category "Crew Manifest" fulfilled?<br>⬛⬛⬛🟩 ⇾ Yes <br>⬛⬛⬛🟥 ⇾ No|
|Rocket Launch Ribbon Port|Ribbon Input|Bit 1:<br>🟩⬛⬛⬛ ⇾ the rocket will try to launch <br>🟥⬛⬛⬛ ⇾ any launch attempts are canceled <br><br>Bit 2:<br>⬛🟩⬛⬛ ⇾ Activates warning override for fuel check <br>⬛🟥⬛⬛ ⇾ Deactivates the override for the fuel check <br><br>Bit 3:<br>⬛⬛🟩⬛ ⇾ Activates warning override for the cargo check <br>⬛⬛🟥⬛ ⇾ Deactivates the override for the cargo check. <br><br>Bit 4:<br>⬛⬛⬛🟩 ⇾ Warning Overrides affect all logic checks; this makes them affect the logic outputs of the rocket platform.<br>⬛⬛⬛🟥 ⇾ Warning Overrides are only applied when the trigger-launch-signal on Bit 1 is active (during launch) <br><br>

### Warning Override
The Rocket Launch Ribbon Port allows overriding Cargo Manifest Warnings - But what does that mean?
When a rocket is launched automatically (via Bit 1), it checks if the Launch Checklist Categories "Cargo Manifest" and "Rocket Construction" are in the state "Ready".<br>
The Warning Override for the category of its Bit (see table under Logic port behaviour) overrides this behaviour, allowing the automated launch when the category displays a warning.

When you look at the items in the category "Cargo Manifest" you will see that these can appear orange, this equals a "Warning".<br>
Warnings allow starting a rocket manually, but prevent an automated launch.<br>
Activating a Warning Override will make it apply the "Ready" behaviour while being in either the "Ready" or "Warning" state.
#### Fueled State
For the "Fueled" state has the following state logic:

|  State | Appearance | Logic behind it| Can the rocket launch like this?|
| :------- | :----: |:---- | :---- |
| 🟥 Error | Text is red  | The rocket does not have enough fuel to reach its target location|No|
| 🟧 Warning | Text is orange  | The rocket has enough fuel to reach its target location, but not enough for the trip back|only manually|
| ✅ Ready | Text is black, Checkmark is set| The rocket has enough fuel to reach its target location and come back without a refuel stop|yes, both manually and automatic|

#### Cargo State
The Cargo state is a bit special in its state logic:

|  State | Appearance | Logic behind it| Can the rocket launch like this?|
| :------- | :----: |:---- | :---- |
| 🟧 Warning | Text is orange  | There are ongoing loading/unloading operations |only manually<br>(yes edge case described below)|
| ✅ Ready | Text is black, Checkmark is set| There are no ongoing loading/unloading operation|yes, both manually and automatic|

This check is "Ready" by default, and it only changes to "Warning" once any loader/unloader building (from now on called "resource transfer building") starts moving resources from or to the rocket.<br>
This results in state of "Ready" for a few seconds while a rocket is landing, before these resource transfer buildings can start their work and change the state to "Warning".
When you don't account for this, the following can happen:<br><br>
A rocket platform that has Bit 1 and Bit 2 enabled, while Bit 3 is disabled, will instantly launch after arriving, since the launch got already triggered before any resource transfer building could start their work and thus, the cargo state never switched to "Warning", which would have prevented the launch.<br><br>
If you plan on creating such a scenario, the aforementioned behaviour can be circumvented by not enabling Bit 1 by default, but instead attaching it to the Rocket Presence Port with a [Filter Gate](https://oxygennotincluded.fandom.com/wiki/FILTER_Gate) in between.<br>
This gives the resource transfer buildings the time to start their work and to update the Cargo state to "Warning".

### But Why?
Using this override allows launching rockets automated that have uncompleted cargo transfer, not enough fuel for a roundtrip or both.<br>
This allows setting up automated Rocket that are only fueled at one of the two rocket platforms. This works as following:<br>

* Set up the two rocket platforms on their respective planets.
* Set up the refuel equipment at one of them, this is your refuel station, the other platform is the outpost.
* Enable the warning override on the planet without the refuel station. Keep it disabled on the refuel station rocket platform.

When an automated rocket has these two platforms set up with roundtrip function, it will start of at the refuel station. Here it will load up fuel, until the Rockets "Fueled" state reaches "Ready". Now it has enough fuel for a full roundtrip.<br>
When it reaches the outpost, it will have burned 1/2 of its total fuel, making it go to the "Warning" state, since it still has (exactly) enough fuel to return to the refuel station, but not for a roundtrip afterwards. Since it gets fully fueled up once it has reached the refuel station, the warning can be safely ignored.<br>
Now you have an automated rocket route that only requires refueling infrastructure on one of the two planets.




