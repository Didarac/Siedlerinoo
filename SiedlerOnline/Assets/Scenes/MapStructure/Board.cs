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

    private void initFelds(){
        felds = new Feld[20];
        int _type;
        int _nummer;
        for (int i=1; i<20; i++){
            _type = this.stash.getRndFeldFromStash();
            if(_type != 0){
                _nummer = this.stash.getNextNummer();
            }else{
                _nummer = 0;
            }
            felds[i] = new Feld(_nummer, _type);
            
        }
    }

    private void initEdges(){
        edges = new Edge[55];
        for (int i=1; i<56; i++){
            edges[i] = new Edge();
        }
        edges[1].setEdges(new MeerEgde(), new MeerEgde(), edges[2], edges[7]);
        edges[2].setEdges(new MeerEgde(), edges[1], edges[3], edges[8]);
        edges[3].setEdges(new MeerEgde(), edges[2], edges[8], edges[4]);
        edges[4].setEdges(new MeerEgde(),edges[3],edges[9],edges[5]);
        edges[5].setEdges(new MeerEgde(),edges[4],edges[9],edges[6]);
        edges[6].setEdges(new MeerEgde(),new MeerEgde(),edges[5],edges[10]);
        edges[7].setEdges(new MeerEgde(),edges[1],edges[11],edges[12]);
        edges[8].setEdges(edges[2],edges[3],edges[13],edges[14]);
        edges[9].setEdges(edges[4],edges[5],edges[15],edges[16]);
        edges[10].setEdges(new MeerEgde(),edges[6],edges[17],edges[18]);
        edges[11].setEdges(new MeerEgde(),edges[7],edges[12],edges[19]);
        edges[12].setEdges(edges[],edges[],edges[],edges[]);
        edges[13].setEdges(edges[],edges[],edges[],edges[]);
        edges[14].setEdges(edges[],edges[],edges[],edges[]);
        edges[15].setEdges(edges[],edges[],edges[],edges[]);
        edges[16].setEdges(edges[],v,v,edges[]);
        edges[17].setEdges(edges[],edges[],edges[],edges[]);
        edges[18].setEdges(new MeerEgde(),edges[],edges[],edges[]);
        edges[19].setEdges(new MeerEgde(),edges[],edges[],edges[]);
        edges[20].setEdges(edges[],edges[],edges[],edges[]);
        edges[21].setEdges(edges[],edges[],edges[],edges[]);
        edges[22].setEdges(edges[],edges[],edges[],edges[]);
        edges[23].setEdges(new MeerEgde(),edges[],edges[],edges[]);
        edges[24].setEdges(new MeerEgde(),edges[],edges[],edges[]);
        edges[25].setEdges(edges[],edges[],edges[],edges[]);
        edges[26].setEdges(edges[],edges[],edges[],edges[]);
        edges[27].setEdges(edges[],edges[],edges[],edges[]);
        edges[28].setEdges(edges[],edges[],edges[],edges[]);
        edges[29].setEdges(edges[],edges[],edges[],edges[]);
        edges[30].setEdges(edges[],edges[],edges[],edges[]);
        edges[31].setEdges(edges[],edges[],edges[],edges[]);
        edges[32].setEdges(edges[],edges[],edges[],edges[]);
        edges[33].setEdges(new MeerEgde(),edges[],edges[],edges[]);
        edges[34].setEdges(new MeerEgde(),new MeerEgde(),edges[],edges[]);
        edges[35].setEdges(edges[],edges[],edges[],edges[]);
        edges[36].setEdges(edges[],edges[],edges[],edges[]);
        edges[37].setEdges(edges[],edges[],edges[],edges[]);
        edges[38].setEdges(edges[],edges[],edges[],edges[]);
        edges[39].setEdges(new MeerEgde(),new MeerEgde(),edges[],edges[]);
        edges[40].setEdges(new MeerEgde(),edges[],edges[],edges[]);
        edges[41].setEdges(edges[],edges[],edges[],edges[]);
        edges[42].setEdges(edges[],edges[],edges[],edges[]);
        edges[43].setEdges(edges[],edges[],edges[],edges[]);
        edges[44].setEdges(edges[],edges[],edges[],edges[]);
        edges[45].setEdges(edges[],edges[],edges[],edges[]);
        edges[46].setEdges(edges[],edges[],edges[],edges[]);
        edges[47].setEdges(edges[],edges[],edges[],edges[]);
        edges[48].setEdges(edges[],edges[],edges[],edges[]);
        edges[49].setEdges(new MeerEgde(),edges[],edges[],edges[]);
        edges[50].setEdges(new MeerEgde(),edges[],edges[],edges[]);
        edges[51].setEdges(edges[],edges[],edges[],edges[]);
        edges[52].setEdges(edges[],edges[],edges[],edges[]);
        edges[53].setEdges(edges[],edges[],edges[],edges[]);
        edges[54].setEdges(new MeerEgde(),edges[],edges[],edges[]);
        edges[55].setEdges(new MeerEgde(),edges[],edges[],edges[]);
        edges[56].setEdges(edges[],edges[],edges[],edges[]);
        edges[57].setEdges(edges[],edges[],edges[],edges[]);
        edges[58].setEdges(edges[],edges[],edges[],edges[]);
        edges[59].setEdges(edges[],edges[],edges[],edges[]);
        edges[60].setEdges(edges[],edges[],edges[],edges[]);
        edges[61].setEdges(edges[],edges[],edges[],edges[]);
        edges[62].setEdges(new MeerEgde(),edges[],edges[],edges[]);
        edges[63].setEdges(new MeerEgde(),edges[],edges[],edges[]);
        edges[64].setEdges(edges[],edges[],edges[],edges[]);
        edges[65].setEdges(edges[],edges[],edges[],edges[]);
        edges[66].setEdges(new MeerEgde(),edges[],edges[],edges[]);
        edges[67].setEdges(new MeerEgde(),new MeerEgde(),edges[],edges[]);
        edges[68].setEdges(new MeerEgde(),edges[],edges[],edges[]);
        edges[69].setEdges(new MeerEgde(),edges[],edges[],edges[]);
        edges[70].setEdges(new MeerEgde(),edges[],edges[],edges[]);
        edges[71].setEdges(new MeerEgde(),edges[],edges[],edges[]);
        edges[72].setEdges(new MeerEgde(),new MeerEgde(),edges[],edges[]);




    }

    private void initKnotens(){

        knotens = new Knoten[54];

        for(int i=1; i<=53; i++){
            knotens[i] = new Knoten()
            
            
        }
    }


    }
