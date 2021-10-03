using DG.Tweening;
using TMPro;
using UnityEngine;

public class OperatorInitializer : MonoBehaviour
{
    public Operator _operator;

    [SerializeField] private GameObject Panel, AmountObject;

    private void Awake()
    {
        string symbolForText;
        symbolForText = HandleMultiplierAndDivisorDiff();

        SetOnPanelText(symbolForText);
        Scale();
    }

    private void Scale()
    {
        transform.localScale = new Vector3(_operator.size, 1f, 1f);
    }

    private void SetOnPanelText(string symbolForText)
    {
        if (symbolForText != null)
        {
            AmountObject.GetComponent<TextMeshPro>().SetText($"{_operator.amount}{symbolForText}");
        }
    }

    private string HandleMultiplierAndDivisorDiff()
    {
        string textRep;
        if (_operator.operatorType == OperatorType.Multiplier)
        {
            setMaterial(new Color(0, 0, 1, 0.33f));
            textRep = "x";
        }
        else
        {
            setMaterial(new Color(1, 0, 0, 0.33f));
            textRep = "÷";
        }

        return textRep;
        
        void setMaterial(Color color)
        {
            Panel.GetComponent<Renderer>().material.SetColor("_Color",color);
        }
    }
    
}
