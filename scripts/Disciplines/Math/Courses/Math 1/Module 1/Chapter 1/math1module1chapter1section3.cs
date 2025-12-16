namespace SchoolData;

public class Math1Module1Chapter1Section3
{
    public static Topic Topic = new()
    {
        Id = "teorema-da-decomposicao-polinomial",
        Name = "1.3 Teorema da Decomposição Polinomial",
        Active = true,
        Body = """
            <h3>1.3 Teorema da Decomposição Polinomial</h3>
            <p>Imagine-se em Bagdá, por volta do ano 825 d.C. Você está na Bayt al-Hikmah, observando o trabalho de Al-Khwarizmi. O mundo está passando por uma revolução, durante milênios, a humanidade calculou usando o ábaco: pedras físicas movidas em sulcos na areia ou em tábuas de madeira. O número era uma entidade palpavel. Se você queria somar, você juntava pilhas de pedras. A verdade matemática estava ali, diante dos seus olhos em um ambiente físico.</p>
            <p>Mas como vimos anteriormente, uma nova tecnologia está surgindo: o algarismo. A ideia audaciosa de que podemos descartar as pedras e manipular apenas símbolos (0 a 9) em argila, ou, folha de papel</p>
            <p>No ábaco, o erro é físico; na escrita, o erro é abstrato. Quando você escreve o símbolo "123", você está afirmando que essa sequência de glifos representa uma quantidade única e específica de ovelhas, moedas ou estrelas. Mas, sem as pedras físicas para provar, o que garante que esse sistema funciona? O que garante que todo número existente pode ser escrito? E, mais aterrorizante ainda para um tesoureiro real ou um astrônomo: o que garante que a representação é única?</p>
            <p>Se fosse possível escrever o número "treze" de duas formas diferentes no mesmo sistema, toda a matemática colapsaria. O sistema posicional precisava de uma garantia. Precisava deixar de ser apenas uma "técnica útil" para se tornar uma ferramenta matemática.</p>
            <br>
            <p>Os matemáticos perceberam que o segredo não estava nos símbolos, mas na mecânica do agrupamento. Pense no Odômetro de um carro antigo, um simples de três rodas. Quando a roda das unidades gira de $0$ até $9$, tudo vai bem. Mas o que acontece quando tentamos somar mais $1$?</p>
            <figure>
                <img src="images/Courses/Math/Math1/Module1/Chapter1/Section1.3/Fig1.3.1.png" alt="Figura 1.3.1: Representação de um odômetro">
                <figcaption>Figura 1.3.1: Representação de um odômetro</figcaption>
            </figure>
            <p>A roda física não tem um símbolo para "dez". Ela é forçada a voltar para o $0$. E, nesse movimento de retorno, um dente da engrenagem "chuta" a roda vizinha (as dezenas) uma posição para frente.</p>
            <p>Isso é a Decomposição Física.</p>
            <ul>
                <li>A roda da direita conta $10^0$ (unidades).</li>
                <li>A roda do meio conta $10^1$ (dezenas).</li>
                <li>A roda da esquerda conta $10^2$ (centenas).</li>
            </ul>
            <p>A falha dos sistemas antigos, como os algarismos romanos, era a falta dessa engrenagem universal. No sistema romano, $X$ (dez) e $C$ (cem) são letras diferentes, animais diferentes. Eles não percebiam que $C$ é apenas o $X$ que sofreu um "shift" de posição.</p>
            <p>A grande sacada intelectual foi perceber que um número não é uma pilha de pedras; um número é um polinômio. O número 42 não é "quarenta e dois" objetos soltos; ele é uma instrução algébrica: "Pegue 4 pacotes da base, e adicione 2 unidades."</p>
            <p>Faltava apenas formalizar isso de modo que funcionasse não só para a base 10 (nossos dedos), mas para qualquer universo numérico possível.</p>
            <br>
            <p>Precisamos de um teorema que garanta a Existência (todo número pode ser escrito) e a Unicidade (só existe uma forma de escrevê-lo).</p>
            <div class="card">
                <h3>Teorema 1.3.1 Teorema da Representação em Base $b$</h3>
                <p>Seja $b > 1$ um número inteiro (chamado de base). Todo número inteiro positivo $n$ pode ser representado de forma única como uma soma de potências da base:</p>
                <p>$$n = d_k b^k + d_{k-1} b^{k-1} + \dots + d_1 b^1 + d_0 b^0 = \sum_{i=0}^{k} d_i b^i$$</p>
                <p>Sujeito às restrições fundamentais:</p>
                <ul>
                    <li><strong>Coeficientes Limitados:</strong> $0 \le d_i < b$ para todo $i$.</li>
                    <li><strong>Líder Não-Nulo:</strong> $d_k \neq 0$ (exceto se $n=0$).</li>
                </ul>
            </div>
            <br>
            <p>Para entender considere que:</p>
            <ul>
                <li>
                    <strong>$\sum_{i=0}^{k}$ (O Somatório):</strong> Este símbolo grego (Sigma) nos diz para acumular valores. Pense no processo que você faz para somar todos os números inteiros de $0$ a $10$
                    <p>$$0 + 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 = \sum_{i=0}^{10} i$$</p>
                </li>
                <li><strong>$b^i$ (A Ordem de Magnitude):</strong> Esta é a "posição" no ábaco. Se $b=10$, isso representa as colunas de 1, 10, 100, 1000... É a estrutura do esqueleto do número.</li>
                <li><strong>$d_i$ (O Dígito/Coeficiente):</strong> Esta é a "quantidade de pedras" naquela posição específica.</li>
                <li>
                    <strong>A Restrição $0 \le d_i < b$ (A Alma do Sistema):</strong> Esta é a parte mais crucial. Ela diz que você nunca pode ter um dígito igual ou maior que a base.
                    <ul>
                        <li>Na base 10, o dígito máximo é 9.</li>
                        <li>Na base 2, o dígito máximo é 1.</li>
                        <li>Se $d_i$ atingisse $b$, o "odômetro" giraria, zerando a posição atual e enviando um carry (transporte) para a próxima potência ($b^{i+1}$). É essa regra que garante a unicidade.</li>
                    </ul>
                </li>
            </ul>
            <p>Por que exigimos $b > 1$? Se tentássemos usar $b=1$ (Base Unária), as potências seriam todas iguais ($1^0 = 1, 1^1 = 1, 1^2 = 1$). A estrutura posicional colapsaria. O número 5 seria apenas |||||. Não haveria economia de espaço nem hierarquia de ordens. A base 2 é, portanto, a menor estrutura complexa possível no universo matemático.</p>
            <br>
            <h4>Aplicações</h4>
            <p><strong>Aplicação 1.3.1</strong> Como encontrar esses $d_i$ da fórmula $\sum d_i b^i$?</p>
            <p>Não adivinhamos. Nós usamos o Algoritmo de Euclides. Os dígitos de um número nada mais são do que os restos sucessivos da divisão pela base.</p>
            <p>Vamos ver isso acontecendo em câmera lenta e converter o número $n = 13$ para a Base 2 (Binário), usando o teorema.</p>
            <p>Queremos empacotar "13 unidades" em potências de 2.</p>
            <ul>
                <li>
                    Primeira Divisão: Dividimos 13 por 2.
                    <ul>
                        <p>$$13 = 6 \times 2 + \mathbf{1}$$</p>
                        <li>O quociente é 6. O resto é 1.</li>
                        <li>Interpretação: Conseguimos formar 6 grupos de 2, e sobrou 1 unidade solta. Esse resto é o nosso $d_0$.</li>
                    </ul>
                </li>
                <li>
                    Segunda Divisão: Agora pegamos os 6 pares (o quociente anterior) e tentamos agrupá-los novamente em grupos de 2.
                    <ul>
                        <p>$$6 = 3 \times 2 + \mathbf{0}$$</p>
                        <li>O resto é 0.</li>
                        <li>Interpretação: Não sobrou ninguém sem par. Esse é o nosso $d_1$.</li>
                    </ul>
                </li>
                <li>
                    Terceira Divisão: Pegamos os 3 grupos e dividimos em grupos de 2.
                    <ul>
                        <p>$$3 = 1 \times 2 + \mathbf{1}$$</p>
                        <li>O resto é 1. Esse é o nosso $d_2$.</li>
                    </ul>
                </li>
                <li>
                    Quarta Divisão: Pegamos o 1 grupo de oito e dividimos.
                    <ul>
                        <p>$$1 = 0 \times 2 + \mathbf{1}$$</p>
                        <li>O resto é 1. O quociente zerou. Acabamos.</li>
                    </ul>
                </li>
            </ul>
            <p>Lendo os restos de baixo para cima (do último para o primeiro), temos os coeficientes: $\mathbf{1}, \mathbf{1}, \mathbf{0}, \mathbf{1}$. Logo, na base 2:</p>
            <p>$$13_{10} = 1101_2$$</p>
            <p>Verificação pelo Polinômio:</p>
            <p>$$1 \cdot 2^3 + 1 \cdot 2^2 + 0 \cdot 2^1 + 1 \cdot 2^0$$</p>
            <p>$$8 + 4 + 0 + 1 = 13$$</p>
            <p><strong>Aplicação 1.3.2</strong> Quando você aprendeu a multiplicar números no ensino fundamental ("multiplica, pula uma casa, soma"), você estava, sem saber, multiplicando polinômios onde $x=10$.</p>
            <p>Isso significa que toda a aritmética avançada computacional (usada em criptografia RSA por exemplo) trata números gigantes não como valores, mas como polinômios de alta ordem.</p>
            <p><strong>Aplicação 1.3.3</strong> O Teorema da Representação não se importa com o valor de $b$. Se ele funciona para base 10, ele precisa funcionar para base 2. Isso nos dá a certeza matemática para construir computadores. Sabemos, por prova rigorosa, que qualquer informação numérica, por mais complexa que seja, pode ser mapeada sem perda de dados para um sistema de apenas dois estados (Ligado/Desligado, 1 e 0). Sem o Teorema 1.3.1, a Era Digital seria impossível.</p>
            <h4>Resumo</h4>
            <div class="card">
                <p><strong>Polinômio Posicional:</strong> Todo número natural é uma soma ponderada de potências de uma base $b$.</p>
                <p><strong>Restrição de Unicidade:</strong> Para garantir que a escrita seja única, cada "dígito" deve ser estritamente menor que a base ($d_i < b$).</p>
                <p><strong>Independência de Substrato:</strong> A lógica funciona para pedras (ábaco), rodas dentadas (odômetro) ou transistores (computadores).</p>
                <p><strong>Algoritmo Gerador:</strong> A Divisão Euclidiana sucessiva é o método que extrai os dígitos de um número.</p>
            </div>
            <br>
        """,
        Problems = new()
        {
            new()
            {
                Id="1",
                Statement= """
                    <p>De acordo com o Teorema da Representação em Base $b$ apresentado, qual é a restrição fundamental imposta ao número inteiro $b$ (a base) para que o sistema funcione e por que o texto afirma que a Base 2 é a "menor estrutura complexa possível"?</p>
                """,
                Solution= """
                    <p>O teorema estabelece que a base $b$ deve ser um inteiro tal que $b > 1$. A Base 2 é considerada a menor estrutura possível porque, se $b=1$ (Base Unária), todas as potências da base seriam iguais a 1 ($1^0=1, 1^1=1, ...$), eliminando a hierarquia de ordens e a economia de espaço (posicionalidade), transformando o número em apenas uma sequência de traços (ex: |||||).</p>
                """
            },
            new()
            {
                Id="2",
                Statement= """
                    <p>No polinômio $n = \sum_{i=0}^{k} d_i b^i$, existe uma regra estrita para os coeficientes $d_i$ (os dígitos). Qual é essa regra matemática e qual analogia mecânica o texto usa para explicar o que acontece se essa regra for violada?</p>
                """,
                Solution = """
                    <p>A regra é $0 \le d_i < b$. Ou seja, cada dígito deve ser maior ou igual a zero e estritamente menor que a base. A analogia usada é a do Odômetro. Se um dígito tentasse igualar a base (ex: chegar a 10 na base 10), a engrenagem "giraria", voltando a zero e "chutando" (carry) uma unidade para a roda da posição superior ($b^{i+1}$).</p>
                """
            },
            new()
            {
                Id="3",
                Statement= """
                    <p>O texto afirma que "um número não é uma pilha de pedras". Como o texto define a natureza algébrica do número 42 sob a ótica da decomposição polinomial?</p>
                """,
                Solution = """
                    <p>O texto define o número 42 não como objetos soltos, mas como uma instrução algébrica: "Pegue 4 pacotes da base (neste caso, base 10) e adicione 2 unidades". Matematicamente, isso é interpretado como $4 \cdot 10^1 + 2 \cdot 10^0$.</p>
                """
            },
            new()
            {
                Id="4",
                Statement= """
                    <p>Na notação $\sum_{i=0}^{k} d_i b^i$, o que representam fisicamente os termos $b^i$ e $d_i$ segundo a analogia do ábaco citada no texto?</p>
                """,
                Solution= """
                    <ul>
                        <li><strong>$b^i$ (Ordem de Magnitude):</strong> Representa a "posição" ou a coluna no ábaco (unidades, dezenas, centenas, etc.). É a estrutura ou esqueleto do sistema.</li>
                        <li><strong>$d_i$ (Coeficiente/Dígito):</strong> Representa a "quantidade de pedras" ou contas colocadas naquela posição específica.</li>
                    </ul>
                """
            },
            new()
            {
                Id="5",
                Statement="""
                    <p>Qual é o nome do algoritmo matemático citado no texto como o "motor" ou método para encontrar os dígitos $d_i$ de um número em uma nova base, e qual operação aritmética básica ele utiliza repetidamente?</p>
                """,
                Solution= """
                    O método é o Algoritmo de Euclides (ou Divisões Sucessivas). Ele utiliza repetidamente a operação de Divisão Inteira com Resto, onde os dígitos do número na nova base correspondem aos restos obtidos nessas divisões.
                """
            },
            new()
            {
                Id="6",
                Statement= """
                    <p>Um computador precisa processar o número decimal 6. Utilize o método das divisões sucessivas descrito no texto para converter este valor para a Base 2.</p>
                """,
                Solution= """
                    <ul>
                        <li>Dividir 6 por 2: $6 = 3 \times 2 + \mathbf{0}$. (Resto $d_0 = 0$).</li>
                        <li>Dividir o quociente 3 por 2: $3 = 1 \times 2 + \mathbf{1}$. (Resto $d_1 = 1$).</li>
                        <li>Dividir o quociente 1 por 2: $1 = 0 \times 2 + \mathbf{1}$. (Resto $d_2 = 1$).</li>
                        <li>Leitura inversa dos restos: 110.</li>
                        <li>Resposta: $6_{10} = 110_2$.</li>
                    </ul>
                """
            },
            new()
            {
                Id="7",
                Statement= """
                    <p>Um pastor antigo decide contar suas ovelhas usando grupos de 5 (Base 5). Se ele tem 23 ovelhas, como esse número é escrito no sistema dele? Apresente os cálculos.</p>
                """,
                Solution= """
                    <ul>
                        <li>Dividir 23 por 5: $23 = 4 \times 5 + \mathbf{3}$. (Resto = 3 unidades soltas).</li>
                        <li>Dividir 4 por 5: $4 = 0 \times 5 + \mathbf{4}$. (Resto = 4 grupos de cinco).</li>
                        <li>Leitura inversa: 43.</li>
                        <li>Resposta: $23_{10} = 43_5$. (Lê-se "quatro-três na base 5", significando 4 cincos e 3 unidades).</li>
                    </ul>
                """
            },
            new()
            {
                Id="8",
                Statement= """
                    <p>Converta o número decimal 15 para a Base 12.</p>
                """,
                Solution= """
                    <ul>
                        <li>Dividir 15 por 12: $15 = 1 \times 12 + \mathbf{3}$. (Resto = 3).</li>
                        <li>Dividir o quociente 1 por 12: $1 = 0 \times 12 + \mathbf{1}$. (Resto = 1).</li>
                        <li>Leitura inversa: 13.</li>
                        <li>Resposta: $15_{10} = 13_{12}$.</li>
                    </ul>
                """
            },
            new()
            {
                Id="9",
                Statement= """
                    <p>Você encontrou um registro antigo com o número $213_4$ (Base 4). Usando a fórmula do polinômio ($\sum d_i b^i$), converta esse número de volta para a Base 10 para saber a quantidade real.</p>
                """,
                Solution= """
                    <p>Aplicamos a decomposição com $b=4$:$n = 2 \cdot 4^2 + 1 \cdot 4^1 + 3 \cdot 4^0$ $n = 2 \cdot 16 + 1 \cdot 4 + 3 \cdot 1$ $n = 32 + 4 + 3$ $n = 39$.</p>
                    <p>Resposta: O número é 39.</p>
                """
            },
            new()
            {
                Id="10",
                Statement= """
                    <p>O texto menciona o ano 825 d.C. Converta este ano para a Base 8 (Octal) usando divisões sucessivas.</p>
                """,
                Solution= """
                    <ul>
                        <li>$825 \div 8 = 103$ com resto 1.</li>
                        <li>$103 \div 8 = 12$ com resto 7.</li>
                        <li>$12 \div 8 = 1$ com resto 4.</li>
                        <li>$1 \div 8 = 0$ com resto 1. Leitura inversa: 1471.</li>
                        <li>Resposta: $825_{10} = 1471_8$.</li>
                    </ul>
                """
            },
            new()
            {
                Id="11",
                Statement= """
                    <p>O texto afirma que multiplicar números é como multiplicar polinômios. Multiplique $23_x \times 2_x$ assumindo que $x$ é a base. Se $x=10$, qual o resultado? E se $x=5$?</p>
                """,
                Solution= """
                    <p>Polinômios: $(2x + 3) \times (2) = 4x + 6$.</p>
                    <ul>
                        <li>Caso $x=10$ (Base 10): $4(10) + 6 = 46$. (Verificação: $23 \times 2 = 46$).</li>
                        <li>Caso $x=5$ (Base 5): O resultado polinomial é $4x + 6$. Mas na base 5, o dígito "6" é ilegal ($6 \ge 5$). Ajuste do coeficiente 6: $6 = 1 \times 5 + 1$. O "1" fica e o "1" sobe para o próximo termo ($4x$). Termo seguinte: $4 + 1 (\text{carry}) = 5$. O "5" é ilegal ($5 = 1 \times 5 + 0$). O "0" fica, sobe "1".</li>
                        <li>Resultado final na Base 5: $101_5$. (Verificação: $23_5 = 13_{10}$. $13 \times 2 = 26_{10}$. $26$ em base 5 é $101_5$).<li>
                    </ul>
                """
            },
            new()
            {
                Id="12",
                Statement= """
                    <p>O número "12" em uma base desconhecida $b$ vale 8 no nosso sistema decimal. Qual é a base $b$? Dica: Escreva a equação polinomial.</p>
                """,
                Solution= """
                    <p>O número $12_b$ significa $1 \cdot b^1 + 2 \cdot b^0$. Sabemos que isso é igual a 8. Equação: $1 \cdot b + 2 = 8$ $b = 8 - 2$ $b = 6$.</p>
                    <p>A base é 6.</p>
                """
            },
            new()
            {
                Id="13",
                Statement="""
                    <p>Você tem o número binário $11_2$. Se você somar 1 unidade ($1_2$), descreva o processo de "carry" (transporte) conforme a analogia do odômetro até chegar ao resultado final.</p>
                """,
                Solution= """
                    <p>Soma: $11_2 + 1_2$.</p>
                    <ul>
                        <li>Posição $2^0$ (direita): $1 + 1 = 2$. Como 2 não existe em binário ($2 = 10_2$), a roda vira 0 e "chuta" 1 para a esquerda.</li>
                        <li>Posição $2^1$ (meio): Temos o 1 original + 1 (carry). Total = 2. Novamente, vira 0 e "chuta" 1 para a esquerda.</li>
                        <li>Posição $2^2$ (esquerda): Estava vazia (0), recebe 1. Fica 1.</li>
                        <li>Resposta: Resultado $100_2$ (que vale 4).</li>
                    </ul>
                """
            },
            new()
            {
                Id="14",
                Statement= """
                    <p>Converta o número 45 para Hexadecimal (Base 16). Use a notação $0,1,...9, A, B, C, D, E, F$.</p>
                """,
                Solution= """
                    <ul>
                        <li>$45 \div 16 = 2$ com resto 13.</li>
                        <li>$2 \div 16 = 0$ com resto 2. O resto 13 corresponde à letra D (pois A=10, B=11, C=12, D=13).</li>
                        <li>Leitura inversa: 2D.</li>
                        <li>$45_{10} = 2D_{16}$.</li>
                    </ul>
                """
            },
            new()
            {
                Id="15",
                Statement="""
                    <p>Prove que $1 \times 3^2 + 4 \times 3^1 + 1 \times 3^0$ NÃO é uma representação válida na Base 3, embora matematicamente some 22. Onde o teorema foi violado?</p>
                """,
                Solution="""
                    <p>O termo do meio tem coeficiente $4$. O Teorema exige $0 \le d_i < b$. Como a base é 3, os dígitos só podem ser 0, 1 ou 2. O coeficiente 4 viola a restrição $d_i < 3$. Para corrigir, o 4 deveria ser decomposto: $4 \times 3^1 = (1 \times 3 + 1) \times 3^1 = 1 \times 3^2 + 1 \times 3^1$. A representação correta (canônica) seria: $(1+1) \cdot 3^2 + 1 \cdot 3^1 + 1 = 211_3$.</p>
                """
            },
            new()
            {
                Id="16",
                Statement= """
                    <p>O texto menciona que nos números reais $0,999... = 1$, mas diz que tal ambiguidade seria "fatal" nos números inteiros. Explique por que a unicidade de representação (garantida pelo Teorema 1.3.1) é crucial para a computação e para a validade de algoritmos. O que aconteceria com um algoritmo de comparação "SE $A == B$" se a unicidade não existisse?</p>
                """,
                Solution="""
                    <p>Se a representação não fosse única, um mesmo valor (ex: treze) poderia ter dois códigos binários diferentes (ex: 1101 e 0011 hipotéticos). Um computador verifica a igualdade comparando bit a bit. Se o mesmo número tivesse múltiplas formas de escrita, a operação lógica de igualdade ($A == B$) falharia, pois o computador diria que os números são diferentes quando representam o mesmo valor. Isso quebraria a consistência de bancos de dados, senhas e cálculos financeiros. A unicidade garante uma bijeção perfeita entre valor e símbolo.</p>
                """
            },
            new()
            {
                Id="17",
                Statement= """
                    <p>Compare escrever o número 1000 na Base 2 e na Base 10. Qual representação usa mais símbolos (comprimento da string)? Com base nisso, analise: Qual é o "custo" (trade-off) de usarmos a Base 2 nos computadores, já que ela é a "menor estrutura complexa possível"?</p>
                """,
                Solution= """
                    <ul>
                        <li>Base 10: "1000" (4 dígitos).</li>
                        <li>Base 2: $1000 \approx 2^{10} = 1024$, logo precisa de cerca de 10 bits (1111101000).</li>
                        <li>A Base 2 é extremamente ineficiente em termos de espaço visual (comprimento da string), exigindo muito mais dígitos para representar a mesma quantidade. O trade-off é que, embora a representação seja longa, a engenharia física é simplificada ao extremo: precisamos distinguir apenas 2 estados de voltagem (0 e 1) em vez de 10 níveis de voltagem precisos, o que torna o hardware robusto a ruídos.</li>
                    </ul>
                """
            },
            new()
            {
                Id="18",
                Statement= """
                    <p>No sistema posicional descrito, qual é a função estrutural do dígito 0? Por que a ausência de um símbolo para o zero impedia sistemas antigos de automatizar cálculos como a multiplicação polinomial? Use a decomposição de $101$ e $11$ como exemplo.</p>
                """,
                Solution= """
                    <p>O zero atua como um "guardador de lugar" (placeholder). Ele indica que, para aquela potência específica da base, o coeficiente é nulo, mas a posição deve ser preservada para manter a magnitude dos dígitos superiores. Sem o zero, não conseguiríamos distinguir $11$ ($1 \cdot b^1 + 1 \cdot b^0$) de $101$ ($1 \cdot b^2 + 0 \cdot b^1 + 1 \cdot b^0$). Em operações polinomiais, o zero garante que os termos de mesma potência ($x^2$ com $x^2$) fiquem alinhados corretamente nas colunas durante a adição ou multiplicação.</p>
                """
            },
            new()
            {
                Id="19",
                Statement="""
                    <p>Se definirmos um polinômio $P(x) = d_k x^k + \dots + d_0$, o texto diz que o valor numérico é apenas $P(b)$. Explique como essa visão unifica a álgebra e a aritmética. Por que dizemos que uma conta de "armar e efetuar" é apenas um caso particular de manipulação de polinômios?</p>
                """,
                Solution= """
                    <p>Quando aprendemos a somar $12 + 25$, estamos somando $(1x + 2) + (2x + 5) = 3x + 7$. O resultado 37 é válido para $x=10$. Essa visão unifica as áreas porque mostra que as regras de manipulação de símbolos (comutatividade, distributividade) são as mesmas. A única diferença é o "transporte" (carry): na álgebra de polinômios puros, não fazemos transporte ($x$ é variável). Na aritmética, como $x$ é uma constante fixa (base), acumulamos e transportamos valores que excedem a base.</p>
                """
            },
            new()
            {
                Id="20",
                Statement= """
                    <p>O texto argumenta que a Base 1 falha porque "não há estrutura polinomial". Demonstre isso tentando aplicar a fórmula $\sum d_i b^i$ para $b=1$. O que acontece com a distinção entre $d_0, d_1, d_2$? Por que isso impede a existência de um sistema "posicional"?</p>
                """,
                Solution="""
                    <p>Se $b=1$, então $b^0 = 1, b^1 = 1, b^2 = 1, \dots, b^n = 1$. A fórmula se torna $n = d_k(1) + d_{k-1}(1) + \dots + d_0(1) = \sum d_i$. O valor do número passa a ser apenas a soma simples dos dígitos, independente de onde eles estão escritos. A posição $i$ perde seu poder de amplificar o valor (magnitude). Um "1" na primeira posição vale o mesmo que um "1" na milésima posição. Sem valor relativo à posição, o sistema deixa de ser posicional e vira puramente aditivo (contagem de traços).</p>
                """
            }
        }
    };
}