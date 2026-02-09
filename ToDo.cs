namespace knightmoves;
public class ToDo
{
    // Add your code here
    public int Count = 0;
    public string[] MarkAsDone(string[] todos){
        Count++;
        if(todos.Length > Count){
            todos[Count] = "done - " + todos[Count];
            return MarkAsDone(todos);
        } else {
            return todos;
        }
    }
}


