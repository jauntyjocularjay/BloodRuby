using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class PlayerManager : ScriptableObject
{
    public List<Battler> party;
}

public class PlayerParty : List<Battler>
{
    public PlayerParty(
        PlayerMonster leader
    )
    {
        Add(leader);
    }

    public PlayerParty(
        PlayerMonster leader, 
        PlayerMonster support1
    )
    {
        Add(leader);
        Add(support1);
    }
    public PlayerParty(
        PlayerMonster leader, 
        PlayerMonster support1, 
        PlayerMonster support2
    )
    {
        Add(leader);
        Add(support1);
        Add(support2);

    }
    public PlayerParty(
        PlayerMonster leader, 
        PlayerMonster support1, 
        PlayerMonster support2, 
        PlayerMonster support3
    )
    {
        Add(leader);
        Add(support1);
        Add(support2);
        Add(support3);
    }
    public PlayerParty(
        PlayerMonster leader, 
        PlayerMonster support1, 
        PlayerMonster support2, 
        PlayerMonster support3, 
        PlayerMonster support4
    )
    {
        Add(leader);
        Add(support1);
        Add(support2);
        Add(support3);
        Add(support4);
    }

    public PlayerMonster GetLeader()
    {
        return (PlayerMonster) this[0];
    }

    public PlayerMonster GetMonster(int index)
    {
        if(index == 0 || index >= this.Count)
        {
            throw new MonsterPosition($"Non-leader Monsters are only located at indices between 1-{this.Count-1} inside this PlayerParty.");
        }
        else
        {
            return (PlayerMonster) this[index];
        }

    }
} 

public class MonsterPosition : Exception
{
    public MonsterPosition() : base(){}

    public MonsterPosition(string message) : base(message){}
}

enum BattleFormation
{
    W, // 2 forward wings, 1 mid, 2 rear
    E, // 3 forward, 2 rear
    M, // 2 forward, 1 mid, 2 rear wings
    V, // 2 forward wings, 1 rear
    invertedE, // 2 forward, 3 rear
    invertedV // 1 forward, 2 rear wings
}