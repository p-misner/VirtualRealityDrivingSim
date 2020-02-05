# Virtual Reality Driving Sim
A guidebook for building and customizing a virtual reality driving simulator for use in human factors and psychology research

## Getting Started
These instructions will walk you through how to install Microsoft Air Sim in Unity and the project files  up and running on your local machine for development and testing purposes.

### System Requirements

Download the [Unity Engine] (https://unity.com/). When instaled, Microsoft Air Sim comes with some sample Unity scenes and a wrapper around the AirLib library to run as a native plugin in Unity.

### Installing Microsoft Air Sim
The github documentation for [AirSim](https://github.com/microsoft/AirSim/blob/master/Unity/README.md) includes intructions for installing the Car simulator but these instructions miss several steps. Thus we have included a more detailed set of instructions here detailing some common errors/ mistakes but many of the steps are paraphrased from the original documentation.

#### Build AirSim
* Install Visual Studios 2017 (it is important that VS 2017 is installed rather than  any of the more current versions of Visual Studio)
* Once installed, open the `x64 Native Tools Command Prompt for VS 2017` after Air Sim has downloaded. This is different from the Windows Command Prompt.
![Adding components](./images/placeholder.png)
* Choose the directory you wish to download Air Sim into, then clone the repo: `git clone https://github.com/Microsoft/AirSim.git`
* Receiving the error ________?
* Once the repo is successfully cloned, go to the Air Sim directory using `cd AirSim`
* Run `build.cmd` from the command line

#### Build Unity Project
* Go inside the AirSim\Unity directory: `cd Unity`.
* Build the unity project: build.cmd.

#### Downloading Windridge City

## Trigger Commands


