using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

                                      
namespace ConsoleAnagrama                                                 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                      PRESSIONE QUALQUER TECLA PARA JOGAR");
            Console.ReadKey();

            new Jogo();
        }
    }

    class Jogo
    {
        public Jogo()
        {
            Menu();
        }

        private void Menu()
        {
            Console.Clear();
            Console.WriteLine("                      MENU");
            Console.WriteLine(" _______________________________________________");
            Console.WriteLine("|                                               |");
            Console.WriteLine("|  Para iniciar o tutorial digite -           1 |");
            Console.WriteLine("|  Para iniciar a sondagem digite -           2 |");
            Console.WriteLine("|  Para iniciar o Jogo Normal digite -        3 |");
            Console.WriteLine("|  Para iniciar o Jogo Difícil digite -       4 |");
            Console.WriteLine("|  Para iniciar o Jogo Personalizado digite - 5 |");
            Console.WriteLine("|  Para Sair digite -                         0 |");
            Console.WriteLine("|_______________________________________________|");
            Console.WriteLine();

            Console.Write("   Digite a opção desejada:");
            int opcao = Int32.Parse(Console.ReadLine());

            Console.Clear();

            switch (opcao)
            {
                case 1:
                    {
                        Intro();
                    }
                    break;
                case 2:
                    {
                        Sondagem();
                    }
                    break;
                case 3:
                    {
                        JogoNormal();
                    }
                    break;
                case 4:
                    {
                        if(opcao == 4)
                        {
                            HardCore();
                        }
                        else
                        {
                            Despacito("Para entrar nesse modo é necessário acertar ao menos 5 pontos no modo Sondagem.");
                        }
                    }
                    break;
                case 5:
                    {
                        Personalizado();
                    }
                    break;
                case 0:
                    {
                        Despacito("Finalizando programa desenvolvido por Gabriel Pietro Zandona.");
                        System.Threading.Thread.Sleep(3000);
                    }
                    break;
            }
        }

        private void Intro()
        {
            Despacito(" Bem vindo ao jogo");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine(" O jogo basicamente consiste em decodificar anagramas, palavras cujas letras estão com suas ordens alteradas, embaralhadas, por assim dizer.");
            Espacinho();
            Console.WriteLine("Pressione qualquer TECLA para continuar: ");
            Console.ReadKey();
            Console.Clear();

            Console.Write("Os anagramas estarão de cor ");
            Amarelo("amarela");
            Console.WriteLine("As inicias do anagrama estarão com letra maiúscula para facilitar a resolução, portanto, você deve respeitar a ordem das letras e sua forma, digitando as iniciais maiúsculas, pois senão a resposta será considerada equivocada. Segue o exemplo abaixo: ");
            Espacinho();
            Console.WriteLine(" Este é o anagrama: ");
            Espacinho();
            Amarelo("             gaamrnAa");
            Espacinho();
            Despacito("Decodificação: Anagrama");
            Espacinho();
            Verde("Acertou");
            Console.WriteLine("Pressione qualquer TECLA para continuar: ");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Se você errar uma questão, o programa irá informar a resposta correta. Segue o exemplo abaixo: ");
            Espacinho();
            Console.WriteLine(" Este é o anagrama: ");
            Espacinho();
            Amarelo("             gaamrnAa");
            Espacinho();
            Despacito("Decodificação: almoxerifado");
            Espacinho();
            Vermelho("ERROU");
            Despacito("A resposta correta é: Anagrama");
            Espacinho();
            Console.WriteLine("Pressione qualquer TECLA para continuar: ");
            Console.ReadKey();
            Console.Clear();

            Despacito("Após resolver todos anagramas do modo, o programa irá informar quantas questões você acertou e irá lhe fazer a seguinte pergunta: ");
            Espacinho();
            Console.WriteLine("Deseja jogar este modo novamente? Sim(1) ou Não(0)");
            Espacinho();
            Vermelho("Neste caso, se premir a tecla (1) você irá para o modo Sondagem, caso você queira verificar se está apto a jogar este jogo, caso não(0), voltará ao MENU, você que sabe, comigo usuário é rei.");
            Espacinho();
            Console.WriteLine("Deseja jogar este modo novamente? Sim(1) ou Não(0)");
            int opcao = Int32.Parse(Console.ReadLine());
            Console.Clear();

            if (opcao == 1)
            {
                Sondagem();
            }
            else
            {
                Menu();
            }
        }

        private void Sondagem()
        {
            int pontuação = 0;

            string[] perguntas = new string[5]
            {
                "iO", //Oi
                "cVaa", //Vaca
                "rioT", //Tiro
                "hCá", //Chá
                "taroP", //Porta
            };

            string[] respostas = new string[5]
            {
                "Oi",
                "Vaca",
                "Tiro",
                "Chá",
                "Porta"
            };

            for (int i = 0; i < perguntas.Length; i++)
            {

                Console.WriteLine(" Este é o anagrama: ");
                Espacinho();
                Amarelo("             " + perguntas[i]);
                Espacinho();
                Console.Write("Decodificação: ");

                string resposta = Console.ReadLine();

                if (respostas[i] == resposta)
                {
                    Verde("Acertou");
                    pontuação = pontuação + 1;
                    Espacinho();
                }

                if (respostas[i] != resposta)
                {
                    Vermelho("ERROU");
                    Console.WriteLine("A resposta correta era: " + respostas[i]);
                    Espacinho();
                }

            }

            Despacito(" Você acertou " + pontuação + "/5 questões");
            Espacinho();

            Console.WriteLine("Deseja jogar este modo novamente? Sim(1) ou Não(0)");
            int opcao = Int32.Parse(Console.ReadLine());
            Console.Clear();

            if(opcao == 1)
            {
                Sondagem();
            }
            else
            {
                Menu();
            }
        }

        private void JogoNormal()
        {
            int pontuação = 0;

            string[] perguntas = new string[15]
            {
                "otPa", //Pato
                "ozArr",//Arroz
                "iBo", //Boi
                "taBtaa", //Batata
                "uaTáb", //Tábua
                "steokpD", //Desktop
                "Aarçcú", //Açúcar
                "looPv", //Polvo
                "gçnauiLi", //Linguiça
                "oaãmrCa", //Camarão
                "gntoêPmiori", //Primogênito
                "rmçgoPraaoã", //Programação
                "natSa atrainaC", //Santa Catarina
                "lrgoioOaasolntgrirnoit", //Otorrinolaringologista
                "AINSE", //SENAI
            };

            string[] respostas = new string[15]
            {
                "Pato",
                "Arroz",
                "Boi",
                "Batata",
                "Tábua",
                "Desktop",
                "Açúcar",
                "Polvo",
                "Linguiça",
                "Camarão",
                "Primogênito",
                "Programação",
                "Santa Catarina",
                "Otorrinolaringologista",
                "SENAI"
            };

            for (int i = 0; i < perguntas.Length; i++)
            {

                Console.WriteLine(" Este é o anagrama: ");
                Espacinho();
                Amarelo("             " + perguntas[i]);
                Espacinho();
                Console.Write("Decodificação: ");

                string resposta = Console.ReadLine();

                if (respostas[i] == resposta)
                {
                    Verde("Acertou");
                    pontuação = pontuação + 1;
                    Espacinho();
                }

                if (respostas[i] != resposta)
                {
                    Vermelho("ERROU");
                    Console.WriteLine("A resposta correta era: " + respostas[i]);
                    Espacinho();
                }

            }

            Despacito(" Você acertou " + pontuação + "/15 questões");
            Espacinho();

            Console.WriteLine("Deseja jogar este modo novamente? Sim(1) ou Não(0)");
            int opcao = Int32.Parse(Console.ReadLine());
            Console.Clear();

            if (opcao == 1)
            {
                JogoNormal();
            }
            else
            {
                Menu();
            }
        }

        private void HardCore()
        {
            int pontuação = 0;

            string[] perguntas = new string[8]
            {
                "ensieisligrlonsaisogMoeadtooloat",
                "aioiioopHpmsopouterdolfinbstoaeqs",
                "osnmTuloníaetttlobeefcasfaerlorar",
                "aleiomalDmdzeontiinltiaefnloiipimr",
                "mcbofotoeierbnntzxeiiirieneadnoxooapP",
                "ipaieboiPiinzlcodblllrztziarriaodnrenloenmo",
                "onasoocclpmeutloinuaPucoiilissccsrmcooonvrie",
                "opiscculucoucvcortolsiPcicaamonnooiiiomróslnet"
            };

            string[] respostas = new string[8]
            {
                "Monosialotetraesosilgangliosideo",
                "Hipopotomonstrosesquipedaliofobia",
                "Tetrabrometacresolsulfonoftaleína",
                "Dimetilaminofenildimetilpirazolona",
                "Piperidinoetoxicarbometoxibenzofenona",
                "Paraclorobenzilpirrolidinonetilbenzimidazol",
                "Pneumoultramicroscopicossilicovulcanoconiose",
                "Pneumoultramicroscopicossilicovulcanoconiótico"
            };

            for (int i = 0; i < perguntas.Length; i++)
            {

                Console.WriteLine(" Este é o anagrama: ");
                Espacinho();
                Amarelo("             " + perguntas[i]);
                Espacinho();
                Console.Write("Decodificação: ");

                string resposta = Console.ReadLine();

                if (respostas[i] == resposta)
                {
                    Verde("Acertou");
                    pontuação = pontuação + 1;
                    Espacinho();
                }

                if (respostas[i] != resposta)
                {
                    Vermelho("ERROU");
                    Console.WriteLine("A resposta correta era: " + respostas[i]);
                    Espacinho();
                }

            }

            Despacito(" Você acertou " + pontuação + "/8 questões");
            Espacinho();

            Console.WriteLine("Deseja jogar este modo novamente? Sim(1) ou Não(0)");
            int opcao = Int32.Parse(Console.ReadLine());
            Console.Clear();

            if (opcao == 1)
            {
                HardCore();
            }
            else
            {
                Menu();
            }
        }

        private void Personalizado()
        {
            int i = 0;
            int g = 0;
            int pontuação = 0;

            List<string> palavraperson = new List<string>();
            List<string> anagramaadd = new List<string>();

            bool entra = true;

            Despacito("Modo criação do modo Personalizado, para sair pressione ENTER sem digitar");
            Espacinho();

            Console.Write("Digite a palavra: ");
            string palavra = Console.ReadLine();

            if (String.IsNullOrEmpty(palavra))
            {
                entra = false;
            }

            while (entra == true)
            {
                g++;
                string embaralhado = Shuffle(palavra);

                palavraperson.Add(palavra);
                anagramaadd.Add(embaralhado);

                Console.Clear();

                Console.WriteLine("Modo criação do modo Personalizado, para sair pressione ENTER sem digitar");
                Espacinho();

                Console.Write("Digite a palavra: ");
                palavra = Console.ReadLine();


                if (String.IsNullOrEmpty(palavra))
                {
                    entra = false;
                }
            }

            Console.Clear();
            Despacito("                      PRESSIONE QUALQUER TECLA PARA JOGAR SEU JOGO");
            Console.ReadKey();
            Console.Clear();

            for (i = 0; i < g; i++)
            {
                Console.WriteLine(" Este é o anagrama: ");
                Espacinho();
                Amarelo("             " + anagramaadd[i]);
                Espacinho();
                Console.Write("Decodificação: ");

                string resposta = Console.ReadLine();

                if (palavraperson[i] == resposta)
                {
                    Verde("Acertou");
                    pontuação = pontuação + 1;
                    Espacinho();
                }

                if (palavraperson[i] != resposta)
                {
                    Vermelho("ERROU");
                    Console.WriteLine("A resposta correta era: " + palavraperson[i]);
                    Espacinho();
                }
            }

            Despacito(" Você acertou " + pontuação + "/" + g + "questões");
            Espacinho();

            Console.WriteLine("Deseja jogar este modo novamente? Sim(1) ou Não(0)");
            int opcao = Int32.Parse(Console.ReadLine());
            Console.Clear();

            if (opcao == 1)
            {
                Personalizado();
            }
            else
            {
                Menu();
            }


        }

        private string Shuffle(string palavra)
        {
            char[] array = palavra.ToCharArray();
            Random randomico = new Random();
            int n = palavra.Length;

            while (n > 1)
            {
                n--;
                int k = randomico.Next(n + 1);
                var value = array[k];
                array[k] = array[n];
                array[n] = value;
            }

            if (new string(array) == palavra)
            {
                return Shuffle(palavra);
            }

            return new string(array);
        }//Mistura as letras

        private void Despacito(string texto) //Efeito digit
        {
            for (int i = 0; i < texto.Length; i++)
            {
                Console.Write(texto[i]);
                System.Threading.Thread.Sleep(24);
            }
        }

        private void Vermelho(string texto) //Efeito despacito vermelho
        {
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Red;

            for (int i = 0; i < texto.Length; i++)
            {
                Console.Write(texto[i]);
                System.Threading.Thread.Sleep(10);
            }

            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(0.5));

            Console.ResetColor();

            Console.WriteLine("");
        }

        private void Verde(string texto) //Efeito despacito verde
        {
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 0; i < texto.Length; i++)
            {
                Console.Write(texto[i]);
                System.Threading.Thread.Sleep(10);
            }

            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(0.5));

            Console.ResetColor();

            Console.WriteLine("");
        }

        private void Amarelo(string texto)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            for (int i = 0; i < texto.Length; i++)
            {
                Console.Write(texto[i]);
                System.Threading.Thread.Sleep(10);
            }

            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(0.5));

            Console.ResetColor();

            Console.WriteLine("");
        }//Efeito despacito amarelo

        private void Espacinho()
        {
            Console.WriteLine();
            Console.WriteLine();
        }//Duas linhas

    }

}
