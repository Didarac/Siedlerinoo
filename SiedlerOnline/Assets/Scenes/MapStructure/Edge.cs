using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//abstrakte Klasse
public abstract class Edge
{
    private Player player;

    private Edge adjEdge1;
    private Edge adjEdge2;
    private Edge adjEdge3;
    private Edge adjEdge4;

    

    public virtual bool isStrasse() {
        return false;
    }

    public virtual bool isEdge(){
       return true;
    }

    public Player getPlayer(){
        return this.player;
    }

    public void setEdges(Edge _adjEdge1, Edge _adjEdge2, Edge _adjEdge3, Edge _adjEdge4){
        this.adjEdge1 = _adjEdge1;
        this.adjEdge2 = _adjEdge2;
        this.adjEdge3 = _adjEdge3;
        this.adjEdge4 = _adjEdge4;
    }

    public Edge getEdge1(){
        return this.adjEdge1;
    }
    public Edge getEdge2(){
        return this.adjEdge2;
    }
    public Edge getEdge3(){
        return this.adjEdge3;
    }
    
}
