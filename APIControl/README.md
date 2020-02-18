# Using AirSim APIs
AirSim exposes APIs for car and simulation control and feedback. Some example scripts are included in the initial AirSim download. Full information about AirSim's APIs can be found [here](https://github.com/Microsoft/AirSim/blob/master/docs/apis.md).

## Set-Up Requirements

1. Make sure Unity and AirSim are installed and set-up and all requirements in [Getting Started](https://github.com/p-misner/VirtualRealityDrivingSim/blob/master/README.md) are completed (Windridge City not necessary).
2. Make sure python (VERSION???) is installed on your computer. 
3. In the file explorer for your AirSim project, navigate into the PythonClient folder. This is where you'll find all the provided example scripts for AirSim's APIs. Double click on setup.py, which should install all the necessary packages for Windows. (FOR MAC INSTALL SEPARATELY?????).

## Running Scripts Manually
Note: This requires use of command prompt (Windows) or Terminal (Mac).

1. In the command line, navigate to the folder in which the script you want to run is located. For example, to run the hello_car provided script, navigate to the AirSim folder, and then `cd PythonClient` then `cd car`.
2. Open the Unity project that you want to start the script in and start running. Try this in the UnityDemo for hello_car by playing the SimModeSelector and choosing the CarDemo. 
3. Switch back to the command line and run the python script with the format: `python filename.py`. For hello_car, type: `python hello_car.py`
4. Switch back to the Unity project and watch the script run. 


## Running python scripts from inside Unity
Note: this script is set up to start when the trigger is clicked with the mouse. 

1. Add a cube to the scene (`GameObject > 3D object > cube`). This will be the trigger for the script. Position cube in an accessible location to be trigger.

2. Attach `StartPython.cs` script to cube. 

3. Type the file address of the script you want to run in the `file_address` box. For easy access, navigate to the file in the file explorer, click the top address bar, and select copy as text and then paste into file_address box. The address should end with the filename.

4. Check the `Is Trigger` box under the Box Collider settings of the trigger cube.

5. To change how the script is triggered, open the script and change `OnMouseDown()` to a different function, for example ` OnTriggerEnter(Collider other)` to trigger when the block is hit. 

 

