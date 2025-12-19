using SchoolData;

public class Math1Module1Chapter1Section3
{
    public static Topic Topic = new()
    {
        Id = "algoritmo-da-contagem",
        Name = "1.3 Algoritmo da Contagem",
        Active = true,
        Body = """
            <h3>1.3 Algoritmo da Contagem</h3>
            <p>Imagine que estamos de volta à era neolítica, sentados ao lado daquele pastor que conhecemos na seção anterior. Graças à correspondência biunívoca (o ato de emparelhar pedras com ovelhas), ele sabe se perdeu algum animal. Ele tem uma pilha de pedras que representa, exatamente, a Cardinalidade (o tamanho) do seu rebanho. Mas como vimos surgiu um problema novo.</p>
            <p>O pastor precisa ir até a aldeia vizinha comprar mantimentos. O mercador pergunta: "Quantas ovelhas você tem para trocar por trigo?". O pastor congela. A pilha de pedras ficou na caverna. As ovelhas estão no pasto. Ele sabe a quantidade, mas não consegue transportá-la. Ele não pode levar as ovelhas, e carregar um saco pesado de pedras é inviável.</p>
            <p>Para resolver isso, a humanidade precisou inventar algo revolucionário: uma "pilha de pedras mental". Uma coleção de símbolos padronizados que todos conhecessem e que pudesse ser carregada dentro da cabeça. Mas, diferentemente de um saco de pedras bagunçado, essa coleção mental precisava de uma regra rígida: Ordem.</p>
            <p>Antes de termos palavras como "um, dois, três", tínhamos o nosso próprio corpo. O corpo humano foi a primeira "sequência canônica" — a primeira lista oficial de verificação. Antropólogos que estudaram tribos na Papua Nova Guiné observaram sistemas de contagem fascinantes. Para dizer a quantidade de inhames colhidos, um homem tocava o dedo mindinho da mão direita (1), depois o anelar (2), seguindo até o polegar, subindo pelo pulso, cotovelo, ombro, orelha direita, olho direito, nariz... e descendo pelo lado esquerdo do corpo.</p>
            <p>Por que isso funciona? Porque a anatomia impõe uma hierarquia natural. O nariz sempre está entre o olho direito e o olho esquerdo. A ordem não muda.</p>
            <p>Contar nada mais era do que apontar para um objeto e associá-lo a uma posição nessa lista corporal.</p>
            <ul>
                <li>Aponto para a ovelha A $\rightarrow$ toco meu mindinho.</li>
                <li>Aponto para a ovelha B $\rightarrow$ toco meu anelar.</li>
                <li>Aponto para a ovelha C $\rightarrow$ toco meu dedo médio.</li>
            </ul>
            <p>O último lugar tocado (o dedo médio) não é apenas uma parte do corpo; ele se torna o nome da quantidade. Mas o corpo é finito. O que acontece se o rebanho for maior que 27 ou 33 pontos do corpo? O sistema entra em colapso ou torna-se ambíguo ("Tenho três homens inteiros e um joelho de ovelhas?").</p>
            <p>Para nos libertarmos das limitações biológicas, precisávamos de uma lista que fosse infinita e abstrata. Precisávamos de sons (palavras) e símbolos que pudessem ser gerados para sempre. Precisávamos criar uma máquina lógica chamada Conjunto dos Números Naturais.</p>
            <br>
            <p><strong>Ordem Linear Estrita</strong> Um conjunto de ovelhas no pasto é um caos. Não há "primeira ovelha" ou "segunda ovelha" na natureza. Todas têm status igual. Para contar, precisamos forçar uma fila.</p>
            <div class="card">
                <h3>Definição 1.3.1</h3>
                <p>Dizemos que um conjunto $S$ é totalmente ordenado por uma relação $<$ se, para quaisquer dois elementos distintos $x$ e $y$ pertencentes a $S$, satisfazemos a Lei da Tricotomia:</p>
                <p>$$\text{Ou } x < y, \quad \text{ou } x = y, \quad \text{ou } y < x$$</p>
                <p>E satisfazemos a Transitividade: Se $x < y$ e $y < z$, então necessariamente $x < z$.</p>
            </div>
            <br>
            <p>Basicamente, isso proíbe ciclos. Você não pode ter Pedra < Papel < Tesoura < Pedra. Na contagem, se 1 vem antes de 2, e 2 vem antes de 3, 1 deve vir antes de 3.</p>
            <p><strong>O Princípio do Sucessor</strong> Para que a contagem nunca pare, precisamos garantir que sempre exista um "próximo número". Não podemos depender de dedos ou pedras. Na teoria dos conjuntos moderna (baseada em Giuseppe Peano e John von Neumann), definimos os números naturais recursivamente. Cada número cria o próximo.</p>
            <div class="card">
                <h3>Definição 1.3.2</h3>
                <p>Para qualquer número natural $n$, o seu sucessor $S(n)$ é definido como:</p>
                <p>$$S(n) = n \cup \{n\}$$</p>
            </div>
            <br>
            <ul>
                <li>$\cup$: União. Significa "juntar".</li>
                <li>Isso diz que o próximo número é o conjunto de todos os números anteriores unido com o próprio número atual.</li>
                <li>Isso garante que nunca ficaremos sem "caixas" para colocar os objetos. É uma máquina eterna de gerar posições na fila.</li>
            </ul>
            <p><strong>O Algoritmo da Enumeração</strong> Contar não é uma bijeção temporária.</p>
            <div class="card">
                <h3>Definição 1.3.3</h3>
                <p>Contar um conjunto finito $A$ é o processo de estabelecer uma função bijetora $f$ entre os elementos de $A$ e um segmento inicial dos números naturais $N_n = \{1, 2, 3, \dots, n\}$.</p>
                <p>$$f: A \to \{1, 2, 3, \dots, n\}$$</p>
            </div>
            <br>
            <h4>Aplicações</h4>
            <p><strong>Aplicação 1.3.1</strong> Você tem um saco com 3 formas geométricas: um Triângulo, um Quadrado e um Círculo. Vamos contá-los usando nosso algoritmo.</p>
            <p><strong>Tentativa A</strong></p>
            <ul>
                <li>
                    Você pega o Quadrado primeiro. A ele, atribui o rótulo "1".
                    <ul>
                        <li>Estado: $f(\text{Quadrado}) = 1$</li>
                    </ul>
                </li>
                <li>
                    Você pega o Triângulo. Rótulo "2".
                    <ul>
                        <li>Estado: $f(\text{Triângulo}) = 2$</li>
                    </ul>
                </li>
                <li>
                    Sobrou o Círculo. Rótulo "3".
                    <ul>
                        <li>Estado: $f(\text{Círculo}) = 3$</li>
                    </ul>
                </li>
            </ul>
            <p>O último número dito foi 3. Portanto, a cardinalidade é 3.</p>
            <p><strong>Tentativa B</strong> Agora, agite o saco. Vamos começar pelo Círculo.</p>
            <ul>
                <li>$f(\text{Círculo}) = 1$</li>
                <li>$f(\text{Quadrado}) = 2$</li>
                <li>$f(\text{Triângulo}) = 3$</li>
            </ul>
            <p>O último número dito ainda é 3.</p>
            <p>Isso parece óbvio para você hoje, mas é uma propriedade profunda chamada Princípio da Conexão Cardinal-Ordinal.</p>
            <div class="card">
                <h3>Teorema 1.3.1</h3>
                <p>O último numeral ordinal alcançado em um processo de contagem completa representa a cardinalidade total do conjunto, independentemente da ordem em que os elementos foram selecionados.</p>
            </div>
            <br>
            <p>Isso significa que a quantidade (cardinalidade) é uma propriedade intrínseca do grupo, imune aos nossos caprichos de organização (ordinalidade).</p>
            <p><strong>Aplicação 1.3.2</strong> Em um hospital ou em um servidor web, saber quantas pessoas estão na fila (Cardinal: 100 pessoas) é importante para o espaço. Mas saber quem é o primeiro (Ordinal: Senha nº 1) é vital para a justiça e o funcionamento do sistema. O conceito de "Primeiro a Entrar, Primeiro a Sair" (FIFO - First In, First Out) depende inteiramente da Ordem Linear Estrita que definimos acima.</p>
            <h4>Resumo</h4>
            <div class="card">
                <p>Ordinalidade é a imposição de uma hierarquia ("primeiro, segundo...") sobre um grupo de objetos. É transformar uma nuvem em uma linha.</p>
                <p>Contagem é um algoritmo (processo temporal) que cria uma correspondência biunívoca entre objetos reais e uma lista padrão de números mentais.</p>
                <p>Princípio do Sucessor é a regra lógica ($n \to n+1$) que garante que nunca ficaremos sem números para contar.</p>
                <p>Teorema da Invariância (Teorema 1.3.1) diz que não importa por onde você comece a contar, se você não pular nenhum objeto e não contar nenhum duas vezes, o número final será sempre o mesmo.</p>
            </div>
            <p>Tudo o que vimos até agora funciona perfeitamente para coisas que são separadas e distintas: ovelhas, pedras, dias, moedas. Chamamos isso de grandezas Discretas. Mas... como você contaria a água em um copo? Como você conta a distância entre duas cidades? Não há "pedras" individuais ali, apenas um fluxo contínuo. Na próxima seção, veremos o que acontece quando nossa "fita métrica de números naturais" falha em medir o mundo real. Bem-vindos ao abismo entre o Discreto e o Contínuo.</p>
        """,
        Problems = new()
        {
            // --- Nível: Fixação (Fácil) ---
            new()
            {
                Id = "1",
                Statement = """
                    <p>De acordo com a <b>Definição 1.3.1</b> apresentada no texto, quais são as três possibilidades exclusivas estabelecidas pela <b>Lei da Tricotomia</b> para quaisquer dois elementos distintos $x$ e $y$ em um conjunto totalmente ordenado?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>A Lei da Tricotomia estabelece que, para $x$ e $y$ distintos, deve ocorrer exatamente uma das seguintes situações:</li>
                        <li>Ou $x < y$;</li>
                        <li>Ou $x = y$;</li>
                        <li>Ou $y < x$.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "2",
                Statement = """
                    <p>Conforme a <b>Definição 1.3.2</b>, qual é a fórmula matemática que define o <b>sucessor</b> $S(n)$ de um número natural $n$ na teoria dos conjuntos moderna?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>A definição recursiva do sucessor é dada pela união do conjunto atual com ele mesmo:</li>
                        <li>$$S(n) = n \cup \{n\}$$</li>
                    </ul>
                """
            },
            new()
            {
                Id = "3",
                Statement = """
                    <p>Qual é a definição formal de <b>Contar</b> um conjunto finito $A$, segundo a <b>Definição 1.3.3</b> (Algoritmo da Enumeração)?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>Contar é o processo de estabelecer uma <b>função bijetora</b> $f$.</li>
                        <li>Essa função mapeia os elementos de $A$ para um segmento inicial dos números naturais $N_n$.</li>
                        <li>$$f: A \to \{1, 2, 3, \dots, n\}$$</li>
                    </ul>
                """
            },
            new()
            {
                Id = "4",
                Statement = """
                    <p>O texto menciona o uso do corpo humano como uma "sequência canônica" por tribos na Papua Nova Guiné. Qual é a justificativa anatômica citada para que esse sistema funcione?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>O sistema funciona porque a anatomia impõe uma <b>hierarquia natural</b>.</li>
                        <li>As partes do corpo possuem uma ordem fixa (ex: o nariz está sempre entre os olhos), permitindo uma correspondência estável.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "5",
                Statement = """
                    <p>Segundo o <b>Teorema 1.3.1</b> (Teorema da Invariância ou Conexão Cardinal-Ordinal), o que o último numeral ordinal alcançado em uma contagem representa?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>Ele representa a <b>cardinalidade total</b> (o tamanho) do conjunto.</li>
                        <li>Isso é válido independentemente da ordem em que os elementos foram selecionados durante a contagem.</li>
                    </ul>
                """
            },

            // --- Nível: Aplicação (Médio) ---
            new()
            {
                Id = "6",
                Statement = """
                    <p>Considere um sistema de senhas em um hospital que segue uma <b>Ordem Linear Estrita</b>. Se a senha do Paciente A vem antes da senha do Paciente B ($A < B$), e a senha do Paciente B vem antes da senha do Paciente C ($B < C$), o que a propriedade da <b>Transitividade</b> nos permite afirmar sobre A e C?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>Pela propriedade da Transitividade definida na <b>Definição 1.3.1</b>:</li>
                        <li>Se $x < y$ e $y < z$, então $x < z$.</li>
                        <li>Aplicando ao problema: Se $A < B$ e $B < C$, então necessariamente a senha de <b>A vem antes de C</b> ($A < C$).</li>
                    </ul>
                """
            },
            new()
            {
                Id = "7",
                Statement = """
                    <p>O jogo "Pedra, Papel e Tesoura" possui a regra: Pedra < Papel, Papel < Tesoura, mas Tesoura < Pedra. Explique, com base no texto, por que esse sistema <b>viola</b> a definição de Ordem Linear Estrita necessária para contagem.</p>
                """,
                Solution =
                """
                    <ul>
                        <li>A definição de Ordem Linear Estrita proíbe explicitamente a existência de <b>ciclos</b>.</li>
                        <li>Na contagem, se $1 < 2$ e $2 < 3$, o 1 deve vir antes do 3.</li>
                        <li>No jogo citado, a relação é cíclica, violando a transitividade e a hierarquia linear necessárias para estabelecer uma sequência de contagem válida.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "8",
                Statement = """
                    <p>Você está aplicando o <b>Algoritmo da Enumeração</b> (Definição 1.3.3) para contar um conjunto de frutas: {Maçã, Banana}. Na primeira etapa, você define $f(\text{Banana}) = 1$. Qual deve ser o próximo passo para concluir a contagem corretamente?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>Como a função deve ser <b>bijetora</b> e cobrir o segmento $\{1, 2, \dots, n\}$:</li>
                        <li>O próximo número natural disponível é 2.</li>
                        <li>Você deve associar o elemento restante (Maçã) a este número.</li>
                        <li>Passo final: Definir $f(\text{Maçã}) = 2$. O último número foi 2, logo a cardinalidade é 2.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "9",
                Statement = """
                    <p>Utilizando o <b>Princípio do Sucessor</b> ($S(n) = n \cup \{n\}$), se representarmos o número "Zero" como um conjunto vazio $\emptyset$, como seria a construção lógica do número "Um" (o sucessor de zero)?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>Aplicando a fórmula onde $n = \emptyset$:</li>
                        <li>$S(\emptyset) = \emptyset \cup \{\emptyset\}$</li>
                        <li>O resultado é um conjunto contendo o conjunto vazio: $\{\emptyset\}$.</li>
                        <li>Isso ilustra como a fórmula cria um "próximo item" a partir do anterior.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "10",
                Statement = """
                    <p>Um mercador conta suas moedas da esquerda para a direita e encontra o total de 50. Se ele decidir recontar as mesmas moedas da direita para a esquerda, qual princípio garante que o resultado será 50 e não mudará?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>O princípio é o <b>Teorema da Invariância</b> (Teorema 1.3.1).</li>
                        <li>Ele afirma que a cardinalidade é uma propriedade intrínseca do grupo e é imune a caprichos de organização ou ordem de seleção.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "11",
                Statement = """
                    <p>Na <b>Aplicação 1.3.2</b>, é feita uma distinção entre a utilidade do número Cardinal e do Ordinal em uma fila. Se você precisa projetar o tamanho da sala de espera, qual dos dois conceitos você utiliza e por quê?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>Para projetar o <b>espaço</b> físico, utiliza-se o número <b>Cardinal</b>.</li>
                        <li>O cardinal (ex: 100 pessoas) indica a <b>quantidade total</b>, o que determina a capacidade necessária da sala, independente de quem chegou primeiro.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "12",
                Statement = """
                    <p>Analise a afirmação: "Tenho três homens inteiros e um joelho de ovelhas". De acordo com o texto, qual é a falha fundamental do sistema de contagem corporal que gera essa frase absurda?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>A falha é que o corpo humano é <b>finito</b>.</li>
                        <li>Quando o conjunto a ser contado excede os pontos disponíveis no corpo (ex: maior que 33), o sistema entra em colapso ou torna-se ambíguo, exigindo repetições confusas do corpo inteiro ("homens inteiros").</li>
                    </ul>
                """
            },
            new()
            {
                Id = "13",
                Statement = """
                    <p>No contexto do <b>Algoritmo da Contagem</b>, o que o símbolo $\cup$ representa na fórmula do Princípio do Sucessor e qual sua função prática?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>O símbolo $\cup$ representa a <b>União</b> ("juntar").</li>
                        <li>Sua função prática é garantir que o próximo número inclua todos os anteriores mais a nova posição atual.</li>
                        <li>Isso assegura que nunca ficaremos sem "caixas" para colocar objetos, criando uma máquina eterna de gerar posições.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "14",
                Statement = """
                    <p>Se ao contar um rebanho o pastor pular uma ovelha mas seguir a sequência numérica correta (1, 2, 3...), qual condição da <b>Definição 1.3.3</b> foi violada?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>Foi violada a condição de a função ser <b>bijetora</b>.</li>
                        <li>Para ser uma bijeção válida na contagem, deve haver uma correspondência um-para-um exata.</li>
                        <li>Pular uma ovelha significa que um elemento do domínio $A$ não foi mapeado, falhando na contagem total.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "15",
                Statement = """
                    <p>Por que o texto afirma que o conceito de FIFO (First In, First Out) depende inteiramente da <b>Ordem Linear Estrita</b>?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>O FIFO depende de saber inequivocamente quem é o "primeiro".</li>
                        <li>A Ordem Linear Estrita garante, pela Lei da Tricotomia, que não há empate nem ambiguidade temporal entre dois elementos que entram na fila.</li>
                        <li>Sem essa ordem rígida, seria impossível determinar a prioridade de saída com justiça.</li>
                    </ul>
                """
            },

            // --- Nível: Análise (Difícil) ---
            new()
            {
                Id = "16",
                Statement = """
                    <p>O texto descreve a invenção dos números naturais como uma "pilha de pedras mental". Analise por que a abstração (sair das pedras físicas para os símbolos mentais) foi necessária para resolver o problema do mercador.</p>
                """,
                Solution =
                """
                    <ul>
                        <li>O problema fundamental era a <b>portabilidade</b> da informação.</li>
                        <li>A correspondência biunívoca física (pedras) exigia a presença dos objetos de referência.</li>
                        <li>A abstração permitiu dissociar a <i>quantidade</i> do <i>objeto físico</i>, criando símbolos padronizados que podiam ser "transportados na cabeça" sem peso físico.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "17",
                Statement = """
                    <p>Analise a relação entre <b>Ordinalidade</b> e <b>Cardinalidade</b> proposta no texto. É possível obter a Cardinalidade de um conjunto sem passar por algum processo de Ordinalidade (mesmo que arbitrária)?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>Segundo o texto, para conjuntos caóticos (como ovelhas no pasto), não há ordem natural.</li>
                        <li>Para medir a Cardinalidade, nós <b>precisamos forçar uma fila</b> (impor Ordinalidade).</li>
                        <li>O texto define Ordinalidade como transformar uma "nuvem" em uma "linha". Sem esse processo temporal de ordenação (1º, 2º, 3º...), o algoritmo da contagem não pode ser executado.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "18",
                Statement = """
                    <p>O <b>Princípio do Sucessor</b> é descrito como uma solução para nos libertarmos das "limitações biológicas". Explique essa afirmação comparando o corpo humano com a máquina lógica de Peano/von Neumann.</p>
                """,
                Solution =
                """
                    <ul>
                        <li>O corpo humano é um sistema finito; a contagem para quando acabam as partes do corpo.</li>
                        <li>A máquina lógica de Peano/von Neumann, através da recursividade ($n \to n+1$), define um sistema <b>infinito</b>.</li>
                        <li>A "libertação" refere-se à capacidade de gerar novos símbolos indefinidamente, sem depender da existência de matéria física ou biológica para representá-los.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "19",
                Statement = """
                    <p>No final do texto, é mencionada uma limitação fundamental da "fita métrica de números naturais" ao tentar medir água ou distância. Qual é a diferença conceitual entre os objetos que contamos até agora (ovelhas, pedras) e esses novos exemplos?</p>
                """,
                Solution =
                """
                    <ul>
                        <li>A diferença é entre grandezas <b>Discretas</b> e <b>Contínuas</b>.</li>
                        <li>Ovelhas e pedras são distintas e separáveis (Discretas), permitindo o emparelhamento um-para-um.</li>
                        <li>Água e distância representam um fluxo contínuo onde não há "unidades" indivisíveis óbvias para serem ordenadas sequencialmente pelo algoritmo da contagem natural.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "20",
                Statement = """
                    <p>O <b>Teorema da Invariância</b> sugere que a quantidade é uma propriedade intrínseca, enquanto a ordem é um "capricho". Analise como essa dualidade se manifesta nas duas tentativas de contagem das formas geométricas (Tentativa A e B).</p>
                """,
                Solution =
                """
                    <ul>
                        <li>Nas tentativas A e B, a atribuição dos rótulos (Ordinalidade) mudou completamente: o Quadrado foi "1" em A e "2" em B.</li>
                        <li>No entanto, o ponto de parada (Cardinalidade) foi "3" em ambos.</li>
                        <li>Isso demonstra que enquanto a <i>posição</i> de um elemento específico é relativa e mutável (capricho), o <i>tamanho total</i> do conjunto permanece constante (intrínseco).</li>
                    </ul>
                """
            }
        }
    };
}