using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knoten
{
    int hafen;

    Building building;

    Knoten adjKnoten1;
    Knoten adjKnoten2;
    Knoten adjKnoten3;

    Edge adjEdge1;
    Edge adjEdge2;
    Edge adjEdge3;

    Feld feld1;
    Feld feld2;
    Feld feld3;
public Knoten(int _hafen, Edge _adjEdge1, Edge _adjEdge2, Edge _adjEdge3, Feld _feld1, Feld _feld2, Feld _feld3){
    this.building = EmptyBuilding();
    this.hafen = _hafen;

    this.adjEdge1 = _adjEdge1;
    this.adjEdge2 = _adjEdge2;
    this.adjEdge3 = _adjEdge3;

    this.feld1 = _feld1;
    this.feld2 = _feld2;
    this.feld3 = _feld3;
}
}
