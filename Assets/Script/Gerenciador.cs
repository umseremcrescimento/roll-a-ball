using UnityEngine;
using TMPro;

public class Gerenciador : MonoBehaviour
{
    public static Gerenciador instancia;

    public TextMeshProUGUI textoPontuacao;
    private int pontuacao = 0;

    void Awake()
    {
        instancia = this;
    }
    void Start()
    {
        AtualizarTexto();
    }

    public void AdicionarPontos(int pontos)
    {
        pontuacao += pontos;
        AtualizarTexto();
    }
    void AtualizarTexto()
    {
        textoPontuacao.text = "Pontuação " + pontuacao;
    }

}
