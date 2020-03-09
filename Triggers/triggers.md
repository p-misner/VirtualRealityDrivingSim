# Triggers
## Pausing the Car (Autonomous)
1. Download the `Pause.cs` and `Timer.cs` script from this folder and add into your Scripts folder
1. Create a cube that intersects with the path of the car
2. Drag and attach the `Pause.cs` script to the box.
3. Once attached in the inspector panel you can control the amount of time to stop the car


## Walking Pedestrian
1. Download the `PedestrianTrigger.cs` scrip from this folder and add into your Scripts folder in Unity
2. Create a cube that intersects with the path of the car
3. Drag and attach the script to the box.
4. Place a character/ figure of a person into your world and drag that GameObject into the Pedestrian field in the inspector panel
	* From the Unity Standards Asset folder you can use the `ThirdPersonController` prefab
5. Ensure the component (Ethan Skeleton in this case) has the component Nav Mesh Agent added in the inspector. Drag the component into the Agent field as well

### Building a NavMesh
* For the character to walk, first you must create a NavMesh from the terrain. Refer to this [link](https://docs.unity3d.com/Manual/nav-BuildingNavMesh.html) for details

