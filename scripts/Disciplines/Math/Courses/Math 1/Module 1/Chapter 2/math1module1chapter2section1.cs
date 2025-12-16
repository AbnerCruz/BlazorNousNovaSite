using SchoolData;

public class Math1Module1Chapter2Section1
{
    public static Topic Topic = new()
    {
        Id = "minimizacao-de-estados",
        Name = "2.1 Minimização de Estados",
        Active = true,
        Body = """
            <h3>2.1 Minimização de Estados</h3>
            <p>No capítulo anterior, nós celebramos o sistema Decimal. Vimos como ele é uma maravilha da "eficiência de escrita": com apenas dez símbolos, podemos escrever o número de átomos no universo em uma única linha de papel.</p>
            <p>Mas, em meados do século XX, quando matemáticos e engenheiros tentaram tirar os números do papel e colocá-los dentro de máquinas elétricas, eles colidiram com uma barreira fundamental. Eles descobriram que o que é eficiente para a mente humana é catastrófico para a engenharia física.</p>
            <p>Imagine que você quer construir um computador elétrico que "pense" em Base 10. Você decide usar voltagem para representar números. O fio elétrico opera entre $0$ Volts e $5$ Volts. Para representar os dez algarismos ($0, 1, 2, ..., 9$), você precisa fatiar essa faixa de $5V$ em dez pedaços distintos.</p>
            <ul>
                <li>$0 \to 0.0V$</li>
                <li>$1 \to 0.5V$</li>
                <li>$2 \to 1.0V$</li>
                <li>...</li>
                <li>$9 \to 4.5V$</li>
            </ul>
            <p>O mundo físico é sujo. Um motor ligado na sala ao lado, uma variação na temperatura ou uma simples onda de rádio cria interferência. Se o seu fio sofrer um "tremor" de apenas $0.3V$ (o que é muito comum), o sinal que era para ser um $2$ ($1.0V$) de repente vira $1.3V$. A máquina fica confusa: "Isso é um 2 ou está quase virando um 3?". Para construir máquinas mais poderosas, precisávamos de um sistema numérico menos eficiente na escrita, mas infinitamente mais robusto na prática.</p>
            <p>Antes de aceitarmos o sistema binário, nós lutamos bravamente para manter a nossa amada Base 10. A história da computação está cheia de protótipos mecânicos dessa insistência.</p>
            <p>Charles Babbage, no século XIX, projetou suas máquinas com engrenagens de 10 dentes. A ideia era mecânica e intuitiva: gire a roda três "cliques" e você tem o número 3. Funcionava na teoria. Mas na prática? O atrito, o desgaste do metal e a folga entre os dentes acumulavam erros. Uma engrenagem ligeiramente gasta poderia parar na posição "3 e meio". Em uma máquina com milhares de engrenagens, o erro se propagava travando todo o cálculo.</p>
            <p>Posteriormente, os primeiros computadores eletrônicos (como o ENIAC em seus estágios iniciais) tentaram usar anéis de 10 válvulas para simular a contagem decimal. O resultado foi um monstro de complexidade: milhares de cabos, calor excessivo e muitas falhas.</p>
            <p>A intuição geométrica nos dizia o seguinte: "Se eu tenho uma estrada larga (0 a 5V), por que não desenhar várias faixas nela?". A resposta da física é porque se as faixas forem muito estreitas, os carros vão bater. Precisávamos parar de perguntar "O sinal é 1, 2, 3 ou 4?" e mudar a pergunta para algo que a física pudesse responder sem ambiguidade. A pergunta deveria ser: "Existe sinal ou não existe sinal?".</p>
            <br>
            <p>Para resolver o problema do ruído, precisamos formalizar o conceito de Discretização e provar matematicamente por que reduzir a base aumenta a segurança. Vamos definir um sistema de comunicação digital abstrato.</p>
            <div class="card">
                <h3>Definição 2.1.1 Espaço de Estados Físicos</h3>
                <p>Seja $S$ um conjunto finito de estados que um sistema físico pode assumir para representar informação. Se o sistema opera em uma base $b$, então a cardinalidade (o tamanho) de $S$ é igual a $b$:</p>
                <p>$$S = \{s_0, s_1, s_2, \dots, s_{b-1}\}$$</p>
            </div>
            <br>
            <p>Agora, precisamos mapear esses estados para uma grandeza física contínua, como a Voltagem ($V$). Suponha que temos uma Amplitude Total disponível, que chamaremos de $A$ (por exemplo, 5 Volts).</p>
            <p>Para distinguir um estado $s_i$ do seu vizinho $s_{i+1}$, precisamos garantir uma distância segura entre eles. Vamos chamar essa distância de $\Delta V$ (Delta V). A relação entre a base $b$ e a margem de segurança $\Delta V$ é dada pela seguinte equação, que é a pedra angular da eletrônica digital:</p>
            <p>$$\Delta V = \frac{A}{b - 1}$$</p>
            <p>Vamos dissecar isso.</p>
            <ul>
                <li>$\Delta V$: É a nossa "margem de manobra". Quanto maior este valor, mais ruído o sistema aguenta sem errar.</li>
                <li>$A$: É o recurso físico total (ex: 5 Volts). É fixo pelas leis da termodinâmica e dos materiais.</li>
                <li>$b - 1$: É o número de intervalos (espaços vazios) entre os estados. Se você tem 10 estados (dedos), você tem 9 espaços entre eles.</li>
            </ul>
            <br>
            <div class="card">
                <h3>Teorema 2.1.1 Teorema da Robustez</h3>
                <p>Agora, vamos comparar a robustez ($R$) de um sistema Decimal ($b=10$) contra um sistema Binário ($b=2$).</p>
                <ul>
                    <li>Caso Decimal ($b=10$):</li>
                    <p>$$\Delta V_{dec} = \frac{A}{10 - 1} = \frac{A}{9} \approx 0,11 \cdot A$$</p>
                </ul>
                <p>Em um sistema de 5V, a margem de segurança é de apenas $0,55V$. Qualquer ruído acima disso corrompe o dado.</p>
                <ul>
                    <li>Caso Binário ($b=2$):</li>
                    <p>$$\Delta V_{bin} = \frac{A}{2 - 1} = \frac{A}{1} = A$$</p>
                </ul>
                <p>Em um sistema de 5V, a margem de segurança é os próprios $5V$ inteiros! Para confundir um $0$ com um $1$ no sistema binário, o ruído teria que ser tão colossal que seria quase uma catástrofe elétrica, não uma simples interferência.</p>
            </div>
            <br>
            <h4>Economia de Radix</h4>
            <p>Se menos é mais, por que não base 1? A Base 1 (sistema unário) é inútil para computação posicional. Matematicamente, existe um ponto ótimo de eficiência de armazenamento (densidade de informação) que ocorre na base $e$ (número de Euler, $\approx 2.718$). O número inteiro mais próximo é $3$. Computadores ternários (base 3) foram tentados pelos soviéticos (o computador Setun), mas a complexidade técnica de manter 3 estados estáveis ainda perdia para a simplicidade bruta de 2 estados. A engenharia escolheu a segurança máxima ($b=2$) em vez da eficiência teórica de armazenamento.</p>
            <br>
            <h4>Aplicações</h4>
            <p><strong>Aplicação 2.1.1</strong> O componente básico de todos os chips modernos, o transistor, funciona melhor quando não é forçado a ser sutil. Ele é um interruptor.</p>
            <ul>
                <li>Corte (Cut-off): O transistor bloqueia totalmente a corrente. Isso é o $0$. É estável e frio.</li>
                <li>Saturação (Saturation): O transistor deixa passar toda a corrente possível. Isso é o $1$. Também é estável.</li>
            </ul>
            <p>Ao ignorar a "região linear" (o meio do caminho), os engenheiros eliminaram a necessidade de calibração fina. Bilhões de transistores podem ser impressos em um chip sem que precisemos ajustar cada um individualmente, pois eles só precisam saber a diferença entre "Ligado" e "Desligado".</p>
            <p><strong>Aplicação 2.1.2</strong> No século XIX, George Boole criou uma álgebra para a verdade, onde tudo era Verdadeiro ou Falso. Por muito tempo, isso foi apenas filosofia. Quando adotamos o sistema binário ($0$ e $1$) por necessidade física, descobrimos um acidente feliz: o Hardware ($0/1$) e a Lógica ($Falso/Verdadeiro$) são Isomorfos (correspondência biunívoca), isto é, bijeção.</p>
            <ul>
                <li>$0$ Volts $\leftrightarrow$ Falso</li>
                <li>$5$ Volts $\leftrightarrow$ Verdadeiro</li>
            </ul>
            <p>Isso permitiu que não precisássemos inventar uma "matemática de voltagem". Pudemos simplesmente pegar toda a lógica de Aristóteles e Boole e "despejá-la" dentro do silício. O computador não "calcula" voltagens; ele manipula proposições lógicas fisicamente manifestadas.</p>
            <br>
            <h4>Resumo</h4>
            <div class="card">
                <p><strong>O Inimigo é o Ruído:</strong> Em sistemas físicos, a precisão infinita é impossível. Tentar dividir uma voltagem em 10 partes (Decimal) cria margens de erro perigosamente pequenas.</p>
                <p><strong>Minimização para Robustez:</strong> A fórmula $\Delta V = \frac{A}{b-1}$ prova que quanto menor a base $b$, maior a distância entre os estados.</p>
                <p><strong>A Supremacia do Binário:</strong> A base 2 oferece a separação máxima possível entre sinais (Distância = Amplitude Total), tornando o sistema virtualmente imune a pequenas interferências.</p>
                <p><strong>Isomorfismo Físico-Lógico:</strong> A escolha de dois estados permitiu unificar a Engenharia Elétrica (On/Off) com a Lógica Matemática (Verdadeiro/Falso), criando a linguagem universal da computação.</p>
            </div>
        """,
        Problems = new()
        {
            new()
            {
                Id="1",
                Statement= """
                    <p>De acordo com a Definição 2.1.1, se um sistema físico opera em Base 8 (octal), qual é a cardinalidade do conjunto de estados $S$ e quais são os elementos desse conjunto?</p>
                """,
                Solution= """
                    <ul>
                        <li>A definição afirma que a cardinalidade (tamanho) de $S$ é igual à base $b$. Logo, se $b=8$, a cardinalidade é 8.</li>
                        <li>O conjunto é formado por estados de $s_0$ até $s_{b-1}$.</li>
                        <li>Resposta: $S = \{s_0, s_1, s_2, s_3, s_4, s_5, s_6, s_7\}$.</li>
                    </ul>
                """
            },
            new()
            {
                Id="2",
                Statement= """
                    <p>O texto menciona que tentar dividir uma voltagem de 5V em 10 partes cria uma "margem de segurança" pequena. O que acontece se um "ruído" (interferência externa) for maior que essa margem de segurança em um sistema decimal analógico?</p>
                """,
                Solution= """
                    <ul>
                        <li>A margem de segurança define o limite entre um número e outro (ex: entre o 2 e o 3).</li>
                        <li>Se o ruído excede essa margem, o valor de voltagem invade a faixa do número vizinho.</li>
                        <li>Resposta: A máquina interpreta o dado incorretamente (ex: lê um 3 onde deveria ser um 2), corrompendo o cálculo e causando instabilidade no sistema.</li>
                    </ul>
                """
            },
            new()
            {
                Id="3",
                Statement= """
                    <p>O texto descreve um "acidente feliz" entre a física e a lógica. Qual é a correspondência biunívoca (bijeção) estabelecida entre os estados do Hardware e a Álgebra de Boole?</p>
                """,
                Solution= """
                    <ul>
                        <li>Identificamos os estados físicos extremos: 0 Volts (sem corrente) e Voltagem Máxima (corrente total).</li>
                        <li>Identificamos os estados lógicos de Boole: Falso e Verdadeiro.</li>
                        <li>A correspondência é: $0$ (Hardware) $\leftrightarrow$ Falso (Lógica) e $1$ (Hardware) $\leftrightarrow$ Verdadeiro (Lógica).</li>
                    </ul>
                """
            },
            new()
            {
                Id="4",
                Statement= """
                    <p>Na Aplicação 2.1.1, descreve-se que o transistor moderno opera em duas regiões extremas para evitar a "região linear". Quais são essas duas regiões e o que elas representam em bits?</p>
                """,
                Solution= """
                    <ul>
                        <li>Região 1: Corte (Cut-off) $\rightarrow$ Bloqueia corrente.</li>
                        <li>Região 2: Saturação (Saturation) $\rightarrow$ Passa corrente total.</li>
                        <li>Resposta: As regiões são Corte (representando o bit 0) e Saturação (representando o bit 1).</li>
                    </ul>
                """
            },
            new()
            {
                Id="5",
                Statement= """
                    <p>Matematicamente, qual é a base "ideal" teórica para densidade de informação (eficiência de armazenamento) e qual foi a base escolhida pela engenharia devido à segurança?</p>
                """,
                Solution= """
                    <ul>
                        <li>O texto cita o número de Euler ($e \approx 2.718$) como a base teórica mais eficiente.</li>
                        <li>O inteiro mais próximo seria 3, mas a engenharia optou por 2.</li>
                        <li>A base ideal teórica é a Base $e$ (ou Base 3, se considerarmos apenas inteiros), mas a engenharia escolheu a Base 2 (Binária) pela robustez contra ruídos.</li>
                    </ul>
                """
            },
            new()
            {
                Id="6",
                Statement= """
                    <p>Um engenheiro decide criar um computador experimental em Base 5 usando uma amplitude total ($A$) de 10 Volts. Calcule a margem de segurança ($\Delta V$) entre os estados.</p>
                """,
                Solution= """
                    <ul>
                        <li>Fórmula: $\Delta V = \frac{A}{b - 1}$</li>
                        <li>Dados: $A = 10$, $b = 5$.</li>
                        <li>Substituição: $\Delta V = \frac{10}{5 - 1} = \frac{10}{4}$</li>
                        <li>Cálculo: $\Delta V = 2.5$</li>
                        <li>Resposta: A margem de segurança é de 2.5 Volts.</li>
                    </ul>
                """
            },
            new()
            {
                Id="7",
                Statement= """
                    <p>Usando o mesmo sistema do exercício anterior ($A = 10$ Volts), calcule qual seria a margem de segurança se usássemos a Base 10. Compare com o resultado da Base 5.</p>
                """,
                Solution= """
                    <ul>
                        <li>Fórmula: $\Delta V = \frac{A}{b - 1}$</li>
                        <li>Dados: $A = 10$, $b = 10$.</li>
                        <li>Substituição: $\Delta V = \frac{10}{10 - 1} = \frac{10}{9}$</li>
                        <li>Cálculo: $\Delta V \approx 1.11$ Volts.</li>
                        <li>Resposta: A margem é de aproximadamente 1.11 Volts. Ela é menos da metade da margem da Base 5, tornando o sistema muito mais suscetível a erros.</li>
                    </ul>
                """
            },
            new()
            {
                Id="8",
                Statement= """
                    <p>Converta o número decimal 13 para a base Binária (Base 2) utilizando o método das divisões sucessivas. Mostre os quocientes e restos.</p>
                """,
                Solution= """
                    <ul>
                        <li>$13 \div 2$: Quociente = 6, Resto = 1 (LSB - bit menos significativo)</li>
                        <li>$6 \div 2$: Quociente = 3, Resto = 0</li>
                        <li>$3 \div 2$: Quociente = 1, Resto = 1</li>
                        <li>$1 \div 2$: Quociente = 0, Resto = 1 (MSB - bit mais significativo)</li>
                        <li>Lemos os restos de baixo para cima (do último para o primeiro).</li>
                        <li>Resposta: $13_{10} = 1101_2$.</li>
                    </ul>
                """
            },
            new()
            {
                Id="9",
                Statement= """
                    <p>O texto menciona computadores ternários (Base 3). Converta o número decimal 14 para a Base 3.</p>
                """,
                Solution= """
                    <ul>
                        <li>$14 \div 3$: Quociente = 4, Resto = 2</li>
                        <li>$4 \div 3$: Quociente = 1, Resto = 1</li>
                        <li>$1 \div 3$: Quociente = 0, Resto = 1</li>
                        <li>Leitura inversa dos restos.</li>
                        <li>Resposta: $14_{10} = 112_3$.</li>
                    </ul>
                """
            },
            new()
            {
                Id="10",
                Statement= """
                    <p>Você tem um sistema com Amplitude Total $A = 12$ Volts. Você precisa de uma margem de segurança de pelo menos 4 Volts entre os estados. Qual é a maior base inteira $b$ que você pode usar?</p>
                """,
                Solution= """
                    <ul>
                        <li>Fórmula: $\Delta V = \frac{A}{b - 1}$. Queremos $\Delta V \geq 4$.</li>
                        <li>Inequação: $\frac{12}{b - 1} \geq 4$.</li>
                        <li>Isolando $(b-1)$: $12 \geq 4(b - 1) \rightarrow 3 \geq b - 1$.</li>
                        <li>Isolando $b$: $3 + 1 \geq b \rightarrow 4 \geq b$.</li>
                        <li>Resposta: A maior base possível é a Base 4.</li>
                    </ul>
                """
            },
            new()
            {
                Id="11",
                Statement= """
                    <p>Converta o número binário $1011_2$ de volta para decimal usando a decomposição polinomial (soma das potências de 2).</p>
                """,
                Solution= """
                    <ul>
                        <li>
                            Mapear posições (da direita para esquerda, começando em 0):
                            <ul>
                                <li>$1$ (pos 3), $0$ (pos 2), $1$ (pos 1), $1$ (pos 0).</li>
                            </ul>
                        </li>
                        <li>Montar polinômio: $1 \cdot 2^3 + 0 \cdot 2^2 + 1 \cdot 2^1 + 1 \cdot 2^0$.</li>
                        <li>Calcular potências: $1 \cdot 8 + 0 \cdot 4 + 1 \cdot 2 + 1 \cdot 1$.</li>
                        <li>Soma: $8 + 0 + 2 + 1 = 11$.</li>
                        <li>Resposta: $11_{10}$.</li>
                    </ul>
                """
            },
            new()
            {
                Id="12",
                Statement= """
                    <p>Em um sistema binário de 5V ($A=5, b=2$), a margem $\Delta V$ é 5V. Se ocorrer um pico de ruído de 2V em um fio que deveria estar em 0V, o sistema irá interpretar o dado erroneamente? (Considere que a troca de estado ocorre na metade da amplitude, 2.5V).</p>
                """,
                Solution= """
                    <ul>
                        <li>Estado 0 está em 0V.</li>
                        <li>O limiar de decisão geralmente é $A/2 = 2.5V$.</li>
                        <li>Sinal com ruído = $0V + 2V = 2V$.</li>
                        <li>Comparação: $2V < 2.5V$. O sinal ainda está abaixo do limiar de troca.</li>
                        <li>Resposta: Não, o sistema não errará. O valor 2V ainda é interpretado como 0 lógico, pois não ultrapassou a metade da margem.</li>
                    </ul>
                """
            },
            new()
            {
                Id="13",
                Statement= """
                    <p>Embora não usado internamente para voltagem, o hexadecimal é usado para representação. Quantas divisões sucessivas por 2 seriam necessárias para reduzir o número 16 a 1? E quantas divisões por 16?</p>
                """,
                Solution= """
                    <ul>
                        <li>Base 2: $16 \to 8 \to 4 \to 2 \to 1$ (4 divisões).</li>
                        <li>Base 16: $16 \div 16 = 1$ (1 divisão).</li>
                        <li>Resposta: 4 divisões para a base 2; 1 divisão para a base 16. Isso ilustra a "compacidade" de bases maiores.</li>
                    </ul>
                """
            },
            new()
            {
                Id="14",
                Statement= """
                    <p>Um pastor conta 23 ovelhas. Como esse número seria representado se ele usasse um sistema de contagem baseado nos dedos de uma única mão (Base 5)?</p>
                """,
                Solution= """
                    <ul>
                        <li>Número decimal: 23.</li>
                        <li>Divisão: $23 \div 5$: Quociente = 4, Resto = 3.</li>
                        <li>Divisão: $4 \div 5$: Quociente = 0, Resto = 4.</li>
                        <li>Leitura inversa.</li>
                        <li>Resposta: $43_5$ (Lê-se "quatro-três na base 5").</li>
                    </ul>
                """
            },
            new()
            {
                Id="15",
                Statement= """
                    <p>Se um transistor opera entre 0V e 3V. Qual seria a margem de segurança $\Delta V$ se tentássemos implementar uma lógica ternária (Base 3) nele?</p>
                """,
                Solution= """
                    <ul>
                        <li>Fórmula: $\Delta V = \frac{A}{b - 1}$.</li>
                        <li>Dados: $A=3$, $b=3$.</li>
                        <li>Cálculo: $\Delta V = \frac{3}{3 - 1} = \frac{3}{2} = 1.5$.</li>
                        <li>Resposta: A margem seria de 1.5 Volts.</li>
                    </ul>
                """
            },
            new()
            {
                Id="16",
                Statement= """
                    <p>O texto afirma que a Base 10 é eficiente para escrita (papel), mas ruim para física (voltagem). Explique esse paradoxo utilizando os conceitos de "Comprimento da representação" (número de dígitos) e "Margem de Ruído" ($\Delta V$).</p>
                """,
                Solution= """
                    <ul>
                        <li>Escrita (Base 10): Usa mais símbolos ($0-9$). Isso permite escrever números grandes com poucos dígitos (polinômio curto). É eficiente para o espaço físico do papel.</li>
                        <li>Física (Base 10): Exige dividir a voltagem em muitos pedaços. Isso reduz drasticamente o $\Delta V$ ($\Delta V = A/9$), tornando o sistema frágil ao ruído.</li>
                        <li>Conclusão: Há uma troca (trade-off). Aumentar a base diminui o número de dígitos necessários (bom para humanos/papel), mas diminui a margem de erro (ruim para máquinas/eletricidade).</li>
                    </ul>
                """
            },
            new()
            {
                Id="17",
                Statement= """
                    <p>Um computador analógico puro pode ser visto, teoricamente, como um sistema onde a base $b$ tende ao infinito ($b \to \infty$). Usando a fórmula da robustez, explique por que computadores analógicos são impossíveis de serem perfeitamente precisos.</p>
                """,
                Solution= """
                    <ul>
                        <li>Considere o limite da fórmula quando $b$ tende ao infinito:</li>
                        <p>$$\lim_{b \to \infty} \frac{A}{b - 1} = 0$$</p>
                        <li>Isso significa que a distância entre dois valores distintos ($\Delta V$) tende a zero.</li>
                        <li>Qualquer ruído, por menor que seja ($\epsilon > 0$), será maior que $\Delta V$.</li>
                        <li>Resposta: Como a margem de segurança tende a zero, torna-se impossível distinguir dois valores muito próximos. A precisão infinita exigiria ausência total de ruído e entropia, o que viola as leis da física.</li>
                    </ul>
                """
            },
            new()
            {
                Id="18",
                Statement= """
                    <p>Matematicamente, a Base 3 ($e \approx 2.718$) é mais eficiente que a Base 2. No entanto, o texto diz que "a engenharia escolheu a segurança máxima". Analise a redução percentual da margem de segurança ($\Delta V$) ao passar de Base 2 para Base 3, mantendo a amplitude $A$ constante.</p>
                """,
                Solution= """
                    <ul>
                        <li>Base 2: $\Delta V_2 = \frac{A}{1} = A$ (100% de A).</li>
                        <li>Base 3: $\Delta V_3 = \frac{A}{3-1} = \frac{A}{2} = 0.5A$ (50% de A).</li>
                        <li>Comparação: Ao mudar de binário para ternário, a margem de segurança cai pela metade.<li>
                        <li>Resposta: Há uma redução de 50% na imunidade ao ruído. O ganho teórico de densidade de informação da base 3 não compensa a perda dramática de metade da robustez física.</li>
                    </ul>
                """
            },
            new()
            {
                Id="19",
                Statement= """
                    <p>O "custo" de um sistema numérico pode ser aproximado por $C = b \cdot \log_b(N)$, onde $b$ é a base e $\log_b(N)$ é o número aproximado de dígitos para escrever $N$. Demonstre que o custo da Base 2 e da Base 4 são matematicamente iguais sob essa fórmula simples.</p>
                """,
                Solution= """
                    <ul>
                        <li>Use a propriedade de mudança de base do logaritmo: $\log_b(N) = \frac{\ln(N)}{\ln(b)}$.</li>
                        <li>Função de custo: $C(b) = b \cdot \frac{\ln(N)}{\ln(b)}$.</li>
                        <li>Para $b=2$: $C(2) = 2 \cdot \frac{\ln(N)}{\ln(2)}$.</li>
                        <li>Para $b=4$: $C(4) = 4 \cdot \frac{\ln(N)}{\ln(4)}$. Como $\ln(4) = \ln(2^2) = 2\ln(2)$, temos: $C(4) = 4 \cdot \frac{\ln(N)}{2\ln(2)} = 2 \cdot \frac{\ln(N)}{\ln(2)}$.</li>
                        <li>Resposta: $C(2) = C(4)$. Isso sugere que, em termos de "custo de hardware vs. dígitos", base 2 e 4 são equivalentes, mas a base 2 ganha na simplicidade do circuito (On/Off).</li>
                    </ul>
                """
            },
            new()
            {
                Id="20",
                Statement= """
                    <p>O texto menciona que Babbage falhou porque as engrenagens desgastavam e paravam em "3 e meio". Em termos de Teoria dos Conjuntos e da Definição 2.1.1, por que o estado "3 e meio" quebra a lógica do sistema digital?</p>
                """,
                Solution= """
                    <ul>
                        <li>A Definição 2.1.1 estabelece que o conjunto $S$ é discreto e finito: $\{s_0, s_1, \dots\}$. Não existem elementos intermediários.</li>
                        <li>Um estado "3 e meio" não pertence ao conjunto $S$.</li>
                        <li>Para que a computação funcione, a função de leitura deve ser uma bijeção estrita para $S$. O estado "3 e meio" cria uma indefinição (não mapeia nem para 3 nem para 4 de forma determinística).</li>
                        <li>Resposta: O estado "3 e meio" viola a Discretização. O sistema deixa de ser digital (estados finitos) e comporta-se como analógico (contínuo), reintroduzindo o erro e a incerteza que a lógica binária visava eliminar.</li>
                    </ul>
                """
            }
        }
    };
}