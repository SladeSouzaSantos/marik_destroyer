using System;

namespace ConsoleApp3
{
    class Program
    {

        static void Main(string[] args)
        {
            //Variaveis do jogo:
            string opcao = ""; // Seleção dos Comôdos da Casa
            string iniciar = ""; // Seleção Inicial (Se desejas ajudar ou não ao Marik) 
            int pontos = 100; // Pontuação do Jogo

            //Cores padrões do jogo:
            ConsoleColor caixaTextoCor = ConsoleColor.Cyan;
            ConsoleColor opinioesCor = ConsoleColor.Red;
            ConsoleColor pontuacaoCor = ConsoleColor.Yellow;

            int comodoAtual = 7; // Comodo Atual do Jogador
            /*
             0 - Escritorio
             1 - Banheiro Principal
             2 - Sala de TV
             3 - Quarto
             4 - Banheiro do Quarto
             5 - Cozinha
             6 - Quintal
             7 - Sala Principal
             */
            string[] comodos = new string[7]; // Comodos da casa, com exceção da sala principal.
            /*
             Obs.: Quando o comodos[i] = "P", significa que o item 'perdido' está neste comodo. (O jogador finalizará a partida quando visistar este comodo)
             Caso o comodos[i] = "", significa que o item 'perdido' não está neste comodo. (O jogador perderá pontos, quando visitar este comodo)
             E por ultimo, caso o comodos[i] = "N", significa que o item 'perdido' não se encontra neste comodo e o jogador já passou pelo mesmo. (O jogador não perderá pontos)
             */
            comodos[0] = "P"; // Escritorio
            comodos[1] = ""; // Banheiro Principal
            comodos[2] = ""; // Sala de TV
            comodos[3] = ""; // Quarto
            comodos[4] = ""; // Banheiro do Quarto
            comodos[5] = ""; // Cozinha
            comodos[6] = ""; // Quintal            

            //Sortear Comodo do Brinquedo:
            Random r = new Random();
            bool briquedoPerdido = false; //Verifica se o brinquedo do dog foi sorteado em algum comodo.

            for (int i = 0; i < comodos.Length; i++) // Irá percorrer a array dos comodos desde o comodos[0] até o comodos[6] e irá informar se o comodo terá o item perdido ou não.
            {
                if (briquedoPerdido == false) // Verifica se o item já foi perdido (se for falso, o item ainda não foi definido em que comodo estará).
                {
                    int verificar = r.Next(0, 2); //Irá sortear valores entre 0 a 1.
                    if (verificar > 0) // Se o numero sorteado for igual a 1, ele irá armazenar o item perdido no comodo referente ao comodos[i].
                    {
                        briquedoPerdido = true; // Declara que o item já foi sorteado, por tanto os demais serão considerados "".
                        comodos[i] = "P";
                    }
                    else if (i == (comodos.Length - 1)) // Caso o item não seja sorteado em nenhum outro comodo anterior, ele irá garantir que o item seja armazenado no ultimo comodo.
                    {
                        comodos[i] = "P";
                        briquedoPerdido = true;
                    }
                    else // Caso o valorsorteado seja 0, o comodo receberá o valor de "".
                    {
                        comodos[i] = "";
                    }
                }
                else // Caso o item tenha sido sorteado, ele irá declarar os demais como ""
                {
                    comodos[i] = "";
                }
            }
            //Fim - Sortear Comodo do Brinquedo.

            //Introdução:
            Console.ForegroundColor = caixaTextoCor;
            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
            Console.WriteLine("\t Marik é um cachorrinho muito agitado!\n");
            Console.WriteLine("\t Ele adora brincar e brincar, comer às vezes e claro... Brincar...\n");
            Console.WriteLine("\t\n");
            Console.WriteLine("\t\n");
            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#");
            Console.ForegroundColor = opinioesCor;
            Console.WriteLine("\tContinuar - Pressione Enter!");
            Console.ReadKey();

            Console.Clear();
            Console.ForegroundColor = caixaTextoCor;
            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
            Console.WriteLine("\t Porém, seus donos costumam ir trabalhar uma vez na semana...\n");
            Console.WriteLine("\t Pois é.. Quem trabalha uma vez na semana, em?\n");
            Console.WriteLine("\t Marik acaba ficando sozinho em casa, apesar de conviver com uma gata que vive se escondendo dele...\n");
            Console.WriteLine("\t E pra piorar... Marik deixou o seu brinquedo favorito dentro de casa...\n");
            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#");
            Console.ForegroundColor = opinioesCor;
            Console.WriteLine("\tContinuar - Pressione Enter!");
            Console.ReadKey();

            Console.Clear();
            Console.ForegroundColor = caixaTextoCor;
            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
            Console.WriteLine("\t Após uns 3 minutos entediado no quintal... Marik finalmente decidiu u.u\n");
            Console.WriteLine("\t Ele irá atrás do seu brinquedo favorito!\n");
            Console.WriteLine("\t Você pode ajuda-lo a encontrar?\n");
            Console.WriteLine("\t\n");
            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#");
            Console.ForegroundColor = opinioesCor;
            Console.WriteLine("\tTecle S/N!");
            iniciar = Console.ReadLine().ToUpper();

            if (iniciar == "S")
            {
                Console.Clear();
                Console.ForegroundColor = caixaTextoCor;
                Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                Console.WriteLine("\t Vamos entrando na casa, pela sala principal...\n");
                Console.WriteLine("\t Ah... Cuidado para Marik não acabar se entretendo com outros moveis da casa!\n");
                Console.WriteLine("\t Isto pode acabar deixando seus donos furiosos ¬¬\n");
                Console.WriteLine("\t\n");
                Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#");
                Console.ForegroundColor = opinioesCor;
                Console.WriteLine("\tContinuar - Pressione Enter!");
                Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = caixaTextoCor;
                Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                Console.WriteLine("\t Vi que não queres ajudar... Tudo bem! Você não têm opção na verdade... Terás que ajuda-lo!\n");
                Console.WriteLine("\t Vamos entrando na casa, pela sala principal...\n");
                Console.WriteLine("\t Ah... Cuidado para Marik não acabar se entretendo com outros moveis da casa!\n");
                Console.WriteLine("\t Isto pode acabar deixando seus donos furiosos ¬¬\n");
                Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#");
                Console.ForegroundColor = opinioesCor;
                Console.WriteLine("\tContinuar - Pressione Enter!");
                Console.ReadKey();
            }
            //Fim - Introdução.

            //Começa a busca!
            while (briquedoPerdido == true) // Enquanto o brinquedo não for encontrado... Ele irá verificar o comodo em que estamos!
            {
                // Verifica o comodo atual, cujo jogador se encontra no jogo!
                if (comodoAtual == 7)// Sala Inicial
                {
                    opcao = ""; // A opção é declarada como "" ao entrar em qualquer comodo, para que o jogador possa informar uma opção valida (de acordo com o comodo atual)
                    while (opcao != "A" && opcao != "B" && opcao != "C" && opcao != "D" && opcao != "E") // Enquanto o jogador não escolher uma das opções oferecidas o jogo não mudará de 'tela'.
                    {
                        Console.Clear();
                        Console.ForegroundColor = pontuacaoCor;
                        Console.WriteLine("\tPontuação: " + pontos + "\n\n");
                        Console.ForegroundColor = caixaTextoCor;
                        Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                        Console.WriteLine("\t Muito bem estamos na sala principal\n");
                        Console.WriteLine("\t Para onde deveriamos ir agora?\n");
                        Console.WriteLine("\t\n");
                        Console.WriteLine("\t\n");
                        Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                        Console.ForegroundColor = opinioesCor;
                        Console.WriteLine("Sala de TV (A)\t\tQuarto (B)\t\tEscritorio (C)\t\tBanheiro Principal (D)\t\tCozinha (E)\n");
                        opcao = Console.ReadLine().ToUpper(); // Transforma o que foi digitado em letras maiusculas.

                        if (opcao != "A" && opcao != "B" && opcao != "C" && opcao != "D" && opcao != "E") // Caso o jogador informe outro valor, que não seja os pedidos.
                        {
                            Console.WriteLine("\tOpção invalida! Tente novamente...");
                            Console.Beep(); // Emite o som de erro!
                            System.Threading.Thread.Sleep(2000); // Aguarda por 2 segundos para que o jogador possa ver a mensagem de error.
                        }
                        else // Caso o jogador informe um a opção valida!
                        {
                            // Verifica a opção e atualiza o comodo atual do jogador!
                            if (opcao == "A")
                            {
                                comodoAtual = 2;
                            }
                            if (opcao == "B")
                            {
                                comodoAtual = 3;
                            }
                            if (opcao == "C")
                            {
                                comodoAtual = 0;
                            }
                            if (opcao == "D")
                            {
                                comodoAtual = 1;
                            }
                            if (opcao == "E")
                            {
                                comodoAtual = 5;
                            }
                        }
                    }
                }

                if (comodoAtual == 0) // Escritorio
                {
                    opcao = "";
                    if (comodos[comodoAtual] == "P")
                    {
                        //Achou o brinquedo!
                        briquedoPerdido = false; // Quando o brinquedo é encontrado, é declarado que o brinquedo não está mais perdido.

                    }
                    else if (comodos[comodoAtual] == "N")
                    {
                        //Você já entrou neste movel, por tanto não irá perder ponto!
                    }
                    else
                    {

                        pontos = pontos - 15; // O jogador perderá pontos por ter entrado neste comodo, caso o item não se encontre aqui...
                        comodos[comodoAtual] = "N"; // Irá atualizar a informação refente a este comodo com o "N", para que o jogo entenda que o jogador já visitou aqui e 'não perderá mais pontos neste comodo'

                        //Imagem do Livro e Mensagem abaixo
                        Console.Clear();
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\t                                             _____________    ");
                        Console.WriteLine("\t                                            |_Livro|_ABC__|   ");
                        Console.WriteLine("\t                                            |______|______|   ");
                        Console.WriteLine("\t                                            |_Cc___|__Gg__|   ");
                        Console.WriteLine("\t                                            |_Dd___|__Hh__|   ");
                        Console.WriteLine("\t                                            |_Ee___|__Ii__|   ");
                        Console.WriteLine("\t                                            |______|______|   ");
                        Console.WriteLine("\t                                                              ");
                        Console.ForegroundColor = caixaTextoCor;
                        Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                        Console.WriteLine("\t Marik, nosso pai parece ter descoberto algo incrivel, em? Mas, o que será isto (Sentido da vida)?\n");
                        Console.WriteLine("\t Ei.. Marik!? Marik! O que você pretende fazer!? Espere! Isto não é um briqued... Deixa pra lá u.u\n");
                        Console.WriteLine("\t Tomará que não tenhamos destruido nada tão importante... Se não, nosso pai ficará brabo x.x\n");
                        Console.WriteLine("\t Perdemos 15 pontos pela bagunça :x\n");
                        Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                        Console.ForegroundColor = opinioesCor;
                        Console.WriteLine("\tContinuar - Pressione Enter!");
                        Console.ReadKey();
                    }

                    //O jogo continua...
                    if (briquedoPerdido == true)
                    {
                        //Mensagem para verificar o proximo local que irás:
                        while (opcao != "A")
                        {
                            Console.Clear();
                            Console.ForegroundColor = pontuacaoCor;
                            Console.WriteLine("\tPontuação: " + pontos + "\n\n");
                            Console.ForegroundColor = caixaTextoCor;
                            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                            Console.WriteLine("\t Parece que teremos problemas... ¬¬\n");
                            Console.WriteLine("\t É melhor acharmos logo este brinquedo, antes que Marik destrua a casa u.u\n");
                            Console.WriteLine("\t Para onde deveriamos ir agora?\n");
                            Console.WriteLine("\t\n");
                            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                            Console.ForegroundColor = opinioesCor;
                            Console.WriteLine("Sala Principal (A)\n");
                            opcao = Console.ReadLine().ToUpper();

                            if (opcao != "A")
                            {
                                Console.WriteLine("\tOpção invalida! Tente novamente...");
                                Console.Beep();
                                System.Threading.Thread.Sleep(2000);
                            }
                            else
                            {
                                if (opcao == "A")
                                {
                                    comodoAtual = 7;
                                }
                            }
                        }
                    }
                }

                if (comodoAtual == 1) // Banheiro Principal
                {
                    opcao = "";
                    if (comodos[comodoAtual] == "P")
                    {
                        //Achou o brinquedo!
                        briquedoPerdido = false;

                    }
                    else if (comodos[comodoAtual] == "N")
                    {
                        //Você já entrou neste movel, por tanto não irá perder ponto!
                    }
                    else
                    {
                        pontos = pontos - 2;
                        comodos[comodoAtual] = "N";

                        //Imagem da Privada e Mensagem abaixo
                        Console.Clear();
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\t                                                *======*    ");
                        Console.WriteLine("\t                                               *  ____  *   ");
                        Console.WriteLine("\t                                              *  (____)  *  ");
                        Console.WriteLine("\t                                              *          *  ");
                        Console.WriteLine("\t                                                *======*    ");
                        Console.WriteLine("\t                                              ============  ");
                        Console.WriteLine("\t                                              *          *  ");
                        Console.WriteLine("\t                                               *        *   ");
                        Console.WriteLine("\t                                                *======*    ");
                        Console.WriteLine("\t                                                            ");
                        Console.ForegroundColor = caixaTextoCor;
                        Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                        Console.WriteLine("\t Parece que deixaram a tampa da privada levantada... ¬¬\n");
                        Console.WriteLine("\t Ei.. Marik!? Marik! Isso não é para beb... Deixa pra lá u.u\n");
                        Console.WriteLine("\t Ainda derramou um pouco da água da privada pelo banheiro...\n");
                        Console.WriteLine("\t Perdemos 2 pontos pela bagunça :x\n");
                        Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                        Console.ForegroundColor = opinioesCor;
                        Console.WriteLine("\tContinuar - Pressione Enter!");
                        Console.ReadKey();
                    }

                    //O jogo continua...
                    if (briquedoPerdido == true)
                    {
                        //Mensagem para verificar o proximo local que irás:
                        while (opcao != "A")
                        {
                            Console.Clear();
                            Console.ForegroundColor = pontuacaoCor;
                            Console.WriteLine("\tPontuação: " + pontos + "\n\n");
                            Console.ForegroundColor = caixaTextoCor;
                            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                            Console.WriteLine("\t Parece que não teremos tantos problemas, neste caso.\n");
                            Console.WriteLine("\t Mas, é melhor acharmos logo este brinquedo, antes que Marik destrua a casa u.u\n");
                            Console.WriteLine("\t Para onde deveriamos ir agora?\n");
                            Console.WriteLine("\t\n");
                            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                            Console.ForegroundColor = opinioesCor;
                            Console.WriteLine("Sala Principal (A)\n");
                            opcao = Console.ReadLine().ToUpper();

                            if (opcao != "A")
                            {
                                Console.WriteLine("\tOpção invalida! Tente novamente...");
                                Console.Beep();
                                System.Threading.Thread.Sleep(2000);
                            }
                            else
                            {
                                if (opcao == "A")
                                {
                                    comodoAtual = 7;
                                }
                            }
                        }
                    }
                }

                if (comodoAtual == 2) // Sala de TV
                {
                    opcao = "";
                    if (comodos[comodoAtual] == "P")
                    {
                        //Achou o brinquedo!
                        briquedoPerdido = false;

                    }
                    else if (comodos[comodoAtual] == "N")
                    {
                        //Você já entrou neste movel, por tanto não irá perder ponto!
                    }
                    else
                    {
                        pontos = pontos - 20;
                        comodos[comodoAtual] = "N";
                        //Imagem da TV e Mensagem abaixo
                        Console.Clear();
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\t                                                \\     /       ");
                        Console.WriteLine("\t                                                 \\   /        ");
                        Console.WriteLine("\t                                                  \\ /         ");
                        Console.WriteLine("\t                                              _____|_____      ");
                        Console.WriteLine("\t                                             | --------- |     ");
                        Console.WriteLine("\t                                             | |  TV   | |     ");
                        Console.WriteLine("\t                                             | --------- |     ");
                        Console.WriteLine("\t                                             |___________|     ");
                        Console.WriteLine("\t                                                               ");
                        Console.ForegroundColor = caixaTextoCor;
                        Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                        Console.WriteLine("\t Olha Marik! Está passando o nosso filme novamente (Resgate Abaixo de Zero) *-*\n");
                        Console.WriteLine("\t Ei.. Marik!? Marik! Não se aproxima! Você pode derrub... Deixa pra lá u.u\n");
                        Console.WriteLine("\t Acho que isto vai deixar nossos pais muito irritado... Além de dar um belo prejuizo x.x\n");
                        Console.WriteLine("\t Perdemos 20 pontos pela bagunça :x\n");
                        Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                        Console.ForegroundColor = opinioesCor;
                        Console.WriteLine("\tContinuar - Pressione Enter!");
                        Console.ReadKey();
                    }

                    //O jogo continua...
                    if (briquedoPerdido == true)
                    {
                        //Mensagem para verificar o proximo local que irás:
                        while (opcao != "A")
                        {
                            Console.Clear();
                            Console.ForegroundColor = pontuacaoCor;
                            Console.WriteLine("\tPontuação: " + pontos + "\n\n");
                            Console.ForegroundColor = caixaTextoCor;
                            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                            Console.WriteLine("\t Parece que teremos problemas... ¬¬\n");
                            Console.WriteLine("\t É melhor acharmos logo este brinquedo, antes que Marik destrua a casa u.u\n");
                            Console.WriteLine("\t Para onde deveriamos ir agora?\n");
                            Console.WriteLine("\t\n");
                            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                            Console.ForegroundColor = opinioesCor;
                            Console.WriteLine("Sala Principal (A)\n");
                            opcao = Console.ReadLine().ToUpper();

                            if (opcao != "A")
                            {
                                Console.WriteLine("\tOpção invalida! Tente novamente...");
                                Console.Beep();
                                System.Threading.Thread.Sleep(2000);
                            }
                            else
                            {
                                if (opcao == "A")
                                {
                                    comodoAtual = 7;
                                }
                            }
                        }
                    }
                }

                if (comodoAtual == 3) // Quarto
                {
                    opcao = "";
                    if (comodos[comodoAtual] == "P")
                    {
                        //Achou o brinquedo!
                        briquedoPerdido = false;

                    }
                    else if (comodos[comodoAtual] == "N")
                    {
                        //Você já entrou neste movel, por tanto não irá perder ponto!
                    }
                    else
                    {
                        pontos = pontos - 10;
                        comodos[comodoAtual] = "N";
                        //Imagem da Cama e Mensagem abaixo
                        Console.Clear();
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\t                                           _________________     ");
                        Console.WriteLine("\t                                          | ______   ______ |    ");
                        Console.WriteLine("\t                                          ||__*___| |___*__||    ");                        
                        Console.WriteLine("\t                                          ___________________    ");
                        Console.WriteLine("\t                                         |___________________|   ");                        
                        Console.WriteLine("\t                                          | --------------  |    ");
                        Console.WriteLine("\t                                          | --------------  |    ");
                        Console.WriteLine("\t                                          |   ##########    |    ");
                        Console.WriteLine("\t                                          | --------------  |    ");
                        Console.WriteLine("\t                                          | --------------  |    ");
                        Console.WriteLine("\t                                          |    ---  ---     |    ");
                        Console.WriteLine("\t                                          |    /  \\/  \\     |  ");
                        Console.WriteLine("\t                                          |    \\      /     |   ");
                        Console.WriteLine("\t                                          |      \\  /       |   ");
                        Console.WriteLine("\t                                          |_________________|    ");
                        Console.WriteLine("\t                                                                 ");
                        Console.ForegroundColor = caixaTextoCor;
                        Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                        Console.WriteLine("\t Olha Marik! A cama dos nossos pais! É um tanto atraente, em? Acho que podemos subir um pouco u.u\n");
                        Console.WriteLine("\t Mas, só vamos deitar um pouco Marik, okay!? Marik? Isto não é pra cav... Deixa pra lá u.u\n");
                        Console.WriteLine("\t Talvez a mamãe não perceba estes buracos do lado dela...\n");
                        Console.WriteLine("\t Perdemos 10 pontos pela bagunça :x\n");
                        Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                        Console.ForegroundColor = opinioesCor;
                        Console.WriteLine("\tContinuar - Pressione Enter!");
                        Console.ReadKey();
                    }

                    //O jogo continua...
                    if (briquedoPerdido == true)
                    {
                        //Mensagem para verificar o proximo local que irás:
                        while (opcao != "A" && opcao != "B")
                        {
                            Console.Clear();
                            Console.ForegroundColor = pontuacaoCor;
                            Console.WriteLine("\tPontuação: " + pontos + "\n\n");
                            Console.ForegroundColor = caixaTextoCor;
                            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                            Console.WriteLine("\t Parece que teremos problemas... ¬¬\n");
                            Console.WriteLine("\t É melhor acharmos logo este brinquedo, antes que Marik destrua a casa u.u\n");
                            Console.WriteLine("\t Para onde deveriamos ir agora?\n");
                            Console.WriteLine("\t\n");
                            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                            Console.ForegroundColor = opinioesCor;
                            Console.WriteLine("Sala Principal (A)\t\tBanheiro do Quarto (B)\n");
                            opcao = Console.ReadLine().ToUpper();

                            if (opcao != "A" && opcao != "B")
                            {
                                Console.WriteLine("\tOpção invalida! Tente novamente...");
                                Console.Beep();
                                System.Threading.Thread.Sleep(2000);
                            }
                            else
                            {
                                if (opcao == "A")
                                {
                                    comodoAtual = 7;
                                }

                                if (opcao == "B")
                                {
                                    comodoAtual = 4;
                                }
                            }
                        }
                    }
                }

                if (comodoAtual == 4) // Banheiro do Quarto
                {
                    opcao = "";
                    if (comodos[comodoAtual] == "P")
                    {
                        //Achou o brinquedo!
                        briquedoPerdido = false;

                    }
                    else if (comodos[comodoAtual] == "N")
                    {
                        //Você já entrou neste movel, por tanto não irá perder ponto!
                    }
                    else
                    {
                        pontos = pontos - 2;
                        comodos[comodoAtual] = "N";

                        //Imagem da Privada e Mensagem abaixo
                        Console.Clear();
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\t                                                *======*    ");
                        Console.WriteLine("\t                                               *  ____  *   ");
                        Console.WriteLine("\t                                              *  (____)  *  ");
                        Console.WriteLine("\t                                              *          *  ");
                        Console.WriteLine("\t                                                *======*    ");
                        Console.WriteLine("\t                                              ============  ");
                        Console.WriteLine("\t                                              *          *  ");
                        Console.WriteLine("\t                                               *        *   ");
                        Console.WriteLine("\t                                                *======*    ");
                        Console.WriteLine("\t                                                            ");
                        Console.ForegroundColor = caixaTextoCor;
                        Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                        Console.WriteLine("\t Parece que deixaram a tampa da privada levantada... ¬¬\n");
                        Console.WriteLine("\t Ei.. Marik!? Marik! Isso não é para beb... Deixa pra lá u.u\n");
                        Console.WriteLine("\t Ainda derramou um pouco da água da privada pelo banheiro...\n");
                        Console.WriteLine("\t Perdemos 2 pontos pela bagunça :x\n");
                        Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                        Console.ForegroundColor = opinioesCor;
                        Console.WriteLine("\tContinuar - Pressione Enter!");
                        Console.ReadKey();
                    }

                    //O jogo continua...
                    if (briquedoPerdido == true)
                    {
                        //Mensagem para verificar o proximo local que irás:
                        while (opcao != "A")
                        {
                            Console.Clear();
                            Console.ForegroundColor = pontuacaoCor;
                            Console.WriteLine("\tPontuação: " + pontos + "\n\n");
                            Console.ForegroundColor = caixaTextoCor;
                            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                            Console.WriteLine("\t Parece que não teremos tantos problemas, neste caso.\n");
                            Console.WriteLine("\t Mas, é melhor acharmos logo este brinquedo, antes que Marik destrua a casa u.u\n");
                            Console.WriteLine("\t Para onde deveriamos ir agora?\n");
                            Console.WriteLine("\t\n");
                            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                            Console.ForegroundColor = opinioesCor;
                            Console.WriteLine("Quarto (A)\n");
                            opcao = Console.ReadLine().ToUpper();

                            if (opcao != "A")
                            {
                                Console.WriteLine("\tOpção invalida! Tente novamente...");
                                Console.Beep();
                                System.Threading.Thread.Sleep(2000);
                            }
                            else
                            {
                                if (opcao == "A")
                                {
                                    comodoAtual = 3;
                                }
                            }
                        }
                    }
                }

                if (comodoAtual == 5) // Cozinha
                {
                    opcao = "";
                    if (comodos[comodoAtual] == "P")
                    {
                        //Achou o brinquedo!
                        briquedoPerdido = false;

                    }
                    else if (comodos[comodoAtual] == "N")
                    {
                        //Você já entrou neste movel, por tanto não irá perder ponto!
                    }
                    else
                    {
                        pontos = pontos - 10;
                        comodos[comodoAtual] = "N";
                        //Imagem da Geladeira e Mensagem abaixo
                        Console.Clear();
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("\t                                             _______________   ");
                        Console.WriteLine("\t                                            | ------------- |  ");
                        Console.WriteLine("\t                                            | |         O | |  ");
                        Console.WriteLine("\t                                            | ------------- |  ");
                        Console.WriteLine("\t                                            |       |       |  ");
                        Console.WriteLine("\t                                            |      _|_      |  ");
                        Console.WriteLine("\t                                            |  O  |---|  O  |  ");
                        Console.WriteLine("\t                                            |     |___|     |  ");
                        Console.WriteLine("\t                                            |       |       |  ");
                        Console.WriteLine("\t                                            |       |       |  ");
                        Console.WriteLine("\t                                            |       |       |  ");
                        Console.WriteLine("\t                                            |_______|_______|  ");
                        Console.WriteLine("\t                                                               ");
                        Console.ForegroundColor = caixaTextoCor;
                        Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                        Console.WriteLine("\t Parece que deixaram a porta da geladeira aberta Marik... Acho que podemos fecha-la!\n");
                        Console.WriteLine("\t Hã? O que são essas cascas de banana? Marik, não! Essas bananas não são para voc... Deixa pra lá u.u\n");
                        Console.WriteLine("\t Espero que ninguem escorregue nessas cascas de banana...\n");
                        Console.WriteLine("\t Perdemos 10 pontos pela bagunça :x\n");
                        Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                        Console.ForegroundColor = opinioesCor;
                        Console.WriteLine("\tContinuar - Pressione Enter!");
                        Console.ReadKey();
                    }

                    //O jogo continua...
                    if (briquedoPerdido == true)
                    {
                        //Mensagem para verificar o proximo local que irás:
                        while (opcao != "A" && opcao != "B")
                        {
                            Console.Clear();
                            Console.ForegroundColor = pontuacaoCor;
                            Console.WriteLine("\tPontuação: " + pontos + "\n\n");
                            Console.ForegroundColor = caixaTextoCor;
                            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                            Console.WriteLine("\t Parece que teremos problemas... ¬¬\n");
                            Console.WriteLine("\t É melhor acharmos logo este brinquedo, antes que Marik destrua a casa u.u\n");
                            Console.WriteLine("\t Para onde deveriamos ir agora?\n");
                            Console.WriteLine("\t\n");
                            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                            Console.ForegroundColor = opinioesCor;
                            Console.WriteLine("Sala Principal (A)\t\tQuintal (B)\n");
                            opcao = Console.ReadLine().ToUpper();

                            if (opcao != "A" && opcao != "B")
                            {
                                Console.WriteLine("\tOpção invalida! Tente novamente...");
                                Console.Beep();
                                System.Threading.Thread.Sleep(2000);
                            }
                            else
                            {
                                if (opcao == "A")
                                {
                                    comodoAtual = 7;
                                }

                                if (opcao == "B")
                                {
                                    comodoAtual = 6;
                                }
                            }
                        }
                    }
                }

                if (comodoAtual == 6) // Quintal
                {
                    opcao = "";
                    if (comodos[comodoAtual] == "P")
                    {
                        //Achou o brinquedo!
                        briquedoPerdido = false;

                    }
                    else if (comodos[comodoAtual] == "N")
                    {
                        //Você já entrou neste movel, por tanto não irá perder ponto!
                    }
                    else
                    {
                        pontos = pontos - 5;
                        comodos[comodoAtual] = "N";
                        //Imagem do Jardim e Mensagem abaixo
                        Console.Clear();
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("\t                                     ____               ____   ");
                        Console.WriteLine("\t                                   ( .  . )   *       ( .  . ) ");
                        Console.WriteLine("\t                                  (  .   . )     *   (  .   . )");
                        Console.WriteLine("\t                                   (_  . _)           (_  . _) ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\t                                      ||    *            ||    ");
                        Console.WriteLine("\t                                   *  || *~~*          * || *~~");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t                                  \\\\\\////\\\\\\////\\\\\\////\\\\/////\\");
                        Console.WriteLine("\t                                                             ");
                        Console.ForegroundColor = caixaTextoCor;
                        Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                        Console.WriteLine("\t Nada melhor do que o ambiente natural que o jardim da mamãe consegue oferecer, em?\n");
                        Console.WriteLine("\t Ei.. Marik!? Marik! Aí não é lugar para cav... Deixa pra lá u.u\n");
                        Console.WriteLine("\t Talvez, se nós enterrarmos as flores, a mamãe não perceba...\n");
                        Console.WriteLine("\t Perdemos 5 pontos pela bagunça :x\n");
                        Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                        Console.ForegroundColor = opinioesCor;
                        Console.WriteLine("\tContinuar - Pressione Enter!");
                        Console.ReadKey();
                    }

                    //O jogo continua...
                    if (briquedoPerdido == true)
                    {
                        //Mensagem para verificar o proximo local que irás:
                        while (opcao != "A")
                        {
                            Console.Clear();
                            Console.ForegroundColor = pontuacaoCor;
                            Console.WriteLine("\tPontuação: " + pontos + "\n\n");
                            Console.ForegroundColor = caixaTextoCor;
                            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                            Console.WriteLine("\t Parece que não teremos tantos problemas, neste caso.\n");
                            Console.WriteLine("\t Mas, é melhor acharmos logo este brinquedo, antes que Marik destrua a casa u.u\n");
                            Console.WriteLine("\t Para onde deveriamos ir agora?\n");
                            Console.WriteLine("\t\n");
                            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                            Console.ForegroundColor = opinioesCor;
                            Console.WriteLine("Cozinha (A)\n");
                            opcao = Console.ReadLine().ToUpper();

                            if (opcao != "A")
                            {
                                Console.WriteLine("\tOpção invalida! Tente novamente...");
                                Console.Beep();
                                System.Threading.Thread.Sleep(2000);
                            }
                            else
                            {
                                if (opcao == "A")
                                {
                                    comodoAtual = 5;
                                }
                            }
                        }
                    }
                }
            }
            //Fim da busca pelo brinquedo!

            //Final do Jogo:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n");
            Console.WriteLine("\t                                                 (\\_/)       ");
            Console.WriteLine("\t                                                 (°.°)        ");
            Console.WriteLine("\t                                                 o( )o        ");
            Console.WriteLine("\t                                                  O_O         ");
            Console.WriteLine("\t                                                              ");
            Console.ForegroundColor = caixaTextoCor;
            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
            Console.WriteLine("\t Aí está o nosso tão amado TED!!!\n");
            Console.WriteLine("\t *-*\n");
            Console.WriteLine("\t *-*\n");
            Console.WriteLine("\t *-*\n");
            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
            Console.ForegroundColor = opinioesCor;
            Console.WriteLine("\tContinuar - Pressione Enter!");
            Console.ReadKey();

            //Variações de Finais:
            if (pontos >= 80)
            {
                //Melhor final:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n");
                Console.WriteLine("\t                                              _         _     ");
                Console.WriteLine("\t                                             ( \\_______/ )   ");
                Console.WriteLine("\t                                             (  _______  )    ");
                Console.WriteLine("\t                                             (_/       \\_)   ");
                Console.WriteLine("\t                                                              ");
                Console.ForegroundColor = pontuacaoCor;
                Console.WriteLine("\tPontuação: " + pontos + "\n\n");
                Console.ForegroundColor = caixaTextoCor;
                Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                Console.WriteLine("\t Parece que temos um Sherlock Holmes aqui, em?\n");
                Console.WriteLine("\t Realmente incrivel!\n");
                Console.WriteLine("\t Graças a você, Marik ganhou um ossinho para brincar!\n");
                Console.WriteLine("\t E claro... Seus donos estão orgulhosos do seu melhor amigo ;)\n");
                Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
            }
            else if (pontos >= 60)
            {
                //Bom final
                Console.Clear();
                Console.ForegroundColor = pontuacaoCor;
                Console.WriteLine("\tPontuação: " + pontos + "\n\n");
                Console.ForegroundColor = caixaTextoCor;
                Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                Console.WriteLine("\t Muito bem! Não pudemos salvar a casa... Mas, pelo menos, ainda há casa, né?\n");
                Console.WriteLine("\t Graças a você, podemos dizer que o estrago não foi tão grande!\n");
                Console.WriteLine("\t Mas, mesmo assim... Na proxima vez, vamos tentar manter a casa em ordem...\n");
                Console.WriteLine("\t Quem sabe o nosso amigo não ganha até um novo brinquedinho ;)\n");
                Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
            }
            else
            {
                //Final Ruim :x
                Console.Clear();
                Console.ForegroundColor = pontuacaoCor;
                Console.WriteLine("\tPontuação: " + pontos + "\n\n");
                Console.ForegroundColor = caixaTextoCor;
                Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                Console.WriteLine("\t Acho melhor a gente se esconder, em?\n");
                Console.WriteLine("\t Antes que os nossos pais cheguem em casa!\n");
                Console.WriteLine("\t Quero dizer... No que restou dela :x\n");
                Console.WriteLine("\t Vamos atrás de Xandelinha e coloca-la no local do crime... Pelo menos nós não levamos a culpa ^^\n");
                Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
            }
            Console.ReadKey();
        }

    }
}