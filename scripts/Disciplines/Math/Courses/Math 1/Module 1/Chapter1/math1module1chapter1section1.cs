namespace SchoolData;

public static class Math1Module1Chapter1Section1
{
    public static Topic Topic = new()
    {
        Id = "principio-da-correspondencia-biunivoca",
        Name = "1.1 O Princípio da Correspondência Biunívoca",
        Active = true,
        Body = """
            <h1>1.1 O Princípio da Correspondência Biunívoca</h1>
            <p>Imagine que você está no Paleolítico Superior, cerca de 20.000 anos atrás. Esqueça tudo o que você sabe sobre matemática. Esqueça os símbolos "1, 2, 3". Eles não existem. Não há palavras para descrever quantidades exatas.</p>
            <p>O mundo ao seu redor é um continuum — uma mistura caótica de árvores, céu, animais e perigos. Mas, para sobreviver, o cérebro humano precisou fazer algo extraordinário: ele precisou aprender a separar o "fundo" da "figura". Você olha para um campo e, mentalmente, recorta uma forma específica. Você diz: "Isto é uma pedra. Aquilo é outra pedra".</p>
            <p>Esta capacidade, que chamamos de Axioma da Existência do Objeto Discreto, parece trivial hoje, mas foi o primeiro passo da lógica humana. Sem separar o objeto do ambiente, não existe contagem. Agora, coloque-se no lugar de um pastor neolítico. De manhã, você libera seu rebanho para pastar. À noite, elas voltam. Aqui nasce o problema: Como você garante que todas as ovelhas que saíram, voltaram?</p>
            <p>Se um lobo comeu uma delas, como você vai saber? Você não sabe contar até 50. Você não tem a palavra "cinquenta". Você só tem a sua visão e a memória, que é falha. Se o chefe da tribo perguntar se os estoques de grãos foram roubados, como provar a integridade do estoque sem números?</p>
            <p>O problema fundamental aqui não é "quantos existem". O problema é a Verificação da Integridade. Precisávamos de uma maneira de comparar a realidade de "antes" com a realidade de "agora", sem usar palavras pois as palavras são falhas.</p>
            <br>
            <p>A humanidade não esperou pelos matemáticos para resolver isso. Eles criaram a tecnologia do Artefato Intermediário. Enquanto cada ovelha passava pela porteira para sair, o pastor fazia uma marca em um osso (como o famoso Osso de Ishango) ou guardava uma pedrinha num saco de couro.</p>
            <p>O que está acontecendo aqui?</p>
            <ul>
                <li>Sai uma ovelha $\rightarrow$ Faz-se um risco.</li>
                <li>Sai outra ovelha $\rightarrow$ Faz-se outro risco.</li>
            </ul>
            <p>À noite, o processo é invertido. Entra uma ovelha, você cruza um risco (ou retira uma pedra).</p>
            <ul>
                <li>Se sobrarem ovelhas sem riscos correspondentes: O rebanho aumentou (nasceu alguém ou uma ovelha do vizinho se juntou ao seu rebanho).</li>
                <li>Se sobrarem riscos sem ovelhas: Alarme! Algo foi perdido.</li>
            </ul>
            <p>Esta técnica é chamada de Entalhe (ou Tallying).</p>
            <p>A sacada intelectual aqui é o princípio da Invariância. O pastor substituiu o rebanho (que é grande, móvel e difícil de segurar) por um punhado de pedras (que é pequeno, estático e cabe na mão). Se as pedras estão seguras, a quantidade do rebanho está segura.</p>
            <p>Mas isso não foi totalmente eficiente porque pedras pesam, ossos quebram, e essa comparação exige presença física. Eu não posso comparar o meu rebanho aqui na montanha com o seu rebanho no vale usando apenas as minhas pedras, a menos que viajemos para nos encontrar. A matéria limita o pensamento. Precisávamos de algo que pudesse viajar na mente, não somente no bolso.</p>
            <br>
            <p>Agora que entendemos a necessidade dela, vamos construir uma ferramenta tentando resolver esses problemas</p>
            <p>Primeiro, precisamos definir o que são esses grupos de ovelhas ou pedras.</p>
            <div class="card">
                <h3>Definição 1.1.1</h3>
                <p>Chamaremos de Agregado, neste momento inicial, qualquer coleção de objetos distintos que tratamos como uma unidade.</p>
            </div>
            <br>
            <p>Vamos chamar o conjunto de Ovelhas de $O$ e o conjunto de Pedras de $P$. E claro, quando digo conjunto você pode entender como sendo um agrupamento.</p>
            <p>A ideia de ligar uma ovelha a uma pedra recebe um nome técnico: Correspondência. Em linguagem moderna, chamamos isso de Função ou Aplicação. Vamos definir uma relação $f$ que leva elementos de $O$ até $P$:</p>
            <br>
            <div class="card">
                <h3>Definição 1.1.2</h3>
                <p>Se $f$ representa uma correspondência que associa cada elemento de $O$ a exatamente um elemento de $P$, então chamamos essa correspondência de Função. Escrevemos:</p>
                <p>$$f: O \rightarrow P$$</p>
            </div>
            <br>
            <p>Para que a verificação do pastor funcione perfeitamente, essa relação precisa obedecer aa duas seguintes regras</p>
            <p><strong>1 Injetividade: </strong>Nenhuma pedra na bolsa pode servir para duas ovelhas ao mesmo tempo. Cada ovelha precisa de seu próprio registro exclusivo.</p>
            <div class="card">
                <h3>Definição 1.1.3</h3>
                <p>Uma função $f: A \rightarrow B$ é injetora se elementos distintos em $A$ têm imagens distintas em $B$.</p>
                <p>$$\forall x, y \in A, \quad x \neq y \implies f(x) \neq f(y)$$</p>
            </div>
            <br>
            <ul>
                <li>$\forall$: "Para todo".</li>
                <li>$\in$: "Pertence".</li>
                <li>$\neq$: "Diferente".</li>
                <li>$\implies$: "Implica que".</li>
                <li>Tradução: Para todo elemento x e y pertencente ao conjunto A, x ser diferente de y implica que o correspondente de x é diferente do correspondente de y.</li>
                <li>Interpretação: Se você pegar uma ovelha no rebanho e pegar outra ovelha diferente, a pedra correspondente de uma é diferente da pedra correspondente da outra.</li>
                <li>Observação: Na definição optamos pela utilização do termo "imagem" para acostumar o leitor, mas no presente contexto a pedra é a imagem da ovelha em nossa correspondência.</li>
            </ul>
            <br>
            <p><strong>2 Sobrejetividade: </strong>Não pode sobrar pedra no saco que não corresponda a uma ovelha. Todo o sistema de controle deve ser utilizado.</p>
            <div class="card">
                <h3>Definição 1.1.3</h3>
                <p>Uma função $f: A \rightarrow B$ é sobrejetora se todo elemento de $B$ é corresponde a alguém de $A$.</p>
                <p>$$\forall b \in B, \quad \exists a \in A \text{ tal que } f(a) = b$$</p>
            </div>
            <br>
            <ul>
                <li>$\forall$: "Para todo".</li>
                <li>$\in$: "Pertencente a"</li>
                <li>$\exists$: "Existe"</li>
                <li>Tradução: Para todo elemento $b$ pertencente ao conjunto $B$ existe um elemento $a$ pertencente ao conjunto $A$ tal que $f(a)$ é igual a $b$</li>
                <li>Interpretação: Para qualquer pedra que se pegue na bolsa existe uma ovelha no rebanho na qual o correspondente dessa ovelha na bolsa é a pedra.</li>
            </ul>
            <br>
            <p><strong>3 Bijeção: </strong>Quando juntamos essas duas regras, atingimos o padrão ouro da comparação.</p>
            <div class="card">
                <h3>Definição 1.1.4</h3>
                <p>Se uma correspondência é, ao mesmo tempo, Injetora e Sobrejetora, ela é biunívoca, isto é, uma Bijeção.</p>
            </div>
            <br>
            <p>Quando existe uma bijeção entre dois conjuntos $A$ e $B$, dizemos que eles são Equinuméricos (ou Equipotentes), em outras palavras o número de elementos do conjunto $A$ é o mesmo número de elementos do conjunto $B$. Notação:</p>
            <p>$$A \sim B$$</p>
            <p>Isso nos leva ao Teorema Fundamental da Comparação. Quando comparamos dois agregados finitos quaisquer, o universo nos dá apenas três opções (a Tricotomia):</p>
            <ul>
                <li>$A \sim B$ (Eles têm a mesma "quantidade").</li>
                <li>$A$ é equivalente a apenas uma parte de $B$ (Intuitivamente, $A$ é menor).</li>
                <li>$B$ é equivalente a apenas uma parte de $A$ (Intuitivamente, $B$ é menor).</li>
            </ul>
            <p>Aqui, esbarramos na Noção Comum 5 de Euclides: "O todo é maior do que a parte". No mundo finito das ovelhas e pedras, é impossível um conjunto ter bijeção com um pedaço dele mesmo. (Guarde essa informação, pois quando estudarmos o Infinito, essa regra será quebrada drasticamente!).</p>
            <br>
            <h4>Exemplos</h4>
            <p><strong>Aplicação 1.1.1 </strong>Pense no seu CPF ou no seu "Nome de Usuário" em um jogo. O banco de dados do servidor é um imenso conjunto $A$ (Jogadores) e um conjunto $B$ (IDs). O sistema exige uma Injeção Rigorosa. Se o sistema falhar na injetividade ($x \neq y$, mas $f(x) = f(y)$), dois jogadores diferentes acabam com a mesma conta. Isso se chama Colisão. Quando uma colisão acontece em tabelas Hash (estruturas de dados fundamentais), o computador precisa gastar energia extra para resolver o erro. Sem a garantia da bijeção, a internet colapsaria em crise de identidade.</p>
            <p><strong>Aplicação 1.1.2 </strong>Antoine Lavoisier, o pai da química moderna, não descobriu a conservação da massa pesando coisas aleatoriamente. Ele assumiu que uma reação química é uma Bijeção de Átomos. Considere a equação da água: $2H_2 + O_2 \rightarrow 2H_2O$. Agregado Inicial (Reagentes): 4 átomos de Hidrogênio, 2 de Oxigênio. Agregado Final (Produtos): 4 átomos de Hidrogênio, 2 de Oxigênio. A natureza reorganiza as ligações, mas a função que mapeia os átomos do "antes" para o "depois" é estritamente bijetora. Nada se cria, nada se perde; tudo se mapeia biunivocamente.</p>
            <br>
            <div class="card">
                <ul>
                    <li>Precisávamos verificar a integridade de grupos (ovelhas, estoques) antes de sabermos contar.</li>
                    <li>Criamos a Correspondência Biunívoca. Começou como riscos em um osso e evoluiu para o conceito matemático de Função Bijetora.</li>
                    <li>Dois conjuntos são Equinuméricos ($A \sim B$) se conseguirmos ligar cada elemento de um ao outro, sem sobras e sem repetições.</li>
                    <li>Aprendemos que $\forall$ significa "para todo" e $\exists$ significa "existe", símbolos que usaremos para construir todo o resto da matemática.</li>
                </ul>
            </div>
            <br>
            <p>Mas note uma coisa curiosa: nós definimos que dois conjuntos podem ser "iguais em quantidade", mas ainda não demos um nome para essa quantidade. Sabemos que o conjunto das ovelhas é equivalente ao conjunto das pedras, mas não chamamos isso de "1", "10" ou "100" ainda.</p>
        """,
        Problems = new()
        {
            // --- Nível 1: Fixação / Fácil (Questões 1-5) ---
            new()
            {
                Id = "1",
                Statement = """
                    <p>De acordo com o texto, qual é a capacidade mental fundamental descrita como o "Axioma da Existência do Objeto Discreto", necessária antes que qualquer contagem possa ocorrer?</p>
                """,
                Solution =
                    """
                    <ul>
                        <li>A capacidade de separar o "fundo" da "figura".</li>
                        <li>É o ato mental de recortar uma forma específica do ambiente (ex: distinguir uma pedra do resto do cenário), permitindo tratar objetos como unidades distintas.</li>
                    </ul>
                    """
            },
            new()
            {
                Id = "2",
                Statement = """
                    <p>Como é definido um <b>Agregado</b> na Definição 1.1.1 apresentada no texto?</p>
                """,
                Solution =
                    """
                    <ul>
                        <li>Um Agregado é definido como <b>qualquer coleção de objetos distintos que tratamos como uma unidade</b>.</li>
                    </ul>
                    """
            },
            new()
            {
                Id = "3",
                Statement = """
                    <p>Associe os seguintes símbolos matemáticos apresentados no texto com suas respectivas traduções:</p>
                    <ul>
                        <li>$\forall$</li>
                        <li>$\exists$</li>
                        <li>$\in$</li>
                        <li>$\implies$</li>
                    </ul>
                """,
                Solution =
                    """
                    <ul>
                        <li>$\forall$: "Para todo".</li>
                        <li>$\exists$: "Existe".</li>
                        <li>$\in$: "Pertence" ou "Pertencente a".</li>
                        <li>$\implies$: "Implica que".</li>
                    </ul>
                    """
            },
            new()
            {
                Id = "4",
                Statement = """
                    <p>Qual é a definição formal de uma <b>Função</b> ($f: O \rightarrow P$) segundo a Definição 1.1.2?</p>
                """,
                Solution =
                    """
                    <ul>
                        <li>É uma correspondência que associa <b>cada elemento</b> do conjunto de origem ($O$) a <b>exatamente um elemento</b> do conjunto de destino ($P$).</li>
                    </ul>
                    """
            },
            new()
            {
                Id = "5",
                Statement = """
                    <p>Para que dois conjuntos $A$ e $B$ sejam considerados <b>Equinuméricos</b> ($A \sim B$), qual condição deve ser satisfeita?</p>
                """,
                Solution =
                    """
                    <ul>
                        <li>Deve existir uma <b>bijeção</b> (correspondência biunívoca) entre os dois conjuntos.</li>
                        <li>Isso significa que conseguimos ligar cada elemento de um ao outro, sem sobras e sem repetições.</li>
                    </ul>
                    """
            },

            // --- Nível 2: Aplicação / Médio (Questões 6-15) ---
            new()
            {
                Id = "6",
                Statement = """
                    <p>Um pastor utiliza o método de Entalhe com riscos em um osso. Ao final do dia, ao realizar o processo inverso (entrar ovelha, cruzar risco), ele percebe que sobraram <b>riscos sem ovelhas</b> correspondentes. O que isso significa no contexto da Verificação de Integridade?</p>
                """,
                Solution =
                    """
                    <ul>
                        <li><b>Alarme! Algo foi perdido.</b></li>
                        <li>Significa que o número de ovelhas que retornou é menor do que o número que saiu. Alguma ovelha foi comida por lobos ou perdida.</li>
                    </ul>
                    """
            },
            new()
            {
                Id = "7",
                Statement = """
                    <p>Considere a função $f: A \rightarrow B$. Se tivermos a situação onde $x \neq y$, mas $f(x) = f(y)$, qual regra da correspondência foi violada e qual é o nome dado a esse evento no contexto de IDs de usuários citado no texto?</p>
                """,
                Solution =
                    """
                    <ul>
                        <li>Foi violada a regra da <b>Injetividade</b>.</li>
                        <li>No contexto de IDs e tabelas Hash, isso é chamado de <b>Colisão</b> (dois jogadores diferentes acabam com a mesma conta/identificador).</li>
                    </ul>
                    """
            },
            new()
            {
                Id = "8",
                Statement = """
                    <p>Analise a seguinte notação matemática fornecida na Definição 1.1.3 e identifique a qual conceito ela se refere:</p>
                    <p>$$\forall b \in B, \quad \exists a \in A \text{ tal que } f(a) = b$$</p>
                """,
                Solution =
                    """
                    <ul>
                        <li>Esta notação define a <b>Sobrejetividade</b>.</li>
                        <li>Ela afirma que para todo elemento no conjunto de destino $B$, existe um elemento na origem $A$ que o mapeia. Ou seja, não sobram elementos em $B$ sem correspondência.</li>
                    </ul>
                    """
            },
            new()
            {
                Id = "9",
                Statement = """
                    <p>No exemplo de Antoine Lavoisier sobre a conservação da massa, a reação química da água ($2H_2 + O_2 \rightarrow 2H_2O$) é descrita como uma bijeção. O que constitui o Agregado Inicial e o Agregado Final neste exemplo?</p>
                """,
                Solution =
                    """
                    <ul>
                        <li><b>Agregado Inicial (Reagentes):</b> 4 átomos de Hidrogênio e 2 átomos de Oxigênio.</li>
                        <li><b>Agregado Final (Produtos):</b> 4 átomos de Hidrogênio e 2 átomos de Oxigênio.</li>
                        <li>A bijeção ocorre no mapeamento dos átomos do "antes" para o "depois".</li>
                    </ul>
                    """
            },
            new()
            {
                Id = "10",
                Statement = """
                    <p>Se um pastor usa pedras para controlar o rebanho e, ao final do dia, sobram ovelhas que não possuem pedras correspondentes para serem retiradas do saco, o que ocorreu com o tamanho do rebanho?</p>
                """,
                Solution =
                    """
                    <ul>
                        <li>O rebanho <b>aumentou</b>.</li>
                        <li>Pode ter nascido um animal ou uma ovelha do vizinho se juntou ao rebanho.</li>
                    </ul>
                    """
            },
            new()
            {
                Id = "11",
                Statement = """
                    <p>Traduza para o português corrente a seguinte expressão lógica relacionada à Injetividade:</p>
                    <p>$$\forall x, y \in A, \quad x \neq y \implies f(x) \neq f(y)$$</p>
                """,
                Solution =
                    """
                    <ul>
                        <li>Para todo elemento $x$ e $y$ pertencentes ao conjunto $A$, se $x$ for diferente de $y$, isso implica que o correspondente (imagem) de $x$ é diferente do correspondente de $y$.</li>
                    </ul>
                    """
            },
            new()
            {
                Id = "12",
                Statement = """
                    <p>De acordo com o <b>Teorema Fundamental da Comparação</b> (Tricotomia) para agregados finitos, quais são as três únicas opções ao comparar dois conjuntos $A$ e $B$?</p>
                """,
                Solution =
                    """
                    <ul>
                        <li>1. $A \sim B$ (Eles têm a mesma quantidade/são equinuméricos).</li>
                        <li>2. $A$ é equivalente a apenas uma parte de $B$ ($A$ é menor).</li>
                        <li>3. $B$ é equivalente a apenas uma parte de $A$ ($B$ é menor).</li>
                    </ul>
                    """
            },
            new()
            {
                Id = "13",
                Statement = """
                    <p>Qual a relação da <b>Noção Comum 5 de Euclides</b> com a comparação de conjuntos finitos descrita no texto?</p>
                """,
                Solution =
                    """
                    <ul>
                        <li>A noção afirma que <b>"O todo é maior do que a parte"</b>.</li>
                        <li>No mundo finito (como ovelhas e pedras), isso implica que é impossível um conjunto ter bijeção com um pedaço (subconjunto próprio) dele mesmo.</li>
                    </ul>
                    """
            },
            new()
            {
                Id = "14",
                Statement = """
                    <p>Para garantir que "nenhuma pedra na bolsa sirva para duas ovelhas ao mesmo tempo", qual propriedade da função é estritamente necessária?</p>
                """,
                Solution =
                    """
                    <ul>
                        <li>A propriedade da <b>Injetividade</b>.</li>
                        <li>Cada ovelha precisa de seu próprio registro exclusivo.</li>
                    </ul>
                    """
            },
            new()
            {
                Id = "15",
                Statement = """
                    <p>Para garantir que "não sobre pedra no saco que não corresponda a uma ovelha", isto é, que todo o sistema de controle seja utilizado, qual propriedade da função é necessária?</p>
                """,
                Solution =
                    """
                    <ul>
                        <li>A propriedade da <b>Sobrejetividade</b>.</li>
                    </ul>
                    """
            },

            // --- Nível 3: Análise / Difícil (Questões 16-20) ---
            new()
            {
                Id = "16",
                Statement = """
                    <p>O texto diferencia o problema de "quantos existem" do problema da "Verificação da Integridade". Analise qual é o objetivo central da Verificação da Integridade no contexto do pastor neolítico.</p>
                """,
                Solution =
                    """
                    <ul>
                        <li>O objetivo não é contar ou dar um número, mas sim <b>comparar a realidade de "antes" com a de "agora"</b>.</li>
                        <li>É garantir que o estado final do rebanho seja uma bijeção perfeita do estado inicial, assegurando que nada se perdeu e nada foi adicionado indevidamente.</li>
                    </ul>
                    """
            },
            new()
            {
                Id = "17",
                Statement = """
                    <p>Explique o <b>Princípio da Invariância</b> aplicado na tecnologia do Artefato Intermediário (pedras ou ossos).</p>
                """,
                Solution =
                    """
                    <ul>
                        <li>O princípio consiste em substituir um conjunto grande, móvel e difícil de controlar (rebanho) por um conjunto pequeno, estático e manipulável (pedras).</li>
                        <li>A ideia é que, se a quantidade de pedras se mantém segura (invariável), a quantidade do rebanho, por correspondência, também está segura.</li>
                    </ul>
                    """
            },
            new()
            {
                Id = "18",
                Statement = """
                    <p>Apesar da utilidade das pedras e ossos, o texto cita que "a matéria limita o pensamento". Analise quais são as limitações físicas do método de Entalhe físico que motivaram a evolução para conceitos abstratos.</p>
                """,
                Solution =
                    """
                    <ul>
                        <li>As limitações incluem: pedras pesam, ossos quebram e a comparação exige <b>presença física</b>.</li>
                        <li>Não é possível comparar rebanhos em locais distantes (montanha vs. vale) sem transportar fisicamente os artefatos de contagem. Precisava-se de algo que "viajasse na mente".</li>
                    </ul>
                    """
            },
            new()
            {
                Id = "19",
                Statement = """
                    <p>Analise a importância da Bijeção para a internet moderna, especificamente no contexto de Bancos de Dados e Servidores, conforme a Aplicação 1.1.1.</p>
                """,
                Solution =
                    """
                    <ul>
                        <li>A bijeção garante a identidade única. Se o sistema falha na injetividade (colisão), dois usuários compartilham a mesma identidade.</li>
                        <li>Sem a garantia de que cada usuário (Agregado A) mapeia para um ID único e exclusivo (Agregado B), e vice-versa, haveria crises de integridade de dados e segurança.</li>
                    </ul>
                    """
            },
            new()
            {
                Id = "20",
                Statement = """
                    <p>O texto termina mencionando que sabemos que dois conjuntos são equivalentes, mas ainda não demos nome a essa quantidade (como "10" ou "100"). O que isso sugere sobre a ordem de aprendizado lógico apresentada no capítulo?</p>
                """,
                Solution =
                    """
                    <ul>
                        <li>Sugere que o conceito de <b>Correspondência (Bijeção)</b> e comparação de integridade precede logicamente e historicamente a invenção dos <b>números</b> e da contagem abstrata.</li>
                        <li>Primeiro garantimos a equivalência ($A \sim B$), depois rotulamos essa classe de equivalência com um número.</li>
                    </ul>
                    """
            }
        }
    };
}