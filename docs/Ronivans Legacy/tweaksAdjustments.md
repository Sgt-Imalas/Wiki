# Tweaks and Additions

This page lists the tweaks, adjustments and additions that have been made to the mods
items found in the sources of Ronivans mods that were hidden, broke or were temporarily removed

LIST WIP.

## General

### UX / UI

- All mod content is now translatable. A template can be found in the mod folder
- The codex now contains pages for several added material tags
- connection lines on the research screen no longer overlap
- research screen items with too many entries now get collapsed when not hovered to preserve space
- the codex now lists random recipe result ranges
- several recipes had their display icon adjusted to be less confusing
- reenabled elements now show up in the codex
- buildings with multiple element converters have them now grouped in the ui for better visibility

### Buildings

- All buildings can now be turned off individually in the building editor of the mod config
- Certain buildings storage / wattage can be adjusted dynamically in the building editor
- Buildings with random recipe results now truly have randomized recipe outputs. These outputs will now be listed in the Codex and the recipe screen.<br>Affected buildings:<br> Ball Crusher Mill (Chemical Washing), Ball Crusher Mill (Mechanical Separation), Selective Arc Furnace, Auger Drill, Asteroid Drill Mk-II
- Recipes that want a type of resource (e.g. ores, metals) in the mod have been changed from hardcoded to dynamic - they now include new materials of that type automatically
- buildings that had duplicates in different mods have been merged into one. Different recipes in the duplicates have been preserved in the merge
- mush bar input consumption of building converters has been reduced
- buildings with different looking variants, but otherwise identical stats, have been merged into one building. The different variants have become building blueprints.
- buildings that require pipe inputs/outputs will now display a status item for each missing connection
- buildings with invisible pipe inputs in the planned building will now show previews for those inputs in buildable preview
- several building pipe ports have had their color tweaked for better visibility
- added sounds to most modded buildings
- all fridge type buildings now list their energy saver wattage in the build menu
- all pipe and conveyor rail buildings now list their transfer capacity in the build menu
- fixed foreground layering of a few animation
- building ports that take in a specific element will have that specified in their "input missing"-tooltip
- added hysteresis storage mod integration to storage and loader buildings
- some buildings have become flippable/rotatable that weren't previously

## Chemical Processing - Biochemistry

### Elements

- Biodiesel has been renamed to "Renewable Diesel" to avoid confusion with the new vanilla element
- vegetable oil can now be turned into phyto oil (25kg oil + 75kg water -> 100kg phytooil, consider it to be concentrated phyto oil)
- Bioplastic now works as a substitute for normal plastic in several recipes

### Buildings

- Anaerobic digester recipes are now generated dynamically based on the underlying formula instead of being hardcoded. This will automatically include new food types now.
- New PPP food recipes have been added to the Expeller Press
- expeller press seed recipes are now dynamic and grouped into one entry
- expeller press seed recipes now use 10 seeds at once
- reduced expeller press working time
- The Algae Growing Basins light requirement has been restored. It can now have its production speed boosted by high light intensity
- Anaerobic digester natural gas output has been significantly increased to make it a viable alternative use method to the expeller press. Default is x10, this can be configured/reverted in the mod config.

## Chemical Processing - Industrial Overhaul

### Elements

- several elements had broken transitions fixed.
- several broken/missing element tags have been restored
- Plasteel and PhosphorBronze can now substitute Steel in building construction (this was intended before, but not working)
- solid ammonia had its shc & tc fixed (it was off by a factor of 100)
- Nitrogen has been restored in gas, liquid, solid form
- Isopropane (a supercoolant level gas) has been restored
- Rayon Fabric now works generally as a substitute to Reed fiber
- Zinc and silver ore now can be acquired in certain meteor showers from new meteor types
- heavy meteors (source of meteor ore) have been added to additional appropriate spaced out meteor shower types
- Metal diet of hatches now includes silver and zinc ore

### Buildings

- the Ball Crusher Mill of this mod is now called Ball Crusher Mill (Chemical Washing) to avoid confusion with the other building from Mineral Processing - Metallurgy.
- the missing Toxic Slurry output from the Ball Crusher Mill recipes has been restored
- the custom buildings for the metal refinery and oil well cap have been deprecated. Instead, the vanilla buildings are now modified. This ensures compatibility with other mods that add new recipes or changes to those buildings.
- The Chemical Mixing Unit building has been restored; it is similar to the Emulsifier, with piped inputs for crafting materials
- The Ammonia Breaker building has been restored, it allows extracting Nitrogen from Ammonia.
- fixed building hitbox of naphta reformer and raw gas reformer
- boiler buildings have been tweaked to better serve as an alternative power source: combined with steam turbines, they allow extracting at least 50% more power from their respective burn material
- coal boiler can now burn peat as an alternative to coal
- The old Raw Gas Refinery and Crude Oil Refinery buildings have been restored as "Multi-Staged-[...]" buildings (they have each been split into two newer buildings)

