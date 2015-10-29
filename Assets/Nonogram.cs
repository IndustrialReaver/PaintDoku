using UnityEngine;
using System.Collections;

public class Nonogram : MonoBehaviour {


    Color[,] graph;
    public GameObject block;
    string[] rows;
    string[] cols;

	// Use this for initialization
	void Start () {



        rows = new string[10];
        cols = new string[10];

        rows[0] = "1.1";
        rows[1] = "2";
        rows[2] = "3.1";
        rows[3] = "5.5";
        rows[4] = "6";
        rows[5] = "1.3";
        rows[6] = "4.1";
        rows[7] = "1";
        rows[8] = "1";
        rows[9] = "1";


        cols[0] = "1.1.1";
        cols[1] = "4.1";
        cols[2] = "2.2";
        cols[3] = "6";
        cols[4] = "1.3";
        cols[5] = "3";
        cols[6] = "1";
        cols[7] = "1";
        cols[8] = "4";
        cols[9] = "3.2";
        
        graph = new Color[rows.Length, cols.Length];

        solve();
        printGraph();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void solve(){

        char[] curcol;
        char[] currow;
        
        for (int i = 0; i < rows.Length; i++)
        {
            currow = rows[i].ToCharArray();

        }



    }

    void printGraph()
    {
        for (int i = 0; i < graph.GetLength(0); i++)
        {
            for (int j = 0; j < graph.GetLength(1); j++)
            {
                GameObject newGO = Instantiate(block, new Vector2(i - (graph.GetLength(0)/2), j - (graph.GetLength(1)/2)), Quaternion.identity) as GameObject;
                newGO.GetComponent<SpriteRenderer>().color = graph[i, j];
            }
        }
    }
}
