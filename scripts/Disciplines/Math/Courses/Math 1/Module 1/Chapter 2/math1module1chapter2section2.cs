using SchoolData;

public class Math1Module1Chapter2Section2
{
    public static Topic Topic = new()
    {
        Id = "sistema-binario",
        Name = "2.2 Sistema Binário",
        Active = true,
        Body = """
            <h3>2.2 Sistema Binário</h3>
            <p>Vamos ajustar nossos relógios para o final do século XVII. A Europa intelectual estava vivendo uma ressaca de dados. A revolução científica havia aberto as portas para a astronomia de precisão, a navegação transoceânica e a balística, mas havia um problema prático imenso: o cálculo manual era uma tortura. Astrônomos passavam vidas inteiras preenchendo tábuas de logaritmos, afogados em um mar de algarismos decimais. O erro humano não era apenas um risco; era uma certeza estatística.</p>
            <p>Neste cenário entra Gottfried Wilhelm Leibniz, um polímata que não via fronteiras entre filosofia, teologia e matemática. Leibniz estava obcecado por uma ideia grandiosa: a Characteristica Universalis. Ele sonhava com uma linguagem universal do pensamento, um alfabeto da lógica humana onde qualquer disputa — seja científica ou legal — pudesse ser resolvida sentando-se à mesa e dizendo: "Calculemos".</p>
            <p>Mas Leibniz olhava para o sistema decimal (base 10) e via os problemas que já discutimos. Por que 10? Porque temos dez dedos? Isso é um acidente biológico, não uma verdade universal. Ele olhava para a base 60 dos babilônios e via conveniência (muitos divisores), mas excesso de símbolos.</p>
            <p>Leibniz buscava a pureza. Ele buscava o "átomo" da representação numérica. Qual é a menor quantidade de símbolos necessária para representar a infinitude de todos os números possíveis? Se removermos tudo o que é supérfluo, o que resta?</p>
            <p>A resposta dele foi: resta apenas o Ser e o Não-Ser. A existência e o vazio. Um e Zero.</p>
            <br>
            <p>Leibniz não estava operando no vácuo. Em sua busca, ele se deparou com correspondências fascinantes vindas do outro lado do mundo. Missionários jesuítas na China enviaram a ele diagramas do I Ching (O Livro das Mutações), especificamente os arranjos de hexagramas do estudioso Shao Yong, do século XI.</p>
            <p>Os chineses haviam intuído uma estrutura dualista fundamental: o Yin (representado por uma linha quebrada: - -) e o Yang (uma linha contínua: —). Ao empilhar essas linhas, eles criavam combinações.</p>
            <p>Leibniz ficou maravilhado. Onde os místicos viam cosmologia, ele viu aritmética. Se você substituir a linha quebrada por $0$ e a contínua por $1$, a sequência dos hexagramas formava uma contagem binária perfeita de 0 a 63.</p>
            <p>Por que, então, a China da Dinastia Song não inventou o computador digital? Porque a estrutura deles era combinatória e simbólica, mas não posicional-aritmética.</p>
            <p>Eles tinham os "bits" (os traços), mas faltava a tecnologia matemática que discutimos na seção 1.3 do Capítulo 1: o Teorema da Decomposição Polinomial. Eles usavam os símbolos para catalogar estados de mutação, não para calcular. Faltava o conceito do zero como um operador de posição que empurra os outros dígitos para potências superiores.</p>
            <p>Sem a álgebra formal, o binário é apenas um padrão qualquer.</p>
            <br>
            <p>No sistema decimal, usamos dez glifos. No sistema binário restringimos nosso alfabeto a apenas dois.</p>
            <div class="card">
                <h3>Definição 2.2.1: O Alfabeto Binário</h3>
                <p>O sistema binário é um sistema de numeração posicional de base $b=2$, cujo alfabeto de símbolos (glifos) é estritamente restrito ao conjunto:</p>
                <p>$$\Sigma_2 = \{0, 1\}$$</p>
            </div>
            <p>Isso parece trivial, mas as consequências são profundas. Lembre-se do Teorema da Decomposição Polinomial do Capítulo 1. Qualquer número $N$ pode ser escrito como a soma de potências da base. No binário, isso se torna extremamente elegante.</p>
            <div class="card">
                <h3>Teorema 2.2.1: Avaliação Polinomial Binária</h3>
                <p>O valor numérico $N$ de uma sequência de bits $d_n d_{n-1} \dots d_1 d_0$ na base 2 é dado pela série:</p>
                <p>$$N = \sum_{i=0}^{n} d_i \cdot 2^i, \quad \text{onde } d_i \in \{0, 1\}$$</p>
            </div>
            <p>Para entender considere que:</p>
            <ul>
                <li>$\sum$ (Sigma Maiúsculo): Significa Some tudo o que segue, incrementando o índice $i$ a cada passo.</li>
                <li>$i=0$ até $n$: Começamos da direita (posição 0, as unidades) e vamos até a esquerda (posição $n$, a maior potência).</li>
                <li>$2^i$ (O Peso da Posição): Esta é a chave. Na base 10, as posições valem 1, 10, 100... Na base 2, elas dobram: 1, 2, 4, 8, 16, 32...</li>
                <li>$d_i$ (O Dígito): Como $d_i$ só pode ser 0 ou 1, ele atua como um interruptor. Ou ele "liga" aquela potência de 2, somando-a ao total, ou ele a "desliga".</li>
            </ul>
            <br>
            <p>Sabemos ler o binário (Avaliação Polinomial), mas como escrevemos nele? Como pegamos um número decimal familiar e o traduzimos para essa linguagem de máquinas? Usamos o Algoritmo das Divisões Euclidianas Sucessivas.</p>
            <div class="Algoritmo 2.2.1: Conversão Decimal $\to$ Binário">
                <p>Dado um inteiro $n$, aplicamos a divisão inteira por 2 repetidamente:</p>
                <p>$$n_k = 2 \cdot q_k + r_k$$</p>
                <p>Onde $q$ é o quociente e $r \in \{0, 1\}$ é o resto. O processo repete-se usando $q$ como o novo $n$, até que o quociente seja zero. A representação binária é a sequência dos restos $r$ lida na ordem inversa (do último para o primeiro).</p>
            </div>
            <p>Tudo funciona perfeitamente para inteiros. Mas cuidado ao entrar no mundo das frações. Um número que é "limpo" e finito em decimal, como $0.1_{10}$ (um décimo), torna-se um pesadelo periódico em binário:$$0.1_{10} = 0.0001100110011..._2$$</p>
            <p>Isso ocorre porque 10 tem os fatores primos 2 e 5, mas a base 2 só tem o fator 2. Como $\frac{1}{10}$ não pode ser construído somando apenas metades, quartos e oitavos ($\frac{1}{2}, \frac{1}{4}, \frac{1}{8}$), a representação nunca termina. Guarde essa informação; ela é a raiz de muitos "bugs" misteriosos de arredondamento que você encontrará na computação moderna.</p>
            <br>
            <h4>Aplicações</h4>
            <p><strong>Aplicação 2.2.1</strong> Imagine que você é um engenheiro tentando codificar o número 13 para enviar a um processador.</p>
            <p>Passo 1: A Codificação (Decimal $\to$ Binário) Usamos o algoritmo da divisão. Pense nisso como empacotar o número em caixas de tamanho 2.</p>
            <ul>
                <li>
                    Dividimos 13 por 2.
                    <ul>
                        <li>Quanto dá? 6.</li>
                        <li>Sobrou alguma coisa? Sim, 1. (Esse é o nosso bit menos significativo, o da direita).</li>
                    </ul>
                </li>
                <li>
                    Agora pegamos o 6 e dividimos por 2.
                    <ul>
                        <li>Dá 3.</li>
                        <li>Sobrou? Não, resto 0.</li>
                    </ul>
                </li>
                <li>
                    Pegamos o 3 e dividimos por 2.
                    <ul>
                        <li>Dá 1.</li>
                        <li>Sobrou? Sim, resto 1.</li>
                    </ul>
                </li>
                <li>
                    Finalmente, pegamos o 1 e dividimos por 2.
                    <ul>
                        <li>Dá 0.</li>
                        <li>Sobrou? Sim, o próprio 1.</li>
                    </ul>
                </li>
            </ul>
            <p>Paramos aqui porque o quociente zerou. Agora, lemos os restos de baixo para cima (ou do último para o primeiro): 1101.</p>
            <p>Passo 2: A Verificação (Binário $\to$ Decimal) Vamos provar que $1101_2$ é realmente 13 usando nossa série polinomial. Lembre-se dos "interruptores" de potência:</p>
            <ul>
                <li>Posição 0 (Direita): O bit é 1. Peso $2^0 = 1$. $\rightarrow 1 \times 1 = 1$.</li>
                <li>Posição 1: O bit é 0. Peso $2^1 = 2$. $\rightarrow 0 \times 2 = 0$.</li>
                <li>Posição 2: O bit é 1. Peso $2^2 = 4$. $\rightarrow 1 \times 4 = 4$.</li>
                <li>Posição 3: O bit é 1. Peso $2^3 = 8$. $\rightarrow 1 \times 8 = 8$.</li>
            </ul>
            <p>Somamos tudo: $8 + 4 + 0 + 1 = \mathbf{13}$. A matemática é consistente. O sistema funciona.</p>
            <br>
            <p><strong>Aplicação 2.2.2</strong> A eletrônica é um mundo ruidoso. A temperatura flutua, cabos sofrem interferência. Se tentássemos construir um computador usando base 10 (onde 0 volts é '0', 1 volt é '1', ..., 9 volts é '9'), qualquer pequena oscilação de 0.5V corromperia o dado. Com a base 2, temos margem de segurança. Definimos que 0V a 1V é "Zero" e 4V a 5V é "Um". Se o sinal chegar como 4.8V, o sistema arredonda e diz: "Isso é inequivocamente um 1". O rigor matemático da base 2 permitiu a engenharia robusta do hardware.</p>
            <p><strong>Aplicação 2.2.3</strong> Leibniz sonhou em codificar o pensamento. Hoje, chamamos isso de ASCII ou Unicode. Atribuímos um número a cada letra (A=65, B=66...), convertemos esses números para binário, e de repente, toda a literatura humana, todas as fotos, todos os vídeos, são reduzidos àquela série polinomial de coeficientes 0 e 1.</p>
            <br>
            <h4>Resumo</h4>
            <div class="card">
                <p><strong>Atomismo Numérico:</strong> A Base 2 é irredutível. É o sistema com o menor alfabeto possível ($\Sigma=\{0,1\}$) que mantém as propriedades de um sistema posicional.</p>
                <p><strong>Dualidade de Conversão:</strong></p>
                <ul>
                    <li>Para Ler (Bin $\to$ Dec): Use a Série de Potências ($\sum d_i 2^i$).</li>
                    <li>Para Escrever (Dec $\to$ Bin): Use as Divisões Euclidianas Sucessivas (leia os restos ao contrário).</li>
                </ul>
                <p><strong>Significância do Bit:</strong> Em binário, cada posição à esquerda dobra o valor. Isso cria um crescimento exponencial rápido, mas com coeficientes simples (apenas "sim" ou "não").</p>
            </div>
        """,
        Problems = new()
        {
            new()
            {
                Id="1",
                Statement= """
                    <p>Qual foi a motivação histórica de Gottfried Wilhelm Leibniz para buscar um sistema numérico diferente do decimal, e como ele chamou essa "linguagem universal"?</p>
                """,
                Solution= """
                    <p>Leibniz estava motivado pela complexidade e pelo "ruído" do sistema decimal, além da dificuldade dos cálculos manuais que atormentavam astrônomos e cientistas da época. Ele buscava uma "pureza" lógica e um "átomo" de representação. Ele chamou essa linguagem universal do pensamento de Characteristica Universalis.</p>
                """
            },
            new()
            {
                Id="2",
                Statement= """
                    <p>Defina formalmente o "Alfabeto Binário" ($\Sigma_2$) conforme apresentado no texto.</p>
                """,
                Solution= """
                    <p>O Alfabeto Binário é o conjunto de símbolos (glifos) estritamente restrito usado no sistema de numeração posicional de base $b=2$. O conjunto é definido como:</p>
                    <p>$$\Sigma_2 = \{0, 1\}$$</p>
                """
            },
            new()
            {
                Id="3",
                Statement="""
                    <p>O texto menciona uma conexão histórica entre o sistema binário e a cultura chinesa antiga. Qual era a obra e o que faltava a ela para ser considerada um sistema computacional moderno?</p>
                """,
                Solution= """
                    <p>A obra era o I Ching (O Livro das Mutações), especificamente os hexagramas de Shao Yong, que usavam linhas contínuas (Yang) e quebradas (Yin). Faltava a ela a tecnologia matemática do Teorema da Decomposição Polinomial e o conceito do zero como operador de posição. O sistema chinês era combinatório e simbólico, mas não posicional-aritmético.</p>
                """
            },
            new()
            {
                Id="4",
                Statement="""
                    <p>Na analogia física apresentada para o hardware (computadores), o que representam matematicamente os estados de tensão elétrica 0V-1V e 4V-5V?</p>
                """,
                Solution="""
                    <p>Eles representam, respectivamente, os dígitos binários 0 (Zero) e 1 (Um). Essa margem de segurança permite que o sistema binário ignore o "ruído" analógico (oscilações de tensão), garantindo a integridade dos dados.</p>
                """
            },
            new()
            {
                Id="5",
                Statement= """
                    <p>Segundo o Teorema da Avaliação Polinomial Binária, qual é o valor do peso posicional ($2^i$) para a quarta posição (índice $i=3$) de um número binário?</p>
                """,
                Solution= """
                    <p>A série de potências de base 2 começa em $i=0$.</p>
                    <ul>
                        <li>$i=0 \rightarrow 2^0 = 1$</li>
                        <li>$i=1 \rightarrow 2^1 = 2$</li>
                        <li>$i=2 \rightarrow 2^2 = 4$</li>
                        <li>$i=3 \rightarrow 2^3 = 8$ Portanto, o peso da quarta posição é 8.</li>
                    </ul>
                """
            },
            new()
            {
                Id="6",
                Statement= """
                    <p>Converta o número decimal $6_{10}$ para binário utilizando o método das Divisões Euclidianas Sucessivas.</p>
                    <ul>
                        <li>$6 \div 2 = 3$, resto 0.</li>
                        <li>$3 \div 2 = 1$, resto 1.</li>
                        <li>$1 \div 2 = 0$, resto 1.</li>
                        <li>Lendo os restos de baixo para cima (ou do último para o primeiro): Resultado: $110_2$</li>
                    </ul>
                """
            },
            new()
            {
                Id="7",
                Statement= """
                    <p>Converta o número decimal $11_{10}$ para binário.</p>
                """,
                Solution= """
                    <ul>
                        <li>$11 \div 2 = 5$, resto 1.</li>
                        <li>$5 \div 2 = 2$, resto 1.</li>
                        <li>$2 \div 2 = 1$, resto 0.</li>
                        <li>$1 \div 2 = 0$, resto 1.</li>
                        <li>Leitura inversa dos restos: Resultado: $1011_2$</li>
                    </ul>
                """
            },
            new()
            {
                Id="8",
                Statement= """
                    <p>Converta o número decimal $23_{10}$ para binário.</p>
                """,
                Solution = """
                    <ul>
                    
                    </ul>
                    <li>$23 \div 2 = 11$, resto 1.</li>
                    <li>$11 \div 2 = 5$, resto 1.</li>
                    <li>$5 \div 2 = 2$, resto 1.</li>
                    <li>$2 \div 2 = 1$, resto 0.</li>
                    <li>$1 \div 2 = 0$, resto 1.</li>
                    <li>Leitura inversa: Resultado: $10111_2$</li>
                """
            },
            new()
            {
                Id="9",
                Statement= """
                    <p>Converta o número decimal $32_{10}$ para binário.</p>
                """,
                Solution= """
                    <ul>
                        <li>$32 \div 2 = 16$, resto 0.</li>
                        <li>$16 \div 2 = 8$, resto 0.</li>
                        <li>$8 \div 2 = 4$, resto 0.</li>
                        <li>$4 \div 2 = 2$, resto 0.</li>
                        <li>$2 \div 2 = 1$, resto 0.</li>
                        <li>$1 \div 2 = 0$, resto 1.</li>
                        <li>Leitura inversa: Resultado: $100000_2$</li>
                    </ul>
                """
            },
            new()
            {
                Id="10",
                Statement= """
                    <p>Converta o número binário $101_2$ para decimal usando a Avaliação Polinomial.</p>
                """,
                Solution= """
                    <ul>
                        <li>$$N = 1 \cdot 2^2 + 0 \cdot 2^1 + 1 \cdot 2^0$$</li>
                        <li>$$N = 1 \cdot 4 + 0 \cdot 2 + 1 \cdot 1$$</li>
                        <li>$$N = 4 + 0 + 1$$</li>
                        <li>Resultado: $5_{10}$</li>
                    </ul>
                """
            },
            new()
            {
                Id="11",
                Statement="""
                    <p>Converta o número binário $1110_2$ para decimal.</p>
                """,
                Solution= """
                    <p>Posições (da direita para esquerda): 0, 1, 2, 3.</p>
                    <ul>
                        <li>$$N = 1 \cdot 2^3 + 1 \cdot 2^2 + 1 \cdot 2^1 + 0 \cdot 2^0$$</li>
                        <li>$$N = 8 + 4 + 2 + 0$$</li>
                        <li>$14_{10}$</li>
                    </ul>
                """
            },
            new()
            {
                Id="12",
                Statement= """
                    <p>Converta o número binário $10001_2$ para decimal.</p>
                """,
                Solution= """
                    <ul>
                        <li>$$N = 1 \cdot 2^4 + 0 \cdot 2^3 + 0 \cdot 2^2 + 0 \cdot 2^1 + 1 \cdot 2^0$$</li>
                        <li>$$N = 16 + 0 + 0 + 0 + 1$$</li>
                        <li>$17_{10}$</li>
                    </ul>
                """
            },
            new()
            {
                Id="13",
                Statement= """
                    <p>Converta o número decimal $42_{10}$ para binário.</p>
                """,
                Solution= """
                    <ul>
                        <li>$42 \div 2 = 21$, resto 0.</li>
                        <li>$21 \div 2 = 10$, resto 1.</li>
                        <li>$10 \div 2 = 5$, resto 0.</li>
                        <li>$5 \div 2 = 2$, resto 1.</li>
                        <li>$2 \div 2 = 1$, resto 0.</li>
                        <li>$1 \div 2 = 0$, resto 1.</li>
                        <li>Leitura inversa: Resultado: $101010_2$</li>
                    </ul>
                """
            },
            new()
            {
                Id="14",
                Statement= """
                    <p>Converta o número binário $11001_2$ para decimal.</p>
                """,
                Solution= """
                    <ul>
                        <li>$$N = 1 \cdot 2^4 + 1 \cdot 2^3 + 0 \cdot 2^2 + 0 \cdot 2^1 + 1 \cdot 2^0$$</li>
                        <li>$$N = 16 + 8 + 0 + 0 + 1$$</li>
                        <li>$25_{10}$</li>
                    </ul>
                """
            },
            new()
            {
                Id="15",
                Statement= """
                    <p>Converta o caractere "A" para binário, sabendo que no código ASCII ele vale $65_{10}$.</p>
                """,
                Solution= """
                    <p>Aplicamos Divisões Euclidianas Sucessivas em 65:</p>
                    <ul>
                        <li>$65 \div 2 = 32$, resto 1.</li>
                        <li>$32 \div 2 = 16$, resto 0.</li>
                        <li>$16 \div 2 = 8$, resto 0.</li>
                        <li>$8 \div 2 = 4$, resto 0.</li>
                        <li>$4 \div 2 = 2$, resto 0.</li>
                        <li>$2 \div 2 = 1$, resto 0.</li>
                        <li>$1 \div 2 = 0$, resto 1.</li>
                        <li>Leitura inversa: Resultado: $1000001_2$</li>
                    </ul>
                """
            },
            new()
            {
                Id="16",
                Statement= """
                    <p>O texto afirma que o sistema decimal é um "acidente biológico". Analise essa afirmação comparando a Base 10 com a Base 2 em termos de "irredutibilidade".</p>
                """,
                Solution= """
                    <p>A Base 10 baseia-se na contagem dos dedos das mãos, o que é uma característica anatômica humana arbitrária. Matematicamente, ela não é fundamental. A Base 2, por outro lado, é irredutível porque usa a menor quantidade possível de símbolos ($\{0, 1\}$) para manter as propriedades de um sistema posicional. Não é possível ter uma base $b=1$ posicional eficiente (seria apenas marcas de contagem/unário). Portanto, o binário é o "átomo" lógico, independente da biologia.</p>   
                """
            },
            new()
            {
                Id="17",
                Statement= """
                    <p>Explique matematicamente por que o número decimal $0.1$ (um décimo) se torna uma dízima periódica infinita em binário ($0.00011...$), enquanto em decimal ele é finito.</p>
                """,
                Solution= """
                    <p>A representação finita de frações depende dos fatores primos da base.</p>
                    <ul>
                        <li>Em Base 10: Os fatores primos são 2 e 5. Como $0.1 = \frac{1}{10} = \frac{1}{2 \times 5}$, o denominador contém apenas fatores que existem na base, permitindo representação finita.</li>
                        <li>Em Base 2: O único fator primo é 2. O número $10$ (do denominador $\frac{1}{10}$) contém o fator 5, que não existe na base 2. Como não podemos construir exatamente $\frac{1}{10}$ somando apenas potências de 2 negativas ($\frac{1}{2}, \frac{1}{4}, \frac{1}{8}...$), o resultado é uma série infinita (periódica).</li>
                    </ul>
                """
            },
            new()
            {
                Id="18",
                Statement= """
                    <p>Analise a relação entre "Eficiência Simbólica" (tamanho do alfabeto) e "Comprimento da Representação" (número de dígitos) comparando Base 2 e Base 10.</p>
                """,
                Solution= """
                    <p>Existe uma relação inversa (trade-off).</p>
                    <ul>
                        <li>Base 10: Alta eficiência simbólica (10 símbolos), o que gera representações mais curtas (ex: "13" usa apenas 2 dígitos).</li>
                        <li>Base 2: Baixa eficiência simbólica (apenas 2 símbolos), o que exige representações mais longas para expressar a mesma quantidade (ex: "1101" usa 4 dígitos para expressar 13). O binário sacrifica a compactação visual em troca da simplicidade extrema dos componentes (apenas dois estados), ideal para máquinas.</li>
                    </ul>
                """
            },
            new()
            {
                Id="19",
                Statement= """
                    <p>Com base no conceito de "Ruído" mencionado na Aplicação 2.2.2, deduza o que aconteceria com a confiabilidade de um computador se ele operasse em Base 10 (usando voltagens de 0V a 9V) em vez de Base 2.</p>
                """,
                Solution= """
                    <p>Se um computador usasse Base 10 com voltagens de 0V a 9V, a margem entre um número e outro seria de apenas 1V (ou menos, dependendo da calibração). Uma pequena interferência ou "ruído" elétrico de 0.5V poderia alterar um "4" (4V) para um "5" (5V), corrompendo o cálculo. Na Base 2, a margem entre o "0" (0-1V) e o "1" (4-5V) é grande (zona morta de ~3V). O sistema binário é escolhido não pela brevidade, mas pela robustez física contra erros.</p>
                """
            },
            new()
            {
                Id="20",
                Statement= """
                    <p>Relacione o conceito de "Série Polinomial" com a ideia de Leibniz de uma "Characteristica Universalis" para textos e imagens (Aplicação 2.2.3). Como a matemática transforma literatura em números?</p>
                """,
                Solution= """
                    <p>A Characteristica Universalis é realizada através de camadas de abstração. Primeiro, mapeamos símbolos humanos (letras, cores de pixels) para números inteiros arbitrários (Tabela ASCII/Unicode). Em seguida, o Teorema da Decomposição Polinomial nos permite converter esses números inteiros em sequências únicas de 0s e 1s. Assim, qualquer pensamento humano registrável (texto, imagem) é reduzido a uma soma de potências de base 2, tornando-se universalmente processável por qualquer máquina lógica.</p>
                """
            }
        }
    };
}