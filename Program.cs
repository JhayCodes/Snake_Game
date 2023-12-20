// See https://aka.ms/new-console-template for more information
namespace MyProject;
class Snake
{
   public int Height = 20;
    int Width = 30;
    int[] X = new int[50];
    int[] Y = new int[50];
    int fruitX;
    int fruitY;
    int parts = 3;

    ConsoleKeyInfo keyinfo = new ConsoleKeyInfo();
    char key = 'W';
    Random rnd = new Random();
    Snake()
    {
        X[0] = 5;
        Y[0] = 5;
        Console.CursorVisible = false;
        fruitX = rnd.Next(2, (Width - 2));
        fruitY = rnd.Next(2, (Height - 2));

    }
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
            Console.Write("|");
        }
        for (int i = 1; i <= (Height + 1); i++)
        {
            Console.SetCursorPosition((Width + 2), 1);
            Console.Write("|");
        }
    }

    public void Input()
    {
        if (Console.KeyAvailable)
        {
            keyinfo = Console.ReadKey(true);
            key = keyinfo.KeyChar;
        }
    }

    public void WritePoint(int x, int y)
    {
        Console.SetCursorPosition(x, y);
        Console.Write("#");
    }

    public void Logic()
    {
        if (X[0] == fruitX)
        {
            if (Y[0] == fruitY)
            {
                parts++;
                fruitX = rnd.Next(2, (Width - 2));
                fruitY = rnd.Next(2, (Height - 2));
            }
        }
        for (int i = parts; i > 1; i--)
        {
            X[i - 1] = X[i - 2];
            Y[i - 1] = Y[i - 2];
        }
        switch (key)
        {
            case 'w':
                Y[0]--;
                break;
            case 's':
                Y[0]++;
                break;
            case 'd':
                X[0]++;
                break;
            case 'a':
                X[0]--;
                break;
        }
        for (int i = 0; i <= (parts - 1); i++)
        {
            WritePoint(X[i], Y[i]);
            WritePoint(fruitX, fruitY);
        }
        Thread.Sleep(100);
    }
    static void Main(string[] args)
    {
        Snake snake = new Snake();
        while (true)
        {
            snake.WriteBoard();
            snake.Input();
            snake.Logic();
            
        }
        Console.ReadKey();
        
    }

}
