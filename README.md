## About
Tower Defense: Go-Block A Project to end all project<br>
<br>
Go-Block is a 3D Tower defense game that has 2 unique maps and have Infinite waves of enemies and 2 towers that has different value and strength opening up different strategies by using `TowerTargetting.cs` and `TowerBehaviour.cs`. Killing enemies gives money which can be used to buy more Towers. Polished version with post processing for showcase and very scaleable with more Towers, Enemies and Maps.
<br> <br>

<tbody>
    <tr>
      <td><img src="https://github.com/fajarnadril/TowerDefense/blob/AlexVersion/Tower-Def.gif"/></td>
    </tr>
    
## Roles
Artist: Fajar <br>
Programmer: Alexander NL

## Scripts and Features
scripts:
|  Script       | Description                                                  | Development Time |
| ------------------- | ------------------------------------------------------------ | -------------- |
| `CameraMover.cs` | Handles the Camera Movement by using standards movement mechanic (W,A,S,D) | ≈ 1 hours | 
| `Economy.cs` | Handles the Economy of the Game, Buying towers and killing enemies | ≈ 2 hours | 
| `TowerBehaviour.cs` | Related to Tower Behaviour like shooting and Tower related stats | ≈ 2 hours | 
| `TowerTargetting.cs` | Related to Targetting of the towers against the Enemy by using Quaternion.LookRotation and shoot the enemies using `TowerBehaviour.cs` AttackTarget() function | ≈ 4 hours | 
| `Enemy.cs` | Handles the Enemy movement and walking to differnt waypoint inside the map and ending up in the Final waypoint | ≈ 2 hours | 
| `WaveSpawner.cs` | Handles spawning enemy waves that is an increment of + 2 | ≈ 2 hours | 
| `etc`  | | ≈ 8 hours | 

This project also uses these package:
- Universal RP

Post Processing used:
- Bloom
- Vignette
- Colour Adjustment 
- Gamma

the game has:
- Economy
- Infinite Waves 
- 2 Towers
- 2 Unique Map
- Post Processing and particle system

<br>

## Game controls
The following controls are bound in-game, for gameplay and testing.
| Key Binding       | Function          |
| ----------------- | ----------------- |
| W,A,S,D           | Camera Controls |
| Q | Cancel Placement of Towers |

<br>

## Notes
this game is developed in **Unity Editor 2021.1.13f1**
