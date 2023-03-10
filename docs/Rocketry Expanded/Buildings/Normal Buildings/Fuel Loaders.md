# Fuel Loaders

Fuel Loaders are a new type of loader building that attaches to the rocket platform.</br>
These new buildings will fill up fuel, oxidizer and radbolt tanks in connected rockets.</br>
The type of fuel it tries to load is always dependent on the engine of the rocket; a fuel loader won't fill a liquid fuel tank or an oxidizer tank on a rocket with a steam engine.

Multiple Fuel Loaders can be used to increase fuel loading speed.

## Fuel Loader

|<font size="+1">Fuel Loader</font>|Refuels connected rockets with the appropriate fuel.</br> Automatically links when built to the side of a<br> [Rocket Platform](https://oxygennotincluded.fandom.com/wiki/Rocket_Platform) or another Rocket Port</td>|
| ----------: | :----------------------------------- |
| **Sprite** |<img src="../../../../img/buildings/fuel_loader.png"> |
| **Building-ID**|`RTB_UniversalFuelLoader`|
| [**Research**](https://oxygennotincluded.fandom.com/wiki/Research)  | Fuel Loaders  |
| **Building Category**  | [Rocketry](https://oxygennotincluded.fandom.com/wiki/Rocketry_(Building))/RocketFueling  |
| **Dimensions**  | 1x2 tiles |
| [**Power**](https://oxygennotincluded.fandom.com/wiki/Guide/Power_Circuits)   | 120W |
| [**Heat**](https://oxygennotincluded.fandom.com/wiki/Guide/Temperature_Management)   | +0.625 kDTU/s|
| [**Overheat**](https://oxygennotincluded.fandom.com/wiki/Overheating) at | 2273.15K / 2000°C |
| [**Shipping**](https://oxygennotincluded.fandom.com/wiki/Piping)| Input: Any Fuel|
| **Requires** | Must be built next to [Rocket Platform](https://oxygennotincluded.fandom.com/wiki/Rocket_Platform) |
| **Effects** | Allows loading of [Fuel Tanks](https://oxygennotincluded.fandom.com/wiki/Rocketry_(Spaced_Out)#Fuel_tanks_and_Oxidizers) |
| <font size="+1">**Materials**</font> |<!-- --> |
| [**Refined Metal**](https://oxygennotincluded.fandom.com/wiki/Refined_Metal) |400kg |

The normal Fuel Loader will fill all types of fuel tanks except radbolt storages with the fuels that are compatible with the rocket engine.</br>


## Oxidizer Loader

|<font size="+1">Oxidizer Loader</font>|Refuels connected rockets with the appropriate oxidizer.</br> Automatically links when built to the side of a<br> [Rocket Platform](https://oxygennotincluded.fandom.com/wiki/Rocket_Platform) or another Rocket Port</td>|
| ----------: | :----------------------------------- |
| **Sprite** |<img src="../../../../img/buildings/oxidizer_loader.png"> |
| **Building-ID**|`RTB_UniversalOxidizerLoader`|
| [**Research**](https://oxygennotincluded.fandom.com/wiki/Research)  | Fuel Loaders  |
| **Building Category**  | [Rocketry](https://oxygennotincluded.fandom.com/wiki/Rocketry_(Building))/RocketFueling  |
| **Dimensions**  | 1x2 tiles |
| [**Power**](https://oxygennotincluded.fandom.com/wiki/Guide/Power_Circuits)   | 120W |
| [**Heat**](https://oxygennotincluded.fandom.com/wiki/Guide/Temperature_Management)   | +0.625 kDTU/s|
| [**Overheat**](https://oxygennotincluded.fandom.com/wiki/Overheating) at | 2273.15K / 2000°C |
| [**Shipping**](https://oxygennotincluded.fandom.com/wiki/Piping)| Input: Any Oxidizer|
| **Requires** | Must be built next to [Rocket Platform](https://oxygennotincluded.fandom.com/wiki/Rocket_Platform) |
| **Effects** | Allows loading of [Oxidizer Tanks](https://oxygennotincluded.fandom.com/wiki/Rocketry_(Spaced_Out)#Fuel_tanks_and_Oxidizers) |
| <font size="+1">**Materials**</font> |<!-- --> |
| [**Refined Metal**](https://oxygennotincluded.fandom.com/wiki/Refined_Metal) |400kg |

The Oxidizer Loader will fill all types of oxidizer tanks when the rocket engine consumes oxidizer.

## Radbolt Loader
|<font size="+1">Radbolt Loader</font>| Fills all sorts of Radbolt Storages. </br>Allows fueling a Radbolt Engine and the Laser Drillcone.</br> Automatically links when built to the side of a [Rocket Platform](https://oxygennotincluded.fandom.com/wiki/Rocket_Platform) </br>or another Rocket Port</td>|
| ----------: | :----------------------------------- |
| **Sprite** |<img src="../../../../img/buildings/radbolt_loader.png"> |
| **Building-ID**|`RTB_HEPFuelLoader`|
| [**Research**](https://oxygennotincluded.fandom.com/wiki/Research)  | Fuel Loaders  |
| **Building Category**  | [Rocketry](https://oxygennotincluded.fandom.com/wiki/Rocketry_(Building))/RocketFueling  |
| **Dimensions**  | 1x3 tiles |
| [**Power**](https://oxygennotincluded.fandom.com/wiki/Guide/Power_Circuits)   | 120W |
| [**Heat**](https://oxygennotincluded.fandom.com/wiki/Guide/Temperature_Management)   | +0.625 kDTU/s|
| [**Overheat**](https://oxygennotincluded.fandom.com/wiki/Overheating) at | 2273.15K / 2000°C |
| [**Shipping**](https://oxygennotincluded.fandom.com/wiki/Piping)| Input: Any Oxidizer|
| **Requires** | Must be built next to [Rocket Platform](https://oxygennotincluded.fandom.com/wiki/Rocket_Platform) |
| **Effects** | Allows loading radbolts into rocket storages|
| **Storage Capacity** | 500 [Radbolts](https://oxygennotincluded.fandom.com/wiki/Radbolt)|
| <font size="+1">**Materials**</font> |<!-- --> |
| [**Refined Metal**](https://oxygennotincluded.fandom.com/wiki/Refined_Metal) | 400kg |

The Radbolt Loader fills up any radbolt storage on connected rockets. These include:
<ul>
<li>Radbolt Engine</li>
<li>Laser Drillcone</li>
<li>Radbolt Chamber Module</li>
</ul>
It has an internal storage of 500 radbolts that outputs a green logic signal when full.

