/*
    o programa vai desenhar uma escada com base no input N que determina o tamanho da largura e altura da escada

    a escada deve ser feita com "#" e usar espaços para desenhá-la alinhada a direita: seguindo o exemplo:
    
     #
    ##
   ###
  ####
 #####
######
*/

staircase(6);
static void staircase(int n)
{

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j + i < n; j++)
        {
            Console.Write(" ");
        }
        for (int j = 0; j < i + 1; j++)
        {
            Console.Write("#");
        }
        Console.WriteLine("");
    }
}