using SchoolData;

public class Math1Module1Chapter3Section2
{
    public static Topic Topic = new()
    {
        Id = "sistema-hexadecimal",
        Name = "3.2 Sistema Hexadecimal",
        Active = false,
        Body = """
            <h3>3.2 Sistema Hexadecimal</h3>
            <p>O ano é 1960, Você é um engenheiro sênior em uma sala refrigerada, cercado pelo zumbido constante de um mainframe IBM. Não há monitores de alta resolução, mouse ou ícones coloridos. O que existe à sua frente é um painel de luzes piscando freneticamente e longas fitas de papel perfurado.</p>
            <figure>
                <img src="images/Courses/Math/Math1/Module1/Chapter3/Section3.2/Fig3.2.1.png" alt="Figura 3.2.1: Ilustração de um mainframe IBM">
                <figcaption>Figura 3.2.1: Ilustração de um mainframe IBM</figcaption>
            </figure>
            <p>Os computadores dessa época estavam se tornando máquinas poderosas. A largura dos dados, estava crescendo. O que antes eram simples interruptores, agora eram fluxos torrenciais de bits. Para o computador, uma instrução complexa é apenas uma sequência de estados elétricos: ligado ou desligado. Mas como vimos anteriormente, para você o operador humano, ler a memória bruta da máquina é um pesadelo.</p>
            <p>$$10110101110001111010100111110000$$</p>
            <br>
            <p>A primeira grande tentativa de resolver isso foi o Sistema Octal (Base 8).</p>
            <p>Por que 8? Porque os matemáticos perceberam uma propriedade elegante das potências: $8 = 2^3$. Isso significava que poderíamos agrupar os bits de 3 em 3. Era muito mais fácil ler "7" do que "111". Durante anos, em sistemas como o PDP-11 ou nas primeiras permissões de arquivos do Unix, o Octal reinou. Mas a tecnologia evoluiu e sabotou o Octal. A indústria padronizou a unidade fundamental de memória: o Byte, composto por 8 bits. E logo depois vieram as "palavras" de 16, 32 e 64 bits.</p>
            <p>Aqui surgiu a falha geométrica. Tente dividir 8 (o tamanho do Byte) por 3 (o agrupamento do Octal):</p>
            <p>$$8 \div 3 = 2 \text{ com resto } 2$$</p>
            <p>Não é uma divisão exata. Ao usar Octal para representar um Byte, você ficava com dois grupos de três e um grupo "quebrado" de dois bits no final. O alinhamento estava arruinado. Era como tentar azulejar uma parede com pisos que não encaixam nas bordas. O Octal, embora útil, tornou-se desajeitado para a arquitetura moderna de computadores.</p>
            <p>A solução estava na próxima potência de dois. Se $2^3$ (8) falhou no alinhamento, olhamos para $2^4$, que é 16. O número 16 resolveu o problema geométrico instantaneamente. Um Byte tem 8 bits. Se usarmos agrupamentos de 4 bits, temos:</p>
            <p>$$8 \div 4 = 2$$</p>
            <p>Uma divisão exata! Um Byte pode ser representado perfeitamente por dois símbolos de base 16. Sem restos, sem "bits órfãos". Nascia a era do Hexadecimal.</p>
            <br>
            <div class="card">
                <h3>Definição 3.2.1 O Alfabeto Hexadecimal</h3>
                <p>O conjunto de símbolos da Base 16, denotado por $\Sigma_{16}$, é a união dos dígitos arábicos com as primeiras seis letras do alfabeto latino:</p>
                <p>$$\Sigma_{16} = \{0, 1, 2, 3, 4, 5, 6, 7, 8, 9, A, B, C, D, E, F\}$$</p>
                <p>Onde a função de valoração $\nu(x)$ para os novos símbolos é definida como:</p>
                <p>$$A = 10, \quad B = 11, \quad C = 12, \quad D = 13, \quad E = 14, \quad F = 15$$</p>
            </div>
            <br>
            <p>A mágica do hexadecimal não é aritmética, é visual. Ele funciona baseada em um conceito que chamaremos de Isomorfismo do Nibble. Um "Nibble" é o nome técnico para um grupo de 4 bits.</p>
            <div class="card">
                <h3>Teorema 3.2.1 Compactação</h3>
                <p>Existe uma bijeção (correspondência um-para-um) entre qualquer sequência de 4 bits e um único dígito hexadecimal.</p>
                <p>$$(b_3 b_2 b_1 b_0)_2 \iff h_i \in \Sigma_{16}$$</p>
                <p>Isso significa que você nunca precisa "calcular" para converter binário em hex. Você apenas substitui. É uma tradução de dicionário, não um cálculo matemático.</p>
            </div>
            <p>Para formalizar isso, considere um número binário longo. O algoritmo de conversão não requer divisão por 16. Ele requer apenas reagrupamento. Seja $N$ um número em base 2. A conversão segue a fórmula de soma direta:</p>
            <p>$$(B_n \dots B_0)_2 = \sum_{i=0}^{k} H_i \cdot 16^i$$</p>
            <p>Não se assuste com o somatório. Vamos dissecá-lo com a "Regra dos 4":</p>
            <ul>
                <li>Pegue o número binário.</li>
                <li>Começando da direita para a esquerda, corte-o em fatias de 4 bits.</li>
                <li>Substitua cada fatia pelo seu glifo hexadecimal correspondente.</li>
            </ul>
            <br>
            <h4>Aplicações</h4>
            <p><strong>Aplicação 3.2.1</strong> Converta</p>
            <p>$$10110101110001111010100111110000_2$$</p>
            <p>Passo 1: Fatiamento (Nibbles) Separamos em grupos de 4, da direita para a esquerda:</p>
            <p>$$[1011] \quad [0101] \quad [1100] \quad [0111] \quad [1010] \quad [1001] \quad [1111] \quad [0000]$$</p>
            <p>Passo 2: Tradução Direta Agora, consultamos nossa tabela mental (ou física):</p>
            <ul>
                <li>$1011 = 8+2+1 = 11 \rightarrow \mathbf{B}$</li>
                <li>$0101 = 4+1 = 5 \rightarrow \mathbf{5}$</li>
                <li>$1100 = 8+4 = 12 \rightarrow \mathbf{C}$</li>
                <li>$0111 = 4+2+1 = 7 \rightarrow \mathbf{7}$</li>
                <li>$1010 = 8+2 = 10 \rightarrow \mathbf{A}$</li>
                <li>$1001 = 8+1 = 9 \rightarrow \mathbf{9}$</li>
                <li>$1111 = 8+4+2+1 = 15 \rightarrow \mathbf{F}$</li>
                <li>$0000 = 0 \rightarrow \mathbf{0}$</li>
            </ul>
            <p>Resultado:</p>
            <p>$$B5C7A9F0_{16}$$</p>
            <p>Veja a elegância disso. Reduzimos 32 caracteres confusos para apenas 8 símbolos distintos. A estrutura lógica dos bits foi preservada, mas a carga cognitiva para o humano foi reduzida drasticamente. O Hexadecimal não mudou o valor do número; ele mudou nossa capacidade de lidar com ele.</p>
            <p><strong>Aplicação 3.2.2</strong> Se você já viu uma "Tela Azul da Morte" no Windows ou um erro de sistema, provavelmente viu algo como Erro em 0x7FFF5B. O prefixo 0x é uma convenção padrão para dizer "o que vem a seguir é hexadecimal". A memória do seu computador (RAM) é uma rua gigantesca de Bytes. Para o processador encontrar um dado, ele precisa do endereço da "casa". Como os endereços modernos são números de 32 ou 64 bits, escrevê-los em decimal seria confuso e ineficiente. Em hexadecimal, 0xFF representa visualmente o preenchimento total de um Byte, algo que 255 não comunica tão bem geometricamente.</p>
            <p><strong>Aplicação 3.2.3</strong> Toda vez que você escolhe uma cor em um software de design ou na web, você usa hexadecimal. Considere a cor laranja vibrante: #FF5733. O que isso significa? É uma instrução direta para os três canais de luz do seu monitor: Vermelho (Red), Verde (Green) e Azul (Blue) - o padrão RGB. O computador reserva 1 Byte (8 bits) para a intensidade de cada cor.</p>
            <ul>
                <li>FF (Vermelho): $FF_{16}$ é o valor máximo ($255_{10}$). "Ligue a luz vermelha no máximo!".</li>
                <li>57 (Verde): Uma intensidade média.</li>
                <li>33 (Azul): Uma intensidade baixa.</li>
            </ul>
            <p>O sistema hexadecimal permite que designers e programadores manipulem a física da luz na tela com precisão cirúrgica, empacotando três níveis de intensidade distintos em um código compacto de 6 dígitos.</p>
            <br>
            <h4>Resumo</h4>
            <div class="card">
                <p><strong>A Necessidade:</strong> O binário é ilegível para humanos; o decimal não se alinha matematicamente com bits.</p>
                <p><strong>A Solução:</strong> Base 16 (Hexadecimal) usa o agrupamento de $2^4$.</p>
                <p><strong>O Alfabeto:</strong> $\Sigma_{16} = \{0-9, A-F\}$. Onde $F=15$.</p>
                <p><strong>A Geometria:</strong> 1 Dígito Hex = 4 Bits (1 Nibble). 2 Dígitos Hex = 1 Byte (8 bits).</p>
                <p><strong>A Vantagem:</strong> Conversão por substituição visual, não por cálculo aritmético complexo.</p>
            </div>
            <p>Na próxima seção, sairemos do conforto das bases fixas (2, 10, 16) e entraremos no território da Generalização de Bases, onde descobriremos que um número é uma entidade abstrata independente do símbolo que usamos para escrevê-lo.</p>
        """,
        Problems = new()
        {
            // === NÍVEL 1: FIXAÇÃO (FÁCIL) ===
            new()
            {
                Id = "1",
                Statement = """
                    <p><b>Definição de Alfabeto:</b> Liste todos os elementos que compõem o conjunto $\Sigma_{16}$ (o alfabeto hexadecimal) e indique quantos símbolos únicos existem neste sistema.</p>
                """,
                Solution = """
                    <ul>
                        <li>O alfabeto hexadecimal é composto pela união dos dígitos arábicos e as primeiras letras latinas.</li>
                        <li>Símbolos Numéricos: $\{0, 1, 2, 3, 4, 5, 6, 7, 8, 9\}$ (10 símbolos).</li>
                        <li>Símbolos Alfabéticos: $\{A, B, C, D, E, F\}$ (6 símbolos).</li>
                        <li><b>Total:</b> $10 + 6 = 16$ símbolos únicos.</li>
                        <li>Conjunto: $\Sigma_{16} = \{0, 1, 2, 3, 4, 5, 6, 7, 8, 9, A, B, C, D, E, F\}$.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "2",
                Statement = """
                    <p><b>Valoração Simbólica:</b> No sistema hexadecimal, os glifos numéricos acabam em 9. Qual é o valor decimal correspondente aos símbolos <b>C</b> e <b>F</b>?</p>
                """,
                Solution = """
                    <ul>
                        <li>Seguindo a sequência após o 9:</li>
                        <li>A = 10, B = 11, <b>C = 12</b>.</li>
                        <li>D = 13, E = 14, <b>F = 15</b>.</li>
                        <li>Portanto, $C$ vale 12 e $F$ representa o valor máximo de um dígito, 15.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "3",
                Statement = """
                    <p><b>Conceito de Nibble:</b> O texto define um "Nibble" como uma unidade fundamental para a conversão Hexadecimal. Quantos bits compõem um Nibble e qual é a relação dele com um dígito Hex?</p>
                """,
                Solution = """
                    <ul>
                        <li>Um Nibble é composto por exatamente <b>4 bits</b>.</li>
                        <li>A relação é descrita pelo Teorema da Compactação: Existe uma bijeção (correspondência um-para-um) entre 1 Nibble e 1 Dígito Hexadecimal.</li>
                        <li>Isso ocorre porque $2^4 = 16$, cobrindo exatamente todas as possibilidades de símbolos do Hex.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "4",
                Statement = """
                    <p><b>Falha do Octal:</b> Antes do Hexadecimal, o sistema Octal (Base 8) era comum. Qual foi a "falha geométrica" que fez o Octal cair em desuso com a padronização do Byte?</p>
                """,
                Solution = """
                    <ul>
                        <li>O Byte foi padronizado como <b>8 bits</b>.</li>
                        <li>O sistema Octal agrupa bits de 3 em 3 ($2^3=8$).</li>
                        <li>Ao tentar dividir um Byte por grupos de 3, temos: $8 \div 3 = 2$ com resto $2$.</li>
                        <li>Isso deixava bits "órfãos" ou exigia padding, quebrando o alinhamento perfeito da memória.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "5",
                Statement = """
                    <p><b>Geometria do Byte:</b> Quantos dígitos hexadecimais são necessários para representar exatamente um Byte (8 bits) e por quê?</p>
                """,
                Solution = """
                    <ul>
                        <li>São necessários exatamente <b>2 dígitos hexadecimais</b>.</li>
                        <li>Como cada dígito Hex representa 4 bits (1 Nibble).</li>
                        <li>Temos que $4 \text{ bits} + 4 \text{ bits} = 8 \text{ bits}$ (1 Byte).</li>
                        <li>Logo, o intervalo de um Byte vai de $00_{16}$ a $FF_{16}$.</li>
                    </ul>
                """
            },

            // === NÍVEL 2: APLICAÇÃO (MÉDIO) ===
            new()
            {
                Id = "6",
                Statement = """
                    <p><b>Conversão de Nibble:</b> Converta o nibble binário $(1010)_2$ para seu símbolo hexadecimal correspondente.</p>
                """,
                Solution = """
                    <ul>
                        <li>Identifique os valores posicionais do binário: $8, 4, 2, 1$.</li>
                        <li>Aplique aos bits 1010: $1 \cdot 8 + 0 \cdot 4 + 1 \cdot 2 + 0 \cdot 1$.</li>
                        <li>Soma: $8 + 2 = 10$.</li>
                        <li>Na base 16, o valor 10 é representado pelo símbolo <b>A</b>.</li>
                        <li>Resultado: $A_{16}$.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "7",
                Statement = """
                    <p><b>Conversão Hex para Binário:</b> Converta o dígito hexadecimal <b>D</b> de volta para sua representação binária de 4 bits.</p>
                """,
                Solution = """
                    <ul>
                        <li>Identifique o valor decimal de D: $D = 13$.</li>
                        <li>Decomponha 13 em potências de 2 (8, 4, 2, 1):</li>
                        <li>$13 = 8 + 4 + 1$.</li>
                        <li>Preencha os bits: 1 (no 8), 1 (no 4), 0 (no 2), 1 (no 1).</li>
                        <li>Resultado: $(1101)_2$.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "8",
                Statement = """
                    <p><b>Conversão Direta:</b> Converta o byte binário $11110001_2$ para Hexadecimal usando a técnica de fatiamento (Nibbles).</p>
                """,
                Solution = """
                    <ul>
                        <li>Divida em dois grupos de 4 bits: $[1111]$ e $[0001]$.</li>
                        <li>Nibble 1 (1111): $8+4+2+1 = 15 \rightarrow \mathbf{F}$.</li>
                        <li>Nibble 2 (0001): $0+0+0+1 = 1 \rightarrow \mathbf{1}$.</li>
                        <li>Resultado: $F1_{16}$.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "9",
                Statement = """
                    <p><b>Cores RGB:</b> No padrão de cores Web, o código <b>#00FF00</b> representa qual cor pura e qual é a intensidade decimal do canal Verde?</p>
                """,
                Solution = """
                    <ul>
                        <li>O formato é #RRGGBB.</li>
                        <li>RR (Vermelho) = 00. BB (Azul) = 00.</li>
                        <li>GG (Verde) = FF.</li>
                        <li>Converta FF para decimal: $15 \cdot 16^1 + 15 \cdot 16^0 = 240 + 15 = 255$.</li>
                        <li>Cor: <b>Verde Puro</b> com intensidade máxima (255).</li>
                    </ul>
                """
            },
            new()
            {
                Id = "10",
                Statement = """
                    <p><b>Soma Simples em Hex:</b> Sem converter para decimal, qual é o resultado da soma $9_{16} + 2_{16}$ em Hexadecimal?</p>
                """,
                Solution = """
                    <ul>
                        <li>Conte sequencialmente a partir do 9 na base 16.</li>
                        <li>$9 + 1 = A$.</li>
                        <li>$9 + 2 = B$.</li>
                        <li>Resultado: $\mathbf{B}_{16}$.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "11",
                Statement = """
                    <p><b>Conversão Inversa RGB:</b> Se a intensidade do canal azul é $10_{10}$ (dez decimal), como isso é representado em Hexadecimal (2 dígitos)?</p>
                """,
                Solution = """
                    <ul>
                        <li>Valor decimal: 10.</li>
                        <li>Símbolo Hex correspondente: A.</li>
                        <li>Como o padrão RGB exige 2 dígitos (1 Byte), adicionamos o zero à esquerda.</li>
                        <li>Resultado: $0A_{16}$.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "12",
                Statement = """
                    <p><b>Análise de Endereço:</b> Converta o endereço hexadecimal de memória <b>0x2C</b> para binário.</p>
                """,
                Solution = """
                    <ul>
                        <li>Separe os dígitos: 2 e C.</li>
                        <li>Converta 2: $0010_2$.</li>
                        <li>Converta C (12): $8+4=12 \rightarrow 1100_2$.</li>
                        <li>Junte os nibbles: $00101100_2$.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "13",
                Statement = """
                    <p><b>Cálculo Posicional:</b> Dado o número Hexadecimal $20_{16}$, qual é o seu valor em decimal? Cuidado: não é vinte.</p>
                """,
                Solution = """
                    <ul>
                        <li>Aplique a decomposição polinomial: $d_1 \cdot 16^1 + d_0 \cdot 16^0$.</li>
                        <li>$2 \cdot 16 + 0 \cdot 1$.</li>
                        <li>$32 + 0$.</li>
                        <li>Resultado: $32_{10}$.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "14",
                Statement = """
                    <p><b>Maior Valor do Byte:</b> Qual é o maior número decimal que pode ser representado por um par hexadecimal (ex: FF)?</p>
                """,
                Solution = """
                    <ul>
                        <li>O maior par é $FF_{16}$.</li>
                        <li>$F = 15$.</li>
                        <li>Cálculo: $15 \cdot 16^1 + 15 \cdot 16^0$.</li>
                        <li>$240 + 15 = 255$.</li>
                        <li>Resultado: $255_{10}$.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "15",
                Statement = """
                    <p><b>Padrão Visual:</b> Converta a sequência binária alternada $10101010_2$ para Hexadecimal.</p>
                """,
                Solution = """
                    <ul>
                        <li>Divida em nibbles: $[1010]$ e $[1010]$.</li>
                        <li>Analise o primeiro nibble: $8+2 = 10 \rightarrow \mathbf{A}$.</li>
                        <li>O segundo nibble é idêntico.</li>
                        <li>Resultado: $AA_{16}$.</li>
                    </ul>
                """
            },

            // === NÍVEL 3: ANÁLISE (DIFÍCIL) ===
            new()
            {
                Id = "16",
                Statement = """
                    <p><b>Taxa de Compressão:</b> O texto menciona que o Hexadecimal atua como uma "lente de compressão". Se tivermos um endereço de memória de 64 bits, quantos caracteres economizamos ao escrevê-lo em Hexadecimal em vez de Binário?</p>
                """,
                Solution = """
                    <ul>
                        <li>Binário: Necessita de <b>64 caracteres</b> (um para cada bit).</li>
                        <li>Hexadecimal: A taxa de conversão é 4:1 (4 bits = 1 hex).</li>
                        <li>Cálculo: $64 \div 4 = 16$ caracteres hexadecimais.</li>
                        <li>Economia: $64 - 16 = 48$.</li>
                        <li>Conclusão: Economizamos a escrita de 48 glifos, tornando a leitura humanamente viável.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "17",
                Statement = """
                    <p><b>Invariância do Valor:</b> "O Hexadecimal não mudou o valor do número; ele mudou nossa capacidade de lidar com ele." Explique essa frase com base no conceito de abstração numérica.</p>
                """,
                Solution = """
                    <ul>
                        <li>O "número" é uma entidade abstrata (quantidade).</li>
                        <li>As bases (2, 10, 16) são apenas sistemas linguísticos de representação.</li>
                        <li>A quantidade elétrica no computador permanece a mesma (voltagens altas/baixas).</li>
                        <li>O Hexadecimal é isomórfico ao binário; ele é apenas uma forma agrupada de escrever a mesma coisa, facilitando a cognição humana sem alterar a semântica da máquina.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "18",
                Statement = """
                    <p><b>Design de Sistemas:</b> Por que a notação <b>0x</b> (como em 0xFF) é crítica para a programação, em vez de escrever apenas FF?</p>
                """,
                Solution = """
                    <ul>
                        <li>Ambiguidade: Em muitos contextos, "FF" poderia ser o nome de uma variável, uma constante ou texto.</li>
                        <li>"10" poderia ser dez decimal, dois binário (10) ou dezesseis hex (10).</li>
                        <li>O prefixo <b>0x</b> elimina a ambiguidade sintática, informando explicitamente ao compilador e ao humano que a string deve ser interpretada usando base 16.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "19",
                Statement = """
                    <p><b>Lógica de Bijeção:</b> Se tentássemos criar um sistema de "Base 100" para compactar ainda mais os bits, por que ele seria menos eficiente para o humano que o Hexadecimal, apesar de comprimir mais?</p>
                """,
                Solution = """
                    <ul>
                        <li>A Base 16 equilibra compressão e memorização. Temos apenas 6 símbolos novos (A-F) para aprender.</li>
                        <li>Uma Base 100 exigiria 100 símbolos únicos (0-9, a-z, A-Z, símbolos gregos, etc.).</li>
                        <li>A carga cognitiva para memorizar a tabela de conversão de 100 símbolos superaria o benefício da compressão visual, violando o princípio de usabilidade.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "20",
                Statement = """
                    <p><b>Conexão Hardware-Software:</b> Como a adoção do sistema Hexadecimal reflete a evolução física dos barramentos de dados (8, 16, 32, 64 bits)?</p>
                """,
                Solution = """
                    <ul>
                        <li>Todos os barramentos modernos são potências de 2 e múltiplos de 4.</li>
                        <li>8 bits = 2 hex. 32 bits = 8 hex. 64 bits = 16 hex.</li>
                        <li>O sistema Hexadecimal escala linearmente com a largura do barramento.</li>
                        <li>Se usássemos base 10, um número de 32 bits poderia ter 10 dígitos, mas um número de 33 bits também, perdendo a correspondência visual direta de "tamanho do número" vs "tamanho do armazenamento".</li>
                    </ul>
                """
            }
        }
    };
}