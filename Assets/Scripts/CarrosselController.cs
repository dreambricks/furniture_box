using UnityEngine;

public class CarrosselController : MonoBehaviour
{
    public GameObject[] objetosDoCarrossel;
    private int objetoAtivoIndex = 0;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    public void AtivarObjeto()
    {
        objetosDoCarrossel[objetoAtivoIndex].SetActive(true);

        int objetoAnteriorIndex = (objetoAtivoIndex + objetosDoCarrossel.Length - 1) % objetosDoCarrossel.Length;
        objetosDoCarrossel[objetoAnteriorIndex].SetActive(false);

        objetoAtivoIndex = (objetoAtivoIndex + 1) % objetosDoCarrossel.Length;
    }

    public void DesativarObjeto()
    {
        objetosDoCarrossel[objetoAtivoIndex].SetActive(false);
    }
}
