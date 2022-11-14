using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public struct Line
{
    public Character character;

    [TextArea(2, 5)]
    public string text;
}

[CreateAssetMenu(fileName ="ConversacionData", menuName = "ConversacionData")]
public class Conversar : ScriptableObject
{
    public Character jugador;
    public Character NPC;
    public Line[] lines;
}
