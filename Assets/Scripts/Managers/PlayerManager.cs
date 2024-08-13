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
        PlayerLeader leader
    )
    {
        Add(leader);
    }

    public PlayerParty(
        PlayerLeader leader, 
        PlayerMonster support1
    )
    {
        Add(leader);
        Add(support1);
    }
    public PlayerParty(
        PlayerLeader leader, 
        PlayerMonster support1, 
        PlayerMonster support2
    )
    {
        Add(leader);
        Add(support1);
        Add(support2);

    }
    public PlayerParty(
        PlayerLeader leader, 
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
        PlayerLeader leader, 
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

    public PlayerLeader GetLeader()
    {
        return (PlayerLeader) this[0];
    }

    public PlayerMonster GetMonster(int index)
    {
        if(index == 0 || index >= this.Count)
        {
            throw new MonsterPosition($"Monsters are only located at indices between 1-{this.Count-1} inside this PlayerParty.");
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

