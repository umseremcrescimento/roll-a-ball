using UnityEngine;
using JetBrains.Annotations;

public class Coletavel : MonoBehaviour
{
    public int valor = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Gerenciador.instancia.AdicionarPontos(valor);
            Destroy(gameObject);
        }
    }
}