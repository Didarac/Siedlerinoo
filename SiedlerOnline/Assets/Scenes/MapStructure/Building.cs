using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Building
{
    private Player player;

    public virtual bool isEmpty(){
        return true;
    }
    public virtual bool isSiedlung(){
        return false;
    }

    public virtual bool isStadt(){
        return false;
    }

    public Player getPlayer(){
        return this.player;
    }
}
