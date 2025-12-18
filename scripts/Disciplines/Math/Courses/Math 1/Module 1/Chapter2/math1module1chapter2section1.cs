using SchoolData;

public class Math1Module1Chapter2Section1
{
    public static Topic Topic = new()
    {
        Id = "sistema-axiomatico",
        Name = "2.1 Sistema Axiomático",
        Active = false,
        Body = """
            <h1>2.1 Sistema Axiomático</h1>
            <p>Europa no final do século XIX, a Matemática vivia uma era de ouro. Engenheiros extraploando os limites do que se pensava ser possivel, físicos previam o comportamento da eletricidade e astrônomos já calculavam as órbitas com precisão. Tudo isso funcionava graças ao Cálculo — uma ferramenta poderosa baseada nos Números Reais.</p>
            <p>O grande matemático Karl Weierstrass tinha acabado de "limpar" o Cálculo, provando que ele funcionava perfeitamente se aceitássemos os Números Reais. Os Reais, por sua vez, eram construídos sobre os Números Racionais (frações). E as frações? Bem, elas dependiam dos Números Inteiros e Naturais ($1, 2, 3...$). Mas como vimos no capítulo anterior nós estabelecemos uma linguagem matemática livre de ambiguidades, e nesse tempo ninguém sabia definir o que era um Número Natural.</p>
            <p>Parece absurdo, não é? Se eu te mostro duas maçãs, você sabe que são "2". Mas isso é física, não matemática. Maçãs apodrecem. Maçãs existem no espaço. E se o universo acabasse? O número "2" deixaria de existir? Os matemáticos perceberam que tinham construído um arranha-céu (o Cálculo moderno) sobre uma fundação de areia (a nossa "intuição" de contagem). Definir o número 2 dizendo "é aquilo que tem em um par de sapatos" é um argumento circular. Precisávamos de uma definição que não dependesse de objetos, de psicologia ou de dedos das mãos. Precisávamos de regras puras.</p>
            <br>
            <p>No início, a resposta padrão era o Platonismo Ingênuo. O matemático Leopold Kronecker declarou famosamente: "Deus fez os números inteiros; todo o resto é obra do homem". A ideia era que os números $1, 2, 3...$ eram entidades divinas ou primordiais. Eles simplesmente "estavam lá". Não precisavam de explicação. Mas essa abordagem falha miseravelmente quando olhamos para o infinito. Se confiamos apenas na intuição, como garantimos que a contagem nunca para? Como provamos que a sequência numérica não faz um loop gigante e volta para o zero depois de um trilhão de passos? A intuição humana não lida bem com o infinito; ela quebra.</p>
            <p>Foi Richard Dedekind quem teve o insight salvador. Ele percebeu que o número "3" não é uma coisa, nem uma coleção de três itens. O "3" é apenas uma posição em uma fila. O que define o "3" não é seu valor intrínseco, mas o fato de que ele vem depois do "2" e antes do "4". Os números são dominós em uma fila infinita. Não importa do que os dominós são feitos; importa apenas a ordem em que estão organizados.</p>
            <br>
            <p>Entra em cena Giuseppe Peano. Em 1889, ele pegou essa ideia de "fila de dominós" e a traduziu para a linguagem lógica rigorosa que começamos a estudar na seção anterior. Peano disse: "Vamos parar de fingir que sabemos o que são números. Vamos jogar um jogo com três peças básicas e ver se conseguimos construir toda a aritmética a partir delas."</p>
            <p>As "peças do jogo" são as seguintes Noções Primitivas:</p>
            <ul>
                <li>Um conjunto de números chamado $\mathbb{N}$ (os Naturais).</li>
                <li>Um elemento inicial especial, que chamaremos de $0$ (zero).</li>
                <li>Uma regra de movimento, chamada de Função Sucessor ($S$).</li>
            </ul>
            <p>Primeiro, precisamos garantir que existe alguma coisa. Se o conjunto for vazio, não temos matemática.</p>
            <div class="card">
                <h3>Axioma 1.2.1</h3>
                <p>$$0 \in \mathbb{N}$$</p>
            </div>
            <ul>
                <li>$0$: É apenas um símbolo para o "ponto de partida". Poderíamos ter usado $\star$ ou "início".</li>
                <li>$\in$ (Pertence): O símbolo grego Epsilon, que indica que o $0$ vive dentro do conjunto $\mathbb{N}$.</li>
                <li>Tradução: "Existe um primeiro dominó posicionado na mesa."</li>
            </ul>
            <br>
            <div class="card">
                <h3>Axioma 1.2.2</h3>
                <p>$$\forall n \in \mathbb{N}, \exists! S(n) \in \mathbb{N}$$</p>
            </div>
            <ul>
                <li>$\forall n$: Para qualquer $n$...</li>
                <li>$\exists!$: Existe um único...</li>
                <li>$S(n)$: Sucessor de $n$.</li>
                <li>Tradução: Todo número natural possui exatamente um próximo número natural, chamado sucessor. Este axioma introduz formalmente a noção de “próximo” na aritmética.</li>
            </ul>
            <br>
            <p>E se a nossa fila de números se dividisse e depois se juntasse de novo, como dois rios se fundindo? E se o sucessor do 2 fosse o 5, mas o sucessor do 4 também fosse o 5? Teríamos uma estrutura em forma de "Y". Isso destruiria a contagem linear. Precisamos proibir isso.</p>
            <div class="card">
                <h3>Axioma 1.2.3</h3>
                <p>$$\forall n, m \in \mathbb{N}, S(n) = S(m) \implies n = m$$</p>
            </div>
            <ul>
                <li>$\implies$ (Implica): A seta lógica de "se... então".</li>
                <li>Tradução: Se o sucessor de um número é o mesmo sucessor de outro, então esses dois números são iguais.</li>
            </ul>
            <
        """,
        Problems = new()
        {
        }
    };
}