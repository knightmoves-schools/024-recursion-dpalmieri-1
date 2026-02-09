namespace Tests;
using knightmoves;
using Xunit;

public class AutogradingTest
{
    /*
should create a function named markAsDone that takes an array of todos and returns the modified array
should loop through the todos and prepend the string 'done - ' to each todo description
    */

    [Fact]
    public void Should_Create_A_Method_Named_MarkAsDone_That_Takes_An_Array_Of_ToDos_And_Returns_The_Modified_String_Array(){
        var toDo = new ToDo();
        var doneToDos = toDo.MarkAsDone(new string[]{"one", "two", "three"});

        Assert.Equal(3, doneToDos.Length);
    }

    [Fact]
    public void Should_Loop_Through_The_Todos_And_Prepend_The_String_Done_Dash_To_Each_Todo(){
        var toDo = new ToDo();
        var doneToDos = toDo.MarkAsDone(new string[]{"one", "two", "three"});

        Assert.Equal("done - one", doneToDos[0]);
        Assert.Equal("done - two", doneToDos[1]);
        Assert.Equal("done - three", doneToDos[2]);
    }
}