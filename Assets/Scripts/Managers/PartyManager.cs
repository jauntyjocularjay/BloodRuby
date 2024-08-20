using System;
using System.Collections.Generic;
using UnityEngine;


public class PartyManager : MonoBehaviour
{
    public Party party;
    public BattleFormation formation;
}

public class Party : List<Battler>
{
    public Party(List<Battler> partyMembers)
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

    public Battler GetLeader()
    {
        return (Battler) this[0];
    }

    public Battler GetMonster(int index)
    {
        if(index <= 0 || index >= this.Count)
        {
            throw new MonsterPosition($"Non-leader Monsters are only located at indices between 1-{this.Count-1} inside this PlayerParty.");
        }
        else
        {
            return (Battler) this[index];
        }
    }

    public void AddSupport(Battler monster)
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

public class MonsterPosition : Exception
{
    public MonsterPosition() : base(){}

    public MonsterPosition(string message) : base(message){}
}

public class PartyOverflow : Exception
{
    public PartyOverflow() : base("A party can contain a maximum of five monsters."){}
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
