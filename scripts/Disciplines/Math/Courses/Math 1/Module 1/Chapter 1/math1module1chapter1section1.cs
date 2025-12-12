namespace SchoolData;

public static class Math1Module1Chapter1Section1
{
    public static Topic Topic = new()
    {
        Id = "correspondencia-e-agrupamento",
        Name = "1.1 Correspondência e Agrupamento",
        Active = true,
        Body = """
            <h3>1.1 Sistemas de Agrupamento e Bases Numéricas</h3>
            <p style="text-indent:2rem">Vamos começar com uma pequena dinâmica. No momento quero que você esqueça tudo o que sabe sobre números. Esqueça o dígito "5", a palavra "cinco", o numeral romano "V". Esqueça a tabuada e a calculadora do seu celular.</p>
            <p style="text-indent:2rem">Agora estamos no final do Paleolítico Superior ou, talvez, no alvorecer da revolução agrícola na Suméria arcaica. O sol está se pondo, tingindo de laranja a poeira que se levanta do chão árido. Você é um pastor. Sua sobrevivência, e a da sua família, depende inteiramente de um fato simples: o rebanho que você levou para pastar pela manhã deve voltar intacto para o cercado à noite.</p>
            <p style="text-indent:2rem">Você olha para o grupo de animais se movendo à sua frente. Sua mente percebe que são "muitos". Se houvessem três ovelhas, você vê "três". Se houver quatro, sabe que são "quatro". Mas acima disso? Em certas quantidades tudo se funde em um borrão indistinto de "muitos". A mente humana primitiva — e até mesmo a moderna se não tem treinamento — sofre de um limite de subitização (a capacidade de reconhecer quantidades instantaneamente) que raramente passa de cinco elementos se estão desorganizados.</p>
            <p style="text-indent:2rem">Se um lobo tiver levado uma ovelha durante o dia, como você saberia? Sem palavras para números, você não pode contar "cinquenta e três" e depois verificar se ainda há "cinquenta e três". A abstração numérica não existe. Você sente a massa do rebanho, mas a precisão lhe escapa. A falha da memória humana colide com a necessidade de sobrevivência. Precisamos de um método de verificação que seja à prova de falhas e que não dependa da linguagem.</p>
            <p>Precisamos inventar a matemática.</p>
            <br>
            <h4>A Intuição e a Primeira Tentativa</h4>
            <p style="text-indent:2rem">A solução que a humanidade encontrou foi brilhante em sua simplicidade física. Se você não pode contar as ovelhas mentalmente, você precisa de um substituto palpável para cada animal.</p>
            <p style="text-indent:4em>Você pega uma bolsa de couro e senta-se à entrada do cercado. Pela manhã, conforme cada ovelha sai para o pasto, você pega uma pequena pedra e a coloca dentro da bolsa. Em latim essa pedra se chamava calculus a origem da palavra "cálculo"</p>
            <ul>
                <li><strong>Ovelha passa</strong> $\rightarrow$ <strong>Pedra na bolsa.</strong></li>
                <li><strong>Outra Ovelha passa</strong> $\rightarrow$ <strong>Pedra na bolsa.</strong></li>
            </ul>
            <p style="text-indent:2rem">À noite, você reverte o processo. Para cada ovelha que entra, você retira uma pedra da bolsa de couro. Se o rebanho estiver todo dentro do cercado e a bolsa estiver vazia: Invariância Preservada. Todos estão a salvo. Se sobrar uma pedra na bolsa: Perda. Uma ovelha não entrou no cercado pois ficou para trás. Se não houver pedra e passar uma última ovelha: Ganho. (Provavelmente, uma ovelha do vizinho se misturou ao seu rebanho).</p>
            <br>
            <p style="text-indent:2rem">O que você acabou de realizar intuitivamente é um dos conceitos mais poderosos da matemática moderna: a Correspondência Biunívoca ("um-para-um"). Você não precisa saber quantas ovelhas existem. Você só precisa garantir que o "Conjunto das Ovelhas" e o "Conjunto das Pedras" tenham a mesma magnitude.</p>
            <br>
            <h4>O Problema das Escalas</h4>
            <p style="text-indent:2rem">Esse sistema funcionou perfeitamente por milênios. Mas a civilização é vítima de seu próprio sucesso. Com a agricultura e as cidades, os rebanhos cresceram. Um rei não possui apenas 50 ovelhas; ele possui 5.000.</p>
            <p>Tente aplicar o método das pedras agora. Carregar uma bolsa com 5.000 pedras é logisticamente impossível. "Tudo bem", você diz, "vamos fazer marcas em um osso ou argila (talhas)". Você começa a riscar: $|||||||||||||...$</p>
            <p style="text-indent:2rem">Rapidamente, você atinge um limite novamente. Ler cinco mil riscos na parede é tão impossível quanto contar as todas as ovelhas a olho nu. O cérebro não processa a repetição linear infinita. O método "um-para-um" é excelente, mas tem seus limites. Como entendemos matemáticamente o que o pastor fez?</p>
            <br>
            <h4>Cardinalidade e Bijeção</h4>
            <p style="text-indent:2rem">O pastor percebeu que a “quantidade” não pertence a cada ovelha individualmente, mas ao conjunto como um todo. Ela é uma noção abstrata que expressa quantos elementos há em um grupo. Chamamos isso de Cardinalidade.</p>
            <br>
            <p style="text-indent:2rem">Para que dois conjuntos tenham a mesma cardinalidade, precisamos provar que eles correspondem perfeitamente.</p>
            <div class="card">
                <h3>Definição 1.1.1 Correspondência Biunívoca (Bijeção)</h3>
                <p style="text-indent:2rem">Dizemos que dois conjuntos $A$ e $B$ têm a mesma cardinalidade, denotada por $|A| = |B|$, se, e somente se, existe uma regra de correspondência (função) $f: A \to B$ que seja bijetora.<p>
                <h4>Para ser uma bijeção, a função precisa cumprir dois requisitos rígidos:</h4>
                <ul>
                    <li>
                        <strong>Injetora:</strong> $\forall x_1, x_2 \in A, f(x_1) = f(x_2) \implies x_1 = x_2$.
                        <ul>
                            <li><strong>Tradução:</strong> Para todo $x_1, x_2$ pertencentes ao conjunto A (ovelhas), se o correspondente de $x_1$ for igual ao correspondente de $x_2$ então $x_1$ é igual a $x_2$</li>
                            <li><strong>Interpretação:</strong> Se estamos falando hipoteticamente de duas ovelhas diferentes, mas a pedra que corresponde a uma ovelha é a mesma que corresponde a outra, então a correspondencia injetiva falhou, porque duas ovelhas distintas não podem receber a mesma pedra. $x_1 \neq x_2 \implies f(x_1) \neq f(x_2)$</li>
                            <li><strong>Observação:</strong> Se duas ovelhas correspondem a uma mesma pedra então a função não é injetora e a correspondencia não é biunívoca.</li>
                        </ul>
                    </li>
                    <br>
                    <li>
                        <strong>Sobrejetora:</strong> $\forall y \in B, \exists x \in A \text{ tal que } f(x) = y$.
                        <ul>
                            <li><strong>Tradução:</strong> Para todo $y$ pertencente ao conjunto B (pedras), existe $x$ pertencente ao conjunto A (ovelhas) de modo que o correspondente de $x$ é igual a $y$</li>
                            <li><strong>Interpretação:</strong> Para uma pedra qualquer dentro da bolsa de couro existe uma ovelha no rebanho de modo que o correspondente dessa ovelha é a pedra.</li>
                        </ul>
                    </li>
                </ul>
                <br>
                <p>Não se assuste com os simbolos, tente entender a ideia geral. Ainda vamos desenvolver a maturidade necessária para compreender sozinhos esses simbolos.</p>
            </div>
            <br>
            <h4>A Estrutura de Bases e O Algoritmo da Divisão</h4>
            <p style="text-indent:2rem">Para resolver o problema das 5.000 ovelhas, a mente humana inventou o Agrupamento Hierárquico. Em vez de contar apenas unidades, começamos a agrupar e contar grupos e grupos de grupos. Pense por exemplo em grupos de 1.000 ovelhas, teriamos um total de 5 grupos.</p>
            <p style="text-indent:2rem">A grande pergunta é qual quantidade ideal para os nossos grupos? Qual quantidade que atenda a todas as nossas necessidades, ou pelo menos a maioria delas?</p>
            <ul>
                <li><strong>Base 10:</strong> Óbvia e mais simples pois temos 10 dedos.</li>
                <li><strong>Base 12:</strong> Olhe para a palma da sua mão. Use o polegar para contar as falanges (ossos) dos outros quatro dedos. 3 falanges x 4 dedos = 12. É uma base tátil excelente.</li>
                <li><strong>Base 60 (Babilônia):</strong> Uma inovação muito criativa pois contem uma divisibilidade ampla.</li>
            </ul>
            <br>
            <p>Matematicamente, agrupar nada mais é do que aplicar repetidamente o Teorema da Divisão Euclidiana.</p>
            <br>
            <div class="card">
                <h3>Teorema 1.1.1 Divisão Euclidiana</h3>
                <p style="text-indent:2rem">Para quaisquer inteiros $a$ (total de elementos) e $b$ (o tamanho do grupo/base), com $b > 0$, existem inteiros únicos $q$ (quociente/grupos) e $r$ (resto) tais que:</p>
                <p>$$a = q \cdot b + r \quad \text{onde} \quad 0 \leq r < b$$</p>
            </div>
            <br>
            <p>Para entender tente considerar que:</p>
            <ul>
                <li><strong>$a$:</strong> É o seu rebanho gigante (5.000).</li>
                <li><strong>$b$:</strong> É a sua Base. Digamos que estamos na Suméria, usando base 60.</li>
                <li><strong>$q$:</strong> É a quantidade de "pacotes cheios" (grupos de 60).</li>
                <li><strong>$r$:</strong> É o que sobrou fora dos grupos (as unidades soltas).</li>
            </ul>
            <p>Ao fazer isso, reduzimos as limitações. Não vemos mais 5.000 unidades. Vemos "83 grupos grandes e 20 unidades soltas" ($83 \times 60 + 20 = 5000$). Comprimimos os dados.</p>
            <br>
            <h4>Aplicação 1.1.1</h4>
            <p style="text-indent:2rem">A batalha entre a representação "um-para-um" e o "agrupamento eficiente" acontece agora mesmo, em seu celular, computador, televisão etc.</p>
            <p style="text-indent:4em>Os computadores são como o pastor primitivo usando pedrinhas. Eles usam o sistema Binário (Base 2): 0 ou 1, ligado ou desligado. Imagine um número do sistema decimal como o 255 (duzentos e cinquenta e cinco). Em binário, ele é 11111111. Agora imagine um engenheiro de software tentando ler um código de erro: 1011011001101... É ilegível. Caímos no mesmo problema das bolsas de bolsas lotadas de "calculus" (pedrinhas)</p>
            <p style="text-indent:2rem">A solução? Agrupamento. Usamos Hexadecimal (Base 16). Por que 16? Porque $16 = 2^4$. Isso significa que podemos agrupar cada 4 "pedras" binárias em um único símbolo elegante.</p>
            <ul>
                <li><strong>Binário:</strong> 1111 (4 dígitos, difícil de ler em massa).</li>
                <li><strong>Hexadecimal:</strong> F (1 símbolo, denso em informação).</li>
            </ul>
            <p style="text-indent:2rem">O Hexadecimal não é "mágica"; é apenas uma técnica de empacotamento para salvar o cérebro do programador, exatamente como os sumérios fizeram com seus rebanhos.</p>
            <br>
            <h4>Aplicação 1.1.2</h4>
            <p style="text-indent:2rem">Por que não vendemos ovos em pacotes de 10 (Base 10)? Afinal, usamos o sistema decimal para dinheiro.</p>
            <p style="text-indent:2rem">Olhe para o número 10. Seus divisores são $\{1, 2, 5, 10\}$. Você só pode dividir 10 ovos ao meio ou em grupos de 5. Geometricamente, uma caixa com 10 só pode ser arranjada como $2 \times 5$. É uma estrutura rígida e pobre.</p>
            <p style="text-indent:2rem">Agora olhe para o número 12 (uma dúzia). Seus divisores são $\{1, 2, 3, 4, 6, 12\}$. Isso é um sonho logístico! Você pode embalar 12 ovos em retângulos de $3 \times 4$, $2 \times 6$, $4 \times 3$, etc. A Base 12 sobrevive no comércio e na logística porque ela oferece mais "opções de empacotamento" (fatoração) do que a nossa base decimal biológica.</p>
            <br>
            <h4>Resumo</h4>
            <div class="card">
                <ul>
                    <li><strong>Problema Original:</strong> A memória humana falha e a subitização é limitada (max ~4 itens). Necessidade de verificar invariância.</li>
                    <li><strong>Correspondência Biunívoca:</strong> Método de verificar igualdade de tamanho entre conjuntos ($|A|=|B|$) sem contagem direta, emparelhando elementos (ex: ovelha $\leftrightarrow$ pedra).</li>
                    <li><strong>O Problema das Escalas:</strong> Representações "um-para-um" tornam-se ilegíveis e intransportáveis para grandes quantidades.</li>
                    <li><strong>Algoritmo da Divisão:</strong> ($a = bq + r$) A base matemática do agrupamento. Transforma contagem linear em contagem hierárquica (pacotes + restos).</li>
                    <li><strong>Aplicação:</strong> Sistemas Hexadecimais (compressão de binário) e Logística (Base 12 otimiza fatoração e empacotamento).</li>
                </ul>
            </div>
            <br>
            <h3>Faça Você Mesmo</h3>
            <p style="text-indent:2rem">A melhor forma de entender que "números são apenas representações de quantidades" é manipulando essas quantidades fisicamente, sem usar os símbolos que você conhece.</p>
            
            <div class="card">
                <h4>Experimento: O Mercador de Grãos</h4>
                <p><strong>Objetivo:</strong> Verificar fisicamente a invariância da quantidade através de diferentes bases de agrupamento (Teorema da Divisão).</p>
                <p><strong>Materiais:</strong> Um punhado de objetos pequenos idênticos (feijões, moedas, clipes de papel ou macarrão cru) — tente pegar uma grande quantidade aleatória</p>                
                <ol>
                    <li>
                        <p>Coloque o punhado de objetos na mesa. Não os conte um por um. Olhe para eles. Essa é a magnitude pura, o $a$ da nossa fórmula.</p>
                    </li>
                    <li>
                        <p>Sem contar o total, comece a separar os objetos em pequenos grupos de <strong>5</strong>.</p>
                        <ul>
                            <li>Quantos grupos completos você conseguiu? Chame isso de $q_5$.</li>
                            <li>Quantos objetos sobraram sozinhos? Chame isso de $r_5$.</li>
                            <li>Escreva no papel: "Base 5: Tenho $q_5$ grupos e sobraram $r_5$".</li>
                        </ul>
                    </li>
                    <li>
                        <p>Misture tudo novamente. Agora, agrupe os mesmos objetos em montes de <strong>12</strong>.</p>
                        <ul>
                            <li>Anote o novo número de grupos ($q_{12}$) e o novo resto ($r_{12}$).</li>
                        </ul>
                    </li>
                    <li>
                        <p>Agora, use a calculadora ou faça a conta tradicional:</p>
                        <p>$$5 \times q_5 + r_5 \quad \text{deve ser igual a} \quad 12 \times q_{12} + r_{12}$$</p>
                    </li>
                </ol>
                <p style="text-indent:2rem"><strong>Conclusão:</strong> Se a igualdade for verdadeira, você acabou de provar fisicamente que a quantidade ($a$) existe independentemente de como a embalamos ($b$). Você realizou a mudança de base numérica manualmente.</p>
            </div>
            <br>
        """,
        Problems = new()
        {
            new()
            {
                Id="1",
                Statement= """
                    <p>O que é "Subitização" e qual é o limite médio mencionado no texto para humanos sem treinamento?</p>
                """,
                Solution= """
                    <p>A subitização é a capacidade de reconhecer quantidades instantaneamente sem precisar contar um por um (ex: olhar para 3 maçãs e saber que são 3). O texto menciona que, para elementos desorganizados, o limite raramente passa de cinco elementos.</p>
                """,
            },
            new()
            {
                Id="2",
                Statement= """
                    <p>Qual foi a motivação fundamental para a invenção da matemática descrita no cenário do pastor?</p>
                """,
                Solution= """
                    <p>A necessidade de sobrevivência e verificação de invariância. A memória humana falha e não consegue processar grandes quantidades (o "borrão indistinto de muitos"), então foi necessário criar um método infalível que não dependesse da linguagem ou da memória para garantir que o rebanho que saiu fosse o mesmo que voltou.</p>
                """,
            },
            new()
            {
                Id="3",
                Statement= """
                    <p>Explique a origem etimológica da palavra "Cálculo" citada no texto.</p>
                """,
                Solution= """
                    <p>A palavra vem do latim calculus, que significa pedra. Refere-se às pedras pequenas usadas pelos pastores para fazer a correspondência biunívoca com as ovelhas.</p>
                """,
            },
            new()
            {
                Id="4",
                Statement= """
                    <p>Por que o método de correspondência "um-para-um" (como pedras em uma bolsa ou riscos em um osso) se torna ineficaz quando a escala aumenta (ex: 5.000 ovelhas)?</p>
                """,
                Solution= """
                    <p>Torna-se um problema logístico e cognitivo. Carregar 5.000 pedras é fisicamente inviável, e ler 5.000 riscos ($|||||...$) é impossível para o cérebro processar rapidamente, pois recai no mesmo problema da falta de subitização. A representação linear infinita não é eficiente para grandes magnitudes.</p>
                """,
            },
            new()
            {
                Id="5",
                Statement= """
                    <p>Defina, com suas palavras, o que é Cardinalidade.</p>
                """,
                Solution= """
                    <p>Cardinalidade é uma noção abstrata que expressa a quantidade de elementos em um conjunto. É o que "sobra" quando abstraímos as qualidades individuais dos objetos e focamos apenas no "quantos".</p>
                """,
            },
            new()
            {
                Id="6",
                Statement= """
                    <p>Para que exista uma Correspondência Biunívoca (Bijeção) entre o conjunto de Ovelhas ($A$) e o conjunto de Pedras ($B$), duas condições devem ser atendidas. Quais são elas?</p>
                """,
                Solution= """
                    <p>A função deve ser Injetora (cada ovelha distinta corresponde a uma pedra distinta) e Sobrejetora (para toda pedra na bolsa, existe uma ovelha correspondente; não sobram pedras sem ovelhas).</p>
                """
            },
            new()
            {
                Id="7",
                Statement= """
                    <p>O pastor recolhe as ovelhas e, ao final, a bolsa de pedras está vazia, mas ainda há uma ovelha do lado de fora querendo entrar. Em termos de função, qual regra foi quebrada?</p>
                """,
                Solution= """
                    <p> A regra da Sobrejetividade falhou em relação ao conjunto inicial planejado (ou a Injetividade, dependendo do referencial, mas o texto foca na perda/ganho). No contexto prático: O conjunto das ovelhas ($A$) ficou maior que o conjunto das pedras ($B$). Não há mais pedra ($y$) para corresponder à ovelha extra ($x$). Logo, $|A| > |B|$. Houve um "Ganho" no rebanho.</p>
                """,
            },
            new()
            {
                Id="8",
                Statement= """
                    <p>Interprete a notação matemática: $\forall x_1, x_2 \in A, f(x_1) = f(x_2) \implies x_1 = x_2$. O que isso significa na prática com as ovelhas?</p>
                """,
                Solution= """
                    <p>Esta é a definição de Injetividade. Significa que se a pedra atribuída à ovelha 1 é idêntica à pedra atribuída à ovelha 2, então a ovelha 1 e a ovelha 2 devem ser o mesmo animal. Em outras palavras: duas ovelhas diferentes não podem ser contadas usando a mesma pedra.</p>
                """,
            },
            new()
            {
                Id="9",
                Statement= """
                    <p>Um pastor tem 53 ovelhas e decide usar a Base 10 (agrupamento por dedos das mãos). Usando o Teorema da Divisão Euclidiana ($a = q \cdot b + r$), determine $q$ e $r$.</p>
                """,
                Solution= """
                    <ul>
                        <li>$a = 53$ (Total)</li>
                        <li>$b = 10$ (Base)</li>
                        <li>Cálculo: $53 \div 10 = 5$ com resto $3$.</li>
                        <li>Equação: $53 = 5 \cdot 10 + 3$.</li>
                        <li>Resposta: $q = 5$ (5 grupos cheios), $r = 3$ (3 unidades soltas).</li>
                    </ul>
                """,
            },
            new()
            {
                Id="10",
                Statement= """
                    <p>No Teorema da Divisão, temos a restrição $0 \leq r < b$. O que aconteceria se, ao agrupar, você encontrasse um resto $r = b$?</p>
                """,
                Solution= """
                    <p>Se $r = b$, significa que você tem unidades suficientes para formar mais um grupo completo. O agrupamento não foi finalizado corretamente. O resto deve ser sempre estritamente menor que o tamanho do grupo (base).</p>
                """,
            },
            new()
            {
                Id="11",
                Statement= """
                    <p>Você encontrou um registro antigo de um pastor que usava a "Base 12" (Dúzia). O registro diz: "Tenho 4 grupos cheios e sobraram 7 ovelhas". Qual o tamanho total do rebanho?</p>
                """,
                Solution= """
                    <ul>
                        <li>$b = 12$</li>
                        <li>$q = 4$</li>
                        <li>$r = 7$</li>
                        <li>Equação: $a = q \cdot b + r$</li>
                        <li>Cálculo: $a = 4 \cdot 12 + 7 \rightarrow a = 48 + 7 \rightarrow a = 55$.</li>
                        <li>Resposta: 55 ovelhas.</li>
                    </ul>
                """,
            },
            new()
            {
                Id="12",
                Statement= """
                    <p>Um pastor sumério usa Base 60. Ele olhou para o rebanho e viu "2 grupos grandes" e "15 ovelhas soltas". Qual é a quantidade total ($a$)?</p>
                """,
                Solution= """
                    <ul>
                        <li>$b = 60$</li>
                        <li>$q = 2$</li>
                        <li>$r = 15$</li>
                        <li>Cálculo: $a = 2 \cdot 60 + 15 \rightarrow a = 120 + 15 \rightarrow a = 135$.</li>
                        <li>Resposta: 135 ovelhas.</li>
                    </ul>
                """,
            },
            new()
            {
                Id="13",
                Statement= """
                    <p>Temos 25 ovelhas. Mostre como esse número é representado na Base 5 e na Base 12.</p>
                """,
                Solution= """
                    <ul>
                        <li><strong>Base 5:</strong> $25 \div 5 = 5$, resto $0$. Opa! O quociente é 5, que é igual à base, então podemos agrupar de novo. (Na verdade, $25 = 5 \cdot 5 + 0$, mas em notação posicional seria $100_5$ ou simplesmente 5 grupos de 5). Pela lógica simples do texto: 5 grupos de 5 e 0 resto.</li>
                        <li><strong>Base 12:</strong> $25 \div 12 = 2$, resto $1$. $\rightarrow$ $25 = 2 \cdot 12 + 1$ (2 grupos e 1 sobra).</li>
                    </ul>
                """,
            },
            new()
            {
                Id="14",
                Statement= """
                    <p>Por que a Base 12 é considerada melhor para logística e comércio do que a Base 10, segundo o texto?</p>
                """,
                Solution= """
                    <p>Devido ao número de divisores. O número 10 só é divisível por 1, 2, 5 e 10. O número 12 é divisível por 1, 2, 3, 4, 6 e 12. Isso permite muito mais configurações de empacotamento (retângulos de $3 \times 4$, $2 \times 6$, etc.) sem quebrar caixas ou sobrar espaços.</p>
                """,
            },
            new()
            {
                Id="15",
                Statement= """
                    <p>O texto menciona que o sistema Hexadecimal é uma forma de "agrupamento" para o sistema Binário. Se temos o binário 1111, ele vira F em hexadecimal. Qual é a relação matemática entre a base 2 e a base 16 que permite esse agrupamento perfeito?</p>
                """,
                Solution= """
                    <p>A relação é que $16 = 2^4$. Isso significa que cada grupo de 4 dígitos binários pode ser representado perfeitamente por 1 dígito hexadecimal, permitindo uma "compressão" da informação visual sem perda de dados.</p>
                """,
            },
            new()
            {
                Id="16",
                Statement= """
                    <p>Se você realizar o experimento "O Mercador de Grãos" com 32 feijões. Quais seriam os valores de ($q, r$) para a Base 5 e para a Base 6?</p>
                """,
                Solution= """
                    <ul>
                        <li>Total $a = 32$.</li>
                        <li><strong>Base 5:</strong> $32 \div 5 = 6$ grupos, sobra $2$. ($q=6, r=2$). Nota: Se permitirmos reagrupamento hierárquico (base posicional), os 6 grupos virariam 1 grupo de ordem superior e sobraria 1 grupo, resultando em $112_5$, mas pelo texto simples: 6 grupos e 2 restos.</li>
                        <li><strong>Base 6:</strong> $32 \div 6 = 5$ grupos, sobra $2$. ($q=5, r=2$).</li>
                    </ul>
                """,
            },
            new()
            {
                Id="17",
                Statement= """
                    <p>O que significa "Invariância Preservada" no contexto da verificação do rebanho?</p>
                """,
                Solution= """
                    <p>Significa que a quantidade (magnitude) do conjunto não mudou, mesmo que a forma de representá-la ou o estado do rebanho tenha mudado de lugar. Se a bolsa de pedras esvazia exatamente quando a última ovelha entra, a invariância foi preservada: nenhum animal foi perdido nem ganho.</p>
                """,
            },
            new()
            {
                Id="18",
                Statement= """
                    <p>Explique matematicamente por que 10 ovos não podem ser organizados em um retângulo de $3 \times \text{algo}$ ou $4 \times \text{algo}$ sem sobras.</p>
                """,
                Solution = """
                    <p>Porque 3 e 4 não são divisores inteiros de 10.</p>
                    <ul>
                        <li>$10 = 3 \cdot 3 + 1$ (Sobra 1)</li>
                        <li>$10 = 4 \cdot 2 + 2$ (Sobram 2)</li>
                    </ul>
                    <p>Isso demonstra a "pobreza geométrica" da base 10 mencionada no texto.</p>
                """,
            },
            new()
            {
                Id="19",
            Statement= """
                <p>Um estudante afirma: "A quantidade de ovelhas muda dependendo se eu as conto em base 10 ou base 12". Use o conceito do texto para corrigir esse estudante.</p>
            """,
            Solution= """
                <p>A afirmação está incorreta. A magnitude ($a$) é invariante e existe independentemente da representação. Base 10 e Base 12 são apenas "embalagens" ou "linguagens" diferentes para descrever a mesma realidade física. O número de ovelhas é o mesmo; o que muda são os coeficientes $q$ e $r$ usados para descrevê-lo.</p>
            """
            },
            new()
            {
                Id="20",
                Statement= """
                    <p>Conecte o conceito de "Bijeção" com o "Algoritmo da Divisão".</p>
                """,
                Solution= """
                    <p>A Bijeção é o método para lidar com unidades individuais ($r$), garantindo precisão absoluta item a item. O Algoritmo da Divisão é o método para lidar com conjuntos de unidades ($q$), permitindo gerenciar grandes escalas. Um sistema numérico eficiente usa o Algoritmo da Divisão para criar grupos ($q$) e, no final, usa a contagem unitária (correspondência) apenas para o pequeno resto ($r$) que sobrou.</p>
                """
            }
        }
    };
}