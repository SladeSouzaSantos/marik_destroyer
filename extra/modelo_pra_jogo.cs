using System;

namespace ConsoleApp3
{
    class Program
    {

        static void Main(string[] args)
        {
            //Variaveis do jogo:
            string opcao = ""; // Sele��o dos Com�dos da Casa
            string iniciar = ""; // Sele��o Inicial (Se desejas ajudar ou n�o ao Marik) 
            int pontos = 100; // Pontua��o do Jogo

            //Cores padr�es do jogo:
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
            string[] comodos = new string[7]; // Comodos da casa, com exce��o da sala principal.
            /*
             Obs.: Quando o comodos[i] = "P", significa que o item 'perdido' est� neste comodo. (O jogador finalizar� a partida quando visistar este comodo)
             Caso o comodos[i] = "", significa que o item 'perdido' n�o est� neste comodo. (O jogador perder� pontos, quando visitar este comodo)
             E por ultimo, caso o comodos[i] = "N", significa que o item 'perdido' n�o se encontra neste comodo e o jogador j� passou pelo mesmo. (O jogador n�o perder� pontos)
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

            for (int i = 0; i < comodos.Length; i++) // Ir� percorrer a array dos comodos desde o comodos[0] at� o comodos[6] e ir� informar se o comodo ter� o item perdido ou n�o.
            {
                if (briquedoPerdido == false) // Verifica se o item j� foi perdido (se for falso, o item ainda n�o foi definido em que comodo estar�).
                {
                    int verificar = r.Next(0, 2); //Ir� sortear valores entre 0 a 1.
                    if (verificar > 0) // Se o numero sorteado for igual a 1, ele ir� armazenar o item perdido no comodo referente ao comodos[i].
                    {
                        briquedoPerdido = true; // Declara que o item j� foi sorteado, por tanto os demais ser�o considerados "".
                        comodos[i] = "P";
                    }
                    else if (i == (comodos.Length - 1)) // Caso o item n�o seja sorteado em nenhum outro comodo anterior, ele ir� garantir que o item seja armazenado no ultimo comodo.
                    {
                        comodos[i] = "P";
                        briquedoPerdido = true;
                    }
                    else // Caso o valorsorteado seja 0, o comodo receber� o valor de "".
                    {
                        comodos[i] = "";
                    }
                }
                else // Caso o item tenha sido sorteado, ele ir� declarar os demais como ""
                {
                    comodos[i] = "";
                }
            }
            //Fim - Sortear Comodo do Brinquedo.

            //Introdu��o:
            Console.ForegroundColor = caixaTextoCor;
            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
            Console.WriteLine("\t Marik � um cachorrinho muito agitado!\n");
            Console.WriteLine("\t Ele adora brincar e brincar, comer �s vezes e claro... Brincar...\n");
            Console.WriteLine("\t\n");
            Console.WriteLine("\t\n");
            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#");
            Console.ForegroundColor = opinioesCor;
            Console.WriteLine("\tContinuar - Pressione Enter!");
            Console.ReadKey();

            Console.Clear();
            Console.ForegroundColor = caixaTextoCor;
            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
            Console.WriteLine("\t Por�m, seus donos costumam ir trabalhar uma vez na semana...\n");
            Console.WriteLine("\t Pois �.. Quem trabalha uma vez na semana, em?\n");
            Console.WriteLine("\t Marik acaba ficando sozinho em casa, apesar de conviver com uma gata que vive se escondendo dele...\n");
            Console.WriteLine("\t E pra piorar... Marik deixou o seu brinquedo favorito dentro de casa...\n");
            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#");
            Console.ForegroundColor = opinioesCor;
            Console.WriteLine("\tContinuar - Pressione Enter!");
            Console.ReadKey();

            Console.Clear();
            Console.ForegroundColor = caixaTextoCor;
            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
            Console.WriteLine("\t Ap�s uns 3 minutos entediado no quintal... Marik finalmente decidiu u.u\n");
            Console.WriteLine("\t Ele ir� atr�s do seu brinquedo favorito!\n");
            Console.WriteLine("\t Voc� pode ajuda-lo a encontrar?\n");
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
                Console.WriteLine("\t Ah... Cuidado para Marik n�o acabar se entretendo com outros moveis da casa!\n");
                Console.WriteLine("\t Isto pode acabar deixando seus donos furiosos ��\n");
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
                Console.WriteLine("\t Vi que n�o queres ajudar... Tudo bem! Voc� n�o t�m op��o na verdade... Ter�s que ajuda-lo!\n");
                Console.WriteLine("\t Vamos entrando na casa, pela sala principal...\n");
                Console.WriteLine("\t Ah... Cuidado para Marik n�o acabar se entretendo com outros moveis da casa!\n");
                Console.WriteLine("\t Isto pode acabar deixando seus donos furiosos ��\n");
                Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#");
                Console.ForegroundColor = opinioesCor;
                Console.WriteLine("\tContinuar - Pressione Enter!");
                Console.ReadKey();
            }
            //Fim - Introdu��o.

            //Come�a a busca!
            while (briquedoPerdido == true) // Enquanto o brinquedo n�o for encontrado... Ele ir� verificar o comodo em que estamos!
            {
                // Verifica o comodo atual, cujo jogador se encontra no jogo!
                if (comodoAtual == 7)// Sala Inicial
                {
                    opcao = ""; // A op��o � declarada como "" ao entrar em qualquer comodo, para que o jogador possa informar uma op��o valida (de acordo com o comodo atual)
                    while (opcao != "A" && opcao != "B" && opcao != "C" && opcao != "D" && opcao != "E") // Enquanto o jogador n�o escolher uma das op��es oferecidas o jogo n�o mudar� de 'tela'.
                    {
                        Console.Clear();
                        Console.ForegroundColor = pontuacaoCor;
                        Console.WriteLine("\tPontua��o: " + pontos + "\n\n");
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

                        if (opcao != "A" && opcao != "B" && opcao != "C" && opcao != "D" && opcao != "E") // Caso o jogador informe outro valor, que n�o seja os pedidos.
                        {
                            Console.WriteLine("\tOp��o invalida! Tente novamente...");
                            Console.Beep(); // Emite o som de erro!
                            System.Threading.Thread.Sleep(2000); // Aguarda por 2 segundos para que o jogador possa ver a mensagem de error.
                        }
                        else // Caso o jogador informe um a op��o valida!
                        {
                            // Verifica a op��o e atualiza o comodo atual do jogador!
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
                        briquedoPerdido = false; // Quando o brinquedo � encontrado, � declarado que o brinquedo n�o est� mais perdido.

                    }
                    else if (comodos[comodoAtual] == "N")
                    {
                        //Voc� j� entrou neste movel, por tanto n�o ir� perder ponto!
                    }
                    else
                    {

                        pontos = pontos - 15; // O jogador perder� pontos por ter entrado neste comodo, caso o item n�o se encontre aqui...
                        comodos[comodoAtual] = "N"; // Ir� atualizar a informa��o refente a este comodo com o "N", para que o jogo entenda que o jogador j� visitou aqui e 'n�o perder� mais pontos neste comodo'

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
                        Console.WriteLine("\t Marik, nosso pai parece ter descoberto algo incrivel, em? Mas, o que ser� isto (Sentido da vida)?\n");
                        Console.WriteLine("\t Ei.. Marik!? Marik! O que voc� pretende fazer!? Espere! Isto n�o � um briqued... Deixa pra l� u.u\n");
                        Console.WriteLine("\t Tomar� que n�o tenhamos destruido nada t�o importante... Se n�o, nosso pai ficar� brabo x.x\n");
                        Console.WriteLine("\t Perdemos 15 pontos pela bagun�a :x\n");
                        Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                        Console.ForegroundColor = opinioesCor;
                        Console.WriteLine("\tContinuar - Pressione Enter!");
                        Console.ReadKey();
                    }

                    //O jogo continua...
                    if (briquedoPerdido == true)
                    {
                        //Mensagem para verificar o proximo local que ir�s:
                        while (opcao != "A")
                        {
                            Console.Clear();
                            Console.ForegroundColor = pontuacaoCor;
                            Console.WriteLine("\tPontua��o: " + pontos + "\n\n");
                            Console.ForegroundColor = caixaTextoCor;
                            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                            Console.WriteLine("\t Parece que teremos problemas... ��\n");
                            Console.WriteLine("\t � melhor acharmos logo este brinquedo, antes que Marik destrua a casa u.u\n");
                            Console.WriteLine("\t Para onde deveriamos ir agora?\n");
                            Console.WriteLine("\t\n");
                            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                            Console.ForegroundColor = opinioesCor;
                            Console.WriteLine("Sala Principal (A)\n");
                            opcao = Console.ReadLine().ToUpper();

                            if (opcao != "A")
                            {
                                Console.WriteLine("\tOp��o invalida! Tente novamente...");
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
                        //Voc� j� entrou neste movel, por tanto n�o ir� perder ponto!
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
                        Console.WriteLine("\t Parece que deixaram a tampa da privada levantada... ��\n");
                        Console.WriteLine("\t Ei.. Marik!? Marik! Isso n�o � para beb... Deixa pra l� u.u\n");
                        Console.WriteLine("\t Ainda derramou um pouco da �gua da privada pelo banheiro...\n");
                        Console.WriteLine("\t Perdemos 2 pontos pela bagun�a :x\n");
                        Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                        Console.ForegroundColor = opinioesCor;
                        Console.WriteLine("\tContinuar - Pressione Enter!");
                        Console.ReadKey();
                    }

                    //O jogo continua...
                    if (briquedoPerdido == true)
                    {
                        //Mensagem para verificar o proximo local que ir�s:
                        while (opcao != "A")
                        {
                            Console.Clear();
                            Console.ForegroundColor = pontuacaoCor;
                            Console.WriteLine("\tPontua��o: " + pontos + "\n\n");
                            Console.ForegroundColor = caixaTextoCor;
                            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                            Console.WriteLine("\t Parece que n�o teremos tantos problemas, neste caso.\n");
                            Console.WriteLine("\t Mas, � melhor acharmos logo este brinquedo, antes que Marik destrua a casa u.u\n");
                            Console.WriteLine("\t Para onde deveriamos ir agora?\n");
                            Console.WriteLine("\t\n");
                            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                            Console.ForegroundColor = opinioesCor;
                            Console.WriteLine("Sala Principal (A)\n");
                            opcao = Console.ReadLine().ToUpper();

                            if (opcao != "A")
                            {
                                Console.WriteLine("\tOp��o invalida! Tente novamente...");
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
                        //Voc� j� entrou neste movel, por tanto n�o ir� perder ponto!
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
                        Console.WriteLine("\t Olha Marik! Est� passando o nosso filme novamente (Resgate Abaixo de Zero) *-*\n");
                        Console.WriteLine("\t Ei.. Marik!? Marik! N�o se aproxima! Voc� pode derrub... Deixa pra l� u.u\n");
                        Console.WriteLine("\t Acho que isto vai deixar nossos pais muito irritado... Al�m de dar um belo prejuizo x.x\n");
                        Console.WriteLine("\t Perdemos 20 pontos pela bagun�a :x\n");
                        Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                        Console.ForegroundColor = opinioesCor;
                        Console.WriteLine("\tContinuar - Pressione Enter!");
                        Console.ReadKey();
                    }

                    //O jogo continua...
                    if (briquedoPerdido == true)
                    {
                        //Mensagem para verificar o proximo local que ir�s:
                        while (opcao != "A")
                        {
                            Console.Clear();
                            Console.ForegroundColor = pontuacaoCor;
                            Console.WriteLine("\tPontua��o: " + pontos + "\n\n");
                            Console.ForegroundColor = caixaTextoCor;
                            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                            Console.WriteLine("\t Parece que teremos problemas... ��\n");
                            Console.WriteLine("\t � melhor acharmos logo este brinquedo, antes que Marik destrua a casa u.u\n");
                            Console.WriteLine("\t Para onde deveriamos ir agora?\n");
                            Console.WriteLine("\t\n");
                            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                            Console.ForegroundColor = opinioesCor;
                            Console.WriteLine("Sala Principal (A)\n");
                            opcao = Console.ReadLine().ToUpper();

                            if (opcao != "A")
                            {
                                Console.WriteLine("\tOp��o invalida! Tente novamente...");
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
                        //Voc� j� entrou neste movel, por tanto n�o ir� perder ponto!
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
                        Console.WriteLine("\t Olha Marik! A cama dos nossos pais! � um tanto atraente, em? Acho que podemos subir um pouco u.u\n");
                        Console.WriteLine("\t Mas, s� vamos deitar um pouco Marik, okay!? Marik? Isto n�o � pra cav... Deixa pra l� u.u\n");
                        Console.WriteLine("\t Talvez a mam�e n�o perceba estes buracos do lado dela...\n");
                        Console.WriteLine("\t Perdemos 10 pontos pela bagun�a :x\n");
                        Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                        Console.ForegroundColor = opinioesCor;
                        Console.WriteLine("\tContinuar - Pressione Enter!");
                        Console.ReadKey();
                    }

                    //O jogo continua...
                    if (briquedoPerdido == true)
                    {
                        //Mensagem para verificar o proximo local que ir�s:
                        while (opcao != "A" && opcao != "B")
                        {
                            Console.Clear();
                            Console.ForegroundColor = pontuacaoCor;
                            Console.WriteLine("\tPontua��o: " + pontos + "\n\n");
                            Console.ForegroundColor = caixaTextoCor;
                            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                            Console.WriteLine("\t Parece que teremos problemas... ��\n");
                            Console.WriteLine("\t � melhor acharmos logo este brinquedo, antes que Marik destrua a casa u.u\n");
                            Console.WriteLine("\t Para onde deveriamos ir agora?\n");
                            Console.WriteLine("\t\n");
                            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                            Console.ForegroundColor = opinioesCor;
                            Console.WriteLine("Sala Principal (A)\t\tBanheiro do Quarto (B)\n");
                            opcao = Console.ReadLine().ToUpper();

                            if (opcao != "A" && opcao != "B")
                            {
                                Console.WriteLine("\tOp��o invalida! Tente novamente...");
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
                        //Voc� j� entrou neste movel, por tanto n�o ir� perder ponto!
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
                        Console.WriteLine("\t Parece que deixaram a tampa da privada levantada... ��\n");
                        Console.WriteLine("\t Ei.. Marik!? Marik! Isso n�o � para beb... Deixa pra l� u.u\n");
                        Console.WriteLine("\t Ainda derramou um pouco da �gua da privada pelo banheiro...\n");
                        Console.WriteLine("\t Perdemos 2 pontos pela bagun�a :x\n");
                        Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                        Console.ForegroundColor = opinioesCor;
                        Console.WriteLine("\tContinuar - Pressione Enter!");
                        Console.ReadKey();
                    }

                    //O jogo continua...
                    if (briquedoPerdido == true)
                    {
                        //Mensagem para verificar o proximo local que ir�s:
                        while (opcao != "A")
                        {
                            Console.Clear();
                            Console.ForegroundColor = pontuacaoCor;
                            Console.WriteLine("\tPontua��o: " + pontos + "\n\n");
                            Console.ForegroundColor = caixaTextoCor;
                            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                            Console.WriteLine("\t Parece que n�o teremos tantos problemas, neste caso.\n");
                            Console.WriteLine("\t Mas, � melhor acharmos logo este brinquedo, antes que Marik destrua a casa u.u\n");
                            Console.WriteLine("\t Para onde deveriamos ir agora?\n");
                            Console.WriteLine("\t\n");
                            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                            Console.ForegroundColor = opinioesCor;
                            Console.WriteLine("Quarto (A)\n");
                            opcao = Console.ReadLine().ToUpper();

                            if (opcao != "A")
                            {
                                Console.WriteLine("\tOp��o invalida! Tente novamente...");
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
                        //Voc� j� entrou neste movel, por tanto n�o ir� perder ponto!
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
                        Console.WriteLine("\t H�? O que s�o essas cascas de banana? Marik, n�o! Essas bananas n�o s�o para voc... Deixa pra l� u.u\n");
                        Console.WriteLine("\t Espero que ninguem escorregue nessas cascas de banana...\n");
                        Console.WriteLine("\t Perdemos 10 pontos pela bagun�a :x\n");
                        Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                        Console.ForegroundColor = opinioesCor;
                        Console.WriteLine("\tContinuar - Pressione Enter!");
                        Console.ReadKey();
                    }

                    //O jogo continua...
                    if (briquedoPerdido == true)
                    {
                        //Mensagem para verificar o proximo local que ir�s:
                        while (opcao != "A" && opcao != "B")
                        {
                            Console.Clear();
                            Console.ForegroundColor = pontuacaoCor;
                            Console.WriteLine("\tPontua��o: " + pontos + "\n\n");
                            Console.ForegroundColor = caixaTextoCor;
                            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                            Console.WriteLine("\t Parece que teremos problemas... ��\n");
                            Console.WriteLine("\t � melhor acharmos logo este brinquedo, antes que Marik destrua a casa u.u\n");
                            Console.WriteLine("\t Para onde deveriamos ir agora?\n");
                            Console.WriteLine("\t\n");
                            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                            Console.ForegroundColor = opinioesCor;
                            Console.WriteLine("Sala Principal (A)\t\tQuintal (B)\n");
                            opcao = Console.ReadLine().ToUpper();

                            if (opcao != "A" && opcao != "B")
                            {
                                Console.WriteLine("\tOp��o invalida! Tente novamente...");
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
                        //Voc� j� entrou neste movel, por tanto n�o ir� perder ponto!
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
                        Console.WriteLine("\t Nada melhor do que o ambiente natural que o jardim da mam�e consegue oferecer, em?\n");
                        Console.WriteLine("\t Ei.. Marik!? Marik! A� n�o � lugar para cav... Deixa pra l� u.u\n");
                        Console.WriteLine("\t Talvez, se n�s enterrarmos as flores, a mam�e n�o perceba...\n");
                        Console.WriteLine("\t Perdemos 5 pontos pela bagun�a :x\n");
                        Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                        Console.ForegroundColor = opinioesCor;
                        Console.WriteLine("\tContinuar - Pressione Enter!");
                        Console.ReadKey();
                    }

                    //O jogo continua...
                    if (briquedoPerdido == true)
                    {
                        //Mensagem para verificar o proximo local que ir�s:
                        while (opcao != "A")
                        {
                            Console.Clear();
                            Console.ForegroundColor = pontuacaoCor;
                            Console.WriteLine("\tPontua��o: " + pontos + "\n\n");
                            Console.ForegroundColor = caixaTextoCor;
                            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                            Console.WriteLine("\t Parece que n�o teremos tantos problemas, neste caso.\n");
                            Console.WriteLine("\t Mas, � melhor acharmos logo este brinquedo, antes que Marik destrua a casa u.u\n");
                            Console.WriteLine("\t Para onde deveriamos ir agora?\n");
                            Console.WriteLine("\t\n");
                            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                            Console.ForegroundColor = opinioesCor;
                            Console.WriteLine("Cozinha (A)\n");
                            opcao = Console.ReadLine().ToUpper();

                            if (opcao != "A")
                            {
                                Console.WriteLine("\tOp��o invalida! Tente novamente...");
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
            Console.WriteLine("\t                                                 (�.�)        ");
            Console.WriteLine("\t                                                 o( )o        ");
            Console.WriteLine("\t                                                  O_O         ");
            Console.WriteLine("\t                                                              ");
            Console.ForegroundColor = caixaTextoCor;
            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
            Console.WriteLine("\t A� est� o nosso t�o amado TED!!!\n");
            Console.WriteLine("\t *-*\n");
            Console.WriteLine("\t *-*\n");
            Console.WriteLine("\t *-*\n");
            Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
            Console.ForegroundColor = opinioesCor;
            Console.WriteLine("\tContinuar - Pressione Enter!");
            Console.ReadKey();

            //Varia��es de Finais:
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
                Console.WriteLine("\tPontua��o: " + pontos + "\n\n");
                Console.ForegroundColor = caixaTextoCor;
                Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                Console.WriteLine("\t Parece que temos um Sherlock Holmes aqui, em?\n");
                Console.WriteLine("\t Realmente incrivel!\n");
                Console.WriteLine("\t Gra�as a voc�, Marik ganhou um ossinho para brincar!\n");
                Console.WriteLine("\t E claro... Seus donos est�o orgulhosos do seu melhor amigo ;)\n");
                Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
            }
            else if (pontos >= 60)
            {
                //Bom final
                Console.Clear();
                Console.ForegroundColor = pontuacaoCor;
                Console.WriteLine("\tPontua��o: " + pontos + "\n\n");
                Console.ForegroundColor = caixaTextoCor;
                Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                Console.WriteLine("\t Muito bem! N�o pudemos salvar a casa... Mas, pelo menos, ainda h� casa, n�?\n");
                Console.WriteLine("\t Gra�as a voc�, podemos dizer que o estrago n�o foi t�o grande!\n");
                Console.WriteLine("\t Mas, mesmo assim... Na proxima vez, vamos tentar manter a casa em ordem...\n");
                Console.WriteLine("\t Quem sabe o nosso amigo n�o ganha at� um novo brinquedinho ;)\n");
                Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
            }
            else
            {
                //Final Ruim :x
                Console.Clear();
                Console.ForegroundColor = pontuacaoCor;
                Console.WriteLine("\tPontua��o: " + pontos + "\n\n");
                Console.ForegroundColor = caixaTextoCor;
                Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
                Console.WriteLine("\t Acho melhor a gente se esconder, em?\n");
                Console.WriteLine("\t Antes que os nossos pais cheguem em casa!\n");
                Console.WriteLine("\t Quero dizer... No que restou dela :x\n");
                Console.WriteLine("\t Vamos atr�s de Xandelinha e coloca-la no local do crime... Pelo menos n�s n�o levamos a culpa ^^\n");
                Console.WriteLine("\t#--------------------------------------------------------------------------------------------------#\n");
            }
            Console.ReadKey();
        }

    }
}