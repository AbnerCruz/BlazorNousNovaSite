namespace SchoolData.Disciplines;

public class DisciplineMath : Discipline
{
    public DisciplineMath()
    {
        Name = "Matemática";
        Label = "math";
        Price = 45;
        Subtitle = "Esqueça os truques de memorização. Aqui, você vai entender a estrutura da realidade. Inspirados pelas mentes que construíram a ciência moderna, desenhamos um caminho que leva você da Lógica Pura ao Cálculo Avançado com um rigor nunca antes visto no Brasil.";
        Description = "A disciplina de Matemática do nosso Centro de Estudos rejeita a fragmentação tradicional do ensino escolar. Em vez de memorizar fórmulas desconexas, adotamos o Sistema Hexagonal, uma arquitetura curricular inspirada no rigor de grupos com sucesso internacional como os Bourbaki, Harvard entre outros. O curso é estruturado em 6 Domínios Sinfônicos, que operam integrados para construir não apenas o conhecimento, mas a capacidade de raciocínio abstrato superior.";
        Courses = GenerateCourses();
        Sections = GenerateSections();
        Sections.Add("Conteúdos", Courses);
        Active = true;
    }

    public override List<Course> GenerateCourses()
    {
        return new List<Course>
        {
            new Course()
            {
                Id="math1",
                Name = "Matemática I",
                // Estimativa Total: ~7 Meses
                Curriculum = new()
                {
                    new()
                    {
                        Name = "Sistemas de Numeração e Bases",
                        Duration = "3 Semanas",
                        Contents = new()
                        {
                            new()
                            {
                                Id="fundamentos-do-valor-posicional",
                                Name="Fundamentos do Valor Posicional",
                                Body= """
                                    <h1>Capítulo 1: Fundamentos do Valor Posicional</h1>
                                    <h3>1.1. Correspondência e Agrupamento</h3>
                                    <p style="text-indent: 4em; text-align: justify">Eu gostaria que você fizesse um experimento rápido: Imagine que eu coloco 4 maçãs sobre a mesa e cubro-as com um pano. Se eu levantar o pano por meio segundo, você saberá instantaneamente que são 4. Você não precisa dizer "um, dois, três, quatro". Você vê a "quantidade" da cena.</p>
                                    <p style="text-indent: 4em; text-align: justify">Agora, imagine que eu despejo 37 maçãs na mesa e levanto o pano pelo mesmo meio segundo. O que você vê? Você não vê "37". Você vê "muitas".</p>
                                    <br>
                                    <p style="text-indent: 4em; text-align: justify">Bem-vindo à sua primeira limitação. O cérebro humano, biologicamente, não foi feito para contar. Ele possui um sistema primitivo chamado subitização, que é um buffer visual capaz de registrar instantaneamente cerca de 4 itens. Acima disso, a precisão colapsa. Para o seu cérebro primata, a diferença entre 4 e 5 é nítida, mas a diferença entre 37 e 38 é invisível.</p>
                                    <p style="text-indent: 4em; text-align: justify">Então, como nós construímos uma sociedade tecnológica e quantitativamente complexa se somos biologicamente incapazes de distinguir grandes quantidades num relance?</p>
                                    <br>
                                    <p>Inventamos uma tecnologia!</p>
                                    <br>
                                    <p style="text-indent: 4em; text-align: justify">Vamos voltar no tempo. Imagine um pastor pré-histórico, vamos chamá-lo de Ur. Ur tem um problema: ele possui um rebanho de 500 ovelhas (embora ele não saiba o que significa "500", nem tenha palavras para números acima de três). Toda manhã ele solta as ovelhas para pastar. Toda noite elas voltam.</p>
                                    <p style="text-indent: 4em; text-align: justify">Como Ur sabe se todas voltaram? Ele não pode contá-las. A "contagem" ainda não foi inventada. Se uma ovelha for comida por um lobo, e 499 voltarem, a subitização de Ur não vai disparar nenhum alarme. Ele verá "muitas" saindo e "muitas" voltando.</p>
                                    <p style="text-indent: 4em; text-align: justify">A solução de Ur é brilhante em sua simplicidade. Ele não precisa saber quantas ovelhas existem. Ele só precisa saber se a quantidade que sai é igual à quantidade que entra.</p>
                                    <p style="text-indent: 4em; text-align: justify">Ele pega um saco de couro e, para cada ovelha que sai do curral pela manhã, ele coloca uma pedra dentro do saco.</p>
                                    <ul>
                                        <li>Sai uma ovelha $\rightarrow$ Entra uma pedra.</li>
                                        <li>Sai outra ovelha $\rightarrow$ Entra outra pedra.</li>
                                    </ul>
                                    <br>
                                    <p>À noite, ele faz o inverso.</p>
                                    <ul>
                                        <li>Entra uma ovelha $\rightarrow$ Sai uma pedra.</li>
                                    </ul>
                                    <br>
                                    <p style="text-indent: 4em; text-align: justify">Se o saco estiver vazio quando a última ovelha entrar, tudo está perfeito. Se sobrar uma pedra no saco, Ur sabe que precisa pegar sua lança e caçar um lobo. Ur acabou de inventar a matemática. Ele percebeu que não precisa lidar com as ovelhas diretamente; ele pode lidar com representantes das ovelhas. Em latim, "pedra pequena" se diz calculus. Daí vem a palavra "Cálculo".</p>
                                    <br>
                                    <p style="text-indent: 4em; text-align: justify">O que Ur fez tem um nome técnico sofisticado, mas o conceito é simples. Chamamos isso de Correspondência Biunívoca (ou correspondência um-para-um).</p>
                                    <br>
                                    <p style="text-indent: 4em; text-align: justify">A beleza dessa tecnologia é que ela ignora a natureza dos objetos. Não importa se são ovelhas, maçãs ou dias da semana. Se você consegue ligar cada elemento do Grupo A (ovelhas) a um elemento único do Grupo B (pedras), e não sobra nada, então os conjuntos têm o mesmo "tamanho".</p>
                                    <br>
                                    <p style="text-indent: 4em; text-align: justify">O sistema de pedras funciona muito bem, até que Ur se torna muito rico. Agora ele tem 1.000 ovelhas. Carregar um saco com 1.000 pedras é fisicamente inviável. É pesado, o saco rasga, e contar as pedras uma a uma demora muito. Ur atingiu um gargalo de largura de banda.</p>
                                    <br>
                                    <p>Ele precisa de uma nova tecnologia: Compressão de Dados.</p>
                                    <br>
                                    <p style="text-indent: 4em; text-align: justify">Então decide o seguinte: "Não vou carregar 1.000 pedras brancas. Vou estabelecer uma regra: cada vez que eu juntar 10 pedras brancas, eu as troco por 1 concha azul."</p>
                                    <ul>
                                        <li>10 Pedras Brancas $\leftrightarrow$ 1 Concha Azul.</li>
                                        <li>10 Conchas Azuis $\leftrightarrow$ 1 Pena Vermelha.</li>
                                    </ul>
                                    <br>
                                    <p>Veja o que aconteceu. Ur parou de contar unidades e começou a contar grupos. Ele inventou a Base Numérica.</p>
                                    <br>
                                    <p style="text-indent: 4em; text-align: justify">Por que Ur escolheu trocar a cada 10 pedras? Existe alguma propriedade mística no número 10? Não. É apenas um fator biológico. Temos 10 dedos. Se fôssemos personagens dos Simpsons, usaríamos base 8. Se fôssemos alienígenas com três tentáculos, usaríamos base 3. O sistema baseado em 10 é uma convenção antropométrica, não necessariamente uma verdade suprema.</p>
                                    <p style="text-indent: 4em; text-align: justify">Historicamente, outras civilizações pensaram diferente. Os Sumérios e Babilônios usavam base 60. Por que? Pense em uma pizza.</p>
                                    <br>
                                    <ul>
                                        <li>Tente dividir 10 fatias para 3 pessoas. Dá confusão ($3,333...$).</li>
                                        <li>Tente dividir 10 fatias para 4 pessoas. Dá confusão ($2,5$).</li>
                                        <li>Agora pegue o número 12 (uma base comum antiga). Divide por 2, 3, 4 e 6 perfeitamente.</li>
                                        <li>Pegue 60. Divide por 2, 3, 4, 5, 6, 10, 12, 15, 20, 30.</li>
                                    </ul>
                                    <br>
                                    <p style="text-indent: 4em; text-align: justify">Do ponto de vista de engenharia e comércio, bases "altamente compostas" (como 12 e 60) são superiores à base 10. Mas os dedos venceram a batalha histórica.</p>
                                    <p>Até agora usamos intuição. Vamos traduzir o que Ur fez para a linguagem formal. Não se assuste com os símbolos ou a dificuldade, vamos nos aprofundar muitas vezes nesses assuntos que, no momento, são apenas abreviações para as ideias que já discutimos.</p>
                                    <div class="card">
                                    <p>Definição 1.1.1: Correspondência Biunívoca (Bijeção)</p>
                                    <p>Sejam $A$ e $B$ dois conjuntos finitos. Uma função $f: A \to B$ é dita uma correspondência biunívoca se for:</p>
                                    <ul>
                                        <li>Injetora: Elementos distintos em $A$ têm imagens distintas em $B$ (ninguém compartilha a mesma pedra).</li>
                                    </ul>
                                    <p>$$\forall x, y \in A, f(x) = f(y) \implies x = y$$</p>
                                    <ul>
                                        <li>Sobrejetora: Todo elemento em $B$ é atingido por alguém em $A$ (não sobram pedras sem uso no saco padrão).</li>
                                    </ul>
                                    <br>
                                    <p>$$\forall y \in B, \exists x \in A \text{ tal que } f(x) = y$$</p>
                                    </div>
                                    <p style="text-indent: 4em; text-align: justify">Se existe tal bijeção, dizemos que a cardinalidade (tamanho) de $A$ é igual à de $B$, denotado por $|A| = |B|$.</p>
                                    <br>
                                    <p style="text-indent: 4em; text-align: justify">Contar, portanto, nada mais é do que estabelecer uma bijeção entre o seu conjunto de objetos e um conjunto que temos por padrão dos Números Naturais $\mathbb{N}_k = \{1, 2, ..., k\}$.</p>
                                    <br>
                                    <p style="text-indent: 4em; text-align: justify">Quando Ur trocou 10 pedras por 1 concha, ele estava aplicando o que chamamos de Algoritmo da Divisão Euclidiana. Isso é o motor de qualquer sistema numérico posicional.</p>
                                    <div class="card">
                                    <p>Axioma 1.1.2: Decomposição em Base $b$</p>
                                    <p>Para qualquer número inteiro $N$ (a quantidade total) e uma base inteira $b > 1$ (o tamanho do grupo), existem inteiros únicos $q$ (quociente) e $r$ (resto) tais que:</p>
                                    <p>$$N = q \cdot b + r$$</p>
                                    <p>Onde a condição crucial é $0 \le r < b$.</p>
                                    </div>
                                    <br>
                                    <p>Para entender essa igualdade tente considerar que:</p>
                                    <ul>
                                        <li>$N$ é o total de ovelhas.</li>
                                        <li>$b$ é a taxa de troca (ex: 10 pedras por concha).</li>
                                        <li>$q$ é o número de conchas (grupos de nível superior).</li>
                                        <li>$r$ são as pedras soltas (unidades que não formaram um grupo).</li>
                                    </ul>
                                    <br>
                                    <p style="text-indent: 4em; text-align: justify">Antes de chegarmos ao sistema moderno, a humanidade tentou algo mais simples: o Sistema Aditivo (como os hieróglifos egípcios ou números romanos).</p>
                                    <br>
                                    <p>O valor do número $V$ é simplesmente a soma dos símbolos:</p>
                                    <p>$$V = \sum_{i=1}^{k} \text{Valor}(glifo_i)$$</p>
                                    <br>
                                    <p style="text-indent: 4em; text-align: justify">O problema disso? Escala. Para escrever "nove" em romano primitivo, você precisaria de VIIII. Para escrever um milhão, você precisaria inventar um símbolo novo ou escrever o símbolo de "mil" mil vezes. A complexidade cresce linearmente, o que é terrível.</p>
                                    <br>
                                    <p>"Ok, professor, mas eu não sou um pastor de ovelhas." Certo, mas você usa computador, celular, tablet, televisão etc...</p>
                                    <br>
                                    <p style="text-indent: 4em; text-align: justify">Você já viu códigos de cores como #FFFFF ou endereços de memória como 0x4A? Isso é o sistema de Base 16 (Hexadecimal).</p>
                                    <br>
                                    <p style="text-indent: 4em; text-align: justify">Por que 16? Porque computadores "pensam" em binário; que é um sistema de base 2 com os símbolos {0 e 1}. Mas ler 10110101 é doloroso para humanos.</p>
                                    <br>
                                    <p style="text-indent: 4em; text-align: justify">Como $16 = 2^4=2 \times 2 \times 2 \times 2$, podemos agrupar cada 4 bits e trocá-los por um símbolo “Hex”.</p>
                                    <br>
                                    <ul>
                                        <li>1111 (binário) = 15 (decimal) = F (Hex).</li>
                                    </ul>
                                    <br>
                                    <p style="text-indent: 4em; text-align: justify">O Hexadecimal não é mágico. É apenas a estratégia de Ur aplicada a bits: "Troque cada 4 pedrinhas de bits por 1 concha Hexadecimal para economizar espaço na bolsa".</p>
                                    <br>
                                    <p style="text-indent: 4em; text-align: justify">Olhe para o relógio. Por que o dia tem 24 horas? Por que a hora tem 60 minutos? Por que o círculo tem 360 graus?</p>
                                    <p style="text-indent: 4em; text-align: justify">Porque os babilônios venceram essa parte da história. A divisibilidade do 12 e do 60 é tão prática para "fatiar" o tempo e o espaço sem criar números quebrados e irritantes que mantemos esse sistema há 4.000 anos.</p>
                                    <br>
                                    <p style="text-indent: 4em; text-align: justify">Vamos fazer um exercício mental juntos. Quero que você esqueça a base 10 por um tempo e vamos operar na Base 4: Imagine que você tem 35 maçãs. Como representamos isso na Base 4?</p>
                                    <p>Não tente adivinhar. Use o algoritmo da divisão (Axioma 1.1.2).</p>
                                    <br>
                                    <p>Nossa base $b = 4$. Nosso total $N = 35$.</p>
                                    <ul>
                                        <li>Quantos grupos de 4 cabem em 35?</li>
                                    </ul>
                                    <br>
                                    <p>$35 \div 4 = 8$ grupos, e sobram $3$ maçãs.</p>
                                    <br>
                                    <p>Então, temos 8 grupos, e 3 unidades soltas. (Lembre-se desse 3).</p>
                                    <ul>
                                        <li>Mas espere, temos 8 grupos. Na Base 4, se você tem 4 coisas, você deve agrupá-las novamente!</li>
                                    </ul>
                                    <br>
                                    <p>Quantos grupos de 4 formamos com os 8?</p>
                                    <p>$8 \div 4 = 2$ "super-grupos", e sobra 0.</p>
                                    <ul>
                                        <li>Temos agora 2 "super-grupos". Eles conseguem formar algum novo grupo ainda maior?</li>
                                    </ul>
                                    <br>
                                    <p>Não, porque $2 < 4$. Então paramos.</p>
                                    <br>
                                    <p>Resultado: 2 super-grupos, 0 grupos na base e 3 unidades.</p>
                                    <p>Na Base 4, o número 35 se escreve 203.</p>
                                    <br>
                                    <p>Isso significa: $2 \cdot (4^2) + 0 \cdot (4^1) + 3 \cdot (4^0) = 32 + 0 + 3 = 35$.</p>
                                    <br>
                                    <p style="text-indent: 4em; text-align: justify">Veja como a matemática é consistente! É apenas empilhar caixas dentro de caixas, grupos dentro de grupos.</p>
                                    <br>
                                    <p>Agora, aqui está o problema que quase destruiu a matemática antiga.</p>
                                """
                            },
                            new()
                            {
                                Id="logica-binaria-e-computacional",
                                Name="Lógica Binária e Computacional",
                                Body= """
                                    <h1>Capítulo 2: Lógica Binária e Computacional</h1>
                                    <h3>2.1. Minimização de Estados</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Redução de Complexidade: Sistemas de dois estados $\{0, 1\}$.</li>
                                        <li>Restrições Físicas: Estabilidade em sistemas discretos (On/Off).</li>
                                    </ul>
                                    <h3>2.2. Sistema Binário (Base 2)</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Alfabeto Binário: $\Sigma_2 = \{0, 1\}$.</li>
                                        <li>Conversão Decimal $\to$ Binário: Algoritmo das Divisões Euclidianas Sucessivas.</li>
                                        <li>Conversão Binário $\to$ Decimal: Avaliação polinomial em $b=2$.</li>
                                    </ul>
                                    <h3>2.3. Aritmética Binária</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Adição: O algoritmo do transporte (Carry) em $\mathbb{Z}_2$: $1_2 + 1_2 = 10_2$.</li>
                                        <li>Subtração: Método do Complemento de 2 (Aritmética sem sinal negativo explícito).</li>
                                        <li>Universalidade Aritmética: Invariância das propriedades de corpo em qualquer base.</li>
                                    </ul>
                                """
                            },
                            new()
                            {
                                Id="abstracao-e-hexadecimal",
                                Name="Abstração e Hexadecimal",
                                Body= """
                                    <h1>Capítulo 3: Abstração e Hexadecimal</h1>
                                    <h3>3.1. Interface Humano-Máquina</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Legibilidade: Compressão de bitstrings.</li>
                                        <li>Mapeamento: O problema da leitura de longas cadeias binárias.</li>
                                    </ul>
                                    <h3>3.2. Sistema Hexadecimal (Base 16)</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Relação de Potências: Isomorfismo entre 1 dígito Hex e 4 bits ($2^4 = 16$).</li>
                                        <li>Alfabeto Estendido: $\Sigma_{16} = \{0\dots9, A\dots F\}$.</li>
                                        <li>Algoritmo de Conversão Direta: Agrupamento por nibbles.</li>
                                    </ul>
                                    <h3>3.3. Generalização de Bases</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Definição de Base Arbitrária $b \in \mathbb{N}, b \ge 2$.</li>
                                        <li>O Algarismo como Função: $d(pos) < b$.</li>
                                        <li>Invariância do Número: O objeto abstrato vs. sua representação linguística.</li>
                                    </ul>
                                """
                            },
                        }
                    },
                    new()
                    {
                        Name = "Algoritmos de Aritmética Mental",
                        Duration = "4 Semanas", // Exige prática repetitiva para fixar
                        Contents = new()
                        {
                            new()
                            {
                                Id="otimizacao-cognitiva",
                                Name="Otimização Cognitiva",
                                Body= """
                                    <h1>Capítulo 1: Otimização Cognitiva</h1>
                                    <h3>1.1. Custo Computacional</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Limitações da Memória de Trabalho: O gargalo do algoritmo serial.</li>
                                        <li>Comparativo: Algoritmos Seriais vs. Algoritmos Paralelos/Padronizados.</li>
                                    </ul>
                                    <h3>1.2. Algoritmos Védicos</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Reconhecimento de Padrões: Aritmética baseada em heurísticas algébricas.</li>
                                        <li>Algoritmo do Complemento: Nikhilam Navatashcaramam Dashatah.</li>
                                        <li>Subtração de Potências: $10^n - N$ via complementos.</li>
                                    </ul>
                                    <h3>1.3. Complemento Aritmético</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Definição Formal: Complemento $C = b^n - N$.</li>
                                        <li>Demonstração Algébrica: A equivalência entre subtração sequencial e complemento nove.</li>
                                    </ul>
                                """
                            },
                            new()
                            {
                                Id="multiplicacao-nao-linear",
                                Name="Multiplicação Não-Linear",
                                Body= """
                                    <h1>Capítulo 2: Multiplicação Não-Linear</h1>
                                    <h3>2.1. Gestão de Produtos Parciais</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Complexidade do Algoritmo Escada: $O(n^2)$ passos e armazenamento intermediário.</li>
                                    </ul>
                                    <h3>2.2. Método Vertical e Cruzado</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Algoritmo Urdhva Tiryagbhyam: Redução à linha única.</li>
                                        <li>Processo: $\text{Unidade} \to \text{Produto Cruzado} \to \text{Dezena}$.</li>
                                    </ul>
                                    <h3>2.3. Fundamentação Polinomial</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Isomorfismo Polinomial: Mapeamento $N \mapsto P(x)$ onde $x=10$.</li>
                                        <li>Produto de Binômios: $(ax+b)(cx+d) = acx^2 + (ad+bc)x + bd$.</li>
                                        <li>Correspondência de Coeficientes: Visualização dos termos do polinômio no algoritmo.</li>
                                    </ul>
                                """
                            },
                            new()
                            {
                                Id="identidades-e-casos-especiais",
                                Name="Identidades e Casos Especiais",
                                Body= """
                                    <h1>Capítulo 3: Identidades e Casos Especiais</h1>
                                    <h3>3.1. Heurísticas para Potenciação</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Redução de Complexidade para Classes Específicas.</li>
                                    </ul>
                                    <h3>3.2. Algoritmos de Quadrados</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Classe $N \equiv 5 \pmod{10}$: Algoritmo $n(n+1) | 25$.</li>
                                        <li>Vizinhança de Base: Quadrados próximos a $5 \cdot 10^k$.</li>
                                    </ul>
                                    <h3>3.3. Demonstrações Algébricas</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Prova (Final 5): $(10n+5)^2 = 100n(n+1) + 25$.</li>
                                        <li>Prova (Vizinhança 50): $(50+x)^2 = 100(25+x) + x^2$.</li>
                                    </ul>
                                """
                            },
                            new()
                            {
                                Id="teoria-da-aproximacao",
                                Name="Teoria da Aproximação",
                                Body= """
                                    <h1>Capítulo 4: Teoria da Aproximação</h1>
                                    <h3>4.1. Incerteza e Escala</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Limitações de Precisão: Dados incompletos e modelagem estocástica.</li>
                                        <li>Paralisia Analítica vs. Estimativa de Ordem.</li>
                                    </ul>
                                    <h3>4.2. Decomposição de Fermi</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Método: Fatoração do problema em variáveis estimáveis.</li>
                                        <li>Limites: Definição de Lower Bound e Upper Bound.</li>
                                    </ul>
                                    <h3>4.3. Ordens de Grandeza</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Notação Científica: $m \cdot 10^e$.</li>
                                        <li>Aritmética de Expoentes: Dominância do termo $10^e$.</li>
                                        <li>Média Geométrica: Estimativa central $\mu_g = \sqrt{min \cdot max}$.</li>
                                    </ul>
                                """
                            }
                        }
                    },
                    new()
                    {
                        Name = "Aritmética Estrutural",
                        Duration = "4 Semanas", // O aluno precisa aprender a provar o óbvio
                        Contents = new()
                        {
                            new()
                            {
                                Id="axiomatica-das-operacoes",
                                Name="Axiomática das Operações",
                                Body= """
                                    <h1>Capítulo 1: Axiomática das Operações</h1>
                                    <h3>1.1. Definição de Operação</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Operadores Binários: Funções $*: S \times S \to S$.</li>
                                        <li>Unicidade do Resultado: Determinismo operatório.</li>
                                    </ul>
                                    <h3>1.2. Propriedades Estruturais</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Comutatividade: Invariância sob permutação.</li>
                                        <li>Elemento Neutro (Identidade): Aditivo ($0$) e Multiplicativo ($1$).</li>
                                        <li>Distributividade: A conexão entre os anéis de soma e produto.</li>
                                    </ul>
                                    <h3>1.3. Estruturas Algébricas ($\mathbb{Z}$)</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Axioma do Fechamento: $\forall a,b \in \mathbb{Z} \implies a+b \in \mathbb{Z}$.</li>
                                        <li>Axioma da Associatividade: $(a+b)+c = a+(b+c)$.</li>
                                        <li>Estrutura de Anel Comutativo com Unidade.</li>
                                    </ul>
                                """
                            },
                            new()
                            {
                                Id="algoritmo-da-divisao",
                                Name="Algoritmo da Divisão",
                                Body= """
                                    <h1>Capítulo 2: Algoritmo da Divisão</h1>
                                    <h3>2.1. O Problema da Divisão em $\mathbb{Z}$</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Não-Fechamento: A inexistência de inverso multiplicativo para inteiros.</li>
                                    </ul>
                                    <h3>2.2. Divisão Euclidiana</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Definição Construtiva: Subtrações iteradas.</li>
                                        <li>Componentes: Dividendo, Divisor, Quociente, Resto.</li>
                                    </ul>
                                    <h3>2.3. Teorema da Divisão Euclidiana</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Enunciado: $\forall a, b \in \mathbb{Z}, b > 0, \exists! (q, r)$ tais que:$$a = b \cdot q + r$$</li>
                                        <li>Condição de Contorno: $0 \le r < |b|$.</li>
                                        <li>Prova de Existência e Unicidade.</li>
                                    </ul>
                                """
                            },
                            new()
                            {
                                Id="teoria-da-divisibilidade",
                                Name="Teoria da Divisibilidade",
                                Body= """
                                    <h1>Capítulo 3: Teoria da Divisibilidade</h1>
                                    <h3>3.1. Relação de Divisibilidade</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Definição Formal: $a | b \iff \exists k \in \mathbb{Z}, b = a \cdot k$.</li>
                                        <li>Propriedades: Reflexividade, Transitividade e Antissimetria (nos naturais).</li>
                                    </ul>
                                    <h3>3.2. Teoremas Fundamentais</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Combinação Linear: $d|a \land d|b \implies d|(ax+by)$.</li>
                                        <li>Conjuntos Associados: $D(n)$ (Divisores) e $M(n)$ (Múltiplos).</li>
                                    </ul>
                                """
                            },
                            new()
                            {
                                Id="introducao-a-aritmetica-modular",
                                Name="Introdução à Aritmética Modular",
                                Body= """
                                    <h1>Capítulo 4: Introdução à Aritmética Modular</h1>
                                    <h3>4.1. Sistemas Cíclicos</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Modelagem de fenômenos periódicos.</li>
                                    </ul>
                                    <h3>4.2. Congruência Modular</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Definição (Gauss): $a \equiv b \pmod m \iff m | (a-b)$.</li>
                                        <li>Classes de Equivalência: O conjunto quociente $\mathbb{Z}_m$.</li>
                                    </ul>
                                    <h3>4.3. Aritmética de Classes</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Operações em $\mathbb{Z}_m$: Soma e Produto de resíduos.</li>
                                        <li>Preservação das operações na congruência.</li>
                                    </ul>
                                """
                            }
                        }
                    },
                    new()
                    {
                        Name = "Lógica Formal e Conjuntos",
                        Duration = "5 Semanas", // Lógica Booleana é uma linguagem nova
                        Contents = new()
                        {
                            new()
                            {
                                Id="logica-proposicional",
                                Name="Lógica Proposicional",
                                Body= """
                                    <h1>Capítulo 1: Lógica Proposicional</h1>
                                    <h3>1.1. Formalização da Linguagem</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Proposições Atômicas e Valores Verdade $\{V, F\}$.</li>
                                        <li>Independência Semântica: Validade vs. Verdade.</li>
                                    </ul>
                                    <h3>1.2. Álgebra Booleana</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Isomorfismo com Aritmética Binária.</li>
                                        <li>Tabelas-Verdade como método de prova exaustiva.</li>
                                    </ul>
                                    <h3>1.3. Cálculo Proposicional</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Conectivos: $\neg$ (Negação), $\land$ (Conjunção), $\lor$ (Disjunção).</li>
                                        <li>Implicação Material ($p \implies q$) e Equivalência ($p \iff q$).</li>
                                        <li>Tautologias e Contradições.</li>
                                    </ul>
                                """
                            },
                            new()
                            {
                                Id="teoria-ingenua-dos-conjuntos",
                                Name="Teoria Ingênua dos Conjuntos",
                                Body= """
                                    <h1>Capítulo 2: Teoria Ingênua dos Conjuntos</h1>
                                    <h3>2.1. Definições Primitivas</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Paradoxo de Russell: Limites da definição por compreensão.</li>
                                        <li>Axioma da Existência: O Conjunto Vazio $\emptyset$.</li>
                                    </ul>
                                    <h3>2.2. Pertinência e Inclusão</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Relação Fundamental: $x \in A$.</li>
                                        <li>Subconjuntos: $A \subseteq B \iff \forall x (x \in A \implies x \in B)$.</li>
                                        <li>Axioma da Extensionalidade: Critério de igualdade de conjuntos.</li>
                                    </ul>
                                """
                            },
                            new()
                            {
                                Id="algebra-de-conjuntos",
                                Name="Álgebra de Conjuntos",
                                Body= """
                                    <h1>Capítulo 3: Álgebra de Conjuntos</h1>
                                    <h3>3.1. Operações Setoriais</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>União ($A \cup B$), Interseção ($A \cap B$), Diferença ($A \setminus B$).</li>
                                        <li>Complementar: $A^c$.</li>
                                    </ul>
                                    <h3>3.2. Leis de De Morgan</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Dualidade entre União/Interseção e Lógica OU/E. $$(A \cup B)^c = A^c \cap B^c$$</li>
                                    </ul>
                                """
                            },
                            new()
                            {
                                Id="cardinalidade-e-infinito",
                                Name="Cardinalidade e Infinito",
                                Body= """
                                    <h1>Capítulo 4: Cardinalidade e Infinito</h1>
                                    <h3>4.1. Mensuração de Conjuntos</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Conceito de Bijeção como medida de equinumerosidade.</li>
                                        <li>Cardinalidade Finita vs. Infinita.</li>
                                    </ul>
                                    <h3>4.2. Teorema de Cantor</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Conjunto das Partes: $\mathcal{P}(A) = \{S \mid S \subseteq A\}$.</li>
                                        <li>Teorema: $|A| < |\mathcal{P}(A)|$.</li>
                                        <li>Hierarquia dos Infinitos (Aleph-0, Aleph-1).</li>
                                    </ul>
                                """
                            },
                            new()
                            {
                                Id="classificacao-numerica",
                                Name="Classificação Numérica",
                                Body= """
                                    <h1>Capítulo 5: Classificação Numérica</h1>
                                    <h3>5.1. Completude dos Sistemas</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Deficiências Algébricas de $\mathbb{N}$ e $\mathbb{Z}$.</li>
                                        <li>Densidade de $\mathbb{Q}$.</li>
                                    </ul>
                                    <h3>5.2. A Reta Real</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Irracionais ($\mathbb{I}$): Incomensurabilidade geométrica.</li>
                                        <li>Cadeia de Inclusão: $\mathbb{N} \subset \mathbb{Z} \subset \mathbb{Q} \subset \mathbb{R}$.</li>
                                    </ul>
                                """
                            },
                        }
                    },
                    new()
                    {
                        Name = "Geometria Euclidiana: Fundamentos",
                        Duration = "4 Semanas",
                        Contents = new()
                        {
                            new()
                            {
                                Id="topologia-poligonal",
                                Name="Topologia Poligonal",
                                Body= """
                                    <h1>Capítulo 1: Topologia Poligonal</h1>
                                    <h3>1.1. Definições Primitivas</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Região Planar: Interior vs. Fronteira.</li>
                                        <li>Cadeia Poligonal Fechada Simples.</li>
                                    </ul>
                                    <h3>1.2. Classificação e Propriedades</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Convexidade: Definição via segmentos internos.</li>
                                        <li>Nomenclatura $n$-gonal.</li>
                                    </ul>
                                    <h3>1.3. Métrica Linear</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Perímetro: Funcional $P: \text{Polígono} \to \mathbb{R}^+$.</li>
                                        <li>Desigualdade Poligonal: $l_{max} < \sum l_{outros}$.</li>
                                    </ul>
                                """
                            },
                            new()
                            {
                                Id="teoria-da-medida-area",
                                Name="Teoria da Medida (Área)",
                                Body= """
                                    <h1>Capítulo 2: Teoria da Medida (Área)</h1>
                                    <h3>2.1. Axiomática da Área</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Normalização: Quadrado unitário $Q_1 = 1 u.a$.</li>
                                        <li>Invariância por Congruência e Aditividade Finita.</li>
                                    </ul>
                                    <h3>2.2. Dedução de Fórmulas</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Retângulo ($b \cdot h$) e Paralelogramo.</li>
                                        <li>Triângulo e Polígonos Decomponíveis.</li>
                                    </ul>
                                """
                            },
                            new()
                            {
                                Id="analise-dimensional",
                                Name="Análise Dimensional",
                                Body= """
                                    <h1>Capítulo 3: Análise Dimensional</h1>
                                    <h3>3.1. Álgebra das Grandezas</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Homogeneidade Dimensional: Operações permitidas entre $[L]$ e $[L^2]$.</li>
                                        <li>Conversão de Unidades via Elemento Neutro Multiplicativo.</li>
                                    </ul>
                                    <h3>3.2. Escala</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Relação Quadrática: Se $L \to kL$, então $A \to k^2A$.</li>
                                    </ul>
                                """
                            },
                            new()
                            {
                                Id="semelhanca-e-proporcao",
                                Name="Semelhança e Proporção",
                                Body= """
                                    <h1>Capítulo 4: Semelhança e Proporção</h1>
                                    <h3>4.1. Teorema de Tales</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Feixes de paralelas e transversais.</li>
                                        <li>Proporcionalidade de segmentos homólogos.</li>
                                    </ul>
                                    <h3>4.2. Homotetia</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Definição de Semelhança: Bijeção que preserva ângulos.</li>
                                        <li>Razão de Semelhança $k$: $\frac{AB}{A'B'} = k$.</li>
                                    </ul>
                                """
                            },
                        }
                    },
                    new()
                    {
                        Name = "Geometria Posicional e Tesselações",
                        Duration = "3 Semanas",
                        Contents = new()
                        {
                            new()
                            {
                                Id="plano-cartesiano",
                                Name="Geometria Analítica Plana",
                                Body= """
                                    <h1>Capítulo 1: Geometria Analítica Plana</h1>
                                    <h3>1.1. Coordenadas Ortogonais</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>O Produto Cartesiano $\mathbb{R} \times \mathbb{R}$.</li>
                                        <li>Bijeção Ponto-Par Ordenado $P(x,y)$.</li>
                                    </ul>
                                    <h3>1.2. Métrica Euclidiana</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Distância entre dois pontos: $d(A,B) = \sqrt{\Delta x^2 + \Delta y^2}$.</li>
                                    </ul>
                                """
                            },
                            new(){
                                Id="isometrias-do-plano",
                                Name="Isometrias do Plano",
                                Body= """
                                    <h1>Capítulo 2: Isometrias do Plano</h1>
                                    <h3>2.1. Transformações Rígidas</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Definição: Funções que preservam distâncias ($d(T(u), T(v)) = d(u, v)$).</li>
                                    </ul>
                                    <h3>2.2. Classificação de Isometrias</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Translação (Vetor).</li>
                                        <li>Rotação (Pivô e Ângulo).</li>
                                        <li>Reflexão (Eixo de Simetria).</li>
                                    </ul>
                                """
                            },
                            new()
                            {
                                Id="tesselacoes-regulares",
                                Name="Tesselações Regulares",
                                Body= """
                                    <h1>Capítulo 3: Tesselações Regulares</h1>
                                    <h3>3.1. Recobrimento do Plano</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Condição de Vértice: $\sum \theta_i = 360^\circ$.</li>
                                    </ul>
                                    <h3>3.2. Soluções Inteiras</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Equação Diofantina para Polígonos Regulares $(n-2)(k-2) = 4$.</li>
                                        <li>As três soluções topológicas: Triangular, Quadrangular e Hexagonal.</li>
                                    </ul>
                                """
                            }
                        }
                    },
                    new()
                    {
                        Name = "Lógica de Programação e Algoritmos",
                        Duration = "4 Semanas",
                        Contents = new()
                        {
                            new()
                            {
                                Id="reconhecimento-de-padroes",
                                Name="Reconhecimento de Padrões",
                                Body= """
                                    <h1>Capítulo 1: Reconhecimento de Padrões</h1>
                                    <h3>1.1. Indução e Sequências</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Determinismo: Regra de formação $a_n = f(n)$.</li>
                                    </ul>
                                    <h3>1.2. Progressões Aritméticas e Geométricas</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Definição Recursiva: $a_n = a_{n-1} + r$ (PA) e $a_n = a_{n-1} \cdot q$ (PG).</li>
                                        <li>Fórmula Fechada (Termo Geral).</li>
                                    </ul>
                                """
                            },
                            new()
                            {
                                Id="representacao-de-algoritmos",
                                Name="Representação de Algoritmos",
                                Body= """
                                    <h1>Capítulo 2: Representação de Algoritmos</h1>
                                    <h3>2.1. Fluxogramas</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Grafos Dirigidos: Nós de Processamento e Arestas de Fluxo.</li>
                                        <li>Terminadores e Decisores.</li>
                                    </ul>
                                """
                            },
                            new()
                            {
                                Id="estruturas-de-controle",
                                Name="Estruturas de Controle",
                                Body= """
                                    <h1>Capítulo 3: Estruturas de Controle</h1>
                                    <h3>3.1. Condicionais</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Lógica de Predicados: Estrutura If-Then-Else.</li>
                                        <li>Funções Definidas por Partes.</li>
                                    </ul>
                                    <h3>3.2. Estruturas de Repetição</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Iteração Controlada (Loops).</li>
                                        <li>Critérios de Parada e Convergência.</li>
                                    </ul>
                                """
                            },
                            new()
                            {
                                Id="definicao-formal-de-algoritmo",
                                Name="Definição Formal de Algoritmo",
                                Body= """
                                    <h1>Capítulo 4: Definição Formal de Algoritmo</h1>
                                    <h3>4.1. Computabilidade Finita</h3>
                                    <p>Tópicos</p>
                                    <ul>
                                        <li>Entrada, Processamento Deterministico, Saída.</li>
                                        <li>Finitude temporal.</li>
                                    </ul>
                                """,
                            }
                        }
                    }
                }
            },

            new Course()
            {
                Id="math2",
                Name = "Matemática II",
                // Estimativa Total: ~8 Meses
                Curriculum = new()
                {
                    new()
                    {
                        Id="teoria-elementar-dos-numeros",
                        Name = "Teoria Elementar dos Números",
                        Duration = "4 Semanas",
                        Contents = new()
                        {
                            new()
                            {
                                Id="crivo-de-eratostenes",
                                Name="Crivo de Eratóstenes e a primalidade",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="teorema-fundamental-da-aritmetica",
                                Name="Teorema Fundamental da Aritmética",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="algoritmo-de-euclides-para-mdc",
                                Name="Algoritmo de Euclides para MDC",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="relacao-fundamental-entre-mmc-mdc",
                                Name="Relação Fundamental entre MMC e MDC",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            }
                        }
                    },
                    new()
                    {
                        Name = "O Corpo dos Racionais $\\mathbb{Q}$",
                        Duration = "3 Semanas",
                        Contents = new()
                        {
                            new()
                            {
                                Id="fracao-como-classe-de-equivalencia-e-operador",
                                Name="Fração como classe de equivalência e operador",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="fracao-geratriz-expansao-decimal",
                                Name="Fração Geratriz e expansão decimal",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="densidade-dos-racionais-na-reta-real",
                                Name="Densidade dos Racionais na reta real",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                        }
                    },
                    new()
                    {
                        Name = "Análise Combinatória I",
                        Duration = "5 Semanas", // Combinatória é difícil de intuir, precisa de tempo
                        Contents = new()
                        {
                            new()
                            {
                                Id="arvore-de-decisao-e-principio-fundamental-da-contagem",
                                Name="Árvore de Decisão e Princípio Fundamental da Contagem",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="permutacao-e-fatorial",
                                Name="Permutações e Fatorial",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="arranjos-e-combinacoes-simples",
                                Name="Arranjos e Combinações Simples",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="introducao-a-grafos",
                                Name="Introdução a Grafos: 4 Cores e Dijkstra",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                        }
                    },
                    new()
                    {
                        Name = "Geometria Euclidiana: Dedutiva",
                        Duration = "5 Semanas", // Foco em demonstração formal
                        Contents = new()
                        {
                            new()
                            {
                                Id="angulos-e-transversalidade",
                                Name="Ângulos e Transversalidade",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="postulado-das-paralelas",
                                Name="Postulado das Paralelas",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="soma-dos-angulos-internos",
                                Name="Soma dos ângulos internos (Polígonos convexos)",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="desigualdade-triangular",
                                Name="Desigualdade Triangular",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="axiomas-de-congruencia-de-triangulos",
                                Name="Axiomas de Congruência de Triângulos",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            }
                        }
                    },
                    new()
                    {
                        Name = "Fundamentos da Álgebra",
                        Duration = "6 Semanas", // O ponto crítico onde muitos desistem. Precisa ser lento.
                        Contents = new()
                        {
                            new()
                            {
                                Id="abstracao-algebrica",
                                Name="Abstração Algébrica",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="propriedade-distributiva-e-fatoracao-primaria",
                                Name="Propriedade distributiva e fatoração primária",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="resolucao-de-equacoes-lineares",
                                Name="Resolução de Equações Lineares",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="modelagem-de-problemas-reais",
                                Name="Modelagem de problemas reais",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="equacoes-quadraticas",
                                Name="Equações Quadráticas: Bhaskara e Discriminante",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            }
                        }
                    },
                    new()
                    {
                        Name = "Linguagem Algébrica e Paridade",
                        Duration = "2 Semanas",
                        Contents = new()
                        {
                            new()
                            {
                                Id="variavel-vs-incognita-vs-parametro",
                                Name="Variável vs. Incógnita vs. Parâmetro",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="traducao-de-linguagem-natural-para-algebrica",
                                Name="Tradução de linguagem natural para algébrica",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="demonstracao-de-paridade",
                                Name="Demonstrações de Paridade (Pares e Ímpares)",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                        }
                    },
                    new()
                    {
                        Name = "Introdução às Funções Reais",
                        Duration = "4 Semanas",
                        Contents = new()
                        {
                            new()
                            {
                                Id="funcao-afim-e-linearidade",
                                Name="Função Afim e Linearidade",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="geometria-analitica-da-reta",
                                Name="Geometria Analítica da Reta (Introdutória)",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="sistemas-lineares-2x2",
                                Name="Sistemas Lineares 2x2: Visão Geométrica",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="funcao-quadratica",
                                Name="Função Quadrática: Parábola e Vértice",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                        }
                    }
                }
            },

            new Course()
            {
                Id="math3",
                Name = "Matemática III",
                // Estimativa Total: ~9 Meses (Conteúdo denso)
                Curriculum = new()
                {
                    new()
                    {
                        Name = "Sistemas Lineares e Matrizes",
                        Duration = "5 Semanas",
                        Contents = new()
                        {
                            new()
                            {
                                Id="metodos-de-resolucao-analiticos",
                                Name="Métodos de resolução analíticos",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="discussao-de-sistemas",
                                Name="Discussão de Sistemas (SPD, SPI, SI)",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="algebra-matricial-e-determinantes",
                                Name="Álgebra Matricial e Determinantes",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="metodo-de-escalonamento",
                                Name="Método de Escalonamento (Gauss)",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                        }
                    },
                    new()
                    {
                        Name = "Teoria dos Polinômios I",
                        Duration = "4 Semanas",
                        Contents = new()
                        {
                            new()
                            {
                                Id="definicao-formal-de-polinomios-e-grau",
                                Name="Definição formal de Polinômios e Grau",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="algoritmo-da-divisao-polinomial",
                                Name="Algoritmo da Divisão Polinomial",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="raizes-zeros-e-multiplicidade",
                                Name="Raízes, Zeros e Multiplicidade",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="comportamento-grafico-local",
                                Name="Comportamento gráfico local",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                        }
                    },
                    new()
                    {
                        Name = "Identidades Algébricas e Séries",
                        Duration = "5 Semanas", // Binômio de Newton é complexo
                        Contents = new()
                        {
                            new()
                            {
                                Id="operadores-de-somatorio-e-produtorio",
                                Name="Operadores de Somatório ($\\Sigma$) e Produtório ($\\Pi$)",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="teorema-do-binomio-de-newton",
                                Name="Teorema do Binômio de Newton",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="triangulo-de-pascal-e-combinatoria",
                                Name="Triângulo de Pascal e Combinatória",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="identidades-de-sophies-germain-e-lagrange",
                                Name="Identidades de Sophie Germain e Lagrange",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="tecnica-de-completar-quadrados",
                                Name="Técnica de Completar Quadrados",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                        }
                    },
                    new()
                    {
                        Name = "Teoria da Probabilidade",
                        Duration = "4 Semanas",
                        Contents = new()
                        {
                            new()
                            {
                                Id="espaco-amostral-e-axiomas-de-kolmogorov",
                                Name="Espaço Amostral e Axiomas de Kolmogorov (Intro)",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="probabilidade-de-laplace",
                                Name="Probabilidade de Laplace",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="eventos-independentes-e-condicionais",
                                Name="Eventos Independentes e Condicionais",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="teorema-de-bayes",
                                Name="Teorema de Bayes",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                        }
                    },
                    new()
                    {
                        Name = "Desigualdades Analíticas",
                        Duration = "3 Semanas",
                        Contents = new()
                        {
                            new()
                            {
                                Id="medias-ma-mg",
                                Name="Médias: MA $\\ge$ MG",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="desigualdade-de-bernoulli",
                                Name="Desigualdade de Bernoulli",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="desigualdade-triangular",
                                Name="Desigualdade Triangular (Módulos)",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                        }
                    },
                    new()
                    {
                        Name = "Trigonometria Geométrica",
                        Duration = "4 Semanas",
                        Contents = new()
                        {
                            new()
                            {
                                Id="razoes-trigonometricas-no-triangulo-retangulo",
                                Name="Razões Trigonométricas no Triângulo Retângulo",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="relacao-fundamental-da-trigonometria",
                                Name="Relação Fundamental da Trigonometria",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="lei-dos-senos-e-cossenos",
                                Name="Lei dos Senos e Cossenos",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="circulo-trigonometrico",
                                Name="Círculo Trigonométrico: Introdução",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                        }
                    },
                    new()
                    {
                        Name = "Geometria Métrica Avançada",
                        Duration = "5 Semanas", // Geometria de competição/Olimpíada
                        Contents = new()
                        {
                            new()
                            {
                                Id="pontos-notaveis-do-triangulo",
                                Name="Pontos Notáveis do Triângulo",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="teorema-trigonometrico-de-ceva-e-menelaus",
                                Name="Teorema Trigonométrico de Ceva e Menelaus",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="potencia-de-ponto",
                                Name="Potência de Ponto",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="quadrilateros-ciclicos",
                                Name="Quadriláteros Cíclicos (Brahmagupta)",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="relacoes-metricas-no-circulo",
                                Name="Relações métricas no círculo",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            }
                        }
                    },
                    new()
                    {
                        Name = "Aritmética Modular",
                        Duration = "3 Semanas",
                        Contents = new()
                        {
                            new()
                            {
                                Id="congruencias-e-classes-de-resto",
                                Name="Congruências e Classes de Resto",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="criterios-de-divisibilidade-avancados",
                                Name="Critérios de Divisibilidade Avançados",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="pequeno-teorema-de-fermat",
                                Name="Pequeno Teorema de Fermat",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="teorema-chines-do-resto",
                                Name="Teorema Chinês do Resto",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                        }
                    }
                }
            },

            new Course()
            {
                Id="math4",
                Name = "Matemática IV",
                // Estimativa Total: ~8 Meses
                Curriculum = new()
                {
                    new()
                    {
                        Name = "Teoria Geral das Funções",
                        Duration = "3 Semanas",
                        Contents = new()
                        {
                            new()
                            {
                                Id="formalismo",
                                Name="Formalismo: Domínio, Contradomínio e Imagem",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="paridade-e-simetria-de-funcoes",
                                Name="Paridade e Simetria de Funções",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="funcoes-bijetoras-e-inversas",
                                Name="Funções Bijetoras e Inversas",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="algebra-de-funcoes-e-composicao",
                                Name="Álgebra de Funções e Composição",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                        }
                    },
                    new()
                    {
                        Name = "Equações Algébricas",
                        Duration = "3 Semanas",
                        Contents = new()
                        {
                            new()
                            {
                                Id="dispositivo-de-briot-ruffini",
                                Name="Dispositivo de Briot-Ruffini",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="teorema-do-resto-e-dalambert",
                                Name="Teorema do Resto e D'Alembert",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="relacoes-de-girard",
                                Name="Relações de Girard (Vieta)",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="teorema-das-raizes-racionais",
                                Name="Teorema das Raízes Racionais",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                        }
                    },
                    new()
                    {
                        Name = "O Corpo dos Complexos $\\mathbb{C}$",
                        Duration = "5 Semanas", // Visualizar Euler e raízes da unidade demora
                        Contents = new()
                        {
                            new()
                            {
                                Id="unidade-imaginaria",
                                Name="Unidade imaginária $i$",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="forma-polar-e-argumento-principal",
                                Name="Forma Polar e Argumento Principal",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="formula-de-euler",
                                Name="Fórmula de Euler ($e^{i\\theta}$)",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="teorema-de-demoivre",
                                Name="Teorema de De Moivre",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="raizes-da-unidade-e-poligonos-regulares",
                                Name="Raízes da Unidade e Polígonos Regulares",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                        }
                    },
                    new()
                    {
                        Name = "Funções Trigonométricas Reais",
                        Duration = "4 Semanas",
                        Contents = new()
                        {
                            new()
                            {
                                Id="dominio-imagem-e-periodicidade",
                                Name="Domínio, Imagem e Periodicidade",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="graficos-das-funcoes-circulares",
                                Name="Gráficos das Funções Circulares",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="transformacoes",
                                Name="Transformações: Amplitude e Fase",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="identidades-trigonometricas-fundamentais",
                                Name="Identidades Trigonométricas Fundamentais",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                        }
                    },
                    new()
                    {
                        Name = "Trigonometria Analítica",
                        Duration = "4 Semanas", // Manipulação algébrica pesada
                        Contents = new()
                        {
                            new()
                            {
                                Id="reducao-ao-1-quadrante",
                                Name="Redução ao 1º Quadrante",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="transformacoes-de-arcos",
                                Name="Transformações de Arcos (Soma/Diferença)",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="prostaferese",
                                Name="Prostaférese (Fatoração Trigonométrica)",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="funcoes-trigonometricas-inversas",
                                Name="Funções Trigonométricas Inversas (Arcsen, Arccos)",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                        }
                    },
                    new()
                    {
                        Name = "Funções Transcendentes e Assíntotas",
                        Duration = "5 Semanas", // Base vital para o Cálculo
                        Contents = new()
                        {
                            new()
                            {
                                Id="exponenciais-e-logaritmos-naturais",
                                Name="Exponenciais e Logaritmos Naturais",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="propriedades-operatorias",
                                Name="Propriedades Operatórias",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="transformacoes-de-graficos",
                                Name="Transformações de Gráficos",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="limites-no-infinito-e-assintotas",
                                Name="Limites no Infinito e Assíntotas (Intuição)",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="taxas-de-crescimento",
                                Name="Taxas de Crescimento",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                        }
                    },
                    new()
                    {
                        Name = "Vetores e Geometria Analítica",
                        Duration = "4 Semanas",
                        Contents = new()
                        {
                            new()
                            {
                                Id="algebra-vetorial",
                                Name="Álgebra Vetorial no $\\mathbb{R}^2$",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="produto-escalar-e-projecoes",
                                Name="Produto Escalar e Projeções",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="equacoes-da-reta",
                                Name="Equações da Reta (Vetorial, Paramétrica, Geral)",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="distancia-ponto-reta",
                                Name="Distância Ponto-Reta",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            }
                        }
                    }
                }
            },

            new Course()
            {
                Id="math5",
                Name = "Matemática V",
                // Estimativa Total: ~8 Meses (Cálculo I sério)
                Curriculum = new()
                {
                    new()
                    {
                        Name = "Limites e Continuidade",
                        Duration = "6 Semanas", // Epsilon-Delta é o maior filtro do cálculo
                        Contents = new()
                        {
                            new()
                            {
                                Id="definicao-formal",
                                Name="Definição Formal $\\epsilon-\\delta$",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="propriedades-dos-limites",
                                Name="Propriedades dos Limites",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="limites-fundamentais",
                                Name="Limites Fundamentais",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="continuidade-e-teorema-do-valor-intermediario",
                                Name="Continuidade e Teorema do Valor Intermediário",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                        }
                    },
                    new()
                    {
                        Name = "Cálculo Diferencial",
                        Duration = "5 Semanas",
                        Contents = new()
                        {
                            new()
                            {
                                Id="interpretacao-geometrica-e-fisica",
                                Name="Interpretação Geométrica e Física",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="regras-de-derivacao",
                                Name="Regras de Derivação (Cadeia, Produto)",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="derivacao-implicita",
                                Name="Derivação Implícita",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="diferenciabilidade",
                                Name="Diferenciabilidade",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                        }
                    },
                    new()
                    {
                        Name = "Cálculo Vetorial Diferencial",
                        Duration = "3 Semanas",
                        Contents = new()
                        {
                            new()
                            {
                                Id="curvas-parametricas-planas",
                                Name="Curvas Paramétricas Planas",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="vetores-tangentes-e-velocidade",
                                Name="Vetores Tangentes e Velocidade",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="introducao-a-campos-vetoriais",
                                Name="Introdução a Campos Vetoriais",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="curvatura",
                                Name="Curvatura (Intro)",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                        }
                    },
                    new()
                    {
                        Name = "Análise do Comportamento de Funções",
                        Duration = "4 Semanas",
                        Contents = new()
                        {
                            new()
                            {
                                Id="teoremas-de-fermat-rolle-e-valor-medio",
                                Name="Teoremas de Fermat, Rolle e Valor Médio",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="criterios-da-1-e-2-derivada",
                                Name="Critérios da 1ª e 2ª Derivada",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="otimizacao-e-taxas-relacionadas",
                                Name="Otimização e Taxas Relacionadas",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="indeterminacoes-e-lhopital",
                                Name="Indeterminações e L'Hôpital",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                        }
                    },
                    new()
                    {
                        Name = "Cálculo Integral",
                        Duration = "8 Semanas", // Onde a maioria reprova. Precisa de muito treino técnico.
                        Contents = new()
                        {
                            new()
                            {
                                Id="integral-indefinida-e-primitivas",
                                Name="Integral Indefinida e Primitivas",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="integral-definida-de-riemann",
                                Name="Integral Definida de Riemann",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="teorema-fundamental-do-calculo",
                                Name="Teorema Fundamental do Cálculo",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="tecnicas-substituicao-e-partes",
                                Name="Técnicas: Substituição e Partes",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="integracao-de-racionais",
                                Name="Integração de Racionais (Frações Parciais)",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            }
                        }
                    },
                    new()
                    {
                        Name = "Geometria Analítica Espacial",
                        Duration = "4 Semanas",
                        Contents = new()
                        {
                            new()
                            {
                                Id="vetores-r3-e-produto-vetorial",
                                Name="Vetores no $\\mathbb{R}^3$ e Produto Vetorial",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="produto-misto-e-volumes",
                                Name="Produto Misto e Volumes",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="planos-e-esferas",
                                Name="Planos e Esferas",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="superficies-quadricas",
                                Name="Superfícies Quádricas",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            }

                        }
                    }
                }
            },

            new Course()
            {
                Id="math6",
                Name = "Matemática VI",
                // Estimativa Total: ~7-8 Meses (Tópicos Avançados)
                Curriculum = new()
                {
                    new()
                    {
                        Name = "Álgebra Linear Abstrata",
                        Duration = "8 Semanas", // Fundamental para Data Science e Engenharia moderna
                        Contents = new()
                        {
                            new()
                            {
                                Id="espacos-vetoriais-e-subespacos",
                                Name="Espaços Vetoriais e Subespaços",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="base-dimensao-e-coordenadas",
                                Name="Base, Dimensão e Coordenadas",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="transformacoes-lineares",
                                Name="Transformações Lineares",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="diagonalizacao-e-teorema-espectral",
                                Name="Diagonalização e Teorema Espectral",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            }
                        }
                    },
                    new()
                    {
                        Name = "Cálculo Multivariável",
                        Duration = "8 Semanas",
                        Contents = new()
                        {
                            new()
                            {
                                Id="topologia-do-rn",
                                Name="Topologia do $\\mathbb{R}^n$ (Curvas de Nível)",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="derivadas-parciais-e-diferencial-total",
                                Name="Derivadas Parciais e Diferencial Total",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="gradiente-e-direcional",
                                Name="Gradiente e Direcional",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="integrais-multiplas-e-mudanca-de-variavel",
                                Name="Integrais Múltiplas e Mudança de Variável (Polar)",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                        }
                    },
                    new()
                    {
                        Name = "Equações Diferenciais Ordinárias",
                        Duration = "6 Semanas",
                        Contents = new()
                        {
                            new()
                            {
                                Id="edos-de-1-ordem-e-campos-de-direcao",
                                Name="EDOs de 1ª ordem e Campos de Direção",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="edos-lineares-de-2-ordem",
                                Name="EDOs Lineares de 2ª ordem",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="osciladores-harmonicos",
                                Name="Osciladores Harmônicos",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="transformada-de-laplace",
                                Name="Transformada de Laplace",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            }
                        }
                    },
                    new()
                    {
                        Name = "Estruturas Algébricas e Lógica",
                        Duration = "6 Semanas", // Abstração pura
                        Contents = new()
                        {
                            new()
                            {
                                Id="metodos-formais-de-prova",
                                Name="Métodos Formais de Prova (Indução, Contradição)",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="introducao-a-teoria-dos-grupos",
                                Name="Introdução à Teoria dos Grupos",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="grupos-ciclicos-e-permutacoes",
                                Name="Grupos Cíclicos e Permutações",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="isomorfismos",
                                Name="Isomorfismos (Conceito)",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            }
                        }
                    }
                }
            }
        };
    }
}