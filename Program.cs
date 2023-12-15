// See https://aka.ms/new-console-template for more information

int Height = 20;
int Width = 30;

void WriteBoard()
{
    Console.Clear();
    for(int i = 1; i<=(Width+2); i++){
        Console.SetCursorPosition(i,1);
        Console.Write("-");
    }
    for(int i = 1; i<=(Width+2); i++){
        Console.SetCursorPosition(i,(Height + 2));
        Console.Write("-");
    }
    for(int i = 1; i<=(Height+1); i++){
        Console.SetCursorPosition(1,i);
        Console.Write("-");
    }
    for(int i = 1; i<=(Height+1); i++){
        Console.SetCursorPosition((Width+1),1);
        Console.Write("-");
    }

}
