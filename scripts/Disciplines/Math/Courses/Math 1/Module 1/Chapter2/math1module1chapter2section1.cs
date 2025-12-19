using SchoolData;

public class Math1Module1Chapter2Section1
{
    public static Topic Topic = new()
    {
        Id = "sistema-axiomatico",
        Name = "2.1 Sistema Axiomático",
        Active = false,
        Body = """
            <h1>2.1 Sistema Axiomático</h1>
            <p>Europa no final do século XIX, a Matemática vivia uma era de ouro. Engenheiros extraploando os limites do que se pensava ser possivel, físicos previam o comportamento da eletricidade e astrônomos já calculavam as órbitas com precisão. Tudo isso funcionava graças ao Cálculo — uma ferramenta poderosa baseada nos Números Reais.</p>
            <p>O grande matemático Karl Weierstrass tinha acabado de "limpar" o Cálculo, provando que ele funcionava perfeitamente se aceitássemos os Números Reais. Os Reais, por sua vez, eram construídos sobre os Números Racionais (frações). E as frações? Bem, elas dependiam dos Números Inteiros e Naturais ($1, 2, 3...$). Mas como vimos no capítulo anterior nós estabelecemos uma linguagem matemática livre de ambiguidades, e nesse tempo ninguém sabia definir o que era um Número Natural.</p>
            <p>Parece absurdo, não é? Se eu te mostro duas maçãs, você sabe que são "2". Mas isso é física, não matemática. Maçãs apodrecem. Maçãs existem no espaço. E se o universo acabasse? O número "2" deixaria de existir? Os matemáticos perceberam que tinham construído um arranha-céu (o Cálculo moderno) sobre uma fundação de areia (a nossa "intuição" de contagem). Definir o número 2 dizendo "é aquilo que tem em um par de sapatos" é um argumento circular. Precisávamos de uma definição que não dependesse de objetos, de psicologia ou de dedos das mãos. Precisávamos de regras puras.</p>
            <br>
            <p>No início, a resposta padrão era o Platonismo Ingênuo. O matemático Leopold Kronecker declarou famosamente: "Deus fez os números inteiros; todo o resto é obra do homem". A ideia era que os números $1, 2, 3...$ eram entidades divinas ou primordiais. Eles simplesmente "estavam lá". Não precisavam de explicação. Mas essa abordagem falha miseravelmente quando olhamos para o infinito. Se confiamos apenas na intuição, como garantimos que a contagem nunca para? Como provamos que a sequência numérica não faz um loop gigante e volta para o zero depois de um trilhão de passos? A intuição humana não lida bem com o infinito; ela quebra.</p>
            <p>Foi Richard Dedekind quem teve o insight salvador. Ele percebeu que o número "3" não é uma coisa, nem uma coleção de três itens. O "3" é apenas uma posição em uma fila. O que define o "3" não é seu valor intrínseco, mas o fato de que ele vem depois do "2" e antes do "4". Os números são dominós em uma fila infinita. Não importa do que os dominós são feitos; importa apenas a ordem em que estão organizados.</p>
            <br>
            <p>Entra em cena Giuseppe Peano. Em 1889, ele pegou essa ideia de "fila de dominós" e a traduziu para a linguagem lógica rigorosa que começamos a estudar na seção anterior. Peano disse: "Vamos parar de fingir que sabemos o que são números. Vamos jogar um jogo com três peças básicas e ver se conseguimos construir toda a aritmética a partir delas."</p>
            <p>As "peças do jogo" são as seguintes Noções Primitivas:</p>
            <ul>
                <li>Um conjunto de números chamado $\mathbb{N}$ (os Naturais).</li>
                <li>Um elemento inicial especial, que chamaremos de $0$ (zero).</li>
                <li>Uma regra de movimento, chamada de Função Sucessor ($S$).</li>
            </ul>
            <p>Primeiro, precisamos garantir que existe alguma coisa. Se o conjunto for vazio, não temos matemática.</p>
            <div class="card">
                <h3>Axioma 2.1.1</h3>
                <p>$$0 \in \mathbb{N}$$</p>
            </div>
            <ul>
                <li>$0$: É apenas um símbolo para o "ponto de partida". Poderíamos ter usado $\star$ ou "início".</li>
                <li>$\in$ (Pertence): O símbolo grego Epsilon, que indica que o $0$ vive dentro do conjunto $\mathbb{N}$.</li>
                <li>Tradução: "Existe um primeiro dominó posicionado na mesa."</li>
            </ul>
            <br>
            <div class="card">
                <h3>Axioma 2.1.2</h3>
                <p>$$\forall n \in \mathbb{N}, \exists! S(n) \in \mathbb{N}$$</p>
            </div>
            <ul>
                <li>$\forall n$: Para qualquer $n$...</li>
                <li>$\exists!$: Existe um único...</li>
                <li>$S(n)$: Sucessor de $n$.</li>
                <li>Tradução: Todo número natural possui exatamente um próximo número natural, chamado sucessor. Este axioma introduz formalmente a noção de “próximo” na aritmética.</li>
            </ul>
            <br>
            <p>E se a nossa fila de números se dividisse e depois se juntasse de novo, como dois rios se fundindo? E se o sucessor do 2 fosse o 5, mas o sucessor do 4 também fosse o 5? Teríamos uma estrutura em forma de "Y". Isso destruiria a contagem linear. Precisamos proibir isso.</p>
            <div class="card">
                <h3>Axioma 2.1.3</h3>
                <p>$$\forall n, m \in \mathbb{N}, S(n) = S(m) \implies n = m$$</p>
            </div>
            <ul>
                <li>$\implies$ (Implica): A seta lógica de "se... então".</li>
                <li>Tradução: Se o sucessor de um número é o mesmo sucessor de outro, então esses dois números são iguais.</li>
            </ul>
            <br>
            <div>
                <h3>Axioma 2.1.4</h3>
                <p>Imagine um relógio. Depois do 12, vem o 1. É um sistema perfeito de sucessores, mas ele é circular. Em $\mathbb{N}$, queremos uma linha reta infinita, não um círculo. Como garantimos isso? Proibindo qualquer um de voltar para o início.</p>
                <p>$$\forall n \in \mathbb{N}, S(n) \neq 0$$</p>
            </div>
            <ul>
                <li>$\neq 0$: Diferente de zero.</li>
                <li>Tradução: "Nenhum número natural tem o zero como sucessor."</li>
            </ul>
            <br>
            <h4>Aplicações</h4>
            <p>Apesar de estarmos acostumados no dia a dia a atribuir valores quantitativos aos números, como por exemplo o simbolo $1$ representando a quantidade um e o simbolo $2$ representando a quantidade de dois, queremos no momento apenas nomear os numeros que são naturalmente sucessores de zero. Isto significa que os simbolos $1$,$2$ ou $3$ são apenas convenções culturais.</p>
            <p><strong>Aplicação 2.1.1 </strong>Tendo isto em vista, vamos utilizar os axiomas  para construir alguns números e utilizaremos a convenção para nomea-los.</p>
            <ul>
                <li>O Início: Pelo Axioma 1, temos o $0$.</li>
                <li>
                    O Primeiro Passo: Pelo Axioma 2, o $0$ deve ter um sucessor. Chamamos $S(0)$ de "1".
                    <ul>
                        <li>Check: O $1$ é igual a $0$? Não, pelo Axioma 4 ($0$ nunca é sucessor).</li>
                    </ul>
                </li>
                <li>
                    O Segundo Passo: O $1$ deve ter um sucessor. Chamamos $S(1)$ de "2".
                    <ul>
                        <li>Check: O $2$ é igual a $1$? Pelo Axioma 3, se $S(1) = S(0)$, então $1 = 0$, o que já vimos que é falso. Logo, $2$ é um elemento novo.</li>
                    </ul>
                </li>
                <li>O Terceiro Passo: O $2$ tem um sucessor, $S(2)$, que chamamos de "3".</li>
            </ul>
            <p>Veja que definimos 1, 2 e 3 sem nunca falar de maçãs. Eles são apenas nomes para $S(0)$, $S(S(0))$ e $S(S(S(0)))$.</p>
            <p><strong>Aplicação 2.1.2 </strong>Pense em uma playlist que você criou, mas com duas regras importantes: o botão "Aleatório" (Shuffle) está desligado e o botão "Repetir" (Repeat) também.</p>
            <ul>
                <li>Axioma 1 (O Início): Existe a primeira música. Nenhuma música toca antes dela. Ela é o nosso $0$.</li>
                <li>Axioma 2 (Sucessor): Quando a música acaba, o aplicativo sabe exatamente qual é a próxima. A função Próxima Faixa é a nossa função Sucessor $S(n)$.</li>
                <li>Axioma 3 (Injetividade): A ordem é fixa. A música 3 sempre vem depois da música 2. Não acontece de você ouvir a música 2 e pular para a 5, e depois ouvir a 4 e pular para a 5 também. Se o destino é o mesmo, a origem era a mesma.</li>
                <li>Axioma 4 (Não-Circularidade): Como desligamos o botão "Repetir", quando a última música acaba, a playlist para. Ela não volta sozinha para a primeira música. Se voltasse, seria um ciclo, e os Axiomas de Peano exigem uma linha infinita (ou, no nosso caso prático, uma linha que não morde a própria cauda).</li>
            </ul>
            <p><strong>Aplicação 2.1.3 </strong>Imagine um jogo de aventura clássico (como um Mario) onde você avança fase por fase.</p>
            <ul>
                <li>O Tutorial é o nosso $0$. Você começa lá. Ninguém termina o jogo antes de começar.</li>
                <li>Passar de Fase é a função Sucessor. Derrotar o chefe da Fase 1 te leva obrigatoriamente para a Fase 2.</li>
                <li>A Lógica do Progresso: O jogo só funciona porque essa ordem é rígida. Imagine se você passasse da Fase 1 e fosse para a Fase 5, mas seu amigo passasse da Fase 1 e fosse para a Fase 2. O jogo estaria "quebrado" (violaria a unicidade do sucessor). A estrutura de Peano garante que todos os jogadores vivam a mesma história na mesma ordem cronológica.</li>
            </ul>
            <br>
            <h4>Resumo</h4>
            <div class="card">
                <p><strong>Primitivos:</strong> Definimos $\mathbb{N}$ não pelo que os números são, mas como se comportam usando $0$ e $S(n)$.</p>
                <p><strong>Injetividade:</strong> A contagem é ordenada. Caminhos distintos não se fundem ($S(n)=S(m) \implies n=m$).</p>
                <p><strong>Linearidade:</strong> A contagem não é cíclica. Nunca voltamos ao início ($S(n) \neq 0$).</p>
            </div>
        """,
        Problems = new()
        {
            new()
            {
                Id = "1",
                Statement = """
                    <p>De acordo com o texto, qual foi a motivação principal para que matemáticos como Peano e Dedekind buscassem uma definição rigorosa para os números naturais, abandonando a intuição de "contagem de objetos"?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>A intuição humana e exemplos físicos (como maçãs) não são suficientes para fundamentar a matemática.</li>
                        <li>Objetos físicos são efêmeros, mas a matemática precisa de regras puras e universais.</li>
                        <li>A intuição falha ao lidar com o <b>infinito</b> e não garante que a contagem nunca pare ou entre em loop.</li>
                        <li>Era necessário sustentar o "arranha-céu" do Cálculo sobre uma base sólida, não baseada em psicologia.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "2",
                Statement = """
                    <p>Quais são as três "Noções Primitivas" (peças do jogo) estabelecidas por Giuseppe Peano para construir a aritmética?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>Um conjunto de números chamado $\mathbb{N}$ (Naturais).</li>
                        <li>Um elemento inicial especial, chamado de $0$ (zero).</li>
                        <li>Uma regra de movimento, chamada de Função Sucessor ($S$).</li>
                    </ul>
                """
            },
            new()
            {
                Id = "3",
                Statement = """
                    <p>O Axioma 1.2.1 estabelece que $0 \in \mathbb{N}$. O que este símbolo $0$ representa fundamentalmente neste sistema axiomático?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>Ele representa apenas o "ponto de partida" ou o elemento inicial.</li>
                        <li>Não representa necessariamente "ausência de quantidade" no sentido físico, mas sim o primeiro "dominó" da fila.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "4",
                Statement = """
                    <p>Qual a definição formal do número "1" utilizando a notação de Função Sucessor apresentada no texto?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>O número "1" é definido como o sucessor do elemento inicial zero.</li>
                        <li>Matematicamente: $1 = S(0)$.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "5",
                Statement = """
                    <p>O que o Axioma 1.2.4 ($\forall n \in \mathbb{N}, S(n) \neq 0$) proíbe explicitamente na estrutura dos números naturais?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>Proíbe a circularidade (retornar ao início).</li>
                        <li>Garante que nenhum número tenha o zero como seu sucessor.</li>
                        <li>Isso assegura que a linha dos números naturais seja uma reta infinita e não um círculo (como um relógio).</li>
                    </ul>
                """
            },
            new()
            {
                Id = "6",
                Statement = """
                    <p>Utilizando a função sucessor $S(n)$, descreva a construção sintática do número que culturalmente chamamos de "3".</p>
                """,
                Solution =
                """
                    <ul>
                        <li>Passo 1: Partimos do $0$.</li>
                        <li>Passo 2: $1 = S(0)$.</li>
                        <li>Passo 3: $2 = S(1) = S(S(0))$.</li>
                        <li>Passo 4: $3 = S(2) = S(S(S(0)))$.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "7",
                Statement = """
                    <p>Considere que $S(x) = S(y)$ dentro do conjunto $\mathbb{N}$. Baseado no Axioma 1.2.3, o que podemos concluir obrigatoriamente sobre $x$ e $y$?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>Podemos concluir que $x = y$.</li>
                        <li>Este é o princípio da Injetividade: se os sucessores são iguais, os números originais também eram iguais.</li>
                        <li>Isso impede que a linha numérica se funda (formato de "Y").</li>
                    </ul>
                """
            },
            new()
            {
                Id = "8",
                Statement = """
                    <p>Na analogia da "Playlist" apresentada na Aplicação 1.2.2, qual funcionalidade deve estar desligada para respeitar o Axioma 1.2.4 e por quê?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>A funcionalidade "Repetir" (Repeat) deve estar desligada.</li>
                        <li>Se estivesse ligada, após a última música, a playlist voltaria para a primeira ($S(n) = 0$).</li>
                        <li>O axioma exige $S(n) \neq 0$, garantindo uma progressão infinita sem retornos.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "9",
                Statement = """
                    <p>Se definirmos um sistema onde $S(2) = 5$ e $S(4) = 5$, qual axioma de Peano estaria sendo violado e qual seria a consequência visual dessa estrutura?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>Violaria o Axioma 1.2.3 (Injetividade), pois teríamos $S(2) = S(4)$ mas $2 \neq 4$.</li>
                        <li>A consequência visual seria a fusão de dois caminhos distintos em um só (formato de "Y" ou dois rios se juntando).</li>
                        <li>Isso quebraria a linearidade única da contagem.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "10",
                Statement = """
                    <p>Na analogia do "Jogo de Aventura" (Aplicação 1.2.3), o que representa a Função Sucessor $S(n)$ e como ela garante a experiência linear do jogador?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>$S(n)$ representa a ação de "Passar de Fase".</li>
                        <li>Ela garante que ao terminar a Fase $n$, o jogador é levado obrigatoriamente e unicamente para a Fase $n+1$.</li>
                        <li>Isso impede que o jogador pule fases aleatoriamente ou escolha caminhos que quebrem a cronologia da história.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "11",
                Statement = """
                    <p>Prove, utilizando os axiomas fornecidos, que o número $1$ (definido como $S(0)$) é diferente de $0$.</p>
                """,
                Solution =
                """
                    <ul>
                        <li>Sabemos que $1 = S(0)$.</li>
                        <li>O Axioma 1.2.4 afirma que para todo $n$, $S(n) \neq 0$.</li>
                        <li>Substituindo $n$ por $0$, temos que $S(0) \neq 0$.</li>
                        <li>Logo, $1 \neq 0$.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "12",
                Statement = """
                    <p>Por que a definição de Richard Dedekind sobre o número "3" é considerada posicional e não cardinal, conforme o texto?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>Dedekind definiu que o "3" não é uma coleção de três itens (cardinalidade).</li>
                        <li>O "3" é definido pelo fato de vir depois do "2" e antes do "4".</li>
                        <li>É uma posição em uma fila (ordem), independente da natureza dos objetos na fila.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "13",
                Statement = """
                    <p>No contexto do Axioma 1.2.2 ($\exists! S(n)$), o que significa o símbolo "$\exists!$" e qual sua importância para a aritmética?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>Significa "Existe um único".</li>
                        <li>Garante o determinismo da matemática: um número não pode ter dois sucessores diferentes (ex: o sucessor de 2 não pode ser 3 e 4 ao mesmo tempo).</li>
                        <li>Sem isso, a contagem se bifurcaria em múltiplos futuros possíveis.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "14",
                Statement = """
                    <p>Se tentássemos definir os números naturais baseados em "pares de sapatos" ou "dedos da mão", qual problema lógico descrito no texto estaríamos cometendo?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>Estaríamos cometendo um "argumento circular".</li>
                        <li>Estamos tentando definir o conceito de "2" usando objetos que pressupõem o conceito de "2" para serem identificados como um par.</li>
                        <li>Além disso, dependeria de objetos físicos que podem deixar de existir.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "15",
                Statement = """
                    <p>O texto menciona que símbolos como "1", "2" e "3" são "convenções culturais". Explique o que isso significa no contexto da construção formal de $\mathbb{N}$.</p>
                """,
                Solution =
                """
                    <ul>
                        <li>Significa que os nomes não importam para a matemática, apenas a estrutura.</li>
                        <li>O que chamamos de "2" é estruturalmente $S(S(0))$.</li>
                        <li>Poderíamos usar quaisquer outros símbolos, desde que respeitassem a ordem dos sucessores gerada a partir do zero.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "16",
                Statement = """
                    <p>Analise a afirmação de Leopold Kronecker: "Deus fez os números inteiros; todo o resto é obra do homem". Como a abordagem de Peano e Dedekind refuta ou reinterpreta essa visão filosófica?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>Kronecker defendia o Platonismo Ingênuo (números já existem e não precisam de explicação).</li>
                        <li>Peano refuta isso ao mostrar que os números naturais precisam ser <b>construídos</b> formalmente a partir de regras lógicas (axiomas) para evitar falhas no infinito.</li>
                        <li>Para Peano, os números não são entidades divinas dadas, mas consequências de um sistema lógico de "dominós".</li>
                    </ul>
                """
            },
            new()
            {
                Id = "17",
                Statement = """
                    <p>Imagine um sistema computacional onde o tipo de dado `byte` vai de 0 a 255. Se somarmos 1 a 255, o valor volta para 0 (overflow). Analise qual Axioma de Peano este sistema viola e por quê.</p>
                """,
                Solution =
                """
                    <ul>
                        <li>Viola o Axioma 1.2.4 ($S(n) \neq 0$).</li>
                        <li>Em um sistema de 8 bits (byte), $S(255) = 0$.</li>
                        <li>Isso cria uma estrutura circular (Aritmética Modular), enquanto os Axiomas de Peano exigem uma estrutura linear infinita. Portanto, `byte` não representa perfeitamente o conjunto $\mathbb{N}$.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "18",
                Statement = """
                    <p>Se retirássemos o Axioma 1.2.3 (Injetividade: $S(n)=S(m) \implies n=m$) do sistema, seria possível provar que $2 \neq 1$? Justifique sua análise.</p>
                """,
                Solution =
                """
                    <ul>
                        <li>Talvez não. Sem a injetividade, a linha numérica poderia fazer loops ou convergir.</li>
                        <li>Se a estrutura permitisse que $S(1) = S(0)$, então teríamos $2 = 1$.</li>
                        <li>O Axioma da Injetividade é crucial para garantir que elementos em posições diferentes da sequência sejam, de fato, números distintos.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "19",
                Statement = """
                    <p>Por que o texto afirma que o "Cálculo Moderno" (limite, derivadas) seria um "arranha-céu em fundação de areia" sem a formalização dos Números Naturais?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>Análise de Dependência: Cálculo depende de Reais $\to$ Reais dependem de Racionais $\to$ Racionais dependem de Inteiros $\to$ Inteiros dependem de Naturais.</li>
                        <li>Se a base (Naturais) for definida apenas por intuição ("maçãs"), qualquer paradoxo no conceito de contagem ou infinito desmoronaria toda a precisão obtida no topo da cadeia (física e engenharia).</li>
                    </ul>
                """
            },
            new()
            {
                Id = "20",
                Statement = """
                    <p>Analise a seguinte situação: Um software de gerenciamento de IDs gera o próximo ID baseado no anterior ($S(n)$). Se o sistema permitir que dois usuários diferentes gerem o mesmo próximo ID, que tipo de falha axiomática ocorreu e qual o impacto no sistema?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>Ocorreu uma falha na unicidade do sucessor ($\exists! S(n)$) ou na injetividade, dependendo da perspectiva (vários caminhos levando ao mesmo lugar).</li>
                        <li>Se o estado atual $n$ pudesse gerar dois sucessores diferentes, o sistema seria não-determinístico.</li>
                        <li>Se dois estados diferentes $n$ e $m$ gerassem o mesmo ID $y$, haveria colisão de dados, violando a distinção entre os usuários.</li>
                    </ul>
                """
            }
        }
    };
}