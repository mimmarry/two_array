namespace twoarray_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool IsOpen = true;
            string[,] songs =
            {
        {"The Weeknd", "Lana Del Rey", "Joji" },
        { "OG Buda", "Bushido Zho", "163ONMYNECK"},
        { "Stray Kids", "BTS", "TWICE"}
        };
            while (IsOpen)
            {
                Console.SetCursorPosition(0, 20);
                Console.WriteLine("\nFull list of singers:\n");
                for (int i = 0; i < songs.GetLength(0); i++)
                {
                    for (int j = 0; j < songs.GetLength(1); j++)
                    {
                        Console.Write(songs[i, j] + "!  ");
                    }
                    Console.WriteLine();
                }
                Console.SetCursorPosition(0,0);
                Console.WriteLine("Playlist");
                Console.WriteLine
                    ("\n\n1-find out the singer's name by song index." +
                    "\n\n2-recognize a song by its author." +
                    "\n\n3 - exit ");
                Console.Write("\nSelect the menu option: ");
                switch (Convert.ToInt32(Console.ReadLine()))
                    {
                    case 1:
                        int line, column;
                        Console.Write("Enter the playlist group number: ");
                        line = Convert.ToInt32(Console.ReadLine())-1;
                        Console.Write("Enter the playlist column number: ");
                        column = Convert.ToInt32(Console.ReadLine())-1;
                        Console.WriteLine("This singer is " + songs[line,column] + "!");
                        break;
                    case 2:
                        string singer;
                        bool singerIsFound = false;
                        Console.Write("Enter the singer: ");
                        singer = Convert.ToString(Console.ReadLine());
                        for (int i = 0; i < songs.GetLength(0); i++)
                        {
                            for (int j = 0; j < songs.GetLength(1); j++)
                            {
                                if (singer.ToLower() == songs[i, j].ToLower())
                                {
                                    Console.Write($"Singer {songs[i,j]} is located at group number {i + 1},at place {j + 1}");
                                    singerIsFound = true;
                                }
                            }
                        }
                        if (singerIsFound == false)
                        {
                            Console.Write("\nSuch a singer is not found.");
                        }

                        break;
                    case 3:
                        IsOpen = false; 
                        break;
                    default:
                        Console.WriteLine("Incorrect command");
                        break;
                
                    }

                {
                    Console.WriteLine("\nPress any key to continue...\n");
                }
                
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}