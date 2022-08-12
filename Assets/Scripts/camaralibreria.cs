using UnityEngine;

public class camaralibreria : MonoBehaviour
{
     public static string selectedObject;
        public string internalObject;
public  RaycastHit hit; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
      
    

      if (Physics.Raycast(ray, out hit)) {  
      {
 selectedObject=hit.transform.gameObject.name;
         internalObject=hit.transform.gameObject.name;
      } 
    }
}
}
