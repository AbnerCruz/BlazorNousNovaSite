namespace SchoolData;

public static class Math1Module1Chapter1Section1
{
    public static Topic Topic = new()
    {
        Id = "correspondencia-e-agrupamento",
        Name = "1.1 Correspondência e Agrupamento",
        Active = true,
        Body = """
            <h3>1.1 Correspondência e Agrupamento</h3>
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
    };
}