using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ButtonImageChange : MonoBehaviour
{
    public Sprite Imagem1, Imagem2;
    public Button botao;
    private bool ativo = true;

    public void trocar()
    {
        if (ativo)
        {
            botao.image.sprite = Imagem2;
            ativo = false;
        }
        else
        {
            botao.image.sprite = Imagem1;
            ativo = true;
        }
    }


}

