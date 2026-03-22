using UnityEngine;

[CreateAssetMenu(menuName = "Dialogue/DialogueObject")]
public class DialogueObject : ScriptableObject
{
    [SerializeField][TextArea] private string[] dialogue; //elements of array are dialogue box texts
    [SerializeField] public string nametag; 

    //response array
    [SerializeField] private Response[] responses; 
    
    //we want the dialogueui to access this but not write to it
    public string[] Dialogue => dialogue; //returns private dialogue string array
    public string DialogueName => name; //returns private dialogue string array
    //response getter
    public Response[] Responses => responses;

    //getter to see if has responses
    public bool HasResponses => Responses != null && Responses.Length > 0;
}
