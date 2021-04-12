using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{

    Transform goal;

    //setando atributos do tank

    //float speed = 5.0f;
    //float accuracy = 1.0f;
    //float rotSpeed = 2.0f;

    //Importando as informações do wpmanager para o controle dos wpoints

    public GameObject wpManager;
    GameObject[] wps;
    GameObject currentNode;
    int currentWP = 0;
    Graph g;
    //importação do  navmeshAgent
    UnityEngine.AI.NavMeshAgent agent;
    void Start()
    {
        //as informações do wpmanager são trazidas para as variaveis wps(controla os waypoinst para onde o tank deve ir) e g(contem as irformações do graphs)
        wps = wpManager.GetComponent<WPManager>().waypoints;
        //getcomponent do agent, para movimentar o  tank
        agent = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
        //g = wpManager.GetComponent<WPManager>().graph;
       
        //currentNode = wps[0];
    }

    //controla para que o tank va para o heliporto
    public void GoToHeli()
    {
        //set destination que define para que ponta o tank irá
        agent.SetDestination(wps[9].transform.position);
        //g.AStar(currentNode, wps[9]);
        //currentWP = 0;
    }

    //controla para que o tank va para as ruinas
    public void GoToRuin()
    {
        //set destination que define para que ponta o tank irá
        agent.SetDestination(wps[5].transform.position);
        //g.AStar(currentNode, wps[3]);       
        //currentWP = 0;
    }
    //controla para que o tank va para a fabrica
    public void GoToFabrica()
    {
        //set destination que define para que ponta o tank irá
        agent.SetDestination(wps[10].transform.position);
        //g.AStar(currentNode, wps[10]);
        //currentWP = 0;
    }

    void LateUpdate()
    {
        //caso não exista um wp configurado para que o tank va até ele, o codigo retorna
        //if (g.getPathLength() == 0 || currentWP == g.getPathLength())
        // return;

        //O nó que estará mais próximo neste momento
        // currentNode = g.getPathPoint(currentWP);

        //se estivermos mais próximo bastante do nó o tanque se moverá para o próximo
        //if (Vector3.Distance(g.getPathPoint(currentWP).transform.position,transform.position) < accuracy)
        // {
        // currentWP++;
        // }

        //caso o wp atual seja menor que para onde ele deve ir, o tank se move em direção ao proximo wp
        //if (currentWP < g.getPathLength())
        // {

        // goal = g.getPathPoint(currentWP).transform;
        // Vector3 lookAtGoal = new Vector3(goal.position.x, this.transform.position.y,goal.position.z);
        //Vector3 direction = lookAtGoal - this.transform.position; this.transform.rotation = Quaternion.Slerp(this.transform.rotation,Quaternion.LookRotation(direction),Time.deltaTime * rotSpeed);
        //}

        //this.transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
