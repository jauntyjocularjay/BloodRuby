using System;
using System.Collections.Generic;
using UnityEngine;


public class PartyManager : MonoBehaviour
{
    public PartyList<PartySpot> partySpots = new();
    public PartyList<BattlerData> partyData = new();
    public BattleFormation formation;

    void Start()
    {
        for(int i = 0; i < partyData.Count; i++)
        {
            partySpots[i].battler = partyData[i];
        }
    }
}

public class PartyList<T> : List<T>
{
    readonly int maximumLength = 5;

    public PartyList() {}
    public PartyList(T item)
    {
        if(Count <= maximumLength)
            Add(item);
        else
            throw new IndexOutOfRangeException($"PartyList<T> has a maximum length of {maximumLength}");
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
    public PartyOverflow() : base("A party can contain a maximum of five members."){}
}

