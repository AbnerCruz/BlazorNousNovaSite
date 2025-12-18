using SchoolData;

public class Math1Module1Chapter3Section1
{
    public static Topic Topic = new()
    {
        Id = "interface-humano-maquina",
        Name = "3.1 Interface Humano-Máquina",
        Active = false,
        Body = """
            <h3>3.1 Interface Humano-Máquina</h3>
            <p>Estamos em 1975, ou talvez um pouco antes, em 1948. O ar na sala é frio e seco, mantido assim para proteger as válvulas termiônicas ou os primeiros transistores frágeis. O cheiro é de ozônio e metal aquecido. Você está diante de um computador como o Altair 8800 ou, voltando mais no tempo, o colossal ENIAC. Não existe tela. Não existe teclado QWERTY. O que existe é um painel frontal — uma parede metálica coberta de fileiras de interruptores e pequenas lâmpadas de neon que piscam incessantemente (blinkenlights).</p>
            <figure>
                <img src="images/Courses/Math/Math1/Module1/Chapter3/Section3.1/Fig3.1.1.png" alt="Figura 3.1.1: Ilustração do computador ENIAC">
                <figcaption>Figura 3.1.1: Ilustração do computador ENIAC</figcaption>
            </figure>
            <p>Aqui reside o problema fundamental da computação primitiva, uma problema físico e mental para os pioneiros. Para programar, você não "escrevia código"; você configurava circuitos. Cada interruptor para cima era um 1, cada interruptor para baixo era um 0.</p>
            <p>Na década de 1950, psicólogos cognitivos, liderados por George Miller, identificaram uma limitação severa no cérebro humano, muitas vezes chamada de "O Número Mágico Sete, Mais ou Menos Dois". Nossa memória de trabalho entra em colapso quando tentamos segurar mais de 7 itens não estruturados de uma vez.</p>
            <p>Tente memorizar isto em 2 segundos: 1101011101011100</p>
            <p>Agora feche os olhos e repita. Você falhou? E se você errar um único bit ao inserir isso nos interruptores, o programa trava. O computador era preciso, mas a interface humano-máquina estava quebrada. Havia um abismo de escala entre a mente humana e o estado da máquina. Precisávamos de uma ponte.</p>
            <p>"Por que não convertemos tudo para os números que usamos no dia a dia?"</p>
            <p>Parece razoável. Se a máquina mostra 11111111, nós escrevemos 255. Se ela mostra 100000000, escrevemos 256. Problema resolvido? Não. Na verdade, acabamos de criar um problema maior. Ao converter binário para decimal, cometemos um crime contra a topologia dos bits. Nós preservamos a quantidade (o valor semântico), mas destruímos a estrutura (a sintaxe do hardware).</p>
            <p>Considere o exemplo acima:</p>
            <ul>
                <li>255 em binário é 11111111 (8 bits ligados).</li>
                <li>256 em binário é 100000000 (1 bit ligado na 9ª posição, 8 desligados).</li>
            </ul>
            <p>Em decimal, 255 e 256 são vizinhos, parecem quase iguais. Mas para o engenheiro de hardware, eles são universos diferentes. O 255 significa "registro cheio". O 256 significa "transbordamento" (overflow), onde o bit de dados escapou para o próximo circuito. O sistema decimal esconde essa informação crucial. Ele obscurece o que está acontecendo fisicamente dentro dos fios.</p>
            <p>Além disso, havia o custo. Nos anos 50, ciclos de processamento eram ouro. Converter binário para decimal exige divisões sucessivas por 10. Fazer o computador gastar tempo precioso apenas para "traduzir" números para o operador era um luxo inaceitável. A intuição correta, que demorou a se consolidar, foi: Não precisamos traduzir. Precisamos compactar. Imagine que você tem um punhado de moedas de 1 centavo. Você não quer contar o valor total o tempo todo; você só quer empilhá-las em montes pequenos e iguais para saber quantas tem num relance. Precisamos de um sistema que agrupe os bits visualmente, sem alterar sua natureza.</p>
            <br>
            <p>A salvação veio de uma propriedade elegante da aritmética modular, que chamaremos aqui de Teorema das Bases Potência. A ideia é a seguinte: não vamos lutar contra o binário. Vamos apenas "embalá-lo" em caixas maiores. Mas para que a embalagem seja perfeita — para que possamos olhar para a caixa e saber exatamente o que está dentro sem abrir — o tamanho da nova base deve ter uma relação muito específica com a base original.</p>
            <div class="card">
                <h3>Definição 3.1.1 Isomorfismo de Agrupamento</h3>
                <p>Uma representação numérica em base $b$ pode ser convertida diretamente, dígito a dígito, para uma base $B$ se, e somente se, a nova base for uma potência inteira da base original.</p>
                <p>$$B = b^k$$</p>
                <p>Onde $k$ é um número inteiro positivo que representa o "tamanho do pacote" (quantos dígitos da base $b$ formam um dígito da base $B$).</p>
            </div>
            <p>Vamos provar por que isso funciona. Sei que a notação de somatório pode assustar, mas vamos dissecá-la juntos. Respire fundo. </p>
            <p>Lembre-se que o valor de um número $N$ em base 2 (binário) é a soma de seus dígitos ($d$) multiplicados por potências de 2:</p>
            <p>$$N = \sum_{i=0}^{m} d_i 2^i = d_0 2^0 + d_1 2^1 + d_2 2^2 + ... + d_m 2^m$$</p>
            <p>Agora, aqui está o "pulo do gato". Vamos decidir agrupar esses termos em pacotes de tamanho $k$. Em vez de somar um por um, vamos somar bloco por bloco. Podemos reescrever a equação acima assim:</p>
            <p>$$N = \sum_{j=0}^{\lceil m/k \rceil} \left( \sum_{p=0}^{k-1} d_{jk+p} 2^p \right) (2^k)^j$$</p>
            <p>Eu sei, parece que explodiu uma fábrica de símbolos. Vamos olhar com calma para as duas partes dessa equação:</p>
            <ul>
                <li>A Base Externa $(2^k)^j$: Veja que a base da soma externa não é mais $2$, é $2^k$. Se escolhermos $k=3$, a nova base é $2^3 = 8$. Se $k=4$, a nova base é $2^4 = 16$.</li>
                <li>O Dígito Interno $\left( \sum d_{jk+p} 2^p \right)$: Esta parte entre parênteses pega exatamente $k$ bits e calcula o seu valor isolado. Esse valor se torna um único dígito ($D_j$) na nova base.</li>
            </ul>
            <p>Isso prova que não precisamos fazer divisões complexas. A conversão é uma substituição visual direta. Cada grupo de $k$ bits vira exatamente um símbolo na nova base.</p>
            <h4>O Problema da Fronteira (Padding)</h4>
            <p>E se tivermos um número de bits que não é divisível por $k$? Por exemplo, queremos agrupar 8 bits em grupos de 3 ($k=3$).$8 \div 3 = 2$ com resto $2$.Matematicamente, isso nos obriga a usar o conceito de Zero Padding (preenchimento com zeros). Adicionamos zeros "fantasmas" à esquerda do número até que o comprimento total seja múltiplo de $k$. Isso não altera o valor do número (zero à esquerda não vale nada), mas preserva a integridade topológica do agrupamento.</p>
            <br>
            <h4>Aplicações</h4>
            <p><strong>Aplicação 3.1.1</strong>Imagine que você é um engenheiro em 1960 e tem a seguinte sequência de 16 bits no registrador de memória, e precisa anotá-la no seu caderno de laboratório: 1011011110101101</p>
            <p>Se você tentar ditar isso para seu colega, vai errar. Vamos aplicar o Teorema das Bases Potência.</p>
            <p><strong>Tentativa A: O Sistema Octal (Base 8)</strong></p>
            <p>Aqui, escolhemos $k=3$, pois $2^3 = 8$. Precisamos agrupar os bits de 3 em 3, da direita para a esquerda. Mas espere! 16 não é divisível por 3. Pois $16 = 5 \times 3 + 1$. Sobra um bit sozinho na ponta esquerda. Aplicamos o Padding: adicionamos dois zeros à esquerda.</p>
            <ul>
                <li>Binário Ajustado: 001 011 011 110 101 101</li>
                <li>
                    Agrupamento:
                    <ul>
                        <li>101 = $1(4) + 0(2) + 1(1) = 5$</li>
                        <li>101 = $5$</li>
                        <li>110 = $6$</li>
                        <li>011 = $3$</li>
                        <li>011 = $3$</li>
                        <li>001 = $1$</li>
                    </ul>
                </li>
                <li>Resultado Octal: $133655_8$</li>
            </ul>
            <p>Melhorou, mas ainda é feio. O agrupamento de 3 não "casa" bem com potências de 2 maiores, como 16 ou 32 bits. O octal deixa "sobras".</p>
            <p><strong>Tentativa B: O Sistema Hexadecimal (Base 16)</strong></p>
            <p>Aqui escolhemos $k=4$, pois $2^4 = 16$. 16 bits divididos por 4 dá exatamente 4 grupos. Perfeição simétrica.</p>
            <ul>
                <li>Separação: 1011 | 0111 | 1010 | 1101</li>
                <li>
                    Nibble:
                    <ul>
                        <li>
                            Grupo 1: 1101 $\rightarrow 8+4+0+1 = 13$.
                            <ul>
                                <li>Problema: Não temos um dígito para "13". Usamos letras! A=10, B=11, C=12, D=13.</li>
                                <li>Símbolo: D</li>
                            </ul>
                        </li>
                        <li>Grupo 2: 1010 $\rightarrow 8+0+2+0 = 10$. Símbolo: A</li>
                        <li>Grupo 3: 0111 $\rightarrow 0+4+2+1 = 7$. Símbolo: 7</li>
                        <li>Grupo 4: 1011 $\rightarrow 8+0+2+1 = 11$. Símbolo: B</li>
                    </ul>
                </li>
                <li>Resultado Hexadecimal: B7AD</li>
            </ul>
            <p>Veja a elegância disso. 1011011110101101 virou B7AD. Reduzimos 16 caracteres para 4 caracteres. Mais importante: se eu te der o símbolo "B", você sabe instantaneamente que os bits são 1011. A estrutura foi preservada. A conversão é reversível e imediata, sem contas de dividir. Essa simples decisão matemática — de agrupar bits em potências de 2 (especialmente $k=4$) — moldou toda a computação moderna.</p>
            <p><strong>Aplicação 3.1.2</strong> É por isso que, décadas depois, quando você abre um editor de imagens e escolhe uma cor, você vê #FF5733. Isso não é um código aleatório; são três grupos de 2 dígitos hexadecimais (Red, Green, Blue), representando a intensidade exata dos elétrons que vão atingir os pixels da sua tela.</p>
            <p>O sistema Hexadecimal tornou-se a lingua franca entre o humano e a máquina. Ele resolveu o paradoxo da precisão permitindo que nós, com nossos cérebros limitados e biológicos, manipulássemos a pureza matemática dos circuitos digitais sem enlouquecer. Nós construímos uma ponte sobre o abismo, e ela foi feita de potências de dois.</p>
            <br>
            <h4>Resumo</h4>
            <div class="card">
                <p><strong>Lei de Miller:</strong> O cérebro humano só processa eficientemente ~7 itens por vez. Binário puro viola essa regra biológica.</p>
                <p><strong>Ineficácia Decimal:</strong> Converter binário para base 10 é computacionalmente caro (divisões) e esconde a topologia dos bits (255 vs 256).</p>
                <p><strong>Teorema das Bases Potência:</strong> Uma base $B$ compacta perfeitamente uma base $b$ se $B = b^k$.</p>
                <p><strong>Nibble:</strong> Um grupo de 4 bits ($k=4$). É a unidade atômica do sistema Hexadecimal.</p>
                <p><strong>Hexadecimal:</strong> A interface padrão da computação de baixo nível, pois $16$ ($2^4$) divide simetricamente os tamanhos de palavra modernos (8, 16, 32, 64 bits).</p>
            </div>
        """,
        Problems = new()
        {
            // --- NÍVEL 1: FIXAÇÃO (1-5) ---
            new()
            {
                Id = "1",
                Statement = """
                    <p>De acordo com o texto, o que estabelece a "Lei de Miller" (ou "O Número Mágico Sete") e qual sua relevância para a interface humano-máquina primitiva?</p>
                """,
                Solution = """
                    <ul>
                        <li><b>Definição:</b> A Lei de Miller postula que a memória de trabalho humana só consegue processar eficientemente cerca de 7 itens (mais ou menos 2) não estruturados simultaneamente.</li>
                        <li><b>Relevância:</b> O sistema binário puro viola essa limitação, pois exige a memorização de longas sequências de bits (como <i>1101011101011100</i>), levando a erros humanos frequentes na programação de computadores antigos.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "2",
                Statement = """
                    <p>Por que a conversão de binário para o sistema <b>decimal</b> (Base 10) é considerada inadequada para a representação de hardware, segundo o texto?</p>
                """,
                Solution = """
                    <ul>
                        <li><b>Perda de Topologia:</b> O decimal preserva o valor semântico (quantidade), mas destrói a estrutura sintática dos bits.</li>
                        <li><b>Exemplo:</b> Os números 255 e 256 parecem vizinhos em decimal, mas em binário representam estados físicos completamente diferentes (registro cheio vs. transbordamento/overflow).</li>
                        <li><b>Custo Computacional:</b> A conversão exige divisões sucessivas por 10, consumindo ciclos de processamento preciosos.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "3",
                Statement = """
                    <p>Qual é a condição matemática fundamental definida no <b>Isomorfismo de Agrupamento</b> para que uma base $B$ possa converter diretamente dígitos de uma base $b$?</p>
                """,
                Solution = """
                    <ul>
                        <li>A nova base $B$ deve ser uma <b>potência inteira</b> da base original $b$.</li>
                        <li>A relação é expressa pela fórmula: $$B = b^k$$</li>
                        <li>Onde $k$ é um número inteiro positivo que representa a quantidade de dígitos da base original agrupados em um único símbolo da nova base.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "4",
                Statement = """
                    <p>O que é um <b>Nibble</b> e qual sua relação com o sistema Hexadecimal?</p>
                """,
                Solution = """
                    <ul>
                        <li><b>Definição:</b> Um Nibble é um grupo de exatos 4 bits.</li>
                        <li><b>Relação:</b> Como $2^4 = 16$, um nibble corresponde exatamente a um dígito hexadecimal. Ele é considerado a "unidade atômica" desse sistema.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "5",
                Statement = """
                    <p>Explique o conceito de <b>Zero Padding</b> (ou preenchimento de fronteira) no contexto do Teorema das Bases Potência.</p>
                """,
                Solution = """
                    <ul>
                        <li>Ocorre quando o número total de bits não é divisível pelo tamanho do agrupamento $k$.</li>
                        <li><b>Ação:</b> Adicionam-se zeros à esquerda ("fantasmas") até que o comprimento total da sequência seja múltiplo de $k$.</li>
                        <li>Isso preserva a integridade do agrupamento sem alterar o valor numérico, pois zeros à esquerda não têm valor.</li>
                    </ul>
                """
            },

            // --- NÍVEL 2: APLICAÇÃO (6-15) ---
            new()
            {
                Id = "6",
                Statement = """
                    <p>Utilizando o Teorema das Bases Potência com $k=4$, converta a sequência binária <b>11001010</b> para Hexadecimal.</p>
                """,
                Solution = """
                    <ul>
                        <li>Separar em nibbles: <b>1100</b> | <b>1010</b></li>
                        <li>Grupo 1 (1100): $8 + 4 + 0 + 0 = 12$. Em Hex, 12 é representado por <b>C</b>.</li>
                        <li>Grupo 2 (1010): $8 + 0 + 2 + 0 = 10$. Em Hex, 10 é representado por <b>A</b>.</li>
                        <li><b>Resultado:</b> CA$_{16}$</li>
                    </ul>
                """
            },
            new()
            {
                Id = "7",
                Statement = """
                    <p>Converta o número binário <b>111101</b> para o sistema Octal (Base 8). Demonstre o uso do agrupamento correto ($k$).</p>
                """,
                Solution = """
                    <ul>
                        <li>Para Base 8, usamos $k=3$ (pois $2^3 = 8$).</li>
                        <li>Agrupamento (da direita para esquerda): <b>101</b> e <b>111</b>.</li>
                        <li>Grupo 1 (111): $4 + 2 + 1 = 7$.</li>
                        <li>Grupo 2 (101): $4 + 0 + 1 = 5$.</li>
                        <li><b>Resultado:</b> 75$_8$</li>
                    </ul>
                """
            },
            new()
            {
                Id = "8",
                Statement = """
                    <p>Dado o valor Hexadecimal <b>#B3</b>, reverta o processo para encontrar sua representação binária original.</p>
                """,
                Solution = """
                    <ul>
                        <li>Dígito <b>B</b> (11 em decimal): Requer 8+2+1 $\rightarrow$ <b>1011</b>.</li>
                        <li>Dígito <b>3</b> (3 em decimal): Requer 2+1 $\rightarrow$ <b>0011</b>.</li>
                        <li>Concatenando os nibbles:</li>
                        <li><b>Resultado:</b> 10110011$_2$</li>
                    </ul>
                """
            },
            new()
            {
                Id = "9",
                Statement = """
                    <p>Utilizando o algoritmo da divisão euclidiana (divisões sucessivas), converta o número decimal <b>23</b> para a <b>Base 5</b>.</p>
                """,
                Solution = """
                    <ul>
                        <li>$23 \div 5 = 4$ com resto <b>3</b>.</li>
                        <li>$4 \div 5 = 0$ com resto <b>4</b>.</li>
                        <li>Lendo os restos de baixo para cima (ou do último para o primeiro):</li>
                        <li><b>Resultado:</b> 43$_5$</li>
                    </ul>
                """
            },
            new()
            {
                Id = "10",
                Statement = """
                    <p>Converta o número decimal <b>50</b> para a <b>Base 12</b> (Duodecimal). Use os símbolos A=10, B=11 se necessário.</p>
                """,
                Solution = """
                    <ul>
                        <li>$50 \div 12 = 4$ com resto <b>2</b>.</li>
                        <li>$4 \div 12 = 0$ com resto <b>4</b>.</li>
                        <li>Lendo os restos de trás para frente:</li>
                        <li><b>Resultado:</b> 42$_{12}$</li>
                    </ul>
                """
            },
            new()
            {
                Id = "11",
                Statement = """
                    <p>Um engenheiro precisa representar o número decimal <b>89</b> em <b>Base 5</b> e em <b>Base 8</b>. Qual representação utiliza menos dígitos?</p>
                """,
                Solution = """
                    <ul>
                        <li><b>Base 5:</b>
                            <ul>
                                <li>$89 \div 5 = 17$ (resto 4)</li>
                                <li>$17 \div 5 = 3$ (resto 2)</li>
                                <li>$3 \div 5 = 0$ (resto 3)</li>
                                <li>Resultado: <b>324</b>$_5$ (3 dígitos).</li>
                            </ul>
                        </li>
                        <li><b>Base 8:</b>
                            <ul>
                                <li>$89 \div 8 = 11$ (resto 1)</li>
                                <li>$11 \div 8 = 1$ (resto 3)</li>
                                <li>$1 \div 8 = 0$ (resto 1)</li>
                                <li>Resultado: <b>131</b>$_8$ (3 dígitos).</li>
                            </ul>
                        </li>
                        <li><b>Conclusão:</b> Ambas utilizam a mesma quantidade de dígitos (3), mas a Base 8 está mais próxima de usar apenas 2 (pois $8^2=64$ e $8^3=512$).</li>
                    </ul>
                """
            },
            new()
            {
                Id = "12",
                Statement = """
                    <p>Se decidíssemos criar um sistema de numeração "Base 32" para computadores, quantos bits formariam um único símbolo dessa base? Aplique a fórmula $B=b^k$.</p>
                """,
                Solution = """
                    <ul>
                        <li>Base original $b = 2$ (Binário).</li>
                        <li>Nova base $B = 32$.</li>
                        <li>Equação: $32 = 2^k$.</li>
                        <li>Decompondo 32: $2 \times 2 \times 2 \times 2 \times 2 = 2^5$.</li>
                        <li><b>Resposta:</b> $k = 5$. Cada símbolo da Base 32 agruparia 5 bits.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "13",
                Statement = """
                    <p>Você tem uma palavra de memória de <b>16 bits</b> e decide representá-la em <b>Octal</b> ($k=3$). Quantos zeros de preenchimento (padding) serão necessários?</p>
                """,
                Solution = """
                    <ul>
                        <li>Total de bits: 16.</li>
                        <li>Tamanho do grupo $k$: 3.</li>
                        <li>Divisão: $16 \div 3 = 5$ com resto 1.</li>
                        <li>Isso significa que temos 5 grupos completos e sobra 1 bit isolado.</li>
                        <li>Para completar o último grupo de 3, precisamos adicionar zeros: $3 - 1 = 2$.</li>
                        <li><b>Resposta:</b> Serão necessários <b>2 zeros</b> de padding.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "14",
                Statement = """
                    <p>Analise a cor hexadecimal <b>#00FF00</b>. Converta-a para binário e identifique o que ela representa (Red, Green ou Blue) baseando-se na posição dos bytes.</p>
                """,
                Solution = """
                    <ul>
                        <li>Estrutura RGB: [RR] [GG] [BB].</li>
                        <li>Hex: 00 FF 00.</li>
                        <li><b>Conversão:</b>
                            <ul>
                                <li>00 $\rightarrow$ 0000 0000 (Desligado)</li>
                                <li>FF $\rightarrow$ 1111 1111 (Intensidade Máxima)</li>
                                <li>00 $\rightarrow$ 0000 0000 (Desligado)</li>
                            </ul>
                        </li>
                        <li><b>Conclusão:</b> Como apenas os bits do meio (Green) estão ativos, a cor é <b>Verde Puro</b>.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "15",
                Statement = """
                    <p>Calcule o valor decimal do maior número que pode ser representado com <b>dois dígitos</b> na <b>Base 12</b>.</p>
                """,
                Solution = """
                    <ul>
                        <li>O maior dígito na base 12 é o 'B' (que vale 11).</li>
                        <li>O número é $BB_{12}$.</li>
                        <li>Expansão polinomial: $11 \times 12^1 + 11 \times 12^0$.</li>
                        <li>Cálculo: $132 + 11 = 143$.</li>
                        <li><b>Alternativa:</b> $12^2 - 1 = 144 - 1 = 143$.</li>
                    </ul>
                """
            },

            // --- NÍVEL 3: ANÁLISE (16-20) ---
            new()
            {
                Id = "16",
                Statement = """
                    <p>Baseado no problema do "Padding" (Aplicações 3.1.1), explique analiticamente por que o sistema <b>Octal</b> caiu em desuso em favor do <b>Hexadecimal</b> à medida que os computadores passaram de 12 ou 36 bits para 16, 32 e 64 bits.</p>
                """,
                Solution = """
                    <ul>
                        <li><b>Simetria de Potências:</b> O Octal agrupa 3 bits. Tamanhos de palavra modernos (16, 32, 64) são potências de 2, mas <b>não</b> são divisíveis por 3. Isso gera sempre restos (padding) desconfortáveis.</li>
                        <li><b>Hexadecimal:</b> O Hex agrupa 4 bits. Como 16, 32 e 64 são divisíveis por 4, o Hexadecimal se alinha perfeitamente ("perfect fit") sem deixar sobras ou exigir padding mental constante.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "17",
                Statement = """
                    <p>Se vivêssemos em um universo onde os computadores fossem baseados em lógica ternária (trits em vez de bits, Base 3), qual seria a base "Hexadecimal" equivalente para agrupamento eficiente? Justifique usando o Teorema $B=b^k$.</p>
                """,
                Solution = """
                    <ul>
                        <li>Base original $b=3$.</li>
                        <li>Para facilitar a leitura, buscaríamos um $k$ que gerasse uma quantidade razoável de símbolos (nem muito poucos, nem centenas).</li>
                        <li>Se $k=2$: Nova base $B = 3^2 = 9$ (Sistema Nonário).</li>
                        <li>Se $k=3$: Nova base $B = 3^3 = 27$ (Sistema "Heptavigesimal").</li>
                        <li><b>Análise:</b> O Base 9 seria o análogo mais próximo do Octal, e a Base 27 o análogo do Hexadecimal (compactação maior).</li>
                    </ul>
                """
            },
            new()
            {
                Id = "18",
                Statement = """
                    <p>O texto afirma que converter binário para decimal é um "crime contra a topologia dos bits". Analise esta afirmação comparando a operação de <b>Bitwise Shift</b> (deslocamento de bits) em Hexadecimal versus Decimal.</p>
                """,
                Solution = """
                    <ul>
                        <li><b>Em Hexadecimal:</b> Um deslocamento de 4 bits (Shift Left 4) é visualmente óbvio. O número $1A_{16}$ vira $1A0_{16}$. A estrutura visual dos símbolos se mantém.</li>
                        <li><b>Em Decimal:</b> $1A_{16}$ é 26. Se multiplicarmos por 16 (shift de 4 bits), vira 416.</li>
                        <li><b>Conclusão:</b> Não há relação visual óbvia entre "26" e "416". O decimal ofusca a operação lógica que ocorreu no hardware, enquanto o Hexadecimal torna a operação transparente.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "19",
                Statement = """
                    <p>Considere a fórmula da soma por blocos: $$N = \sum (\sum d_{jk+p} 2^p) (2^k)^j$$ Explique o papel do termo $(2^k)^j$ na construção de sistemas de numeração de alto nível.</p>
                """,
                Solution = """
                    <ul>
                        <li>Este termo define a <b>Base Externa</b> ou a "posição" do novo símbolo.</li>
                        <li>Ele prova matematicamente que, ao agrupar bits, não estamos apenas somando valores aleatórios, mas criando um novo sistema posicional onde cada posição vale uma potência de $2^k$.</li>
                        <li>É o termo que valida tratar um grupo inteiro de bits (como '1101') como se fosse um único algarismo ('D') em uma casa decimal específica.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "20",
                Statement = """
                    <p>Sob a ótica da Engenharia de Software, como a adoção do Hexadecimal exemplifica a resolução de um problema de "Interface" sem alterar a "Implementação"?</p>
                """,
                Solution = """
                    <ul>
                        <li><b>Implementação:</b> O hardware continua operando exclusivamente em binário (tensão alta/baixa). Nada mudou fisicamente nos circuitos.</li>
                        <li><b>Interface:</b> O Hexadecimal atua como uma camada de abstração (Adapter Pattern). Ele muda como os dados são apresentados ao usuário (programador) para se adequar à cognição humana (Lei de Miller), sem exigir processamento extra de tradução complexa da máquina.</li>
                        <li>É uma solução que otimiza a usabilidade mantendo a eficiência do sistema.</li>
                    </ul>
                """
            }
        }
    };
}