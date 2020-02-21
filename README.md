# Virtual Reality Driving Sim
A guidebook for building and customizing a virtual reality driving simulator for use in human factors and psychology research
## How To Use This Project

## Getting Started
These instructions will walk you through how to install Microsoft Air Sim in Unity and the project files  up and running on your local machine for development and testing purposes.

### System Requirements

Download the [Unity Engine](https://unity.com/). When instaled, Microsoft Air Sim comes with some sample Unity scenes and a wrapper around the AirLib library to run as a native plugin in Unity.

### Background Knowledge
This guidebook assumes that users have prior knowledge of the basics of Unity -- i.e. creating GameObjects, C# scripts, physics properties and components, UI elements, and integrating assets from the Unity Asset store. Unity has a very detailed source of documentation, which you can check out at: https://docs.unity3d.com/Manual/index.html

### Installing Microsoft Air Sim
The github documentation for [AirSim](https://github.com/microsoft/AirSim/blob/master/Unity/README.md) includes intructions for installing the Car simulator but these instructions miss several steps. Thus we have included a more detailed set of instructions here detailing some common errors/ mistakes but many of the steps are paraphrased from the original documentation.

#### Build AirSim
* Install Visual Studios 2017 (it is important that VS 2017 is installed rather than  any of the more current versions of Visual Studio). Make sure to select VC++ and Windows SDK 8.1 while installing VS 2017.
* Once installed, open the `x64 Native Tools Command Prompt for VS 2017` after Air Sim has downloaded.
This is different from the Windows Command Prompt and should look like the image below
![Adding components](./images/placeholder.png)
* Choose the directory you wish to download Air Sim into, then clone the repo: `git clone https://github.com/Microsoft/AirSim.git`
* Receiving the error ________?
* Once the repo is successfully cloned, go to the Air Sim directory using `cd AirSim`
* Run `build.cmd` from the command line

#### Build Unity Project
* Go inside the AirSim\Unity directory: `cd Unity`.
* Build the unity project: build.cmd.

#### Downloading Windridge City
* After the Unity project is built, go to open a new Unity project and create a scene
* Go to the Asset Store and search "Windridge City" and download the asset of the same name
* After downloading there should be a folder in your scene titled `Folder Title here` with a subfolder `Scenes` that holds a scene titled `Windridge City Demo`. Double click on this scene to launch
* Upon opening this scene and trying to run it, a whole host of errors will pop up. The reason for this is the correct postprocessing package is not installed. Go to the `Window` tab in Unity and click on package manager in the drop down menu.
* Go to the Postprocessing tab and select `Install` for the most recent version of the postprocessing script. If the Postprocessing tab is not appearing, switch the view from In Project to All
* The warning `Lighting data asset 'LightingData' inconsistent. Please use Generate Lighting to rebuild the lihgting data` may appear.
* Air Sim should be fully set up after this point



