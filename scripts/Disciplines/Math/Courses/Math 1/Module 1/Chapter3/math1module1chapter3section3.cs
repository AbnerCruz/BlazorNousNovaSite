using SchoolData;

public class Math1Module1Chapter3Section3
{
    public static Topic Topic = new()
    {
        Id = "generalizacao-de-base",
        Name = "3.3 Generalização de Base",
        Active = false,
        Body = """
            <h3>3.3 Generalização de Base</h3>
            <p>Imagine que estamos na Europa do final do século XVII. A ciência está explodindo: Newton está desvendando a gravidade, e a luz está sendo decomposta em arco-íris em laboratórios escuros. Por milênios, a humanidade viveu presa em uma espécie de "Torre de Babel" numérica. Se você viajasse para a Babilônia antiga, os astrônomos de lá olhariam para o céu e calculariam movimentos planetários usando a Base 60. Se atravessasse o oceano para encontrar os Maias, veria um sistema baseado no número 20. E, na Europa moderna, estávamos obcecados pela Base 10, contada nos dedos das mãos.</p> 
            <p>A matemática funcionava em todos esses lugares, mas os cientistas não conseguiam conversar entre si sem "tradutores" e portanto atrasando o desenvolvimento da humanidade.</p>
            <p>Imagine que você é um comerciante romano tentando explicar uma quantidade a um sábio babilônico.</p>
            <ul>
                <li>Você tem 3 cestos cheios de maçãs (onde cada cesto romano, digamos, vale 10 unidades) e 2 maçãs soltas. Total: 32.</li>
                <li>O babilônico olha para aquilo confuso. O cesto dele comporta 60 unidades.</li>
                <li>Para se entenderem, vocês teriam que despejar todas as maçãs no chão (voltar à unidade fundamental, a pedra bruta) e recontá-las uma a uma para o novo sistema.</li>
            </ul>
            <p>Mas nós sabemos que escrever um número é apenas um jogo de empacotamento.</p>
            <ul>
                <li>Na Base 10, empacotamos em caixas de 10.</li>
                <li>Na Base 12, empacotamos em caixas de 12.</li>
                <li>Na Base 2, empacotamos em caixinhas minúsculas de 2.</li>
            </ul>
            <p>A quantidade de maçãs (o número $N$) nunca muda. A única coisa que muda é o tamanho da caixa (a Base $b$) e quantas caixas usamos.</p>
            <br>
            <p>Leibniz e os matemáticos que o seguiram perceberam que precisavam de uma regra que funcionasse para qualquer caixa, de qualquer tamanho. Eles criaram o que chamamos hoje de Teorema Fundamental da Numeração.</p>
            <div class="card">
                <h3>Teorema 3.3.1 Representação em Base Arbitrária</h3>
                <p>Para qualquer inteiro $b > 1$ (que chamaremos de Base) e qualquer inteiro positivo $N$, existe uma representação única na forma de uma soma de potências de $b$.</p>
                <p>$$N = \sum_{i=0}^{k} d_i \cdot b^i$$</p>
            </div>
            <ul>
                <li>$N$ (O Número): Este é o objeto real, a quantidade de maçãs. Ele é invariante. Ele não se importa com a base que você escolhe.</li>
                <li>
                    $b$ (A Base): É o tamanho do seu agrupamento. A única regra é que $b$ deve ser maior que 1 ($b > 1$).
                    <ul>
                        <li>Por que maior que 1? Se a base fosse 1, teríamos o "sistema unário" (traços na parede: |||||). Para escrever "um milhão", você precisaria de um milhão de traços. Isso viola o princípio da eficiência; queremos que o número de símbolos cresça lentamente (logaritmicamente), não loucamente.</li>
                    </ul>
                </li>
                <li>
                    $d_i$ (Os Dígitos): Aqui está o segredo. Estes são os símbolos que usamos. Mas a regra é a seguinte:$$0 \le d_i < b$$
                    <ul>
                        <li>Isso significa que o dígito nunca pode ser igual ou maior que a base. Na base 10, o maior dígito é 9. Na base 2, o maior dígito é 1. Se você atingir o valor da base, você precisa criar uma nova caixa (fazer o transporte ou "vai um") e zerar a posição atual.</li>
                    </ul>
                </li>
                <li>$b^i$ (A Posição): Esta é a potência. Ela diz se o dígito está na casa das unidades ($b^0$), das dezenas/base ($b^1$), das centenas/quadrado da base ($b^2$), e assim por diante.</li>
            </ul>
            <p>A notação posicional que usamos no dia a dia, $(d_k \dots d_1 d_0)_b$, nada mais é do que uma abreviação preguiçosa para não termos que escrever esse polinômio inteiro todas as vezes.</p>
            <br>
            <h4>Aplicações</h4>
            <p><strong>Aplicação 3.3.1</strong> Vamos pegar o conceito abstrato de "três dezenas e sete unidades" (o número 37) e ver como essa Invariância funciona provando que ele é o mesmo objeto, não importa a "roupa" que vista.</p>
            <p>O Objeto: 37 (quantidade absoluta).</p>
            <p>Cenário A: A Lente Decimal ($b=10$) Quando escrevemos $37$, nosso cérebro faz automaticamente:</p>
            <p>$$N = 3 \cdot 10^1 + 7 \cdot 10^0$$</p>
            <p>$$N = 30 + 7 = 37$$</p>
            <p>Note que os dígitos (3 e 7) são menores que a base 10.</p>
            <br>
            <p>Cenário B: A Lente Binária ($b=2$) Como escrevemos essa mesma quantidade usando apenas caixas de tamanho 2? Vamos aplicar a fórmula polinomial. O número 37 em binário é escrito como $100101_2$. Vamos verificar se a conta fecha usando a fórmula da soma:</p>
            <p>$$N = \mathbf{1} \cdot 2^5 + \mathbf{0} \cdot 2^4 + \mathbf{0} \cdot 2^3 + \mathbf{1} \cdot 2^2 + \mathbf{0} \cdot 2^1 + \mathbf{1} \cdot 2^0$$</p>
            <p>Vamos narrar o cálculo:</p>
            <ul>
                <li>$1 \cdot 32$ (Uma caixa de 32)</li>
                <li>$0 \cdot 16$ (Nenhuma caixa de 16)</li>
                <li>$0 \cdot 8$ (Nenhuma caixa de 8)</li>
                <li>$1 \cdot 4$ (Uma caixa de 4)</li>
                <li>$0 \cdot 2$ (Nenhuma caixa de 2)</li>
                <li>$1 \cdot 1$ (Uma unidade solta)</li>
            </ul>
            <p>Somando tudo: $32 + 0 + 0 + 4 + 0 + 1 = \mathbf{37}$.</p>
            <p>Veja a mágica acontecer: O resultado da soma é idêntico. O objeto matemático $37$ permaneceu imóvel, sólido e perfeito, enquanto trocávamos as lentes pelas quais olhávamos para ele.</p>
            <p><strong>Aplicação 3.3.2</strong> Sem entender que $b$ pode ser qualquer coisa, não teríamos, por exemplo, o Base64. Você já viu aqueles links estranhos ou anexos de e-mail cheios de letras aleatórias? Isso é Base64. Como computadores só "comem" zeros e uns, mas a internet foi feita para transportar texto, engenheiros criaram um sistema onde a base é $b=64$. O "alfabeto" inclui $A-Z, a-z, 0-9$ e mais dois símbolos. Isso permite compactar sequências binárias complexas em texto legível. Eles aplicaram exatamente a mesma fórmula polinomial que acabamos de ver.</p>
            <p><strong>Aplicação 3.3.3</strong> Mais impressionante ainda é a Criptografia Moderna. Quando você acessa seu banco, a segurança depende de números gigantescos, maiores que a quantidade de átomos no universo. Computadores comuns (que operam em 64-bits) não conseguem contar até lá nativamente.A solução? Bibliotecas de "BigInts" (Grandes Inteiros) tratam esses números como polinômios em bases absurdas, como base $2^{32}$ ou base $2^{64}$. O computador faz a matemática "caixa por caixa", usando a generalização de bases para proteger seus segredos.</p>
            <br>
            <h4>Resumo</h4>
            <div class="card">
                <p><strong>Generalização:</strong> A base $b$ é uma escolha arbitrária. Qualquer inteiro $b > 1$ pode servir como fundação para um sistema numérico.</p>
                <p><strong>Invariância do Valor:</strong> O número $N$ existe independentemente de sua representação. $(100101)_2$ e $(37)_{10}$ são sinônimos exatos para a mesma quantidade.</p>
                <p><strong>Lei do Dígito:</strong> Para garantir que a escrita seja única e não ambígua, cada dígito $d_i$ deve satisfazer a condição $0 \le d_i < b$.</p>
                <p><strong>Poder Polinomial:</strong> A estrutura $N = \sum d_i b^i$ é a chave mestra que nos permite traduzir qualquer sistema numérico para qualquer outro, unificando a aritmética humana e a computacional.</p>
            </div>
        """,
        Problems = new()
        {
            new()
            {
                Id="",
                Statement= """

                """,
                Solution= """
                
                """
            }
        }
    };
}