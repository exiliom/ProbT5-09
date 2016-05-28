using UnityEngine;
using System.Collections;

public class Event : MonoBehaviour {

    private Eval currentEval;
    private float change;
    private Eval lastEval;

    // Use this for initialization
    void Start() {
        currentEval = (Eval)((Random.Range(1,40))%4);
        foreach (int prim in primo)
            primos.Add(prim);
        change = Time.time;
    }

    bool Evaluate(int entrada)
    {
        switch (currentEval)
        {
            case Eval.Par: return (entrada % 2 == 0) ? true : false;

            case Eval.Impar: return (entrada % 2 != 0) ? true : false;

            case Eval.Raiz: return (Mathf.Sqrt(entrada) == (int)Mathf.Sqrt(entrada));
                
            case Eval.Primo: return primos.Contains(entrada);
               
        }
        return false;
    }

    // Update is called once per frame
    void Update() {
        if(Time.time >= change + 10f)
          {
              lastEval = currentEval;
              currentEval = (Eval)((Random.Range(1, 40)) % 4);
            if (currentEval == lastEval)
                currentEval = (Eval)(((int)currentEval + 1) % 4);
              change = Time.time;
            
          }
        
    }
    public enum Eval
    {
        Par, Impar, Primo, Raiz
    }
    public int[] primo = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
    public ArrayList primos = new ArrayList();
}
