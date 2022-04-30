// Tic Tac Toe - Joshua Smith
using System;
using System.Collections.Generic;

char[] spot = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
int player = 1;
int choice;
int win = 0;

void print_board()
{
    Console.WriteLine("");
    Console.WriteLine("  {0}  |  {1}  |  {2}", spot[1], spot[2], spot[3]);
    Console.WriteLine("_____|_____|_____ ");
    Console.WriteLine("     |     |      ");
    Console.WriteLine("  {0}  |  {1}  |  {2}", spot[4], spot[5], spot[6]);
    Console.WriteLine("_____|_____|_____ ");
    Console.WriteLine("     |     |      ");
    Console.WriteLine("  {0}  |  {1}  |  {2}", spot[7], spot[8], spot[9]);
    Console.WriteLine("     |     |      ");
}

int gamecheck()
{
    //First row
    if (spot[1] == spot[2] && spot[2] == spot[3])
    {
        return 1;
    }
    //row 2
    else if (spot[4] == spot[5] && spot[5] == spot[6])
    {
        return 1;
    }
    //row 3
    else if (spot[7] == spot[8] && spot[8] == spot[9])
    {
        return 1;
    }
    //vert row 1
    else if (spot[1] == spot[4] && spot[4] == spot[7])
    {
        return 1;
    }
    //vert row 2
    else if (spot[2] == spot[5] && spot[5] == spot[8])
    {
        return 1;
    }
    //vert row 3
    else if (spot[3] == spot[6] && spot[6] == spot[9])
    {
        return 1;
    }
    //diaganol 1
    else if (spot[1] == spot[5] && spot[5] == spot[9])
    {
        return 1;
    }
    //diaganol 2
    else if (spot[3] == spot[5] && spot[5] == spot[7])
    {
        return 1;
    }
    //tie 
    else if (spot[1] != '1' && spot[2] != '2' && spot[3] != '3' && spot[4] != '4' && spot[5] != '5' && spot[6] != '6' && spot[7] != '7' && spot[8] != '8' && spot[9] != '9')
    {
        return 2;
    }
    else {
        return 0;
    }
}


void main()
{
    
    while (win == 0)
    {
        
        print_board();
        if (player == 2)
        {
            Console.WriteLine("Player two's turn");
            
        }
        else 
        {
            Console.WriteLine("Player one's turn");
            
        }
        Console.WriteLine("\n");
        choice = int.Parse(Console.ReadLine());
        if (spot[choice] != 'X' && spot[choice] != 'O')
        {
            if (player == 2)
            {
                spot[choice] = 'O';
                player = 1;
            }
            else
            {
                spot[choice] = 'X';
                player = 2;
            }
        }
        else 
        {
            //cheater addition
            if (player == 2)
            {
                Console.WriteLine("You can't go there you cheater X wins!");
                //exit program
                System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("You can't go there you cheater O wins!");
                //exit program
                System.Environment.Exit(0);
            }
            

        }
        win = gamecheck();
        if (win == 1)
        {
            print_board();
            if (player == 2)
            {
                Console.WriteLine("Player 1 has won!");
            }
            else 
            {
                Console.WriteLine("Player 2 has won!");
            }
        }
        else if (win == 2)
        {
            Console.WriteLine("Congrats you both lost! It was a tie");
        }

    }

}
main();