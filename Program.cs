
int player = 2;
int input = 0;
bool inputCorrect = true;

Program1.SetField();
Console.ReadKey();

do
{
    if (player == 2)
    {
        player = 1;
        Program1.EnterXorO(player, input);
    }
    else if (player == 1)
    {
        player = 2;
        Program1.EnterXorO(player, input);
    }

    Program1.SetField();

    //check winning condition
    char[] playerChars = { 'X', 'O' };
    foreach (char playerChar in playerChars)
    {
        if (((Program1.playField[0, 0] == playerChar) && (Program1.playField[0, 1] == playerChar) && (Program1.playField[0, 2] == playerChar))
        || ((Program1.playField[1, 0] == playerChar) && (Program1.playField[1, 1] == playerChar) && (Program1.playField[1, 2] == playerChar))
        || ((Program1.playField[2, 0] == playerChar) && (Program1.playField[2, 1] == playerChar) && (Program1.playField[2, 2] == playerChar))
        || ((Program1.playField[0, 0] == playerChar) && (Program1.playField[1, 0] == playerChar) && (Program1.playField[2, 0] == playerChar))
        || ((Program1.playField[0, 1] == playerChar) && (Program1.playField[1, 1] == playerChar) && (Program1.playField[1, 2] == playerChar))
        || ((Program1.playField[0, 2] == playerChar) && (Program1.playField[2, 1] == playerChar) && (Program1.playField[2, 2] == playerChar))
        || ((Program1.playField[0, 0] == playerChar) && (Program1.playField[1, 1] == playerChar) && (Program1.playField[2, 2] == playerChar))
        || ((Program1.playField[0, 2] == playerChar) && (Program1.playField[1, 1] == playerChar) && (Program1.playField[2, 0] == playerChar))
        )
        {
            Console.WriteLine("We have a winner!");
        }
    }




    //Test if field is already occupied
    do
    {
        Console.WriteLine("\nPlayer {0}: Choose your field!", player);
        try
        {
            input = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Please, Enter a number.");
        }

        if ((input == 1) && (Program1.playField[0, 0] == '1'))
        {
            inputCorrect = true;
        }
        else if ((input == 2) && (Program1.playField[0, 1] == '2'))
        {
            inputCorrect = true;
        }
        else if ((input == 3) && (Program1.playField[0, 1] == '3'))
        {
            inputCorrect = true;
        }
        else if ((input == 4) && (Program1.playField[1, 0] == '4'))
        {
            inputCorrect = true;
        }
        else if ((input == 5) && (Program1.playField[1, 1] == '5'))
        {
            inputCorrect = true;
        }
        else if ((input == 6) && (Program1.playField[1, 2] == '6'))
        {
            inputCorrect = true;
        }
        else if ((input == 7) && (Program1.playField[2, 0] == '7'))
        {
            inputCorrect = true;
        }
        else if ((input == 8) && (Program1.playField[2, 1] == '8'))
        {
            inputCorrect = true;
        }
        else if ((input == 9) && (Program1.playField[2, 2] == '9'))
        {
            inputCorrect = true;
        }
        else
        {
            Console.WriteLine("\n Incorrect input! Please use another field!");
            inputCorrect = false;
        }

    } while (!inputCorrect);


} while (true);

public class Program1
{
    public static char[,] playField =
 {
    {'1','2','3'}, //row 0
    {'4','5','6'}, // row 1
    {'7','8','9'}, // row 2
};
    public static void SetField()
    {
        Console.WriteLine("     |     |     ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", playField[0, 0], playField[0, 1], playField[0, 2]);
        Console.WriteLine("_____|_____|_____");
        Console.WriteLine("     |     |     ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", playField[1, 0], playField[1, 1], playField[1, 2]);
        Console.WriteLine("_____|_____|_____");
        Console.WriteLine("     |     |     ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", playField[2, 0], playField[2, 1], playField[2, 2]);
        Console.WriteLine("     |     |     ");
    }
    public static void EnterXorO(int player, int input)
    {
        char playerSign = ' ';

        if (player == 1)
        {
            playerSign = 'X';
        }
        else if (player == 2)
        {
            playerSign = 'O';
        }


        switch (input)
        {
            case 1: Program1.playField[0, 0] = playerSign; break;
            case 2: Program1.playField[0, 1] = playerSign; break;
            case 3: Program1.playField[0, 2] = playerSign; break;
            case 4: Program1.playField[1, 0] = playerSign; break;
            case 5: Program1.playField[1, 1] = playerSign; break;
            case 6: Program1.playField[1, 2] = playerSign; break;
            case 7: Program1.playField[2, 0] = playerSign; break;
            case 8: Program1.playField[2, 1] = playerSign; break;
            case 9: Program1.playField[2, 2] = playerSign; break;
        }
    }
}

