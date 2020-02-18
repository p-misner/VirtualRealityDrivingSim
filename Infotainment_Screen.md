# Infotainment Screen - Documentation

1. Create a cube game object (Game Object > 3D object > Cube)

2. Move the cube to be a child of the instance of the realistic car prefab.
It does not necessarily matter where in the hierarchy, it just needs to be a
child so that it's movement is consistent with that of the rest of the car. 

-photo-

3. For positioning the screen, it is good to (at least initially) place it
as a child of car interior, with a transform of 0,0,0 - and then manually 
adjusting the transform so that the screen is located somewhere to the right
of the steering wheel. It is good practice to angle it a bit so that it can
appear more like a real screen

4. Change the dimensions of the cube so that it resembles a thin 
rectangular prism (.30,.18,.001 work well)

5. Check that the gameObject's settings are the following:
(*Note - the lighting settings are especially important and can cause 
the video to black out under shadows if not configured properly)


-photo-

6. Add a video player component to the cube game object in the inspector

7. Make sure your video is an MP4 file in your project's assets folder

8. Drag the video from the assets folder to the inspector to fill the value
of the Video Clip Variable in the Video Source component

9. Ensure that the rest of these settings in the image below are in place.

10. Add an audio source component to the cube game object in the inspector

11. Make sure the corresponding audio for the video is in the project's assets folder.
(We got this by using a simple MP4->MP3 converter online) 

12. Drag the audio from the assets folder to the inspector the fill the value 
of the AudioClip variable in the Audio Source Component


13. Ensure that the rest of these settings are in place:


-photo-
