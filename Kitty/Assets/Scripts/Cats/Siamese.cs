using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Siamese : Cat
{
    private void Start()
    {
        type = Type.Siamese;
        rarity = Rarity.Common;
    }

    Siamese(string catName, Profession pro) : base (catName, pro)
    {
        Start();
    }

    public override void Lifecycle()
    {
        // lifecycle override
    }
}