## Custom Generators

- restored custom solar panel building
- adjusted heat production of custom generators to be scaled to their production
- increased custom steam turbine base wattage to reflect size percentage of regular turbine
- generators piping is now optional, with no pipe installed, it vents into the world
- super sustainable now accounts for custom burner generators

## Custom Reservoirs

- rebalanced the default capacity of reservoirs to new gas reservoir capacity
- medium reservoirs no longer require the any port to be connected to function
- condensed the two variants of the small reservoirs into one build menu entry, swappable via blueprint selector
- all reserovir capacities can be tweaked in the building editor of the config
- medium reservoirs can now be flipped

## Dupes Engineering

- Removed POI props -> dedicated poi building mod
- Cement Mixer now has new recipes that interact with Chemical Processing
- several buildings merged into one + skins
- Restored Spacer Window Tile and Spacer Tile
- Elemental tiles have been merged into a single building screen entry, each variant is accessible by selecting its respective element
- Brick Tile has been restored
- wooden panel/wall have been turned into drywall skins
- concrete tile now acts as a bunker tile

## Dupes Machinery

- when chemical processing is enabled, the Flocculation Seeve gets a new converter for toxic slurry
- reduced algae vat wattage to 60 to be more in line with most buildings

## Dupes Refrigeration

- Rebalanced power consumption and heat production - this can be changed in the building editor
- hightech frige and hightech refrigerator now have an optional rail input
- merged several large refridgerators into one building + skins
- restored some alternative animations as skins

## Dupes Logistics

- when HPA is enabled, Logistic rails now have reduced transfer capacity to fill the niche of "early game rails" better. This can be adjusted/disabled in the config
- when the above is enabled, transfering "too heavy" items onto a logistic rail will cause the excess mass to drop from the rail.
- added valve building to transfer items from a regular to a logistic rail without dropping items.
- the logistic sweeper now rotates slightly slower than the regular sweeper
- Storage Cabinets now have an optional rail input
- logistic rails are now slightly tinted in green in the conveyor overlay

## Mineral Processing - Metallurgy

- the Ball Crusher Mill of this mod is now called Ball Crusher Mill (Mechanical Separation) to avoid confusion with the other building from Mineral Processing - Metallurgy.
- The plasma furnace now uses any carrier gas, not only hydrogen
- basic oil refinery can now burn peat as an alternative to coal

## Mineral Processing - Mining

- the old mk1 mineral drill building has been restored
- Guidance Units are now programmable. This can be done either by the new recipe in the CNC-machine, or manually by a duplicant after selecting the new program in its sidescreen.
- Guidance Units now no longer get consumed in the drilling operation, instead it has durability that is slowly consumed with the drilling operation. If an operation is set to run continuously, the unit will be kept in storage, otherwise it will drop a the end of the drilling operation.
- When Chemical Processing is enabled, elements from that mod can be found in the drill result lists
- The Asteroid Drill is now limited to one per asteroid as it was intended in the code, but buggy before.
- When Heavy-Duty rails are enabled, the Asteroid Drill now requires one.
- Cancelling a drilling operation will no longer refund the drillbit

## High Pressure Applications

- the "filled" amount of liquids and gas blobs of high pressure pipes is now scaled to the total capacity of the pipe
- the mod no longer patches Game.Update, which would cause it to be blamed on every crash
- Rocket port buildings and Spacefarer module ports now support high pressure pipe throughput
- liquid in high pressure liquid pump animation is now tinted to its contents
- high pressure pumps no longer become activated by gas behind walls
- added powered High Pressure Gas and Liquid Vent buildings
- Added High Capacity Rail System: these work similar to heavy watt wires (no building them in tiles) and serve as a rail variant of high pressure pipes
- Added Insulated High Capacity Rails
- Added High Capacity Autosweeper
- Optimized high pressure pipe logic in a few spots
- high pressure pumps now have their center input tile at the position the animation shows it
- Decompression valves now always output the regular capacity amount
- increased internal storage of high pressure pumps to ensure continuous operation
- added multi-material filters for all 3 types of pipes/rails
- high pressure pumps and certain other high pressure buildings may now require a high pressure pipe to function

## Nuclear Processing

- fixed building hitbox of light reactor
- made rad projector 3 high to have the emitter in the center of the animation again
- restored radiation emission values from mod page
