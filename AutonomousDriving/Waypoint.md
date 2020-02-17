# Driving the Car with Waypoint Markers

## Dependencies
Ensure the Car package from Unity Standard Assets is installed. All scripts used are included in this download

## Car Route
### Adding Controller Scripts to Car
1. Navigate to the  `Standard Assets > Vehicles > Car > Scripts ` folder and drag the script titled `CarAIControl` onto the car model in your scene.
2. If the `CarUserControl` script is currently attached to the car, deselect it in the Inspector.
3. Navigate to the `Standard Assets > Utility` folder, locate the `WaypointProgressTracker` script and drag it onto the car. Once the Waypoint Circuit (empty object created below ) has been made, drag that empty object into the `Circuit` category in the Inspector.
4. In the hierarchy underneath your car prefab, there should be a folder titled `Helpers` with a child named `WaypointTargetObject`. Drag that object into the `Target` field in the inspector in both the `Waypoint Progress Tracker` script and the `Car AI Control` script

![Adding components](../images/WaypointCircuitInspector.png).
5. Ensure that in the inspector for the `Car AI Control` script, driving is checked.


### Creating Waypoint Circuit
1. Create an empty object in the hierarchy.
2. From the `Standard Assets > Utility` folder, locate the `WaypointCircuit` script and drag it onto the empty object
3. Place instances, or 'waypoints, of a 3D object (cubes are standard) along the path which you want the vehicle to take. For all the waypoints, ensure that the Box Collider is unchecked.
4. Drag the waypoints so they are children of the empty object. In the inspector, select `Assign using all child objects`. A yellow line showing the path your car will travel should appear similar to the image depicted below
![Adding components](../images/placeholder.png).


