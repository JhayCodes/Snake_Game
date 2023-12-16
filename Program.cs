// See https://aka.ms/new-console-template for more information
namespace MyProject;
class Snake
{
    int Height = 20;
    int Width = 30;
    int[] x = new int[50];
    int[] y = new int[50];
    int fruitX;
    int fruitY;
    int parts = 3;

    ConsoleKeyInfo keyinfo = new ConsoleKeyInfo();
    char key = 'W';
    Random rnd = new Random();

    void WriteBoard()
    {
        Console.Clear();
        for (int i = 1; i <= (Width + 2); i++)
        {
            Console.SetCursorPosition(i, 1);
            Console.Write("-");
        }
        for (int i = 1; i <= (Width + 2); i++)
        {
            Console.SetCursorPosition(i, (Height + 2));
            Console.Write("-");
        }
        for (int i = 1; i <= (Height + 1); i++)
        {
            Console.SetCursorPosition(1, i);
            Console.Write("-");
        }
        for (int i = 1; i <= (Height + 1); i++)
        {
            Console.SetCursorPosition((Width + 1), 1);
            Console.Write("-");
        }
    }

    public void Input()
    {
        if(Console.KeyAvailable){
            keyinfo = Console.ReadKey(true);
            key = keyinfo.KeyChar;
        }
    }

    public void WritePoint(int x, int y){
        Console.SetCursorPosition(x,y);
        Console.Write("#");
    }

    public void Logic(){
        if(x[0] == fruitX)
        {
            if(y[0] == fruitY)
            {
                parts++;
                fruitX = rnd.Next(2, (Width -2));
                fruitY - rnd.Next(2, (Height -2));
            }
        }
        for(int i)
    }
    static void Main(string[] args)
    {
        Snake snake = new Snake();
        snake.WriteBoard();
        snake.Input();
        Console.ReadKey();
    }

}
