namespace SchoolData;

public static class Math1Module1Chapter1Section2
{
    public static Topic Topic = new()
    {
        Id = "cardinalidade-e-abstracao",
        Name = "1.2 Cardinalidade e Abstração",
        Active = true,
        Body = """
            <h1>1.2 Cardinalidade e Abstração</h1>
            <p>Na seção anterior, nós celebramos uma grande vitória humana: a invenção da Correspondência Biunívoca. Descobrimos que não precisávamos ser gênios para saber se o rebanho estava completo; bastava ter um saco de pedras (ou ossos com entalhes) onde cada pedra correspondia a uma ovelha. Se sobrasse pedra, faltava ovelha. Problema resolvido, certo?</p>
            <p>Errado.</p>
            <p>A sociedade evoluiu. As cidades-estado de Ur e Uruk começaram a crescer. O comércio deixou de ser apenas entre vizinhos e passou a cruzar desertos. Agora, imagine o problema: você é um rico proprietário de terras em Uruk e quer vender todo o seu rebanho — digamos, 500 cabeças de gado — para um comprador na distante cidade de Eridu. Você viaja até Eridu para negociar. O comprador pergunta: "Qual o tamanho do seu rebanho?"</p>
            <p>Aqui, a correspondência biunívoca falha catastroficamente.</p>
            <ul>
                <li><strong>O Problema da Presença:</strong> Você não trouxe as 500 vacas com você; elas ficaram em Uruk. Você não pode alinhar as vacas com as moedas de prata do comprador.</li>
                <li><strong>O Problema da Portabilidade:</strong> Você poderia ter trazido o saco com 500 pedras que representam as vacas? Sim, mas é pesado, inconveniente e arriscado. Se você perder uma pedra no caminho, você "perdeu" uma vaca na negociação.</li>
            </ul>
            <p>A correspondência física (pedra-por-vaca) era limitada ao aqui e agora. Eles precisavam de uma maneira de transportar a quantidade sem transportar a matéria. Precisávamos extrair a "quantidade" do corpo físico das vacas e transformá-la em algo que coubesse na mente. Precisávamos inventar o Número.</p>
            <br>
            <p>A mente humana não nasceu pronta para contar. Estudos antropológicos e cognitivos sugerem que, originalmente, nossa percepção de quantidade era muito limitada, quase instintiva. Pense como um caçador primitivo.</p>
            <ul>
                <li>Você vê um leão. Seu cérebro registra: Unitário (Perigo!).</li>
                <li>Você vê dois leões. Seu cérebro registra: Par (Perigo duplo!).</li>
                <li>Você vê cinco leões. Seu cérebro entra em pânico e registra apenas: Muitos.</li>
            </ul>
            <p>Durante milênios, o conceito de número ficou preso a essas distinções visuais ou a partes do corpo (contagem antropomórfica). Usávamos dedos, juntas e até orelhas para marcar quantidades. Mas isso ainda tinha uma falha grave pois ainda é uma forma de correspondência física. Dizer "tenho esta quantidade de ovelhas" mostrando as duas mãos abertas ainda depende das suas mãos. Se eu disser que tenho "três" ovelhas, mas usar pedras para mostrar isso, a ideia de "três" ainda está refém das pedras. A revolução aconteceu quando percebemos que um trio de ovelhas, um trio de pedras e um trio de estrelas compartilham uma "alma" comum. Essa propriedade invisível, que não tem cheiro, nem peso, nem cor, é o que chamamos de Cardinalidade.</p>
            <br>
            <p>A grande sacada foi dada séculos depois por lógicos como Gottlob Frege e David Hume. Eles perceberam que o número não é uma propriedade do objeto (a ovelha não é "número 3", ela é branca e peluda). O número é uma propriedade do grupo (conjunto). Eles formularam o que chamamos de Princípio de Abstração:</p>
            <div class="card'>
                <h3>Princípio de Frege-Hume</h3>
                <p>O número cardinal de um conjunto $A$ é idêntico ao número cardinal de um conjunto $B$ se, e somente se, é possível estabelecer uma correspondência biunívoca (uma bijeção) entre eles.</p>
                <p>$$Card(A) = Card(B) \iff A \sim B$$</p>
            </div>
            <br>
            <ul>
                <li>$Card(A)$: Lê-se "o cardinal de A". É o tamanho do conjunto.</li>
                <li>$\iff$: Lê-se "se, e somente se". Significa que os dois lados são equivalentes; um garante o outro.</li>
                <li>$A \sim B$: Lê-se "A é equipotente a B". Significa que existe aquela ligação perfeita, um-para-um, que vimos na Seção 1.1</li>
            </ul>
            <p>Mas o que é o número "3"?</p>
            <p>Na matemática definimos o número cardinal como uma Classe de Equivalência. Pense no número "3" como sendo uma caixa gigante. Dentro dessa caixa chamada "3", nós jogamos todos os conjuntos do universo que possuem três elementos.</p>
            <ul>
                <li>O conjunto dos Três Porquinhos está nessa caixa.</li>
                <li>O conjunto $\{\text{Sol}, \text{Lua}, \text{Terra}\}$ está nessa caixa.</li>
                <li>O conjunto das rodas de um triciclo está nessa caixa.</li>
            </ul>
            <p>Formalmente, escrevemos assim:</p>
            <div class="card">
                <h3>Definição 1.2.1</h3>
                <p>Um número cardinal é a classe de todos os conjuntos que são equipotentes a um conjunto modelo.</p>
                <p>Por exemplo, definimos o "Três" como:</p>
                <p>$$3 := \{ S \mid S \sim \{a, b, c\} \}$$</p>
            </div>
            <ul>
                <li>$:=$: Significa "é definido como".</li>
                <li>$\mid$: Significa "de modo que".</li>
                <li>$\sim$: Significa "equipotênte"</li>
                <li>Tradução: $3$ é definido como o conjunto S de modo que S é equipotênte a um conjunto de três elementos ${a,b,c}$</li>
            </ul>
            <h4>A Operação de Adjunção</h4>
            <p>Uma vez que temos o conceito de cardinal, não precisamos contar "um, dois, três" ainda. Podemos definir o "próximo número" puramente através de conjuntos. Isso se chama Soma Unária ou Adjunção.</p>
            <p>Se temos um conjunto $A$ com cardinal $n$, como criamos o sucessor $n'$ (o próximo número)? Simples: pegamos algo que não está em $A$ (vamos chamar de $x$) e jogamos dentro.</p>
            <p>$$Card(A \cup \{x\}) = n'$$</p>
            <p>Isso é poderoso porque define o progresso numérico sem precisar recitar nomes de números. É a base da estrutura lógica da aritmética.</p>
            <br>
            <h4>Aplicações</h4>
            <p><strong>Aplicação 1.2.1 </strong>Imagine que você criou uma playlist chamada "Foco" com 10 músicas no seu aplicativo de músicas. Agora, imagine que seu amigo criou uma playlist chamada "Épicas" também com 10 músicas.</p>
            <p>Para a matemática da Cardinalidade, essas duas playlists são idênticas: ambas têm o cardinal 10. Mas, na realidade física, elas podem ser drasticamente diferentes.</p>
            <ul>
                <li>Suas 10 músicas podem ser punk rock curtos (totalizando 20 minutos).</li>
                <li>As 10 músicas dele podem ser rock progressivo longo (totalizando 1 hora e meia).</li>
            </ul>
            <p>A "quantidade" (10) ignora a "duração". É graças a essa abstração que o aplicativo pode te dizer "Você tem 10 faixas adicionadas", tratando uma música de 1 minuto exatamente igual a uma de 10 minutos. O número cardinal é democrático: ele não se importa com o tamanho do objeto, apenas com a presença dele.</p>
            <br>
            <p><strong>Aplicação 1.2.2 </strong>Talvez a aplicação mais poderosa da cardinalidade seja social: o Voto. Numa eleição, aplicamos rigorosamente o conceito de cardinalidade abstrata.</p>
            <ul>
                <li>O voto da pessoa mais rica do país = 1.</li>
                <li>O voto de um estudante de 18 anos = 1.</li>
            </ul>
            <p>No mundo físico, essas pessoas são muito diferentes (influência, dinheiro, idade). Mas, na urna, a matemática remove todas essas características e deixa sobrar apenas o Unitário. Quando contamos os votos, não estamos somando dinheiro nem inteligência; estamos somando cardinais puros. A democracia só funciona porque concordamos em usar essa abstração matemática onde cada indivíduo conta como uma unidade idêntica, independentemente de quem seja na vida real.</p>
            <br>
            <p>A invenção da cardinalidade foi o momento em que a humanidade separou a "alma" da "matéria". Isso permitiu o nascimento da aritmética, da álgebra e de toda a ciência exata. Sem essa abstração, ainda estaríamos presos à troca de pedras. Com ela, ganhamos a capacidade de contar o que não podemos tocar: os dias do ano, as distâncias estelares e as transações financeiras digitais.</p>
            <p>Criamos o conceito de "quantidade". Mas ainda falta uma peça. Sabemos o que é o número, mas como organizá-los? Como sabemos que o 4 vem depois do 3? Para isso, precisaremos sair do mundo dos Cardinais e entrar no reino da Ordem. Mas isso é assunto para a próxima seção.</p>
            <h4>Resumo</h4>
            <div class="card">
                <p>Correspondência física (pedras) não funciona à distância. Necessidade de um padrão mental.</p>
                <p>A propriedade de "quantidade" compartilhada por conjuntos que podem ser mapeados um-para-um (bijeção).</p>
                <p>$Card(A) = Card(B) \iff A \sim B$. O número é definido pela possibilidade de pareamento, não pela contagem verbal.</p>
                <p>O número "5" é uma caixa abstrata de todos os grupos de cinco coisas no universo.</p>
                <p>O número de elementos não muda se você os reorganiza ou substitui os objetos, desde que a quantidade se mantenha (bijeção preservada).</p>
            </div>
        """,
        Problems = new()
        {
            // NÍVEL 1: FIXAÇÃO (1-5)
            new()
            {
                Id = "1",
                Statement = """
                    <p>De acordo com o texto, quais foram os dois problemas principais identificados na correspondência biunívoca física (pedra-por-vaca) quando o comércio começou a crescer e se expandir para outras cidades?</p>
                """,
                Solution = """
                    <ul>
                        <li><strong>O Problema da Presença:</strong> A impossibilidade de levar os objetos físicos (vacas) até o local da negociação.</li>
                        <li><strong>O Problema da Portabilidade:</strong> A inconveniência e o risco de transportar os objetos correspondentes (pedras), que são pesados e podem ser perdidos.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "2",
                Statement = """
                    <p>Segundo estudos antropológicos citados no texto, como o cérebro de um caçador primitivo registrava quantidades antes da invenção do número abstrato?</p>
                """,
                Solution = """
                    <p>O cérebro registrava as quantidades de forma instintiva e limitada em três categorias:</p>
                    <ul>
                        <li><strong>Unitário:</strong> Ao ver um leão.</li>
                        <li><strong>Par:</strong> Ao ver dois leões.</li>
                        <li><strong>Muitos:</strong> Ao ver cinco ou mais leões (entrando em pânico).</li>
                    </ul>
                """
            },
            new()
            {
                Id = "3",
                Statement = """
                    <p>Qual é o princípio formulado por Frege e Hume que define a igualdade entre números cardinais de dois conjuntos?</p>
                """,
                Solution = """
                    <p>É o <strong>Princípio de Abstração</strong> (ou Princípio de Frege-Hume), que afirma:</p>
                    <p>$$Card(A) = Card(B) \iff A \sim B$$</p>
                    <p>Isso significa que o cardinal de $A$ é idêntico ao de $B$ se, e somente se, existe uma correspondência biunívoca entre eles.</p>
                """
            },
            new()
            {
                Id = "4",
                Statement = """
                    <p>Conforme a Definição 1.2.1 apresentada no texto, como a matemática define formalmente um "número cardinal"?</p>
                """,
                Solution = """
                    <p>Um número cardinal é definido como uma <strong>Classe de Equivalência</strong>. É a classe de todos os conjuntos que são equipotentes a um conjunto modelo.</p>
                """
            },
            new()
            {
                Id = "5",
                Statement = """
                    <p>O texto menciona uma operação chamada "Soma Unária" ou "Adjunção" para definir o próximo número sem precisar contar. Qual é a fórmula apresentada para o sucessor $n'$ de um conjunto $A$?</p>
                """,
                Solution = """
                    <p>A fórmula da Adjunção é:</p>
                    <p>$$Card(A \cup \{x\}) = n'$$</p>
                    <p>Onde $x$ é um elemento que não está contido originalmente em $A$.</p>
                """
            },

            // NÍVEL 2: APLICAÇÃO (6-15)
            new()
            {
                Id = "6",
                Statement = """
                    <p>Um comerciante de Uruk viaja para Eridu para vender gado, mas deixa os animais em sua terra natal. Ao tentar negociar, ele percebe que não pode alinhar as vacas com as moedas do comprador. Segundo o texto, este cenário exemplifica qual falha da correspondência biunívoca?</p>
                """,
                Solution = """
                    <p>Este cenário exemplifica o <strong>Problema da Presença</strong>. A correspondência física exige que os objetos a serem contados estejam presentes no "aqui e agora" da negociação.</p>
                """
            },
            new()
            {
                Id = "7",
                Statement = """
                    <p>O texto afirma que usar os dedos para contar "três ovelhas" ainda possui uma falha grave similar ao uso de pedras. Por que isso ainda não é considerado uma abstração numérica completa?</p>
                """,
                Solution = """
                    <p>Porque ainda é uma forma de <strong>correspondência física</strong> (contagem antropomórfica). A ideia de quantidade ainda está "refém" ou presa ao objeto usado para representar (neste caso, as mãos), em vez de ser uma propriedade invisível e independente.</p>
                """
            },
            new()
            {
                Id = "8",
                Statement = """
                    <p>Considere a notação $3 := \{ S \mid S \sim \{a, b, c\} \}$. Aplique o significado dos símbolos explicados no texto para traduzir esta definição em linguagem natural.</p>
                """,
                Solution = """
                    <p>A tradução baseada nos símbolos do texto é: O número 3 é definido como ($:=$) o conjunto de todos os conjuntos $S$, de modo que ($\mid$) $S$ é equipotente ($\sim$) a um conjunto modelo de três elementos $\{a, b, c\}$.</p>
                """
            },
            new()
            {
                Id = "9",
                Statement = """
                    <p>No contexto do Princípio de Frege-Hume, se temos dois conjuntos $A$ e $B$ e afirmamos que $Card(A) = Card(B)$, o que necessariamente precisa ser verdadeiro sobre a relação entre $A$ e $B$?</p>
                """,
                Solution = """
                    <p>Necessariamente, deve ser possível estabelecer uma <strong>correspondência biunívoca</strong> (uma bijeção) entre $A$ e $B$. Em notação matemática do texto: $A \sim B$.</p>
                """
            },
            new()
            {
                Id = "10",
                Statement = """
                    <p>O texto utiliza o exemplo de playlists de música para ilustrar a cardinalidade. Se uma playlist tem 10 músicas curtas e outra tem 10 músicas longas, por que seus cardinais são idênticos apesar da diferença de tempo?</p>
                """,
                Solution = """
                    <p>Porque a cardinalidade ignora características físicas como a "duração" ou o tamanho. O número cardinal preocupa-se apenas com a <strong>presença</strong> dos elementos (unidades), tratando cada música como um item idêntico na contagem, independentemente de suas propriedades individuais.</p>
                """
            },
            new()
            {
                Id = "11",
                Statement = """
                    <p>Na aplicação sobre o Voto Social descrita no texto, o que acontece matematicamente com as características individuais (riqueza, inteligência, idade) de um eleitor ao entrar na urna?</p>
                """,
                Solution = """
                    <p>A matemática da cardinalidade <strong>remove todas essas características</strong>. O processo de abstração reduz o indivíduo ao conceito de "Unitário", fazendo com que o voto do mais rico e do estudante sejam somados como cardinais puros e idênticos (1).</p>
                """
            },
            new()
            {
                Id = "12",
                Statement = """
                    <p>Se utilizarmos a operação de Adjunção para gerar o número sucessor de um conjunto vazio $\emptyset$ (cujo cardinal é 0), qual seria a estrutura da operação, considerando $x$ como um novo elemento?</p>
                """,
                Solution = """
                    <p>Aplicando a fórmula do texto $Card(A \cup \{x\}) = n'$:</p>
                    <p>Tomamos $A = \emptyset$. Adicionamos um elemento $x$.</p>
                    <p>$$Card(\emptyset \cup \{x\}) = 1$$</p>
                    <p>Isso cria o conceito de "1" através da união de um conjunto com um elemento externo.</p>
                """
            },
            new()
            {
                Id = "13",
                Statement = """
                    <p>O texto diferencia "Número como propriedade do objeto" de "Número como propriedade do grupo". Se dissermos "Esta ovelha é o número 3", qual erro conceitual estamos cometendo segundo Frege e Hume?</p>
                """,
                Solution = """
                    <p>Estamos cometendo o erro de atribuir o número ao objeto físico. A ovelha em si tem propriedades como "branca" ou "peluda". O "número 3" é uma propriedade do <strong>grupo</strong> (conjunto) ao qual ela pertence, não do indivíduo.</p>
                """
            },
            new()
            {
                Id = "14",
                Statement = """
                    <p>Analise a seguinte afirmação com base no texto: "O símbolo $\iff$ indica que se eu sei o tamanho do conjunto, eu sei quais elementos estão nele". Esta afirmação está correta? Justifique usando a definição do símbolo.</p>
                """,
                Solution = """
                    <p>Não, está incorreta. O símbolo $\iff$ (se, e somente se) indica <strong>equivalência lógica</strong> entre os dois lados da equação ($Card(A)=Card(B)$ e $A \sim B$). Ele garante que a quantidade é igual se a bijeção existe, mas não diz nada sobre a identidade ou natureza dos elementos dentro dos conjuntos.</p>
                """
            },
            new()
            {
                Id = "15",
                Statement = """
                    <p>O texto afirma que o número é "democrático". Como essa característica é aplicada no exemplo do aplicativo de música?</p>
                """,
                Solution = """
                    <p>A característica "democrática" significa que o número não discrimina o conteúdo. No exemplo, uma música de 1 minuto tem o mesmo "peso" cardinal (1 unidade) que uma música de 10 minutos. Ambas contam igualmente para o total de faixas.</p>
                """
            },

            // NÍVEL 3: ANÁLISE (16-20)
            new()
            {
                Id = "16",
                Statement = """
                    <p>O texto descreve a transição da percepção primitiva ("Unitário, Par, Muitos") para a Cardinalidade. Por que a categoria "Muitos" representava uma falha crítica de precisão para a sobrevivência ou comércio complexo?</p>
                """,
                Solution = """
                    <p>A categoria "Muitos" é uma resposta de pânico e imprecisão. Ela falha porque não distingue entre, por exemplo, 5 leões e 50 leões. Sem a cardinalidade exata, não é possível planejar defesas adequadas ou realizar transações comerciais justas, pois a percepção visual entra em colapso após pequenas quantidades.</p>
                """
            },
            new()
            {
                Id = "17",
                Statement = """
                    <p>Analise a frase do texto: "Precisávamos extrair a 'quantidade' do corpo físico das vacas e transformá-la em algo que coubesse na mente". Como essa abstração específica permitiu o surgimento de transações financeiras digitais mencionadas no final do texto?</p>
                """,
                Solution = """
                    <p>Ao separar a "alma" (quantidade) da "matéria" (objeto físico), a humanidade permitiu que o valor numérico existisse independentemente do toque físico. Transações digitais são puramente cardinais: elas manipulam números que representam valor sem mover fisicamente ouro ou gado, algo impossível se ainda dependêssemos da correspondência física (pedras).</p>
                """
            },
            new()
            {
                Id = "18",
                Statement = """
                    <p>Critique a seguinte situação usando os conceitos do texto: Um sistema eleitoral onde o voto de uma pessoa com doutorado vale 2, e o de uma pessoa sem escolaridade vale 1. Isso viola qual aplicação da cardinalidade descrita?</p>
                """,
                Solution = """
                    <p>Isso viola a <strong>abstração da Cardinalidade no Voto</strong>. A matemática da cardinalidade exige que se ignorem as características qualitativas (como inteligência ou escolaridade) para focar apenas no Unitário. Ao dar pesos diferentes, o sistema reintroduz "propriedades do objeto" na contagem, quebrando a igualdade abstrata onde cada indivíduo é uma unidade idêntica.</p>
                """
            },
            new()
            {
                Id = "19",
                Statement = """
                    <p>Com base na seção "A Operação de Adjunção", explique como é possível construir toda a aritmética sem nunca usar nomes de números ("um", "dois") verbalmente.</p>
                """,
                Solution = """
                    <p>A Adjunção define o progresso numérico através da lógica de conjuntos: o "próximo" número é sempre o cardinal do conjunto atual unido a um novo elemento ($Card(A \cup \{x\})$). Isso cria uma cadeia lógica de sucessores baseada puramente na existência de elementos extras, permitindo estruturar a aritmética sem dependência linguística ou cultural de nomes de números.</p>
                """
            },
            new()
            {
                Id = "20",
                Statement = """
                    <p>No parágrafo final, o texto menciona que "criamos o conceito de quantidade", mas que isso não é suficiente para saber se "4 vem depois do 3". O que isso indica sobre a limitação do conceito de Cardinalidade isoladamente?</p>
                """,
                Solution = """
                    <p>Isso indica que a <strong>Cardinalidade</strong> define apenas o "tamanho" ou a "quantidade" dos grupos, mas não carrega intrinsecamente a informação de posição ou sequência. Saber o tamanho de um conjunto não explica automaticamente a hierarquia ou a sucessão dos números; para isso, é necessário um conceito distinto, que o texto identifica como <strong>Ordem</strong>.</p>
                """
            }
        }
    };
}