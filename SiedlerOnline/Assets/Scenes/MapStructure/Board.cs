using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public Knoten[] knotens;

    public Edge[] edges;

    public Feld[] felds;

    public FelderStash stash;

    public Board (){
        this.stash = new FelderStash();
    }



    public void initialize(){
        //uff
    }


    }
