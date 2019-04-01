using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class City : MonoBehaviour
{
    public Text panelText;

    private string cityName;

    public enum Size
    {
        Capital,
        Town,
        Village
    }

    public Size size;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(DisplayInformation);
        cityName = GetComponentInChildren<Text>().text;
    }

    public void DisplayInformation()
    {
        panelText.text = cityName + " (" + size.ToString() + ")";
    }
}
