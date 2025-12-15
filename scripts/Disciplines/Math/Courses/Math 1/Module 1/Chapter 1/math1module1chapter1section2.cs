namespace SchoolData;

public static class Math1Module1Chapter1Section2
{
    public static Topic Topic = new()
    {
        Id = "o-principio-posicional",
        Name = "1.2 O Princípio Posicional",
        Active = true,
        Body = """
            <h3>1.2 O Princípio Posicional</h3>
            <p>Imagine que estamos na Babilônia, por volta de 1800 a.C. O ar é seco, e você é um escriba do rei encarregado de registrar a colheita de grãos do império. O problema não é a falta de grãos; é o excesso. As quantidades são na grandeza de montanhas.</p>
            <p>Para calcular, você usa uma ferramenta física, talvez um antecessor do ábaco ou apenas sulcos desenhados na areia. Nesses sulcos, você coloca pedras. Uma pedra no primeiro sulco vale 1. A mesma pedra, movida para o segundo sulco, vale 60 (os babilônios amavam a base 60). A posição da pedra dita seu valor. É um sistema tátil, visual e intuitivo.</p>
            <figure>
                <img src="images/Courses/Math/Math1/Module1/Chapter1/Section1.2/Fig1.2.1.png" alt="Figura 1.2.1: Sistema de numeração posicional na areia">
                <figcaption>Figura 1.2.1: Sistema de numeração posicional na areia</figcaption>
            </figure>
            <p>Mas agora, o rei exige um registro permanente. Você precisa transferir a configuração das pedras na areia para uma tábua de argila úmida. E aqui reside a tragédia que atormentou a humanidade por milênios: Como você desenha o lugar onde não há pedra alguma?</p>
            <p>Se você tem duas pedras na posição das centenas e duas na posição das unidades, mas nenhuma na posição das dezenas, como você escreve isso?</p>
            <figure>
                <img src="images/Courses/Math/Math1/Module1/Chapter1/Section1.2/Fig1.2.2.png" alt="Figura 1.2.2: Representação sem um símbolo para o ''nada''">
                <figcaption>Figura 1.2.2: Representação sem um símbolo para o "nada"</figcaption>
            </figure>            
            <p>Sem um símbolo para o "nada", a bijeção entre o pensamento (o número real) e a escrita quebrava. Esse era o paradoxo da Ambiguidade da Ausência. Como podemos representar a ausência de valor sem deixar de escrever algo? Se eu não escrevo nada, o leitor não sabe se eu esqueci o número ou se o valor é nulo. Se eu junto os símbolos, o valor colapsa e o que deveria representar uma centena e uma unidade se torna 11.</p>
            <p>Durante séculos, a aritmética escrita foi um jogo de adivinhação contextual, enquanto a aritmética física (ábacos) fluía suavemente. O mundo precisava de uma maneira de capturar o "nada" da coluna vazia.</p>
            <p>A primeira reação da humanidade foi improvisar. Os babilônios, percebendo o perigo de confundir $1$ (uma unidade) e $60$ (um grupo), tentaram uma solução tipográfica do espaço vazio</p>
            <p>Parece razoável, certo? Mas pense, o quão largo deve ser esse espaço? Se você escrever rápido e sua mão escorregar, aquele espaço vira um espaço simples? E se fossem dois zeros seguidos (1001)? Você deixaria um espaço duplo 1&nbsp;&nbsp;1? Que número é esse 1&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;1?</p>
            <p>A frustração foi tamanha que civilizações inteiras, como os Gregos e os Romanos, abandonaram a ideia de posição. Eles optaram pela Força Bruta Simbólica. Se o número é grande, invente um símbolo novo.</p>
            <ul>
                <li>10? Use <strong>$X$.</strong></li>
                <li>100? Use <strong>$C$.</strong></li>
                <li>1.000? Use <strong>$M$.</strong></li>
            </ul>
            <p>Isso resolve a ambiguidade, mas cria outro problema lógico que é a limitação do alfabeto. Para representar números infinitamente grandes, você precisaria memorizar infinitos símbolos. Tentar multiplicar MDCCXL por XVII isso é uma tortura. O progresso matemático estagnou porque a ferramenta de escrita era ineficiente.</p>
            <br>
            <h4>O Zero</h4>
            <p>A solução para esse problema veio da Índia, entre os séculos V e VII d.C., com matemáticos como Brahmagupta. Eles perceberam que o vazio não é apenas a falta de algo; ele é uma entidade. Eles o chamaram de Sunya (vazio) mas nós o chamamos de Zero.</p>
            <p>O zero não altera a quantidade total quando somado, mas sua função crítica aqui é posicional, ocupar espaço para empurrar os outros dígitos para suas posições corretas, dessa forma podemos representar um grupo de cem mais uma unidade sem correr o risco de estarmos registrando $12$.</p>
            <div class="card">
                <h3>Definição 1.2.1 Zero Posicional</h3>
                <p>Em uma cadeia de caracteres numéricos, o símbolo $0$ atua como o elemento identidade da soma ($x+0=x$) em valor absoluto, mas atua como um operador de deslocamento para os dígitos à sua esquerda, preservando a potência da base $b^k$ associada a eles.</p>
            </div>
            <p>Sem o zero, o dígito $1$ em "10" se confunde com a posição das unidades. O zero é a entidade que segura a estrutura.</p>
            <br>
            <h4>O Princípio da Economia de Simbolos</h4>
            <p>Ao contrário dos romanos que precisavam de infinitos símbolos, nós provamos com o zero que, para qualquer base $b$, precisamos apenas de $b$ símbolos únicos.</p>
            <div class="Card">
                <h3>Definição 1.2.2 O Alfabeto do Sistema Posicional</h3>
                <p>Seja $b \in \mathbb{N}$ tal que $b > 1$. O sistema de numeração base-$b$ é univocamente determinado por um alfabeto finito $\Sigma$ (Sigma) de cardinalidade $b$ de modo que:</p>
                <p>$$\Sigma = \{0, 1, 2, \dots, b-1\}$$</p>
                <p>Qualquer quantidade expressa número real $N$ pode ser representado por uma sequência ordenada de dígitos $d_i \in \Sigma$.</p>
            <div>
            <p>Para entender considere que:</p>
            <ul>
                <li>$\Sigma$: Denota o conjunto de todos os símbolos permitidos.</li>
                <li>$b-1$: O maior dígito é sempre um a menos que a base. Na base 10, o maior símbolo é 9. Por quê? Porque se você tiver uma quantidade igual a $b$, você não cria um símbolo novo; você "zera" a posição atual e incrementa a próxima. Isso é o mecanismo do "vai um".</li>
            </ul>
            <p>Isso nos leva à distinção mais crítica deste capítulo</p>
            <div class="card">
                <h3>Teorema 1.2.1 Valor Absoluto vs. Valor Relativo</h3>
                <p>Para um dígito $d_k$ em uma posição $k$:</p>
                <ul>
                    <li><strong>Valor Absoluto (Facial):</strong> É o valor intrínseco do glifo. Ex: O desenho "5" sempre evoca a ideia de cinco unidades.</li>
                    <li><strong>Valor Relativo (Posicional):</strong> É o valor projetado pela sua localização.</li>
                </ul>
                <p>$$V(d_k) = d_k \cdot b^k$$</p>
            </div>
            <br>
            <h4>Aplicações</h4>
            <p><strong>Aplicação 1.2.1</strong> Vamos visualizar a construção do número $101$ na base 10. Para isso devemos pensar como podemos representar uma centena e uma unidade utilizando o alfabeto matemático $\Sigma = \{0, 1, \dots, 9\}$?</p>
            <ul>
                <li>
                    <strong>Posição 0 (Unidades):</strong> Temos 1 item. Usamos o glifo $1$.
                    <ul>
                        <li><strong>Valor:</strong> $1 \cdot 10^0 = 1$.</li>
                    </ul>
                </li>
                <li>
                    <strong>Posição 1 (Dezenas):</strong> Não temos grupos de dez.
                    <ul>
                        <li><strong>A Tentativa Antiga:</strong> Não escreva nada. Resultado: "1 1".</li>
                        <li><strong>A Solução Moderna:</strong> Usamos o vazio $0 \in \Sigma$.</li>
                        <li><strong>Valor:</strong> $0 \cdot 10^1 = 0$. (Ele não adiciona quantidade, mas ocupa o lugar).</li>
                    </ul>
                </li>
                <li>
                    <strong>Posição 2 (Centenas):</strong> Temos 1 grupo de cem. Usamos o glifo $1$.
                    <ul>
                        <li><strong>Valor:</strong> $1 \cdot 10^2 = 100$.</li>
                    </ul>
                </li>
            </ul>
            <p>A mágica acontece quando lemos a string $S = (101)_{10}$. O zero central diz: "Pule esta ordem de magnitude! O 1 à esquerda vale cem vezes mais que o 1 à direita!".</p>
            <p><strong>Contraexemplo:</strong> Existe um sistema chamado Bijetivo Base-10, que não usa o zero e usa os dígitos $\{1, 2, \dots, 9, A\}$ onde A vale dez. Nele, o número dez é escrito como "A", e onze é "11". Vinte é "1A". É matematicamente possível, mas aritmeticamente horrível para somas e multiplicações. O zero posicional venceu pela pura eficiência algorítmica.</p>
            <br>
            <p><strong>Aplicação 1.2.2:</strong> Seus computadores operam em Base 2 ($b=2$). O alfabeto é minúsculo: $\Sigma = \{0, 1\}$. Dentro do processador, não existem "números". Existem apenas transistores que estão ligados (1) ou desligados (0).</p>
            <p>Como um computador sabe a diferença entre o número 1 e o número 8?</p>
            <ul>
                <li>$1 = (0001)_2$ (O fio ligado está na posição 0).</li>
                <li>$8 = (1000)_2$ (O fio ligado está na posição 3).</li>
            </ul>
            <p>O mesmo componente físico representa valores completamente diferentes dependendo de onde ele está soldado no barramento. Sem o princípio posicional, precisaríamos de voltagens diferentes para cada número, o que seria fisicamente impossível.</p>
            <p><strong>Aplicação 1.2.3:</strong> Pense no odômetro de um carro antigo ou em um Array (Vetor) em programação. Quando você pede ao computador o valor de lista[5], ele não procura a lista inteira. Ele usa aritmética posicional pura. Ele sabe onde a lista começa (Endereço Base) e calcula:</p>
            <p>$$\text{Endereço Alvo} = \text{Base} + (5 \times \text{Tamanho do Item})$$</p>
            <p>Ele salta diretamente para a "posição" 5. Essa velocidade instantânea de acesso à memória só é possível porque tratamos a memória como um sistema posicional gigante.</p>
            <br>
            <h4>Resumo</h4>
            <div class="card">
                <p><strong>O Problema Histórico:</strong> A incapacidade de registrar a "ausência" em sistemas escritos causava ambiguidade (1 vs 10 vs 100).</p>
                <p><strong>O Salto Cognitivo:</strong> A invenção do Zero Posicional não como valor, mas como operador sintático (guardião de lugar).</p>
                <p><strong>Economia de Simbolos:</strong> Um sistema de base $b$ requer exatamente $b$ símbolos (alfabeto $\Sigma$). Não precisamos inventar novos símbolos para números maiores.</p>
                <p><strong>A Equação:</strong> O valor de um dígito é dinâmico: $d \cdot b^{\text{posição}}$.</p>
            </div>
            <br>
        """,
        Problems = new()
        {
            new()
            {
                Id="1",
                Statement= """
                    <p>De acordo com a Definição 1.2.1 apresentada no texto, o zero possui duas funções distintas em uma cadeia de caracteres numéricos. Quais são elas?</p>
                """,
                Solution= """
                    <ul>
                        <li>Elemento de Identidade: Em valor absoluto (soma), o zero não altera o valor ($x + 0 = x$).</li>
                        <li>Operador de Deslocamento: Sua função principal é ocupar espaço físico ("guardião de lugar") para empurrar os outros dígitos para suas posições corretas (potências de base $b^k$ à esquerda), evitando ambiguidades como confundir "1" com "10".</li>
                    </ul>
                """
            },
            new()
            {
                Id="2",
                Statement= """
                    <p>Explique o que era a "Ambiguidade da Ausência" enfrentada pelos escribas babilônicos ao tentar transferir contagens de pedras para tábuas de argila.</p>
                """,
                Solution= """
                    <p>O paradoxo residia na dificuldade de representar o "nada" por escrito.</p>
                    <ul>
                        <li>Fisicamente (na areia), a ausência de uma pedra em um sulco era clara.</li>
                        <li>Na escrita, não havia símbolo para o vazio. Se o escriba deixasse um espaço em branco, o leitor poderia interpretar como esquecimento ou erro. Se juntasse os símbolos, os valores posicionais colapsavam (ex: 101 virava 11). A bijeção entre o número real e sua representação escrita quebrava.</li>
                    </ul>
                """
            },
            new()
            {
                Id="3",
                Statement= """
                    <p>Considere o número $55$ na base 10. Diferencie o "Valor Absoluto" do "Valor Relativo" de cada um dos dois dígitos 5, conforme o Teorema 1.2.1.</p>
                """,
                Solution= """
                    <ul>
                        <li>
                            Dígito 5 (Direita/Unidades):
                            <ul>
                                <li>Valor Absoluto: 5 (a ideia intrínseca de "cinco").</li>
                                <li>Valor Relativo: $5 \times 10^0 = 5$.</li>
                            </ul>
                        </li>
                        <li>
                            Dígito 5 (Esquerda/Dezenas):
                            <ul>
                                <li>Valor Absoluto: 5 (o desenho é o mesmo).</li>
                                <li>Valor Relativo: $5 \times 10^1 = 50$. A distinção crucial é que o valor relativo depende da posição $k$ ($d \cdot b^k$).</li>
                            </ul>
                        </li>
                    </ul>
                """
            },
            new()
            {
                Id="4",
                Statement= """
                    <p>Segundo o texto, quantos símbolos únicos (glifos) são necessários para criar um sistema de numeração em Base 8? Liste o alfabeto $\Sigma$ correspondente.</p>
                """,
                Solution= """
                    <p>Para qualquer base $b$, precisamos exatamente de $b$ símbolos únicos.</p>
                    <ul>
                        <li>Para Base 8 ($b=8$), precisamos de 8 símbolos.</li>
                        <li>O alfabeto é $\Sigma = \{0, 1, 2, 3, 4, 5, 6, 7\}$.</li>
                        <li>Nota: O maior dígito é sempre $b-1$ (neste caso, 7).</li>
                    </ul>
                """
            },
            new()
            {
                Id="5",
                Statement= """
                    <p>Qual foi a solução "Força Bruta" adotada por Romanos e Gregos para lidar com números grandes, em contraste com o sistema posicional?</p>
                """,
                Solution= """
                    <p>Eles optaram pela criação de novos símbolos para cada nova ordem de grandeza, em vez de reutilizar os mesmos símbolos em posições diferentes.</p>
                    <ul>
                        <li>Exemplo: Usar 'X' para 10, 'C' para 100, 'M' para 1000.</li>
                        <li>O texto classifica isso como ineficiente pois exigiria memorizar infinitos símbolos para representar números infinitamente grandes.</li>
                    </ul>
                """
            },
            new()
            {
                Id="6",
                Statement= """
                    <p>Um pastor tem 13 ovelhas. Converta esse valor para a Base 5 (sistema quinário) usando o agrupamento posicional.</p>
                """,
                Solution= """
                    <p>Precisamos agrupar as 13 unidades em potências de 5 ($5^0=1, 5^1=5, 5^2=25...$).</p>
                    <ul>
                        <li>
                            Quantos grupos de 5 cabem em 13?
                            <ul>
                                <li>$13 \div 5 = 2$ com resto $3$.</li>
                            </ul>
                        </li>
                        <li>Isso significa que temos 2 grupos de cinco e 3 unidades soltas.</li>
                        <li>Posição 1 (pesos de 5): Dígito 2.</li>
                        <li>Posição 0 (pesos de 1): Dígito 3.</li>
                        <li>Resultado: $23_5$ (Lê-se "dois-três na base cinco").</li>
                    </ul>
                """
            },
            new()
            {
                Id="7",
                Statement= """
                    <p>Represente o número decimal 26 na Base 12 (Duodecimal).</p>
                """,
                Solution= """
                    <p>Base 12 agrupa em dúzias ($12^1$) e unidades ($12^0$).</p>
                    <ul>
                        <li>
                            Dividimos 26 por 12.
                            <ul>
                                <li>$26 \div 12 = 2$ com resto $2$.</li>
                            </ul>
                        </li>
                        <li>Temos 2 dúzias completas e sobram 2 unidades.</li>
                        <li>Resultado: $22_{12}$. Verificação: $(2 \times 12^1) + (2 \times 12^0) = 24 + 2 = 26$.</li>
                    </ul>
                """
            },
            new()
            {
                Id="8",
                Statement= """
                    <p>Utilize a fórmula $V(d_k) = d_k \cdot b^k$ para decompor explicitamente o número 4096 na base 10.</p>
                """,
                Solution= """
                    <p>O número tem 4 dígitos, ocupando as posições $k=0$ a $k=3$.</p>
                    <ul>
                        <li>$d_0 = 6$ (posição 0) $\rightarrow 6 \times 10^0$</li>
                        <li>$d_1 = 9$ (posição 1) $\rightarrow 9 \times 10^1$</li>
                        <li>$d_2 = 0$ (posição 2) $\rightarrow 0 \times 10^2$</li>
                        <li>$d_3 = 4$ (posição 3) $\rightarrow 4 \times 10^3$</li>
                        <li>Expressão Decomposta: $4 \cdot 10^3 + 0 \cdot 10^2 + 9 \cdot 10^1 + 6 \cdot 10^0$.</li>
                    </ul>
                """
            },
            new()
            {
                Id="9",
                Statement= """
                    <p>Conforme a Aplicação 1.2.2 (computadores), converta o número binário $(1101)_2$ para decimal.</p>
                """,
                Solution= """
                    <p>Mapeamos os dígitos às potências de 2, da direita para a esquerda (começando do índice 0):</p>
                    <ul>
                        <li>$1 \times 2^3 = 1 \times 8 = 8$</li>
                        <li>$1 \times 2^2 = 1 \times 4 = 4$</li>
                        <li>$0 \times 2^1 = 0 \times 2 = 0$</li>
                        <li>$1 \times 2^0 = 1 \times 1 = 1$</li>
                        <li>Soma: $8 + 4 + 0 + 1 = 13$.</li>
                    </ul>
                """
            },
            new()
            {
                Id="10",
                Statement= """
                    <p>Um computador precisa armazenar o número 6. Quais transistores (bits) estariam ligados (1) ou desligados (0) em um sistema de 4 bits?</p>
                """,
                Solution= """
                    <p>Precisamos somar potências de 2 ($8, 4, 2, 1$) para obter 6.</p>
                    <ul>
                        <li>8 é maior que 6? Sim, bit 3 desligado (0).</li>
                        <li>4 cabe em 6? Sim. Bit 2 ligado (1). Resta $6-4=2$.</li>
                        <li>2 cabe no resto? Sim. Bit 1 ligado (1). Resta $2-2=0$.</li>
                        <li>1 cabe no resto? Não. Bit 0 desligado (0).</li>
                        <li>Configuração: $0110_2$.</li>
                    </ul>
                """
            },
            new()
            {
                Id="11",
                Statement= """
                    <p>Baseado na Aplicação 1.2.3, imagine um vetor (array) que começa no endereço de memória 1000. Cada item ocupa 4 bytes. Qual é o endereço de memória onde começa o item de índice 5?</p>
                """,
                Solution= """
                    <p>Fórmula: $\text{Endereço Alvo} = \text{Base} + (\text{Índice} \times \text{Tamanho})$.</p>
                    <ul>
                        <li>Base = 1000</li>
                        <li>Índice = 5</li>
                        <li>Tamanho = 4</li>
                        <li>Cálculo: $1000 + (5 \times 4) = 1000 + 20$.</li>
                        <li>Resultado: Endereço 1020.</li>
                    </ul>
                """
            },
            new()
            {
                Id="12",
                Statement= """
                    <p>Se o endereço calculado para o índice 3 de um vetor é 515 e o vetor começa no endereço 500, qual é o tamanho (em bytes) de cada item armazenado?</p>
                """,
                Solution= """
                    <ul>
                        <li>Fórmula: $515 = 500 + (3 \times \text{Tamanho})$.</li>
                        <li>Isolando o termo do tamanho: $15 = 3 \times \text{Tamanho}$.</li>
                        <li>$\text{Tamanho} = 15 \div 3$.</li>
                        <li>Resultado: 5 bytes por item.</li>
                    </ul>
                """
            },
            new()
            {
                Id="13",
                Statement= """
                    <p>No sistema babilônico (base 60), o que representa uma quantidade maior: A) Um símbolo '1' no segundo sulco (posição 1). B) Cinquenta e nove símbolos '1' no primeiro sulco (posição 0).</p>
                """,
                Solution= """
                    <ul>
                        <li>Opção A: $1 \times 60^1 = 60$.</li>
                        <li>Opção B: $59 \times 60^0 = 59$.</li>
                        <li>Resultado: A Opção A é maior (60 > 59). Isso ilustra a potência do sistema posicional, onde a posição supera a quantidade absoluta de marcas.</li>
                    </ul>
                """
            },
            new()
            {
                Id="14",
                Statement= """
                    <p>Explique matematicamente por que, na Base 4, o número após "3" torna-se "10".</p>
                """,
                Solution= """
                    <p>O alfabeto da Base 4 é $\Sigma = \{0, 1, 2, 3\}$.</p>
                    <ul>
                        <li>Ao somar 1 ao dígito máximo (3), atingimos o valor da base (4).</li>
                        <li>Como não existe símbolo para "4" em $\Sigma$, "zeramos" a posição atual (unidades viram 0) e incrementamos a próxima posição à esquerda.</li>
                        <li>Resultado: $1$ grupo de quatro e $0$ unidades $\rightarrow 10_4$.</li>
                    </ul>
                """
            },
            new()
            {
                Id="15",
                Statement="""
                    <p>Se um número é escrito como $100$ na Base 7, qual é o seu valor em decimal?</p>
                """,
                Solution= """
                    <p>Aplicamos a fórmula do valor relativo: $1 \cdot 7^2 + 0 \cdot 7^1 + 0 \cdot 7^0$ $= 1 \cdot 49 + 0 + 0$</p>
                    <p>Resultado: 49.</p>
                """
            },
            new()
            {
                Id="16",
                Statement= """
                    <p>O texto menciona o "Sistema Bijetivo Base-10" onde o dez é representado por 'A' e não existe zero. Por que o texto afirma que esse sistema é "aritmeticamente horrível" para somas e multiplicações em comparação ao sistema com Zero Posicional?</p>
                """,
                Solution="""
                    <p>No sistema com Zero (convencional), a multiplicação por 10 é uma operação trivial de deslocamento (shift): basta adicionar um 0 ao final ($5 \times 10 = 50$). No sistema bijetivo, multiplicar '5' por 'A' (dez) resultaria em '50' (cinquenta)? Não, resultaria em uma representação que exigiria recálculo complexo de todos os símbolos, perdendo a propriedade simples onde a posição do dígito está diretamente atrelada à potência da base de forma limpa. O zero atua como um operador sintático que facilita algoritmos mecânicos; sem ele, cada operação requer tabelas de conversão ad-hoc.</p>
                """
            },
            new()
            {
                Id="17",
                Statement= """
                    <p>Se a Base 60 (Babilônica) é mais compacta (guarda mais informação por dígito) que a Base 10, por que a humanidade convergiu globalmente para bases menores (como 10 ou 12) em vez de manter a base 60 ou adotar a base 100? Baseie-se no "Princípio da Economia de Símbolos".</p>
                """,
                Solution= """
                    <p>O Princípio da Economia de Símbolos dita que uma base $b$ requer $b$ símbolos únicos para ser memorizada.</p>
                    <ul>
                        <li>Base 10 exige memorizar 10 glifos ($0-9$).</li>
                        <li>Base 60 exigiria memorizar 60 glifos únicos distintos para ser um sistema posicional puro. A carga cognitiva para aprender e distinguir 60 (ou 100) símbolos diferentes é muito alta para a alfabetização em massa. Bases menores equilibram a compactação do número com a capacidade de memorização do alfabeto.</li>
                    </ul>
                """
            },
            new()
            {
                Id="18",
                Statement="""
                    <p>Como o princípio posicional explicado na "Aplicação 1.2.3" é responsável pela eficiência $O(1)$ (tempo constante) no acesso a dados em computadores, e como isso seria diferente se a memória funcionasse como um pergaminho (sistema não posicional)?</p>
                """,
                Solution= """
                    <p>O princípio posicional permite o cálculo direto do local da informação ($\text{Base} + \text{Offset}$) sem a necessidade de percorrer os dados anteriores.</p>
                    <ul>
                        <li>Se a memória fosse como um pergaminho (fita sequencial ou lista ligada), para ler o item 1000, o computador teria que ler e desenrolar os 999 itens anteriores.</li>
                        <li>Graças à matemática posicional, o computador "salta" para o endereço exato instantaneamente. A eficiência da computação moderna depende dessa propriedade aritmética do endereçamento.</li>
                    </ul>
                """
            },
            new()
            {
                Id="19",
                Statement= """
                    <p>O texto afirma: "O vazio não é apenas a falta de algo; ele é uma entidade". Analise essa afirmação contrastando a representação "1 1" (com espaço vazio) com "101". O que o símbolo '0' fornece que o espaço em branco falha em fornecer?</p>
                """,
                Solution= """
                    <p>O espaço em branco é ambíguo e passivo; ele é definido pelo que não está lá. Ele não tem dimensões padronizadas (um espaço duplo parece dois espaços simples?). O símbolo '0' é uma entidade ativa e explícita. Ele:</p>
                    <ul>
                        <li>Define inequivocamente que a ordem de magnitude existe, mas está vazia.</li>
                        <li>Mantém a integridade estrutural da string numérica, independente da caligrafia ou espaçamento.</li>
                        <li>Transforma a ausência em um dado processável (é um símbolo que pode ser lido, copiado e computado).</li>
                    </ul>
                """
            },
            new()
            {
                Id="20",
                Statement="""
                    <p>Suponha que você precise multiplicar dois números na casa dos milhões usando algarismos romanos ($M, \bar{M}$, etc.). Qual é o impedimento fundamental descrito no texto que estagnou o progresso matemático com esse sistema, além da dificuldade das regras de soma?</p>
                """,
                Solution="""
                    <p>O impedimento é a limitação do alfabeto finito e não-recursivo. No sistema posicional, podemos representar números arbitrariamente grandes reutilizando o conjunto finito $\Sigma = \{0..9\}$. No sistema romano (Força Bruta Simbólica), números maiores exigem a invenção constante de novos símbolos ou notações (barras sobre letras) para continuar crescendo. Isso torna impossível criar algoritmos gerais de multiplicação (como a nossa multiplicação em colunas) que funcionem para qualquer número, pois as regras mudam conforme os símbolos mudam.</p>
                """
            }
        }
    };
}