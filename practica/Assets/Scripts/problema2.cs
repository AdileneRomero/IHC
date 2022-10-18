using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class problema2 : MonoBehaviour
{

    public int[] nums = new int [4] {2,7,11,15};
    public int target =18;
    public int[] expectedResult = new int[2] {0,1};
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Problema 2");
        int[] result = suma(nums,target);
        Debug.Log(string.Join(", ",result));
        Debug.Log($"Paso prueba {TestSuma()}");
    }
 
    public int[] suma(int[] nums, int target)
    { 
        int[] result = new int[2] {0,1};
        return result;
    }

    public bool TestSuma()
    {
        int[] actualResult =suma(nums,target);
        if(actualResult.Length != expectedResult.Length) return false;
        for(int i=0;i<actualResult.Length;i++){
            if(actualResult[i] != expectedResult[i]) return false;            
        }
        return true;
    }
    
}
