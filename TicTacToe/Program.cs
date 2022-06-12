// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

static string[] pos = new string[10] { "0", "1", "2","3","4","5","6","7","8","9" }; // Array that contains board positions, 0 isnt used --------------------------------

static void DrawBoard() // Draw board method ==========================================
{
    Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[1], pos[2], pos[3]);
    Console.WriteLine("-------------------");
    Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[4], pos[5], pos[6]);
    Console.WriteLine("-------------------");
    Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[7], pos[8], pos[9]);
}