namespace PairImpairBoucle;

class Program
{
    static void Main(string[] args)
    {
        int answer = 0;
        Console.WriteLine("Quelle es ton nombre?");
        answer = Convert.ToInt32(Console.ReadLine);


        if(answer = modulo = 0)
        {
            Console.WriteLine("Paire");
        } 
        else
        {
            Console.WriteLine("impaire");
        }


        Console.WriteLine("choisis entre y/n");
        Console.ReadLine(y = int answer);

        if(answer = y)
        {
            continue;
        } 
        else
        {
            break;
        }

        /*
         * Consignes
         * Demandez à l'utilisateur un nombre
         * Dites à l'utilisateur si le nombre fourni est pair ou impair
         * Demandez à l'utilisateur s'il veut proposer un autre nombre
         *  On lui permet de le faire lorsqu'il entre "y". Dans les autres cas, on termine le programme
         */
        int testedNumber = 0;

        Console.Writeline("> Veuiller inserer un nombre entier : ");
        testedNumber = Convert.ToInt32(Console.ReadLine());

        if (testedNumber % 2 == 0)
        {
            Console.WriteLine("paire");
        }
        else
        {
            Console.WriteLine("impaire");
        }
    }
}
