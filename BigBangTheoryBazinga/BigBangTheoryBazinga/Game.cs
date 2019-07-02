using System;
using System.Collections.Generic;
using System.Text;

namespace BigBangTheoryBazinga
{
    class Game
    {
        public string Vencedor(string r1, string r2)
        {
            if (r1 == "tesoura" && r2 == "papel") //tesoura corta papel;
                return "Bazinga!";

            else if (r2 == "tesoura" && r1 == "papel") //tesoura corta papel;                                       
                return "Raj trapaceou!";

            else if (r1 == "papel" && r2 == "pedra")    //papel cobre pedra;
                return "Bazinga!";

            else if (r2 == "papel" && r1 == "pedra") //papel cobre pedra;
                return "Raj trapaceou";

            else if (r1 == "pedra" && r2 == "lagarto") //pedra esmaga lagarto;
                return "Bazinga!";

            else if (r2 == "pedra" && r1 == "lagarto") //pedra esmaga lagarto;
                return "Raj trapaceou";

            else if (r1 == "lagarto" && r2 == "Spock") //lagarto envenena Spock;
                return "Bazinga!";

            else if (r2 == "lagarto" && r1 == "Spock") //lagarto envenena Spock;
                return "Raj trapaceou!";

            else if (r1 == "Spock" && r2 == "tesouras") //Spock esmaga tesouras;
                return "Bazinga!";

            else if (r2 == "Spock" && r1 == "tesouras") //Spock esmaga tesouras;
                return "Raj trapaceou!";

            else if (r1 == "tesoura" && r2 == "lagarto") //tesoura decapita lagarto;
                return "Bazinga!";

            else if (r2 == "tesoura" && r1 == "lagarto") //tesoura decapita lagarto;
                return "Raj Trapaceou!";

            else if (r1 == "lagarto" && r2 == "papel") //lagarto come o papel;
                return "Bazinga!";

            else if (r2 == "lagarto" && r1 == "papel") //lagarto come o papel;
            return "Raj trapaceou!";

            else if (r1 == "papel" && r2 == "Spock")//papel refuta Spock;
                return "Bazinga!";

            else if (r2 == "papel" && r1 == "Spock") //papel refuta Spock;
            return "Raj trapaceou!";

            else if (r1 == "Spock" && r2 == "pedra")//Spock vaporiza a pedra;
                return "Bazinga!";

            else if (r2 == "Spock" && r1 == "pedra")//Spock vaporiza a pedra;
                return "Raj trapaceou!";

            else if (r1 == "pedra" && r2 == "tesoura")//pedra esmaga tesoura;
                return "Bazinga!";

            else if (r2 == "pedra" && r1 == "tesoura")//pedra esmaga tesoura;
                return "Raj trapaceou!";
            else
                return "De novo!"; //empate
        }
    }
}
