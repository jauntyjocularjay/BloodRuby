using System;
using System.Collections.Generic;
using UnityEngine;


public class PartyManager : MonoBehaviour
{
    public Party party;
    public BattleFormation formation;
}

public class Party : List<BattlerData>
{
    public Party(List<BattlerData> partyMembers)
    {
        if(partyMembers.Count > 5){
            throw new PartyOverflow();
        }
        else
        {
            for(int i = 0; i < partyMembers.Count; i++)
            {
                this.Add(partyMembers[i]);
            }
        }
    }

    public BattlerData GetLeader()
    {
        return (BattlerData) this[0];
    }

    public BattlerData GetMonster(int index)
    {
        if(index <= 0 || index >= this.Count)
        {
            throw new PartyIndexInvalid($"Non-leader Monsters are only located at indices between 1-{this.Count-1} inside this PlayerParty.");
        }
        else
        {
            return (BattlerData) this[index];
        }
    }

    public BattlerData GetBattler(int index)
    {
        if(index < 0 || index > this.Count)
        {
            throw new PartyIndexInvalid($"Monsters in this party are between 0 and {this.Count - 1}");
        }
        else
        {
            return this[index];
        }
    }

    public void AddPartyMember(BattlerData monster)
    {
        if(this.Count > 5)
        {
            throw new PartyOverflow();
        }
        else
        {
            this.Add(monster);
        }
    }
} 

public enum BattleFormation
{
    W, // 2 forward wings, 1 mid, 2 rear
    E, // 3 forward, 2 rear
    M, // 2 forward, 1 mid, 2 rear wings
    V, // 2 forward wings, 1 rear
    invertedE, // 2 forward, 3 rear
    invertedV // 1 forward, 2 rear wings
}

public class PartyIndexInvalid : Exception
{
    public PartyIndexInvalid() : base(){}

    public PartyIndexInvalid(string message) : base(message){}
}

public class PartyOverflow : Exception
{
    public PartyOverflow() : base("A party can contain a maximum of five monsters."){}
}

