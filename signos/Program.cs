using System;

namespace signo_aval
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] signos = new string[12, 3];

            //Signos - Posição columns/lines
            signos[0, 0] = "Áries";
            signos[1, 0] = "Touro";
            signos[2, 0] = "Gêmeos";
            signos[3, 0] = "Câncer";
            signos[4, 0] = "Leão";
            signos[5, 0] = "Virgem";
            signos[6, 0] = "Libra";
            signos[7, 0] = "Escorpião";
            signos[8, 0] = "Sagitário";
            signos[9, 0] = "Capricórnio";
            signos[10, 0] = "Aquário";
            signos[11, 0] = "Peixes";

            //Elementos - Posição columns/lines
            signos[0, 1] = "Fogo";
            signos[1, 1] = "Terra";
            signos[2, 1] = "Ar";
            signos[3, 1] = "Água";
            signos[4, 1] = "Fogo";
            signos[5, 1] = "Terra";
            signos[6, 1] = "Ar";
            signos[7, 1] = "Água";
            signos[8, 1] = "Fogo";
            signos[9, 1] = "Terra";
            signos[10, 1] = "Ar";
            signos[11, 1] = "Água";

            //Planetas - Posição columns/lines
            signos[0, 2] = "Marte";
            signos[1, 2] = "Vênus";
            signos[2, 2] = "Mercúrio";
            signos[3, 2] = "Lua";
            signos[4, 2] = "Sol";
            signos[5, 2] = "Mercúrio";
            signos[6, 2] = "Vênus";
            signos[7, 2] = "Plutão";
            signos[8, 2] = "Júpiter";
            signos[9, 2] = "Saturno";
            signos[10, 2] = "Urano";
            signos[11, 2] = "Neptuno";

            DateTime date_new = DateTime.Now;
            DateTime born_M, born_W;
            int day_M, month_M, year_M, day_W, month_W, year_W;
            int age_M, age_W, sign_M, sign_W;
            string sn;

              do
            {
                Console.Clear();

                Console.WriteLine("\t\t*** Encontre o seu amor de acordo com a compatibilidade dos signos *** ");
                Console.WriteLine();

                Console.Write(" Insira a data de nascimento do Homem: ");
                born_M = Convert.ToDateTime(Console.ReadLine());

                Console.Write(" Insira a data de nascimento da Mulher: ");
                born_W = Convert.ToDateTime(Console.ReadLine());

                //Homem
                day_M = born_M.Day;
                month_M = born_M.Month;
                year_M = born_M.Year;

                //Mulher
                day_W = born_W.Day;
                month_W = born_W.Month;
                year_W = born_W.Year;

                age_M = CalcIdade(day_M, month_M, year_M);
                age_W = CalcIdade(day_W, month_W, year_W);

                sign_M = AchaSigno(day_M, month_M);
                sign_W = AchaSigno(day_W, month_W);

                Console.WriteLine("\n O Homem tem {0} anos de idade ", age_M);
                Console.WriteLine(" O signo dele é: {0}, com o elemento: {1} e seu planeta é: {2} ", signos[sign_M, 0], signos[sign_M, 1], signos[sign_M, 2]);

                Console.WriteLine("\n A Mulher tem {0} anos de idade ", age_W);
                Console.WriteLine("Ela é do signo de {0}, Seu elemento é {1} e seu planeta é {2}", signos[sign_W, 0], signos[sign_W, 1], signos[sign_W, 2]);


                if (signos[sign_M, 1].Equals(signos[sign_W, 1])) 
                    Console.WriteLine("\n De acordo com a compatibilidade dos signos o casal é totalmente compatível, \n pois são regidos pelo mesmo elemento {0}", signos[sign_M, 1]);

                else
                    Console.WriteLine("\n De acordo com a compatibilidade dos signos o casal é incompatível, \n pois o Homem é regido pelo elemento {0} e a Mulher pelo elemento {1}", signos[sign_M, 1], signos[sign_W, 1]);

                Console.Write("\n Você gostaria de acessar a tabela do zodíaco? Digite 'S' caso queir ver a tabela: ");
                sn = Console.ReadLine();

                switch (sn)
                {
                    case "S":
                    case "s":
                        Console.Clear();
                        Console.WriteLine("\n Verifique a tabela dos zodíacos \n");

                        for (int l = 0; l <= 11; l++)
                        {
                            Console.WriteLine(" Signo {0} | Elemento {1} | Planeta {2} ", signos[l, 0], signos[l, 1], signos[l, 2]);
                        }
                        break;

                    default:
                        break;
                }

                Console.Write("\n Você Deseja Consultar a compatibilidade de outro casal? 'S' caso queira consultar ou precione a tecla 'N' para sair...: ");
                sn = Console.ReadLine();


            } while (sn == "S" || sn == "s");

        }


        static int CalcIdade(int day, int month, int year)
        {
            DateTime date_new = DateTime.Now;
            int age;

            age = date_new.Year - year;

            if (date_new.Month < month)
                return (age - 1);

            else if (date_new.Month > month)
                return age;

            else
                return (date_new.Day < day) ? (age - 1) : (age); // condição ternária
        }

        static int AchaSigno(int day_s, int month_s)
        {
            int indice = 0;

            if ((day_s >= 21 && month_s == 3) || (day_s <= 20 && month_s == 4))
                indice = 0;

            else if ((day_s >= 21 && month_s == 4) || (day_s<= 21 && month_s == 5))
                indice = 1;

            else if ((day_s >= 22 && month_s == 5) || (day_s <= 21 && month_s == 6))
                indice = 2;

            else if ((day_s >= 21 && month_s == 6) || (day_s<= 23 && month_s == 7))
                indice = 3;

            else if ((day_s >= 24 && month_s == 7) || (day_s <= 23 && month_s == 8))
                indice = 4;

            else if ((day_s >= 24 && month_s == 8) || (day_s <= 23 && month_s == 9))
                indice = 5;

            else if ((day_s >= 24 && month_s == 9) || (day_s <= 23 && month_s == 10))
                indice = 6;
                
            else if ((day_s >= 24 && month_s == 10) || (day_s <= 22 && month_s == 11))
                indice = 7;
            else if ((day_s >= 23 && month_s == 11) || (day_s <= 21 && month_s == 12))
                indice = 8;

            else if ((day_s >= 22 && month_s == 12) || (day_s <= 20 && month_s == 1))
                indice = 9;

            else if ((day_s >= 21 && month_s == 1) || (day_s <= 19 && month_s == 2))
                indice = 10;

            else if ((day_s >= 20 && month_s == 2) || (day_s <= 20 && month_s == 3))
                indice = 11;

            return indice;
        }

    }
}