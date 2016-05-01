using UnityEngine;
using System.Collections;

public class Character
{
    public int _Health { get; set; }
    public int _Attack { get; set; }
    public int _Defense { get; set; }

    public Character()
    {
        _Health = 20;
        _Attack = 5;
        _Defense = 3;
    }
    public Character(int health, int attack, int defense)
    {
        _Health = health;
        _Attack = attack;
        _Defense = defense;
    }
}
