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
            <p style="text-indent:4em">Vamos começar com uma pequena dinâmica. No momento quero que você esqueça tudo o que sabe sobre números. Esqueça o dígito "5", a palavra "cinco", o numeral romano "V". Esqueça a tabuada e a calculadora do seu celular.</p>
            <p style="text-indent:4em">Agora estamos no final do Paleolítico Superior ou, talvez, no alvorecer da revolução agrícola na Suméria arcaica. O sol está se pondo, tingindo de laranja a poeira que se levanta do chão árido. Você é um pastor. Sua sobrevivência, e a da sua família, depende inteiramente de um fato simples: o rebanho que você levou para pastar pela manhã deve voltar intacto para o cercado à noite.</p>
            <p style="text-indent:4em">Você olha para o grupo de animais se movendo à sua frente. Sua mente percebe que são "muitos". Se houvessem três ovelhas, você vê "três". Se houver quatro, sabe que são "quatro". Mas acima disso? Em certas quantidades tudo se funde em um borrão indistinto de "muitos". A mente humana primitiva — e até mesmo a moderna se não tem treinamento — sofre de um limite de subitização (a capacidade de reconhecer quantidades instantaneamente) que raramente passa de cinco elementos se estão desorganizados.</p>
            <p style="text-indent:4em">Se um lobo tiver levado uma ovelha durante o dia, como você saberia? Sem palavras para números, você não pode contar "cinquenta e três" e depois verificar se ainda há "cinquenta e três". A abstração numérica não existe. Você sente a massa do rebanho, mas a precisão lhe escapa. A falha da memória humana colide com a necessidade de sobrevivência. Precisamos de um método de verificação que seja à prova de falhas e que não dependa da linguagem.</p>
            <p>Precisamos inventar a matemática.</p>
            <br>
            <h4>A Intuição e a Primeira Tentativa</h4>
            <p style="text-indent:4em">A solução que a humanidade encontrou foi brilhante em sua simplicidade física. Se você não pode contar as ovelhas mentalmente, você precisa de um substituto palpável para cada animal.</p>
            <p style="text-indent:4em>Você pega uma bolsa de couro e senta-se à entrada do cercado. Pela manhã, conforme cada ovelha sai para o pasto, você pega uma pequena pedra e a coloca dentro da bolsa. Em latim essa pedra se chamava calculus a origem da palavra "cálculo"</p>
            <ul>
                <li><strong>Ovelha passa</strong> $\rightarrow$ <strong>Pedra na bolsa.</strong></li>
                <li><strong>Outra Ovelha passa</strong> $\rightarrow$ <strong>Pedra na bolsa.</strong></li>
            </ul>
            <p style="text-indent:4em">À noite, você reverte o processo. Para cada ovelha que entra, você retira uma pedra da bolsa de couro. Se o rebanho estiver todo dentro do cercado e a bolsa estiver vazia: Invariância Preservada. Todos estão a salvo. Se sobrar uma pedra na bolsa: Perda. Uma ovelha não entrou no cercado pois ficou para trás. Se não houver pedra e passar uma última ovelha: Ganho. (Provavelmente, uma ovelha do vizinho se misturou ao seu rebanho).</p>
            <br>
            <p style="text-indent:4em">O que você acabou de realizar intuitivamente é um dos conceitos mais poderosos da matemática moderna: a Correspondência Biunívoca ("um-para-um"). Você não precisa saber quantas ovelhas existem. Você só precisa garantir que o "Conjunto das Ovelhas" e o "Conjunto das Pedras" tenham a mesma magnitude.</p>
            <br>
            <h4>O Problema das Escalas</h4>
            <p style="text-indent:4em">Esse sistema funcionou perfeitamente por milênios. Mas a civilização é vítima de seu próprio sucesso. Com a agricultura e as cidades, os rebanhos cresceram. Um rei não possui apenas 50 ovelhas; ele possui 5.000.</p>
            <p>Tente aplicar o método das pedras agora. Carregar uma bolsa com 5.000 pedras é logisticamente impossível. "Tudo bem", você diz, "vamos fazer marcas em um osso ou argila (talhas)". Você começa a riscar: $|||||||||||||...$</p>
            <p style="text-indent:4em">Rapidamente, você atinge um limite novamente. Ler cinco mil riscos na parede é tão impossível quanto contar as todas as ovelhas a olho nu. O cérebro não processa a repetição linear infinita. O método "um-para-um" é excelente, mas tem seus limites. Como entendemos matemáticamente o que o pastor fez?</p>
            <br>
            <h4>Cardinalidade e Bijeção</h4>
            <p style="text-indent:4em">O pastor percebeu que a “quantidade” não pertence a cada ovelha individualmente, mas ao conjunto como um todo. Ela é uma noção abstrata que expressa quantos elementos há em um grupo. Chamamos isso de Cardinalidade.</p>
            <br>
            <p style="text-indent:4em">Para que dois conjuntos tenham a mesma cardinalidade, precisamos provar que eles correspondem perfeitamente.</p>
            <div class="card">
                <h3>Definição 1.1.1 Correspondência Biunívoca (Bijeção)</h3>
                <p style="text-indent:4em">Dizemos que dois conjuntos $A$ e $B$ têm a mesma cardinalidade, denotada por $|A| = |B|$, se, e somente se, existe uma regra de correspondência (função) $f: A \to B$ que seja bijetora.<p>
                <h4>Para ser uma bijeção, a função precisa cumprir dois requisitos rígidos:</h4>
                <ul>
                    <li>
                        <strong>Injetora (Injetividade):</strong> $\forall x_1, x_2 \in A, f(x_1) = f(x_2) \implies x_1 = x_2$.
                        <ul>
                            <li><strong>Tradução:</strong> Para todo $x_1, x_2$ pertencentes ao conjunto A (ovelhas), se o correspondente de $x_1$ for igual ao correspondente de $x_2$ então $x_1$ é igual a $x_2$</li>
                            <li><strong>Interpretação:</strong> Se estamos falando hipoteticamente de duas ovelhas diferentes, mas a pedra que corresponde a uma ovelha é a mesma que corresponde a outra, então a correspondencia injetiva falhou, porque duas ovelhas distintas não podem receber a mesma pedra. $x_1 \neq x_2 \implies f(x_1) \neq f(x_2)$</li>
                            <li><strong>Observação:</strong> Se duas ovelhas correspondem a uma mesma pedra então a função não é injetora e a correspondencia não é biunívoca.</li>
                        </ul>
                    </li>
                    <br>
                    <li>
                        <strong>Sobrejetora (Sobrejetividade):</strong> $\forall y \in B, \exists x \in A \text{ tal que } f(x) = y$.
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
            <p style="text-indent:4em">Para resolver o problema das 5.000 ovelhas, a mente humana inventou o Agrupamento Hierárquico. Em vez de contar apenas unidades, começamos a agrupar e contar grupos e grupos de grupos. Pense por exemplo em grupos de 1.000 ovelhas, teriamos um total de 5 grupos.</p>
            <p style="text-indent:4em">A grande pergunta é qual quantidade ideal para os nossos grupos? Qual quantidade que atenda a todas as nossas necessidades, ou pelo menos a maioria delas?</p>
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
                <p style="text-indent:4em">Para quaisquer inteiros $a$ (total de elementos) e $b$ (o tamanho do grupo/base), com $b > 0$, existem inteiros únicos $q$ (quociente/grupos) e $r$ (resto) tais que:</p>
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
            <p style="text-indent:4em">A batalha entre a representação "um-para-um" e o "agrupamento eficiente" acontece agora mesmo, em seu celular, computador, televisão etc.</p>
            <p style="text-indent:4em>Os computadores são como o pastor primitivo usando pedrinhas. Eles usam o sistema Binário (Base 2): 0 ou 1, ligado ou desligado. Imagine um número do sistema decimal como o 255 (duzentos e cinquenta e cinco). Em binário, ele é 11111111. Agora imagine um engenheiro de software tentando ler um código de erro: 1011011001101... É ilegível. Caímos no mesmo problema das bolsas de bolsas lotadas de "calculus" (pedrinhas)</p>
            <p style="text-indent:4em">A solução? Agrupamento. Usamos Hexadecimal (Base 16). Por que 16? Porque $16 = 2^4$. Isso significa que podemos agrupar cada 4 "pedras" binárias em um único símbolo elegante.</p>
            <ul>
                <li><strong>Binário:</strong> 1111 (4 dígitos, difícil de ler em massa).</li>
                <li><strong>Hexadecimal:</strong> F (1 símbolo, denso em informação).</li>
            </ul>
            <p style="text-indent:4em">O Hexadecimal não é "mágica"; é apenas uma técnica de empacotamento para salvar o cérebro do programador, exatamente como os sumérios fizeram com seus rebanhos.</p>
            <br>
            <h4>Aplicação 1.1.2</h4>
            <p Style="text-indent:4em">Por que não vendemos ovos em pacotes de 10 (Base 10)? Afinal, usamos o sistema decimal para dinheiro.</p>
            <p style="text-indent:4em">Olhe para o número 10. Seus divisores são $\{1, 2, 5, 10\}$. Você só pode dividir 10 ovos ao meio ou em grupos de 5. Geometricamente, uma caixa com 10 só pode ser arranjada como $2 \times 5$. É uma estrutura rígida e pobre.</p>
            <p style="text-indent:4em">Agora olhe para o número 12 (uma dúzia). Seus divisores são $\{1, 2, 3, 4, 6, 12\}$. Isso é um sonho logístico! Você pode embalar 12 ovos em retângulos de $3 \times 4$, $2 \times 6$, $4 \times 3$, etc. A Base 12 sobrevive no comércio e na logística porque ela oferece mais "opções de empacotamento" (fatoração) do que a nossa base decimal biológica.</p>
            <br>
            <h4>Resumo</h4>
            <div class="card">
                <ul>
                    <li><strong>Problema Original:</strong> A memória humana falha e a subitização é limitada (max ~4 itens). Necessidade de verificar invariância.</li>
                    <li><strong>Correspondência Biunívoca (Bijeção):</strong> Método de verificar igualdade de tamanho entre conjuntos ($|A|=|B|$) sem contagem direta, emparelhando elementos (ex: ovelha $\leftrightarrow$ pedra).</li>
                    <li><strong>O Problema das Escalas:</strong> Representações "um-para-um" tornam-se ilegíveis e intransportáveis para grandes quantidades.</li>
                    <li><strong>Algoritmo da Divisão ($a = bq + r$):</strong> A base matemática do agrupamento. Transforma contagem linear em contagem hierárquica (pacotes + restos).</li>
                    <li><strong>Aplicação:</strong> Sistemas Hexadecimais (compressão de binário) e Logística (Base 12 otimiza fatoração e empacotamento).</li>
                </ul>
            </div>
        """
    };
}