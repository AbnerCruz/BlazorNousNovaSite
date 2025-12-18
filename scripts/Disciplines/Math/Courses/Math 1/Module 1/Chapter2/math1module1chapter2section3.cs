using SchoolData;

public class Math1Module1Chapter2Section3
{
    public static Topic Topic = new()
    {
        Id = "aritmetica-binaria",
        Name = "2.3 Aritmética Binária",
        Active = false,
        Body = """
            <h3>2.3 Aritmética Binária</h3>
            <p>Quando os inventores começaram a tentar mecanizar o cálculo — desde a Pascalina de Blaise Pascal até os gigantes de engrenagens de Charles Babbage, e finalmente os tubos de vácuo do ENIAC — eles esbarraram com o problema do Custo da Subtração.</p>
            <p>Pense em uma engrenagem ou em um contador de água. Para somar, você gira a roda para a frente. É um movimento natural, acumulativo. Mas e para subtrair? Mecanicamente, você precisaria de um sistema para inverter a rotação ou mecanismos complexos de "pedir emprestado" (borrow) entre as casas decimais. Eletronicamente, isso significava construir circuitos inteiramente separados: um para somar, outro para subtrair.</p>
            <p>Como podemos construir uma máquina universal que execute todas as operações, mas que, fisicamente, saiba apenas somar? Como eliminar a necessidade de "andar para trás"?</p>
            <p>A resposta exigiria que parássemos de pensar em números como linhas infinitas e começássemos a pensar neles como círculos.</p>
            <br>
            <p>Antes de chegarmos à solução elegante que seus computadores usam hoje, a humanidade tentou a abordagem óbvia: imitar a nossa escrita manual. Nós escrevemos $+3$ e $-3$. Naturalmente, os primeiros engenheiros pensaram: "Vamos reservar o primeiro bit para ser o sinal (0 para positivo, 1 para negativo) e usar o resto para o número". Isso é chamado de Sinal e Magnitude.</p>
            <p>Imagine um sistema simples de 4 bits:</p>
            <ul>
                <li>$0011$ seria $+3$</li>
                <li>$1011$ seria $-3$</li>
            </ul>
            <p>Parece lógico, não é? Mas tente construir um circuito para isso e o pesadelo começa. Se eu pedir para a máquina calcular $0011 + 1011$ ($3 + (-3)$), uma soma simples de bits resultaria em nada com sentido. A máquina precisaria de uma "Unidade Lógica" (ALU) cheia de regras condicionais: "Se os sinais forem iguais, some; se forem diferentes, verifique qual módulo é maior, subtraia o menor do maior e use o sinal do maior..."</p>
            <p>Isso é lento. Isso é complexo. E pior, gerou uma aberração lógica: o Zero Duplo. Nesse sistema, $0000$ é $+0$ e $1000$ é $-0$. Matematicamente, $0$ deve ser igual a $-0$. Mas para o computador, essas são sequências de bits diferentes. Isso desperdiça espaço de memória e exige verificações extras em cada operação lógica. A intuição humana falhou diante da eficiência da máquina. Precisávamos de uma nova matemática.</p>
            <br>
            <p>A solução veio ao abandonarmos a intuição visual e abraçarmos a Aritmética Modular. Vamos construir isso em duas etapas: primeiro, como a máquina soma; segundo, como ela subtrai somando.</p>
            <h4>2.3.1 Aritmética Aditiva e o "Carry"</h4>
            <p>No coração de qualquer processador, não há "números", apenas voltagens passando por portas lógicas. A soma binária é governada por uma regra simples, idêntica à que você aprende na escola, mas restrita a 0 e 1.</p>
            <div class="card">
                <h3>Definição 2.3.1: O Somador Completo (Full Adder)</h3>
                <p>Dados dois bits de entrada $A$ e $B$, e um transporte de entrada $C_{in}$ (o "vai-um" da casa anterior), a soma $S$ e o novo transporte $C_{out}$ são definidos pelas operações lógicas:</p>
                <p>$$S = A \oplus B \oplus C_{in}$$</p>
                <p>$$C_{out} = (A \land B) \lor (C_{in} \land (A \oplus B))$$</p>
            </div>
            <p>Para entender considere que:</p>
            <ul>
                <li>$\oplus$ é o operador XOR (Ou Exclusivo). Ele diz: "O resultado é 1 se as entradas forem diferentes, e 0 se forem iguais". Isso captura perfeitamente a aritmética de $1+1=0$ (naquela posição) e "vai um".</li>
                <li>$\land$ é o AND e $\lor$ é o OR. Eles determinam quando o transporte ($C_{out}$) deve ser acionado (quando temos pelo menos dois "1s" nas entradas).</li>
            </ul>
            <p>Essa estrutura prova que $1+1=10_2$ é a única regra necessária para construir qualquer número no universo computacional.</p>
            <h4>2.3.2 Subtração por Adição: O Complemento de 2</h4>
            <p>Aqui está a mágica. Para evitar circuitos de subtração, redefinimos o que significa ser "negativo". Em vez de um sinal negativo, usamos a ideia de um "odômetro" de carro. Se o odômetro está em $0000$ e você roda um quilômetro para trás, ele mostra $9999$. No mundo binário finito, o número negativo é aquele que, somado ao positivo, "zera" o contador (estourando a capacidade máxima).</p>
            <p>Chamamos isso de Complemento de 2.</p>
            <div class="card">
                <h3>Definição 2.3.2: Representação em Complemento de 2</h3>
                <p>Para um sistema de $n$ bits, o negativo de um número $x$, denotado $-x$, é o inverso aditivo no anel de inteiros módulo $2^n$. Formalmente:</p>
                <p>$$-x \equiv 2^n - x \pmod{2^n}$$</p>
            </div>
            <p>Isso parece abstrato? Vamos tornar operacional. Graças à álgebra modular, descobrimos um atalho computacional brilhante para encontrar esse valor sem fazer subtrações:</p>
            <div class="card">
                <h3>Teorema 2.3.1 Operacional do Inverso:</h3>
                <p>$$-x = \bar{x} + 1$$</p>
                <p>Onde $\bar{x}$ representa a inversão bit a bit (NOT lógico) de $x$.</p>
            </div>
            <p>A Prova da Subtração: Por que $A - B$ funciona se fizermos $A + (\bar{B} + 1)$? Sabemos que a soma de um número $B$ com seus bits invertidos $\bar{B}$ é sempre uma sequência de uns (ex: $101 + 010 = 111$). Em $n$ bits, isso é igual a $2^n - 1$.</p>
            <p>$$B + \bar{B} = 2^n - 1$$</p>
            <p>$$\bar{B} = (2^n - 1) - B$$</p>
            <p>Somando 1 em ambos os lados:</p>
            <p>$$\bar{B} + 1 = 2^n - B$$</p>
            <p>Observe o termo $2^n$. Em um sistema de $n$ bits, o valor $2^n$ é o "estouro" (overflow) — ele desaparece porque não cabe nos bits disponíveis (como o odômetro virando de 9999 para 0000). Logo, na aritmética modular ($\pmod{2^n}$):</p>
            <p>$$\bar{B} + 1 \equiv -B$$</p>
            <p>Transformamos a subtração em uma adição e eliminamos o problema do zero duplo (o zero agora é único: $0000$).</p>
            <h4>2.3.3 A Universalidade Algébrica</h4>
            <p>É crucial notar um ponto filosófico e matemático aqui: a Invariância de Corpo. As regras da álgebra (associatividade, distributividade) não se importam se você usa base 10, base 2 ou base 60 babilônica.</p>
            <p>$$5 \times 3 = 15$$</p>
            <p>$$0101_2 \times 0011_2 = 1111_2$$</p>
            <p>A "verdade" do número 15 existe independentemente da representação. A base binária é apenas uma "roupagem" eficiente para as mesmas verdades eternas que Euclides estudava.</p>
            <br>
            <h4>Aplicações</h4>
            <p><strong>Aplicação 2.3.1</strong> Graças ao Complemento de 2, os processadores modernos (como o do dispositivo onde você lê isto) não possuem circuitos de subtração. A ALU contém apenas somadores. Quando o programa pede $5 - 3$, o hardware inverte os bits do 3, soma 1, e joga o resultado no somador junto com o 5. Essa simplificação economizou bilhões de transistores ao longo da história e reduziu drasticamente o consumo de energia e a complexidade dos chips. A teoria matemática pura gerou eficiência física direta.</p>
            <p><strong>Aplicação 2.3.2</strong> A aritmética modular tem um efeito colateral perigoso: o Overflow (Estouro). Em Complemento de 2, o bit mais à esquerda atua como indicador de sinal. Se você tem um número positivo máximo (ex: $0111... = +127$ em 8 bits) e soma $1$, o resultado é $1000...$, que o sistema lê como $-128$. Você "deu a volta" no círculo numérico e caiu no negativo.</p>
            <p>Isso gerou um dos bugs mais famosos da história dos games. No jogo Civilization, o líder indiano Gandhi tinha um nível de agressividade definido como 1 (o mínimo). Se o jogador adotasse a democracia, a agressividade caía em 2. Matematicamente: $1 - 2 = -1$. Mas o computador, usando aritmética modular em uma variável não preparada para negativos, interpretou esse "retorno" como o maior valor positivo possível ($255$). Resultado: O pacífico Gandhi tornava-se subitamente um maníaco nuclear. Esse é o lembrete de que, na computação, a matemática é finita e cíclica.</p>
            <br>
            <h4>Resumo</h4>
            <div class="card">
                <p><strong>Soma Binária (Full Adder):</strong> A base de tudo. Opera com lógica $XOR$ para a soma e $AND/OR$ para o transporte (carry). É a única operação real que o processador faz.</p>
                <p><strong>Complemento de 2:</strong> A "cura" para a subtração. Definimos $-x$ como $\bar{x} + 1$. Isso transforma problemas de subtração em problemas de adição, permitindo que o hardware seja simples e unificado.</p>
                <p>Aritmética Modular: O computador não conta em uma linha reta infinita, mas em um círculo. O estouro ($2^n$) é descartado, o que faz a matemática funcionar, mas cria o risco de Overflow se não formos cuidadosos.</p>
            </div>
        """,
        Problems = new()
        {
            new()
            {
                Id="1",
                Statement= """
                    <p>No contexto da mecanização do cálculo (da Pascalina ao ENIAC), qual foi o principal obstáculo físico e lógico ("A Dor Intelectual") para a criação de uma máquina universal de cálculo e por que a adição não sofria do mesmo problema?</p>
                """,
                Solution= """
                    <ul>
                        <li>O Obstáculo: O "Custo da Subtração".</li>
                        <li>A Razão: Somar é um processo acumulativo natural (girar uma engrenagem para frente). Subtrair exige inverter a rotação ou criar mecanismos complexos de empréstimo (borrow) entre casas decimais. Eletronicamente, isso exigiria circuitos duplicados (um para somar, outro para subtrair), aumentando o tamanho e o calor da máquina.</li>
                    </ul>
                """
            },
            new()
            {
                Id="2",
                Statement= """
                    <p>O sistema de "Sinal e Magnitude" tenta imitar a escrita humana reservando um bit para o sinal. Qual "aberração lógica" esse sistema cria em relação ao número zero e por que isso é ineficiente para computadores?</p>
                """,
                Solution= """
                    <ul>
                        <li>A Aberração: A existência de dois zeros: $+0$ ($0000$) e $-0$ ($1000$).</li>
                        <li>A Ineficiência: Matematicamente, $0$ é igual a $-0$. Computacionalmente, desperdiça-se um estado de memória e exige-se que a Unidade Lógica e Aritmética (ALU) faça verificações extras em cada operação para tratar esses dois valores binários diferentes como iguais.</li>
                    </ul>
                """
            },
            new()
            {
                Id="3",
                Statement= """
                    <p>De acordo com a Definição 2.3.1, qual porta lógica é responsável por calcular o bit de Soma ($S$) e qual propriedade aritmética básica ela captura?</p>
                """,
                Solution= """
                    <ul>
                        <li>Porta Lógica: A porta XOR ($\oplus$, Ou Exclusivo).</li>
                        <li>Propriedade: Ela captura a aritmética de $1+1=0$ (na posição atual) e a necessidade de gerar um transporte. Ela resulta em 1 apenas se as entradas forem diferentes.</li>
                    </ul>
                """
            },
            new()
            {
                Id="4",
                Statement= """
                    <p>Qual é a definição formal de um número negativo ($-x$) em um sistema de $n$ bits usando Complemento de 2, baseada na aritmética modular?</p>
                """,
                Solution= """
                    <ul>
                        <li>Definição: O negativo de $x$ é o inverso aditivo no anel de inteiros módulo $2^n$.</li>
                        <li>Fórmula: $-x \equiv 2^n - x \pmod{2^n}$.</li>
                    </ul>
                """
            },
            new()
            {
                Id="5",
                Statement= """
                    <p>ara evitar a subtração direta, utilizamos um "atalho" computacional descrito no Teorema 2.3.1. Qual é a fórmula operacional para encontrar o complemento de 2 de um número $x$?</p>
                """,
                Solution= """
                    <ul>
                        <li>Fórmula: $-x = \bar{x} + 1$.</li>
                        <li>Significado: Inverte-se todos os bits de $x$ (operação NOT) e soma-se 1 ao resultado.</li>
                    </ul>
                """
            },
            new()
            {
                Id="6",
                Statement= """
                    <p>Dado o número binário $A = 0101_2$ (que representa 5 em decimal), calcule $\bar{A}$ (o inverso bit a bit).</p>
                """,
                Solution= """
                    <ul>
                        <li>Escreva o número original: $0101$.</li>
                        <li>Aplique a operação NOT (troque 0 por 1 e 1 por 0).</li>
                        <li>Resultado: $\bar{A} = 1010_2$.</li>
                    </ul>
                """
            },
            new()
            {
                Id="7",
                Statement= """
                    <p>Utilizando um sistema de 4 bits, encontre a representação binária de $-5$. Use o Teorema Operacional ($\bar{x} + 1$).</p>
                """,
                Solution= """
                    <ul>
                        <li>Representação de $+5$ em 4 bits: $x = 0101$.</li>
                        <li>Inverter os bits ($\bar{x}$): $1010$.</li>
                        <li>
                            Somar 1: $1010 + 0001$.
                            <ul>
                                <li>$0+1 = 1$</li>
                                <li>$1+0 = 1$</li>
                                <li>$0+0 = 0$</li>
                                <li>$1+0 = 1$</li>
                            </ul>
                        </li>
                        <li>Resultado: $-5 = 1011_2$.</li>
                    </ul>
                """
            },
            new()
            {
                Id="8",
                Statement= """
                    <p>Realize a operação $7 - 2$ utilizando aritmética binária de 4 bits e Complemento de 2. Mostre que a operação se torna uma soma.</p>
                """,
                Solution= """
                    <ul>
                        <li>
                            Converter operandos para binário (4 bits):
                            <ul>
                                <li>$7 \to 0111$</li>
                                <li>$2 \to 0010$</li>
                            </ul>
                        </li>
                        <li>
                            Encontrar o Complemento de 2 de 2 (para representar $-2$):
                            <ul>
                                <li>Inverso de $0010$ é $1101$.</li>
                                <li>Soma 1: $1101 + 1 = 1110$. (Logo, $-2 = 1110$).</li>
                            </ul>
                        </li>
                        <li>
                            Realizar a soma $7 + (-2)$:
                            <ul>
                                <li>$0111 + 1110 = 10101$</li>
                            </ul>
                        </li>
                        <li>Descartar o 5º bit (overflow em sistema de 4 bits).</li>
                        <li>Resultado: $0101_2$ (que equivale a 5 em decimal). A conta fecha.</li>
                    </ul>
                """
            },
            new()
            {
                Id="9",
                Statement= """
                    <p>Realize a operação $2 - 5$ em um sistema de 4 bits usando Complemento de 2.</p>
                """,
                Solution= """
                    <ul>
                        <li>Operandos: $2 \to 0010$, $5 \to 0101$.</li>
                        <li>
                            Achar Complemento de 2 de 5 ($-5$):
                            <ul>
                                <li>Inverso de $0101 \to 1010$.</li>
                                <li>Soma 1: $1010 + 1 = 1011$.</li>
                            </ul>
                        </li>
                        <li>
                            Soma $2 + (-5)$:
                            <ul>
                                <li>$0010 + 1011 = 1101$</li>
                            </ul>
                        </li>
                        <li>
                            Resultado: $1101_2$.
                            <ul>
                                <li>Verificação: Como o bit mais à esquerda é 1, o número é negativo. Para saber a magnitude, invertemos e somamos 1 novamente: Inverso de $1101 \to 0010$; Soma 1 $\to 0011$ (3). Logo, o resultado é $-3$.</li>
                            </ul>
                        </li>
                    </ul>
                """
            },
            new()
            {
                Id="10",
                Statement= """
                    <p>Em um circuito somador, temos as entradas $A=1$, $B=1$ e $C_{in}=1$. Calcule os valores de saída $S$ e $C_{out}$ usando as fórmulas lógicas.</p>
                """,
                Solution= """
                    <ul>
                        <li>
                            Fórmula Soma: $S = A \oplus B \oplus C_{in}$.
                            <ul>
                                <li>$1 \oplus 1 = 0$.</li>
                                <li>$0 \oplus 1 = 1$.</li>
                                <li>$S = 1$.</li>
                            </ul>
                        </li>
                        <li>
                            Fórmula Carry: $C_{out} = (A \land B) \lor (C_{in} \land (A \oplus B))$.
                            <ul>
                                <li>$(1 \land 1) = 1$.</li>
                                <li>$(A \oplus B) = 0 \to (1 \land 0) = 0$.</li>
                                <li>$1 \lor 0 = 1$.</li>
                                <li>$C_{out} = 1$.</li>
                            </ul>
                        </li>
                        <li>Resultado binário: $11$ (que é 3 em decimal, correto para $1+1+1$).</li>
                    </ul>
                """
            },
            new()
            {
                Id="11",
                Statement= """
                    <p>Converta o número decimal 13 para binário usando o método das divisões sucessivas por 2.</p>
                """,
                Solution= """
                    <ul>
                        <li>$13 \div 2 = 6$, resto 1.</li>
                        <li>$6 \div 2 = 3$, resto 0.</li>
                        <li>$3 \div 2 = 1$, resto 1.</li>
                        <li>$1 \div 2 = 0$, resto 1.</li>
                        <li>Ler os restos de baixo para cima.</li>
                        <li>Resultado: $1101_2$.</li>
                    </ul>
                """
            },
            new()
            {
                Id="12",
                Statement= """
                    <p>Em um sistema de 4 bits com sinal (Complemento de 2), o maior número positivo é $+7$ ($0111$). O que acontece binariamente se somarmos 1 a ele? Interprete o resultado.</p>
                """,
                Solution= """
                    <ul>
                        <li>
                            Operação: $0111 + 0001$.
                            <ul>
                                <li>$1+1 = 10$ (fica 0, vai 1).</li>
                                <li>$1+1 = 10$ (fica 0, vai 1).</li>
                                <li>$1+1 = 10$ (fica 0, vai 1).</li>
                                <li>$0+1 = 1$.</li>
                            </ul>
                        </li>
                        <li>Resultado Binário: $1000_2$.</li>
                        <li>Interpretação: Em complemento de 2, o bit mais significativo $1$ indica negativo. O valor $1000$ representa $-8$. Ocorreu Overflow: $7 + 1 = -8$.</li>
                    </ul>
                """
            },
            new()
            {
                Id="13",
                Statement= """
                    <p>Quantos valores únicos podem ser representados em 8 bits usando a notação estrita de (A) Sinal e Magnitude vs (B) Complemento de 2?</p>
                """,
                Solution= """
                    <ul>
                        <li>otal de combinações em 8 bits: $2^8 = 256$.</li>
                        <li>(A) Sinal e Magnitude: Devido ao zero duplo ($+0$ e $-0$), representamos apenas $255$ números únicos (de $-127$ a $+127$).</li>
                        <li>(B) Complemento de 2: O zero é único. Representamos 256 números únicos (de $-128$ a $+127$).</li>
                    </ul>
                """
            },
            new()
            {
                Id="14",
                Statement= """
                    <p>Se um sistema opera em módulo 16 (4 bits), qual é o resultado de $10 + 8 \pmod{16}$?</p>
                """,
                Solution= """
                    <ul>
                        <li>Soma aritmética: $10 + 8 = 18$.</li>
                        <li>Aplicar módulo: $18 \div 16 = 1$ com resto 2.</li>
                        <li>Resultado: $2$ (Binariamente: $0010$). O "1" da dezena (16) foi descartado como overflow.</li>
                    </ul>
                """
            },
            new()
            {
                Id="15",
                Statement= """
                    <p>No jogo Civilization, a agressividade era armazenada em 8 bits sem sinal (0 a 255). Gandhi tinha agressividade 1. A democracia reduzia a agressividade em 2. Calcule $1 - 2$ em binário de 8 bits (sem sinal) e converta para decimal.</p>
                """,
                Solution= """
                    <ul>
                        <li>Binário de 1: $00000001$.</li>
                        <li>
                            Subtrair 2 é somar o complemento de 2 de 2 em 8 bits.
                            <ul>
                                <li>$2 = 00000010$. Inverso $\to 11111101$. Soma 1 $\to 11111110$ (isso representa -2).</li>
                            </ul>
                        </li>
                        <li>Soma: $00000001 + 11111110 = 11111111$.</li>
                        <li>Como a variável no jogo era unsigned (sem sinal), $11111111$ não é lido como -1, mas como magnitude total.</li>
                        <li>Resultado: $255$ (Agressividade máxima).</li>
                    </ul>
                """
            },
            new()
            {
                Id="16",
                Statement= """
                    <p>Analise a equação $\bar{B} + 1 = 2^n - B$. Por que o termo $2^n$ é crucial para transformar a subtração em adição e por que ele "desaparece" na prática da engenharia?</p>
                """,
                Solution= """
                    <ul>
                        <li>Análise: O termo $2^n$ representa matematicamente o módulo do sistema (o ponto onde o ciclo reinicia).</li>
                        <li>Engenharia: Em um registrador de $n$ bits, o valor $2^n$ exigiria um bit $n+1$ (ex: em 4 bits, $2^4=16$ é $10000$). Como o hardware fisicamente só tem $n$ fios de saída, esse bit extra é descartado eletricamente.</li>
                        <li>Conclusão: Ao descartar o $2^n$, a igualdade matemática se torna uma congruência modular, permitindo que a soma com o complemento produza o mesmo padrão de bits que a subtração real.</li>
                    </ul>
                """
            },
            new()
            {
                Id="17",
                Statement= """
                    <p>Se fôssemos projetar um processador usando "Sinal e Magnitude" em vez de "Complemento de 2", descreva detalhadamente como a Unidade Lógica Aritmética (ALU) teria que processar a operação $A + B$.</p>
                """,
                Solution= """
                    <p>A ALU precisaria de um algoritmo condicional complexo:</p>
                    <ul>
                        <li>Comparar os bits de sinal de A e B.</li>
                        <li>SE sinais iguais: Somar as magnitudes e manter o sinal.</li>
                        <li>SE sinais diferentes: Comparar as magnitudes (quem é maior?).</li>
                        <li>Subtrair a magnitude menor da maior.</li>
                        <li>Atribuir ao resultado o sinal do número de maior magnitude. Conclusão: Isso exige circuitos comparadores e subtratores dedicados, além de maior latência (tempo de resposta), enquanto o Complemento de 2 usa apenas um circuito somador cego para todos os casos.</li>
                    </ul>
                """
            },
            new()
            {
                Id="18",
                Statement= """
                    <p>O texto afirma que "A verdade do número 15 existe independentemente da representação". Explique como a propriedade distributiva $A \times (B + C) = A \times B + A \times C$ se sustenta se mudarmos da base 10 para a base 2. Use $A=2, B=1, C=1$ como exemplo.</p>
                """,
                Solution= """
                    <ul>
                        <li>Base 10: $2 \times (1 + 1) = 2 \times 2 = 4$. E $(2\times1) + (2\times1) = 2 + 2 = 4$.</li>
                        <li>
                            Base 2: $A=10_2, B=1_2, C=1_2$.
                            <li>Lado esquerdo: $10_2 \times (1_2 + 1_2) = 10_2 \times 10_2 = 100_2$.</li>
                            <li>Lado direito: $(10_2 \times 1_2) + (10_2 \times 1_2) = 10_2 + 10_2 = 100_2$.</li>
                        </li>
                        <li>Análise: $100_2$ é igual a 4. A estrutura lógica (corpo matemático) é invariante; apenas os símbolos mudam. Isso prova que a matemática computacional não é uma "nova matemática", mas uma nova notação para as mesmas leis universais.</li>
                    </ul>
                """
            },
            new()
            {
                Id="19",
                Statement= """
                    <p>Na matemática tradicional, podemos escrever números negativos infinitamente ($-5, -500, -5000$). Por que o conceito de Complemento de 2 colapsaria sem a definição rígida de uma largura de bits (ex: "sistema de 8 bits")?</p>
                """,
                Solution= """
                    <p>O Complemento de 2 depende do "estouro" para funcionar. Sem um teto definido ($n$ bits), não existe o valor $2^n$ para atuar como o módulo (o ponto de retorno do círculo). Por exemplo, o padrão binário $111$ é $-1$ em um sistema de 3 bits, mas é $+7$ em um sistema de 4 bits ($0111$). Sem fixar a largura, o bit mais à esquerda perde seu significado de sinal e a aritmética modular perde sua referência de "onde está o zero".</p>
                """
            },
            new()
            {
                Id="20",
                Statement= """
                    <p>Compare as Bases Naturais (Seção 1.1) com a Base Binária (Seção 2.2). Por que a humanidade evoluiu usando base 10 ou 12 para comércio, mas foi obrigada a regredir para a base 2 (a menor base possível) para criar inteligência artificial?</p>
                """,
                Solution= """
                    <ul>
                        <li>Humano (Base 10/12): Otimizada para divisibilidade e contagem manual (dedos/falanges). Alta densidade de informação (um símbolo "9" vale muito). Prioriza a compactação para o cérebro.</li>
                        <li>Máquina (Base 2): Otimizada para robustez física. Distinguir entre 10 níveis de voltagem (para base 10) seria propenso a erros devido a ruído elétrico. Distinguir apenas "Ligado/Desligado" (Base 2) é extremamente seguro e estável. A máquina troca a densidade de informação pela segurança do estado (Minimização de Estados, Seção 2.1).</li>
                    </ul>
                """
            }
        }
    };
}