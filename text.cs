using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Import the TextMeshPro namespace

public class HelloWorld : MonoBehaviour
{
    public string firstName;
    public string lastName;
    private TextMeshProUGUI textMeshPro; // Correct the variable name

    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>(); // Correct the variable name
        textMeshPro.text = $"Hello {firstName} {lastName}!";
    }

    // Update is called once per frame
    void Update()
    {
        // No need for anything in Update for this example
    }
}
