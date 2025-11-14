# Unity Vector Practice — Distance Test

Test project for practicing vector operations in Unity.

 ## Demo:
 
<div align="center">
   <h3>Waypoint Movement</h3>
  <img src="https://github.com/user-attachments/assets/3fe0bf52-fc6b-46d5-919a-2a78d50a8f85" alt="Waypoint Movement">
  <p><em>Enemy following waypoints. UI displays real-time distance to player.</em></p>
</div>


<div align="center">
   <h3>Player Chase</h3>
  <img src="https://github.com/user-attachments/assets/b4fb9b67-dd7e-4366-ae93-985f99391deb" alt="Player Chase">
  <p><em>Enemy chasing the player using direction calculations.</em></p>
</div>

## What I tested:
- Object movement along waypoints
- Player chase behavior
- Direction and distance calculations
- Vector3 operations (normalized, magnitude)
- Debug.DrawRay and Gizmos
- UI updates with real-time distance

## Requirements:
- Unity 6.0.59
- URP
- TextMesh Pro

## Scripts:
- `EnemyController.cs` - waypoint movement using Queue
- `DistanceDetector.cs` - calculates distance between objects and updates UI

## How to run:
Open scene in Assets/Scenes and press Play.
