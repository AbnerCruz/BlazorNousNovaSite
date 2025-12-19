using SchoolData;

public class Math1Module1Chapter2Section1
{
    public static Topic Topic = new()
    {
        Id = "principio-do-agrupamento",
        Name = "2.1 Princípio do Agrupamento",
        Active = true,
        Body = """
            <h1>2.1 Princípio do Agrupamento</h1>
            <p>Feche os olhos por um momento e imagine que estamos há cerca de 10.000 anos, na fronteira entre o Paleolítico e o Neolítico. Durante milênios, a humanidade sobreviveu muito bem com o Princípio da Correspondência Biunívoca. Se você precisava contar os membros da sua tribo ou as luas até o inverno, bastava fazer um risco em um osso para cada objeto. Um risco, uma coisa. Simples. O osso de Ishango e os bastões de talha são testemunhas silenciosas dessa era. A matemática era tátil, direta e, acima de tudo, unitária. Mas o mundo mudou e de repente, não estamos mais falando de contar 15 pessoas. Estamos falando de controlar um estoque de 5.000 grãos de cevada ou um rebanho real de 400 ovelhas.</p>
            <p>Pense em um escriba na antiga Suméria tentando registrar essas quantidades usando o método antigo. Para representar o número "400", ele precisaria fazer quatrocentos riscos na argila:</p>
            <p>$$||||||||||||||||||||||... \text{ (e assim por diante 400 vezes)}$$</p>
            <p>Primeiro, existe o Muro Cognitivo. Nosso cérebro possui uma limitação chamada Subitizing (ou percepção imediata de quantidade). Olhe para um grupo de objetos: se houver até 4 itens, você sabe quantos são instantaneamente, sem contar. Mas se houver 27 riscos na parede, seu cérebro trava. Você precisa contar um por um. O risco $|||...$ é visualmente inútil para grandes quantidades.</p>
            <p>Segundo, existe a Ineficácia da Informação. Um número escrito no sistema unário (apenas riscos) ocupa um espaço físico imenso. O "custo de armazenamento" na argila tornou-se proibitivo. O escriba percebeu algo aterrorizante: contar um por um não era mais suficiente. Nós precisávamos de um jeito de compactar essa realidade.</p>
            <br>
            <p>Para resolver isso a primeira reação humana foi tentar "aumentar o suporte". Se o osso é pequeno, pegue um osso maior. Se a tábua de argila encheu, faça mais tábuas. Mas isso não resolve o problema do processamento mental. O problema não era a falta de argila, A verdadeira revolução aconteceu quando alguém — um gênio anônimo do passado — teve uma ideia ousada. E se parássemos de tratar todos os objetos como iguais?</p>
            <p>Imagine que você tem um monte de pedrinhas para contar. Em vez de alinhá-las infinitamente, você decide que, a cada vez que juntar 10 pedrinhas pequenas, você vai trocá-las por uma pedra maior. Com isso não mudamos a quantidade de ovelhas no pasto. Mudamos a maneira como organizamos a informação sobre elas.</p>
            <p>Este é o nascimento da Hierarquia. Na Suméria, isso foi materializado nos Calculi (pequenos objetos de contagem).</p>
            <ul>
                <li>Um cone pequeno de argila representava 1.</li>
                <li>Uma pequena esfera de argila não representava "uma coisa diferente", ela representava 10 cones.</li>
            </ul>
            <figure>
                <img src="/images/Courses/Math/Math1/Module1/Chapter2/Section2.1/Fig2.1.1.png">
                <figcaption>Figura 2.1.1 Representação de valores nos Calculi</figcaption>
            </figure>
            <p>Pela primeira vez, um objeto físico não representava uma unidade, mas uma coleção. Foi a necessidade de auditoria e burocracia estatal que forçou a matemática a deixar de ser uma simples contagem (1, 2, 3...) para se tornar um sistema de agrupamento.</p>
            <br>
            <p>O "truque" da pedra maior é o que chamamos formalmente de Base Numérica.</p>
            <div class="card">
                <h3>Definição 2.1.1</h3>
                <p>Uma base numérica é um cardinal finito fixo, denotado por $b$, onde $b \in \mathbb{N}$ e $b > 1$.</p>
                <p>Este número $b$ atua como o limiar de transbordamento. É a quantidade máxima de unidades que podemos acumular antes de sermos obrigados a "empacotá-las" em uma unidade de ordem superior.</p>
            </div>
            <br>
            <ul>
                <li>$b \in \mathbb{N}$ (Natural) pois contamos coisas inteiras.</li>
                <li>$b > 1$ pois se a base for 1, voltamos ao sistema de riscos (unário). Se a base for 0 ou negativa, as coisas ficam estranhas (mas isso é outro assunto).</li>
            </ul>
            <p>O processo de contar deixa de ser uma linha reta e passa a ser um ciclo de agrupar e sobrar. Isso nos leva ao mecanismo central de todos os sistemas numéricos antigos e modernos:</p>
            <div class="card">
                <h3>Teorema 2.1.1</h3>
                <p>Dado um conjunto com cardinalidade (quantidade) $N$, e uma base de agrupamento $b$, podemos expressar $N$ de forma única como:</p>
                <p>$$N = q \cdot b + r$$</p>
                <p>Onde:</p>
                <ul>
                    <li>$q$ (quociente) é o número de grupos completos formados.</li>
                    <li>$r$ (resto) é a quantidade de unidades "soltas" que não foram suficientes para formar um novo grupo, tal que $0 \leq r < b$.</li>
                </ul>
            </div>
            <br>
            <ul>
                <li>O $r$ (resto) são as pedrinhas soltas que ficaram na sua mão.</li>
                <li>O $q$ (quociente) são as "pedras maiores" ou pacotes que você formou.</li>
            </ul>
            <p>Mas a genialidade não para aí. O princípio é recursivo. Se o número $q$ (quantidade de pacotes) for muito grande (maior que $b$), nós aplicamos a regra novamente sobre $q$. Criamos pacotes de pacotes. É assim que nascem as potências da base: $b^0$ (unidade), $b^1$ (o grupo), $b^2$ (o grupo de grupos).</p>
            <div class="card">
                <h3>Definição 2.1.2</h3>
                <p>Para uma base $b$, definimos um conjunto de grafemas distintos $S = \{s_0, s_1, \dots, s_{b-1}\}$ que representam todas as quantidades possíveis de restos (de $0$ a $b-1$).</p>
            </div>
            <p>Nota Importante: Nesta etapa da história, estamos falando de Agrupamento, não de Posição. Os egípcios, por exemplo, desenhavam o símbolo de 100 (uma corda enrolada) e o símbolo de 1 (um bastão). Não importava se a corda vinha antes ou depois do bastão; o valor era a soma dos grupos. Era como ter moedas no bolso: o valor é o mesmo, não importa como elas estão misturadas.</p>
            <br>
            <h4>Aplicações</h4>
            <p><strong>Aplicação 2.1.1</strong> O sistema monetário físico é o exemplo perfeito de um sistema de agrupamento não-posicional (ou híbrido). Considere o seguinte problema: Você precisa pagar uma dívida de $R\$ 253,00$ a um comerciante.</p>
            <p>Com a Solução Unária, você entrega 253 moedas de 1 real. O comerciante te odeia, sua bolsa pesa quilos e a chance de erro na contagem é enorme.</p>
            <p><strong>A Solução por Agrupamento (Base 10):</strong> O Banco Central (nossa autoridade burocrática) definiu símbolos (notas) que representam potências da base 10.</p>
            <ul>
                <li>Moeda de 1 = $10^0$</li>
                <li>Nota de 10 = $10^1$</li>
                <li>Nota de 100 = $10^2$</li>
            </ul>
            <p>Quando você paga com duas notas de 100, cinco notas de 10 e três moedas de 1, você está executando fisicamente a decomposição polinomial do número:</p>
            <p>$$253 = (2 \times 10^2) + (5 \times 10^1) + (3 \times 10^0)$$</p>
            <p>Observe a mágica:</p>
            <ul>
                <li>Você comprimiu a informação. Em vez de 253 objetos físicos, você manipulou apenas 10 objetos (2+5+3 notas/moedas).</li>
                <li>A nota de $R\$ 100$ não é "maior" fisicamente que a nota de $R\$ 10$ ou $R\$ 2$. Ela vale mais por convenção. É uma cifra que representa um grupo.</li>
            </ul>
            <br>
            <p>Essa transição do "contar um por um" para o "contar por pacotes" foi o que permitiu o surgimento da civilização complexa. Sem o agrupamento, não haveria engenharia (como calcular tijolos para uma pirâmide?), não haveria comércio em larga escala e, certamente, não haveria computação.</p>
            <p>Hoje, a Ciência da Computação vive desse legado. Pense na Compressão de Dados. Se um computador tivesse que escrever o número "um milhão" em sistema unário (bits ligados), ele gastaria cerca de 1 Megabyte de espaço apenas para fazer riscos. Usando o agrupamento binário (base 2) ou decimal (base 10), representamos "1.000.000" com apenas alguns bytes. A base numérica é, em essência, o primeiro algoritmo de compressão de dados da história (reduzindo o espaço de $N$ para o logaritmo de $N$).</p>
            <br>
            <h4>Resumo</h4>
            <div class="card">
                <ul>
                    <li>Subitizing: A limitação biológica que nos impede de reconhecer grandes quantidades instantaneamente, forçando a contagem.</li>
                </ul>
                <li>Crise do Unário: O sistema de riscos ($|||$) é perfeito para precisão, mas péssimo para armazenamento e leitura de grandes números.</li>
                <li>Base Numérica ($b$): Um número fixo ($b > 1$) usado para criar pacotes de unidades. É a "unidade de ordem superior".</li>
                <li>Princípio do Agrupamento: A ideia de substituir $b$ objetos soltos por 1 objeto que vale $b$.</li>
                <li>Decomposição: Todo número pode ser quebrado em grupos e restos: $N = q \cdot b + r$.</li>
            </div>
            <p>No próximo passo da nossa jornada, veremos como diferentes culturas tentaram desenhar esses grupos, e por que os romanos tiveram tantos problemas com a multiplicação, até chegarmos à invenção final: o valor posicional.</p>
        """,
        Problems = new()
        {
            // --- NÍVEL 1: FIXAÇÃO (1-5) ---
            new()
            {
                Id = "1",
                Statement = """
                    <p>De acordo com o texto, qual é a limitação biológica do cérebro humano que nos impede de reconhecer instantaneamente quantidades maiores que 4 itens sem precisar contar?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>O texto identifica essa limitação como <b>Subitizing</b> (ou percepção imediata de quantidade).</li>
                        <li>É descrito como o "Muro Cognitivo" que ocorre quando o cérebro "trava" ao olhar para grupos com mais de 4 objetos, exigindo contagem um por um.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "2",
                Statement = """
                    <p>Qual é a definição formal de uma <b>base numérica</b> apresentada na Definição 2.1.1?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>Uma base numérica é um cardinal finito fixo, denotado por $b$.</li>
                        <li>As condições para $b$ são: $b \in \mathbb{N}$ (deve ser um número natural) e $b > 1$.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "3",
                Statement = """
                    <p>No sistema de Calculi da Suméria mencionado, o que representava uma pequena esfera de argila e como isso ilustra o Princípio do Agrupamento?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>Uma pequena esfera representava <b>10 cones</b> (onde cada cone valia 1).</li>
                        <li>Isso ilustra o princípio pois a esfera não era um objeto diferente por natureza, mas uma representação física de uma <b>coleção</b> ou grupo de unidades menores.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "4",
                Statement = """
                    <p>O que define o "Sistema Unário" (ou Princípio da Correspondência Biunívoca) descrito no início do texto?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>É o sistema onde para cada objeto contado, faz-se uma marca física correspondente (um risco, um osso, etc.).</li>
                        <li>A regra é: "Um risco, uma coisa".</li>
                    </ul>
                """
            },
            new()
            {
                Id = "5",
                Statement = """
                    <p>Segundo a Definição 2.1.2, o que é o conjunto $S = \{s_0, s_1, \dots, s_{b-1}\}$?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>É um conjunto de <b>grafemas distintos</b>.</li>
                        <li>Eles representam todas as quantidades possíveis de <b>restos</b> em uma divisão pela base, variando de $0$ a $b-1$.</li>
                    </ul>
                """
            },

            // --- NÍVEL 2: APLICAÇÃO (6-15) ---
            new()
            {
                Id = "6",
                Statement = """
                    <p>Utilizando o <b>Teorema 2.1.1</b> ($N = q \cdot b + r$), decomponha o número $N = 23$ considerando uma base de agrupamento $b = 5$. Identifique $q$ e $r$.</p>
                """,
                Solution =
                """
                    <ul>
                        <li>Aplicamos a fórmula: $23 = q \cdot 5 + r$.</li>
                        <li>Dividindo 23 por 5, temos 4 grupos completos e sobram 3.</li>
                        <li>Portanto: $23 = 4 \cdot 5 + 3$.</li>
                        <li>Onde $q = 4$ (quociente/grupos) e $r = 3$ (resto/unidades soltas).</li>
                    </ul>
                """
            },
            new()
            {
                Id = "7",
                Statement = """
                    <p>Com base na analogia do sistema monetário (Aplicação 2.1.1), realize a decomposição polinomial do valor $R\$ 342,00$ em base 10.</p>
                """,
                Solution =
                """
                    <ul>
                        <li>Identificamos as potências de 10: $10^2$ (centenas), $10^1$ (dezenas), $10^0$ (unidades).</li>
                        <li>O número 342 é decomposto como:</li>
                        <li>$$342 = (3 \times 10^2) + (4 \times 10^1) + (2 \times 10^0)$$</li>
                        <li>Fisicamente, isso equivale a 3 notas de 100, 4 notas de 10 e 2 moedas de 1.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "8",
                Statement = """
                    <p>Por que, matematicamente, não podemos ter um resto $r = 6$ se estivermos trabalhando com uma base $b = 5$? Justifique com o Teorema 2.1.1.</p>
                """,
                Solution =
                """
                    <ul>
                        <li>O Teorema 2.1.1 estabelece a condição estrita para o resto: $0 \leq r < b$.</li>
                        <li>Se a base $b$ é 5, o resto máximo possível é 4.</li>
                        <li>Se tivéssemos 6 itens soltos, eles seriam suficientes para formar mais um grupo de 5, alterando o quociente $q$.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "9",
                Statement = """
                    <p>Se um escriba sumério tivesse 22 cones (onde 1 cone = 1 unidade) e quisesse aplicar o agrupamento onde 1 esfera = 10 cones, quantos objetos físicos ele teria ao final?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>Ele agruparia os cones em grupos de 10.</li>
                        <li>22 cones formam 2 grupos de 10 (2 esferas) e sobram 2 cones.</li>
                        <li>Objetos finais: 2 esferas + 2 cones.</li>
                        <li>Total de objetos físicos manipulados: 4 (uma compressão de 22 para 4).</li>
                    </ul>
                """
            },
            new()
            {
                Id = "10",
                Statement = """
                    <p>Aplique o conceito de "Custo de Armazenamento" do texto para explicar por que registrar o número 400 em sistema unário era problemático para um escriba.</p>
                """,
                Solution =
                """
                    <ul>
                        <li>No sistema unário, representar o número 400 exigiria 400 marcas físicas ($|||...$).</li>
                        <li>Isso gera a <b>Ineficácia da Informação</b>: ocupa muito espaço na argila e torna a leitura visualmente impossível devido à limitação de <i>Subitizing</i>.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "11",
                Statement = """
                    <p>O texto menciona que o princípio é <b>recursivo</b>. Explique como surgem as potências da base ($b^2$) a partir da regra $N = q \cdot b + r$.</p>
                """,
                Solution =
                """
                    <ul>
                        <li>Se o quociente $q$ (número de pacotes formados) for maior ou igual à base $b$, aplicamos a regra novamente sobre $q$.</li>
                        <li>Criamos "pacotes de pacotes".</li>
                        <li>Isso gera unidades de ordem superior, correspondendo a $b^2$ (grupo de grupos).</li>
                    </ul>
                """
            },
            new()
            {
                Id = "12",
                Statement = """
                    <p>Dado um conjunto de pedras $N=15$ e uma base $b=4$. Calcule quantos grupos completos ($q$) e quantas pedras soltas ($r$) teremos.</p>
                """,
                Solution =
                """
                    <ul>
                        <li>Aplicando $15 = q \cdot 4 + r$.</li>
                        <li>O múltiplo de 4 mais próximo e menor que 15 é 12 ($3 \times 4$).</li>
                        <li>Portanto, $q = 3$ e $r = 15 - 12 = 3$.</li>
                        <li>Resultado: 3 grupos e 3 sobras.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "13",
                Statement = """
                    <p>Na etapa de "Agrupamento" descrita (como no Egito), a posição dos símbolos importava? Justifique com o exemplo do texto.</p>
                """,
                Solution =
                """
                    <ul>
                        <li>Não, a posição não importava nesta fase (era um sistema não-posicional).</li>
                        <li>O texto usa a analogia de moedas no bolso ou dos símbolos egípcios (corda e bastão): o valor é a soma dos grupos, independente da ordem em que aparecem.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "14",
                Statement = """
                    <p>Considere a base $b=10$. Quais são os grafemas possíveis para o resto $r$ segundo a Definição 2.1.2?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>O conjunto de grafemas $S$ deve representar restos de $0$ até $b-1$.</li>
                        <li>Para $b=10$, os grafemas são $\{0, 1, 2, 3, 4, 5, 6, 7, 8, 9\}$.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "15",
                Statement = """
                    <p>Explique por que uma base $b=1$ não é considerada uma base válida para agrupamento, conforme o texto.</p>
                """,
                Solution =
                """
                    <ul>
                        <li>Se $b=1$, não há agrupamento real.</li>
                        <li>O texto afirma que voltamos ao sistema de riscos (unário), onde a representação é idêntica à quantidade, anulando a vantagem da compactação.</li>
                    </ul>
                """
            },

            // --- NÍVEL 3: ANÁLISE (16-20) ---
            new()
            {
                Id = "16",
                Statement = """
                    <p>O texto afirma que a base numérica é "o primeiro algoritmo de compressão de dados da história". Analise essa afirmação comparando a representação do número "um milhão" em unário versus decimal/binário.</p>
                """,
                Solution =
                """
                    <ul>
                        <li><b>Unário:</b> Ocuparia espaço linear proporcional a $N$. Para um computador, escrever 1 milhão exigiria ~1 Megabyte de espaço (riscos/bits ligados).</li>
                        <li><b>Agrupamento (Base):</b> Reduz o espaço de $N$ para o logaritmo de $N$. Em decimal ou binário, o mesmo número é representado com apenas alguns bytes.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "17",
                Statement = """
                    <p>Relacione o conceito de <b>Subitizing</b> com a necessidade histórica de criar sistemas de agrupamento. Como um problema biológico forçou uma solução matemática?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>O Subitizing limita a percepção humana a ~4 itens. Quando as sociedades complexas precisaram lidar com estoques grandes (ex: 400 ovelhas), o cérebro humano falhou ("travou").</li>
                        <li>A contagem unária (riscos) tornou-se visualmente inútil. O agrupamento foi a solução para contornar essa falha biológica, permitindo processar grandes quantidades através de "pacotes" que o cérebro consegue gerenciar.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "18",
                Statement = """
                    <p>Analise a seguinte frase do texto: "Uma pequena esfera de argila não representava 'uma coisa diferente', ela representava 10 cones". Qual é a implicação filosófica/abstrata dessa mudança para a matemática?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>Implica o nascimento da <b>Hierarquia</b> e da abstração.</li>
                        <li>Pela primeira vez, um objeto físico deixou de ter correspondência biunívoca (1 para 1) e passou a valer por uma coleção.</li>
                        <li>Isso marca a transição da simples contagem para a aritmética de agrupamento, fundamental para auditoria e burocracia.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "19",
                Statement = """
                    <p>De acordo com a aplicação no sistema monetário, por que a nota de R$ 100 vale mais que a nota de R$ 2, apesar de terem tamanhos físicos similares? Relacione com o conceito de "cifra".</p>
                """,
                Solution =
                """
                    <ul>
                        <li>O valor não deriva das propriedades físicas do objeto (tamanho ou peso), mas de uma <b>convenção</b>.</li>
                        <li>A nota atua como uma cifra que representa um <b>grupo</b> (potência da base). Ela é um símbolo de um "pacote" de 100 unidades, permitindo a manipulação comprimida de valor.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "20",
                Statement = """
                    <p>O texto menciona que o Princípio do Agrupamento resolveu o problema do armazenamento, mas sugere uma limitação que seria resolvida apenas posteriormente com o "Valor Posicional". Qual é a distinção fundamental entre Agrupamento Simples e Valor Posicional inferida no texto?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>No Agrupamento Simples (fase descrita no texto), usamos símbolos distintos para cada potência (ex: corda para 100, bastão para 1) e a ordem não importa.</li>
                        <li>O Valor Posicional (mencionado como o "próximo passo") elimina a necessidade de criar novos símbolos infinitamente, usando a posição do dígito para indicar sua potência.</li>
                    </ul>
                """
            }
        }
    };
}