using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public struct Link
{
    //configurações das estruturas
    public enum direction { UNI, BI }
    public GameObject node1;
    public GameObject node2;
    public direction dir;
}

public class WPManager : MonoBehaviour
{
    //setando as variaveis que serão usadas (array de links, de waypoints e criando uma nova importação de graphs)
    public GameObject[] waypoints;


    public Link[] links;


    public Graph graph = new Graph();


    void Start()
    {
        //se o tamanho do array waypoints for maior que 0, para cada waypoint é adicionado um node
        if (waypoints.Length > 0)
        {
         
            foreach (GameObject wp in waypoints)
            {
              
                graph.AddNode(wp);
            }

            //para cada link em links é adicionado a graphs um edge de acordo se é uni ou bi
            foreach (Link l in links)
            {
               
                graph.AddEdge(l.node1, l.node2);
            
                if (l.dir == Link.direction.BI)
                  
                    graph.AddEdge(l.node2, l.node1);
            }
        }
    }
    //traça o caminho entre os pontos
    void Update()
    {
        graph.debugDraw();
    }
}

