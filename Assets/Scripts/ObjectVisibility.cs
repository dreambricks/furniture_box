using UnityEngine;

public class ObjectVisibility : MonoBehaviour
{
    private GameObject[] objects;
    Camera cam;

    void Start()
    {
        cam = Camera.main;
        // Encontre todos os objetos na cena
        objects = GameObject.FindGameObjectsWithTag("DetalhesObjeto");

        // Oculte todos os objetos no início
        HideAllObjects();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                // Verifique se o objeto clicado possui um "GameObject" de detalhes
                GameObject clickedObject = hit.collider.gameObject;
                if (clickedObject.name == "empty_box")
                {
                    HideAllObjects();
                }
                else
                {
                    GameObject objectDetails = clickedObject.transform.Find("details").gameObject;

                    print(clickedObject);
                    

                    if (objectDetails != null)
                    {
                        // Oculte todos os objetos e mostre apenas o "GameObject" de detalhes do objeto clicado
                        HideAllObjects();
                        objectDetails.gameObject.SetActive(true);
                    }
                }
            }
        }
    }

    void HideAllObjects()
    {
        foreach (GameObject obj in objects)
        {
            obj.SetActive(false);
        }
    }
}
