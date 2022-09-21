# Outer Wilds : Unity Template
Template Unity Project with Outer Wilds scripts in it, meant for making AssetBundles to use in mods (such as new horizons).

Works with Unity **2019.4.27f1**. You need to use specifically **this version.** 
Newer versions will not work, as AssetBundles are not forward-compatible.

To make textures look right you have to change the colour space in project settings.

Edit -> Project Settings -> Player -> Other Settings -> Rendering -> Color Space

Change it to `linear`.

### How to use

1. Clone the template and load it into Unity with **2019.4.27f1**
2. Open the *Project Settings*, change paths and options as required
3. Build your content (usually into a prefab) and label it to be build into an AssetBundle.
4. In the top bar, go *Assets > Build AssetBundles*
5. All AssetBundles will get built, and if you specified the game launch option the game will also be started.
