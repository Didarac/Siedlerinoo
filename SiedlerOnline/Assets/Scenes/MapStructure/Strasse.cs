using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strasse : Edge
{
    Player player;
    public Strasse(Player _player) {
        this.player = _player;

    }

    public override bool isStrasse() {
        return true;
    }

    public override bool isEdge(){
        return true;
    }
}
