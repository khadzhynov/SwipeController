# SwipeController
Input overlay to detect swipe movements

SwipeController initially utilizes old Unitys InputManager, but can be easely converted to use any input.

## Features ##

- Contains a bunch of presets: two-directions (like left-right), four directions, eight directions, hexagonal swipes.
- Can be easely configured (from code) to act with any number of directions.
- No-Code-Usage: just attach SwipeListener script onto gameobject, then find UnityEvents OnSwipe(string) and OnSwipeCancelled in Inspector.
- Same code for desktop (Mac, PC) and handheld (iOS, Android) versions.

## How it works ##

In Update method, it looks onto Input events. When mouse button pressed (or touch started), it starts to wait, while pointer will be moved far enough to beat the treshold (based on sensetivity parameter). 
When it happened, OnSwipe event is invoked with a string parameter. In case when pre-defined preset (like FourDirections) is used, the parameter is one of pre-defined string constants of class DirectionId.
If user releases button (or removed finger) without movement, or the movement is less than sensetivity treshold, OnSwipeCancelled event is fiered.

For set up the custom set of directions, you should call 
SwipeListener.SetDetectionMode(param),
Where <param> is a List<DirectionId>.
Direction ID is a simple read-only container for Vector3 direction and string ID.
So, as mentioned above, you can easely build your own coordinate system, based on Vector3/string pairs.
Note, that there is no negative values, and no actual axes - only vector directions, which enables user to build, for example, 3-directions system with directions like UP, RIGHT and DOWN-LEFT.
And even more, there is an ability to implement 3D swipes (for virtual reality) - its not supported because of default Input system utilized, but not a big deal to replace it with unitys XR input (implementation planned for future versions).

## Video tutorials ##

#### Codeless setup ####
https://youtu.be/sMYx8NY8FEs 

#### Scripting setup ####
https://youtu.be/G6imm7pTA1c

## WebGL Demo ##

http://bryarey.zzz.com.ua/SwipeController/index.html

## Contact ##
Mail:
bryarey@gmail.com

Skype:
m.khadzhynov

Support me on Patreon:
https://www.patreon.com/user?u=26313020&fan_landing=true

Subscribe on Games Garden channel on YouTube:
https://www.youtube.com/channel/UCH6WybnFgT199Kkd6vm7-Lg

LinkedIn:
https://www.linkedin.com/in/mykhaylo-khadzhynov-15635915/

Games Garden web site:
https://www.gamesgarden.net/


  
