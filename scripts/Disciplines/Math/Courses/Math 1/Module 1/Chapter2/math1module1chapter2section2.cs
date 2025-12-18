using SchoolData;

public class Math1Module1Chapter2Section2
{
    public static Topic Topic = new()
    {
        Id = "axioma-da-inducao",
        Name = "2.2 Axioma da Indução",
        Active = false,
        Body = """
            <h3>2.2 Axioma da Indução</h3>
            <p>Até agora, em nossa jornada pelos Axiomas de Peano, estabelecemos algumas regras sólidas:</p>
            <ul>
                <li>Existe um começo (o Zero).</li>
                <li>Todo número tem um próximo (o Sucessor).</li>
                <li>Ninguém volta para o Zero.</li>
                <li>Números diferentes não levam ao mesmo lugar (injetividade).</li>
            </ul>
            <p>Com isso temos uma linha infinita de números: $0 \to 1 \to 2 \to 3 \dots$.</p>
            <p>Mas havia um problema. Imagine que você é um arquiteto construindo uma estrada. Os axiomas anteriores garantem que você colocou o primeiro tijolo e que, depois de cada tijolo, você coloca outro. Mas eles não proíbem que existam tijolos em outro lugar, flutuando no espaço, desconectados da sua estrada principal.</p>
            <p>Os matemáticos perceberam que um modelo "quebrado" poderia obedecer a todas as regras anteriores e ainda assim não ser o Conjunto dos Naturais ($\mathbb{N}$) que conhecemos. seria por exemplo um universo que contém os números naturais normais $\{0, 1, 2, \dots\}$ e, além deles, dois números estranhos chamados $a$ e $b$ que vivem por ai e de modo que</p>
            <ul>
                <li>O sucessor de $a$ é $b$ ($S(a) = b$).</li>
                <li>O sucessor de $b$ é $a$ ($S(b) = a$).</li>
            </ul>
            <p>Neste universo bizarro:</p>
            <ul>
                <li>O Zero existe? Sim.</li>
                <li>Todo mundo tem sucessor? Sim ($a$ e $b$ têm).</li>
                <li>Alguém volta para o Zero? Não (o loop $a-b$ nunca toca no zero).</li>
                <li>A injetividade funciona? Sim.</li>
            </ul>
            <p>Esses "intrusos" ($a$ e $b$) satisfazem os primeiros axiomas, mas eles não são números naturais. Para resolver esse problema surgiu uma ideia desde 1575, com Francesco Maurolico, e foi refinada pelo gênio Blaise Pascal. Eles usavam uma lógica que hoje chamamos de "E assim por diante" (et cetera). A melhor analogia para entender isso é o Efeito Dominó.</p>
            <p>Para garantir que uma fila infinita de dominós caia inteira, você não precisa empurrar cada um deles individualmente (isso levaria a eternidade). Você só precisa garantir duas coisas:</p>
            <ul>
                <li>O Gatilho: Você precisa derrubar o primeiro dominó.</li>
                <li>A Transmissão: A queda de qualquer dominó (vamos chamá-lo de dominó $k$) garante a queda do próximo dominó ($k+1$).</li>
            </ul>
            <p>Se essas duas condições forem verdadeiras, a reação em cadeia é inevitável.</p>
            <p>Maurolico e Pascal usavam isso como uma ferramenta para provar curiosidades sobre números. Mas Peano teve uma visão muito mais profunda, ele inverteu a lógica: A indução é a definição da própria estrutura dos números.</p>
            <p>Se os "intrusos" $a$ e $b$ existissem, o efeito dominó não funcionaria neles. Se eu derrubar o dominó Zero, o dominó $1$ cai, o $2$ cai... mas a força nunca chega em $a$ e $b$. O Axioma da Indução é a regra que diz: "Se o efeito dominó não te derruba, você não existe no meu conjunto."</p>
            <br>
            <p>Na época de Peano, ele pensava em termos de conjuntos. Mas na lógica moderna (ZFC e Lógica de Primeira Ordem), somos ainda mais precisos. Usamos o que chamamos de Esquema de Axiomas da Indução.</p>
            <div class="card">
                <h3>Axioma 2.2.1</h3>
                <p>Para qualquer fórmula $\varphi(x)$ (uma propriedade ou afirmação sobre um número $x$):</p>
                <p>$$[ \varphi(0) \land \forall k (\varphi(k) \implies \varphi(S(k))) ] \implies \forall n \, \varphi(n)$$</p>
            </div>
            <ul>
                <li>$\varphi$ (Phi): Pense em $\varphi$ como "A Propriedade". Pode ser "ser par", "ser maior que 10", ou "o dominó cair". $\varphi(x)$ significa "o número $x$ tem essa propriedade".</li>
                <li>$\varphi(0)$ (O Caso Base): Esta é a primeira parte da nossa condição. Estamos dizendo: "A propriedade vale para o Zero". É o seu dedo empurrando o primeiro dominó.</li>
                <li>
                    $\forall k (\varphi(k) \implies \varphi(S(k)))$ (O Passo Indutivo):
                    <ul>
                        <li>$\forall k$: "Para qualquer número $k$ que você escolher..."</li>
                        <li>$\implies$: "Implica que..."</li>
                        <li>Tradução: "Se a propriedade vale para $k$, então ela obrigatoriamente vale para o sucessor de $k$ ($S(k)$)."</li>
                    </ul>
                </li>
                <li>
                    $\implies \forall n \, \varphi(n)$ (A Conclusão):
                    <ul>
                        <li>O símbolo grande do meio ($\implies$) diz: "Se você garantiu o passo 2 e o passo 3, então..."</li>
                        <li>"...a propriedade é verdadeira para todos os números naturais $n$."</li>
                    </ul>
                </li>
            </ul>
            <p>Às vezes, saber apenas que o dominó anterior caiu não é suficiente. Às vezes precisamos saber que todos os dominós anteriores caíram.</p>
            <ul>
                <li>Indução Fraca: Assume que vale para $k$ para provar $k+1$.</li>
                <li>Indução Forte: Assume que vale para todos os números menores que $k$ para provar $k$.</li>
            </ul>
            <p>Embora pareçam diferentes, em conjuntos bem ordenados como os Naturais, elas são logicamente equivalentes. Mas a Indução Forte é a ferramenta pesada que usamos para provas mais difíceis, como o Teorema Fundamental da Aritmética.</p>
            
        """,
        
    };
}