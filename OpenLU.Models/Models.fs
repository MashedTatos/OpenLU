﻿namespace OpenLU.Models
open System
open System.Net
open System.Numerics

module rec GameModels = 
   
    type public User() =  class
        member val Id = 0 with get,set
        member val Username = "" with get,set
        member val Password = "" with get,set
        member val Characters = System.Collections.Generic.List<Character>() with get,set
        member val CurrentCharId : int64 = int64 0 with get,set
        
        end

    type public UserSession() = class
        member val Id = "" with get, set
        member val UserId = 0 with get, set
        
        member val EndPoint = "" with get,set
        member val Port = IPEndPoint.MinPort with get, set

        end
        
    type public Character() = class
        member val Id  = (int64)0 with get,set
        member val Name = "" with get,set
        member val DisplayName = "" with get, set
        member val FreeToPlay = false with get,set
        member val HeadColor = uint32 0 with get, set
        member val Head = uint32 0 with get, set
        member val ShirtColor  = uint32 0 with get,set
        member val ShirtStyle = uint32 0 with get,set
        member val PantsStyle =uint32 0 with get,set
        member val PantsColor = uint32 0 with get,set
        member val HairStyle = uint32 0 with get,set
        member val HairColor = uint32 0 with get,set
        member val LH = uint32 0 with get,set
        member val RH = uint32 0 with get,set
        member val Eyebrows = uint32 0 with get,set
        member val Eyes = uint32 0 with get,set
        member val Mouth = uint32 0 with get,set
        member val Zone = uint16 0 with get,set
        member val LastMapInstance = uint16 0 with get,set
        member val LastMapClone = uint32 0 with get,set
        member val LastLogin = uint64 0 with get,set
        member val UserId = 0 with get,set
        member val User : User = User() with get,set
        member val LegoScore = uint64 0 with get,set
        member val Currency = uint64 0 with get,set
        member val BricksCollected = uint64 0 with get,set
        member val SmashablesSmashed = uint64 0 with get,set
        member val QuickBuildsCollected = uint64 0 with get,set
        member val EnemiesSmashed = uint64 0 with get,set
        member val RocketsUsed = uint64 0 with get,set
        member val MissionsCompleted = uint64 0 with get,set
        member val PetsTamed = uint64 0 with get,set
        member val ImaginationPowerUps = uint64 0 with get,set
        member val LifePowerUps = uint64 0 with get,set
        member val ArmorPowerUps = uint64 0 with get,set
        member val DistanceTraveled = uint64 0 with get,set
        member val NumberTimesSmashed = uint64 0 with get,set
        member val TotalDamageTaken = uint64 0 with get,set
        member val TotalDamageHealed = uint64 0 with get,set
        member val TotalArmorRepaired = uint64 0 with get,set
        member val TotalImaginationRestored = uint64 0 with get,set
        member val TotalImaginationUsed = uint64 0 with get,set
        member val TotalDistanceDrivenCar = uint64 0 with get,set
        member val TimeAirbornInRaceCar = uint64 0 with get,set
        member val RacingImaginationPowerUps = uint64 0 with get,set
        member val RacingImaginationCrates = uint64 0 with get,set
        member val RaceCarBoostsActivated = uint64 0 with get,set
        member val WrecksInRaceCar = uint64 0 with get,set
        member val RacingSmashablesSmashed = uint64 0 with get,set
        member val RacesFinished = uint64 0 with get,set
        member val RacesWon = uint64 0 with get,set
        member val Level = uint32 1 with get,set
        
        member val Inventory = System.Collections.Generic.List<InventoryItem>() with get,set
        

        end

    type public InventoryItem() = class
        member val Id : int64 = int64 0 with get,set 
        member val Lot = uint32 0 with get, set
        member val Equipped : bool =  false with get,set
        member val CharacterId = int64 0 with get, set
        member val Character = Character() with get,set
        
        end







    


    
