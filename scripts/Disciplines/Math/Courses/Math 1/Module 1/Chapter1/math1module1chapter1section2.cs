namespace SchoolData;

public static class Math1Module1Chapter1Section2
{
    public static Topic Topic = new()
    {
        Id = "igualdade-e-relacoes",
        Name = "1.2 Igualdade e Relações",
        Active = false,
        Body = """
            <h1>1.2 Igualdade e Relações</h1>
            <p>Como vimos nas seção anterior a linguagem humana, com a qual escrevíamos matemática há milênios, era ambígua demais para sustentar a lógica moderna. Em português, usamos a mesma palavra para duas situações completamente diferentes:</p>
            <ul>
                <li>Predicação (Propriedade): "Sócrates é mortal." (Aqui, "mortal" é apenas uma característica de Sócrates).</li>
                <li>Identidade (Igualdade): "A Estrela da Manhã é a Estrela da Tarde." (Aqui, estamos dizendo que dois nomes diferentes se referem exatamente ao mesmo objeto físico, o planeta Vênus).</li>
            </ul>
            <p>Essa confusão era fatal. Se não conseguíssemos definir com rigor absoluto o que significa "ser igual" (identidade), jamais conseguiríamos definir o que é o número 1, ou o 2, ou como a aritmética funciona. Como podemos construir os Números Naturais se não sabemos nem dizer se um número é ele mesmo? Precisávamos limpar essa bagunça. Precisávamos de uma definição sintática de igualdade.</p>
            <br>
            <p>Euclides, em seus famosos Elementos, estabeleceu o que chamou de "Noções Comuns". A mais famosa delas dizia: "Coisas iguais a uma mesma coisa são iguais entre si."</p>
            <p>Durante mais de dois mil anos, isso bastou. A intuição era geométrica e visual (superposição). Se eu recortasse um triângulo de madeira e ele cobrisse perfeitamente outro triângulo, eles eram "iguais".</p>
            <p>O problema é que a matemática parou de tratar apenas de triângulos de madeira e começou a tratar de conceitos abstratos, infinitos e invisíveis. Sem uma regra rígida, matemáticos caíam na Armadilha da Substituição: eles assumiam que podiam trocar uma coisa pela outra em equações, mas às vezes isso gerava paradoxos absurdos. A intuição de "parecer igual" não era suficiente. Precisávamos de uma regra que dissesse: "Se estes dois objetos são iguais, eles são indistinguíveis em qualquer universo lógico possível."</p>
            <br>
            <p>Para resolver a crise, a lógica moderna parou de tratar a igualdade como uma noção óbvia e passou a tratá-la como um Predicado Lógico Primitivo. Não se assuste com o nome. Um predicado é apenas uma pergunta que resulta em Verdadeiro ou Falso. A igualdade ($=$) é a pergunta mais fundamental de todas. Para que ela funcione, precisamos de apenas dois pilares (axiomas).</p>
            <p>O primeiro passo é admitir que o universo é consistente. Todo objeto é idêntico a si mesmo. Parece óbvio, mas precisa ser dito.</p>
            <div class="card">
                <h3>Axioma 1.2.1</h3>
                <p>$$\forall x (x = x)$$</p>
            </div>
            <p>Dissecando a Notação:</p>
            <ul>
                <li>$\forall$ (Quantificador Universal): Lê-se "Para todo". Estamos dizendo que isso vale para qualquer coisa no universo.</li>
                <li>$x$: É a nossa variável, o objeto.</li>
                <li>$(x = x)$: É a afirmação de identidade. "X é igual a X".</li>
            </ul>
            <p>O filósofo e matemático Gottfried Wilhelm Leibniz sonhou com uma "característica universal". Ele propôs o princípio da Indiscernibilidade dos Idênticos. A ideia é poderosa: se $x$ e $y$ são realmente a mesma coisa, então não pode existir nenhuma propriedade que $x$ tenha e $y$ não tenha. Se houver uma única diferença, eles não são iguais.</p>
            <div class="card">
                <h3>Axioma 1.2.2</h3>
                <p>$$\forall x \forall y (x = y \to (\varphi(x) \leftrightarrow \varphi(y)))$$</p>
            </div>
            <p>Dissecando a Notação:</p>
            <ul>
                <li>$\forall x \forall y$: "Para quaisquer dois objetos x e y..."</li>
                <li>$\to$: Símbolo de Implicação. "Se isso for verdade, então..."</li>
                <li>$\varphi$ (Letra grega Phi): Representa uma fórmula ou propriedade qualquer. Pode ser "ser vermelho", "ser par", ou "ser maior que 3".</li>
                <li>$\leftrightarrow$: Símbolo de Equivalência. "É verdadeiro se, e somente se, o outro também for".</li>
            </ul>
            <p>Tradução: "Se $x$ é igual a $y$, então qualquer propriedade $\varphi$ que seja verdadeira para $x$ TAMBÉM deve ser verdadeira para $y$."</p>
            <br>
            <h4>Exemplo</h4>
            <p>Você aprende na escola que a igualdade tem três propriedades: Reflexiva, Simétrica e Transitiva. Mas eu só te dei a Reflexiva e a Lei de Leibniz. Cadê as outras duas? Nós não precisamos aceitá-las como fé. Nós podemos prová-las.</p>
            <p>Vamos provar a Simetria ($Se\ x = y,\ ent\tilde{a}o\ y = x$) usando apenas a Lei de Leibniz. Acompanhe o raciocínio:</p>
            <ul>
                <li>Assuma que $x = y$.</li>
                <li>Pela Lei de Leibniz, se $x = y$, então para qualquer predicado $P$, $P(x)$ é verdadeiro se, e somente se, $P(y)$ for verdadeiro.</li>
                <p>$$\forall P \ (x = y \implies (P(x) \iff P(y)))$$</p>
                <li>Vamos escolher uma propriedade muito específica. Seja a propriedade $\varphi(z)$ definida como "ser igual a $x$" ($z = x$).</li>
                <li>Sabemos que $x$ tem essa propriedade (pois $x = x$, pela Reflexividade).</li>
                <p>$$\varphi(x) \iff x = x$$</p>
                <li>Como assumimos que $x = y$, pela Lei de Leibniz, o que é verdade para $x$ deve ser verdade para $y$. Como $\varphi(x)$ é verdadeiro, então $\varphi(y)$ deve ser verdadeiro.</li>
                <li>Substituindo $y$ na definição do predicado $\varphi$:</li>
                <p>$$\varphi(y) \iff y = x$$</p>
            </ul>
            <p>Portanto: $y = x$</p>
            <br>
            <p>Antes de avançarmos, precisamos evitar uma confusão comum trazida pela computação. Na programação, você vê coisas como: x = x + 1</p>
            <p>Para um matemático do século XIX isso é uma abominação. Um número $x$ nunca pode ser igual ao seu sucessor.</p>
            <ul>
                <li>Em Lógica Matemática o simbolo $=$ significa Identidade Eterna.</li>
                <li>Em Programação o simbolo $=$ significa Atribuição ("Pegue o valor antigo, some 1 e guarde no lugar do novo").</li>
                <li>Em Lógica, usamos $:=$ ou $\equiv$ para definições, mas $=$ é quase que sagrado.</li>
            </ul>
            <br>
            <h4>Aplicações</h4>
            <p><strong>Aplicação 1.2.1 </strong>A Lei de Leibniz é a regra física de como a memória do seu computador funciona. Imagine dois ponteiros, ptrA e ptrB. Se dizemos que ptrA == ptrB (eles apontam para o mesmo endereço de memória), estamos invocando a Indiscernibilidade. Se eu altero o objeto através do ptrA (digamos, mudo a cor de um personagem num jogo), e depois leio o objeto pelo ptrB, a cor precisa ter mudado. Se não mudasse, a igualdade seria falsa e o seu software estaria "quebrado". A lógica de Leibniz garante que referências diferentes para o mesmo objeto se comportem de maneira consistente.</p>
            <p><strong>Aplicação 1.2.2 </strong>Estamos prestes a construir a aritmética. Queremos provar que $1 + 1 = 2$. Isso só é possível graças à Transitividade (que, como vimos, deriva de Leibniz). O raciocínio será:</p>
            <ul>
                <li>$1 + 1$ é igual a "Sucessor de 1".</li>
                <li>"Sucessor de 1" é igual a $2$.</li>
                <li>Logo (por transitividade/substituição), $1 + 1 = 2$. Sem essa definição rigorosa de igualdade, a matemática colapsaria antes mesmo de chegarmos à soma.</li>
            </ul>
            <p><strong>Aplicação 1.2.3 </strong>Quando um sistema busca seu usuário pelo CPF ou ID, ele confia na unicidade. Um banco de dados relacional funciona sob a premissa de que se a Chave Primária é igual, o registro é o mesmo. A integridade dos dados bancários mundiais depende dessa definição estrita: não aceitamos "quase igual" quando se trata do seu dinheiro.</p>
            <br>
            <h4>Resumo</h4>
            <div class="card">
                <p><strong>Problema da linguagem: </strong>A linguagem natural ("é") confunde propriedade com identidade. Precisávamos de rigor.</p>
                <p><strong>A Solução: </strong>A Igualdade é um predicado lógico baseado em dois axiomas.</p>
                <p><strong>Reflexividade: </strong>$\forall x (x = x)$. Tudo é espelho de si mesmo.</p>
                <p><strong>Leibniz (Substitutividade): </strong>$\forall x \forall y (x = y \to (\varphi(x) \leftrightarrow \varphi(y)))$. Se são iguais, compartilham todas as propriedades.</p>
                <p><strong>O Poder:</strong> Desses dois, nascem a Simetria e a Transitividade, permitindo a substituição segura em equações.</p>
            </div>
        """,
        Problems = new()
        {
            // --- NÍVEL 1: FIXAÇÃO (FÁCIL) ---
            new()
            {
                Id = "1",
                Statement = """
                    <p>O texto diferencia dois usos do verbo "ser" na linguagem natural que causavam confusão lógica. Qual é a diferença fundamental entre "Sócrates é mortal" e "A Estrela da Manhã é a Estrela da Tarde"?</p>
                """,
                Solution = """
                    <ul>
                        <li><strong>Predicação:</strong> "Sócrates é mortal" descreve uma propriedade ou característica do sujeito.</li>
                        <li><strong>Identidade:</strong> "A Estrela da Manhã é a Estrela da Tarde" afirma que dois nomes diferentes referem-se exatamente ao mesmo objeto (igualdade).</li>
                    </ul>
                """
            },
            new()
            {
                Id = "2",
                Statement = """
                    <p>Antes da formalização moderna, qual era o método intuitivo utilizado desde Euclides para determinar se duas figuras geométricas eram iguais?</p>
                """,
                Solution = """
                    <ul>
                        <li>O método era a <b>superposição</b>.</li>
                        <li>A ideia era que se uma figura pudesse ser movida para cobrir perfeitamente a outra, elas eram consideradas iguais.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "3",
                Statement = """
                    <p>Qual é o enunciado formal e a notação do <b>Axioma da Reflexividade</b> apresentado no texto?</p>
                """,
                Solution = """
                    <ul>
                        <li>O axioma afirma que todo objeto é idêntico a si mesmo.</li>
                        <li>Notação: $\forall x (x = x)$</li>
                    </ul>
                """
            },
            new()
            {
                Id = "4",
                Statement = """
                    <p>O texto introduz a Lei de Leibniz como um pilar da igualdade. Qual é o conceito central desta lei, também conhecida como "Indiscernibilidade dos Idênticos"?</p>
                """,
                Solution = """
                    <ul>
                        <li>O conceito é que se $x$ e $y$ são a mesma coisa, eles devem compartilhar <b>todas</b> as propriedades.</li>
                        <li>Não pode existir nenhuma propriedade que $x$ tenha e $y$ não tenha.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "5",
                Statement = """
                    <p>Por que a expressão <code>x = x + 1</code> é considerada válida em programação, mas uma "abominação" na lógica matemática clássica apresentada?</p>
                """,
                Solution = """
                    <ul>
                        <li>Em programação, o símbolo <code>=</code> representa <b>atribuição</b> (mudança de estado no tempo).</li>
                        <li>Em matemática lógica, o símbolo $=$ representa <b>identidade eterna</b>. Um número não pode ser igual ao seu sucessor.</li>
                    </ul>
                """
            },

            // --- NÍVEL 2: APLICAÇÃO (MÉDIO) ---
            // Nota: O prompt solicitava exercícios de divisão euclidiana/base, mas o Texto fornecido é sobre Lógica/Igualdade. 
            // Para manter a coerência pedagógica e a utilidade do código, os exercícios de aplicação foram adaptados 
            // ao conteúdo real do texto (Lógica de 1ª Ordem e Aplicações Computacionais de Igualdade).

            new()
            {
                Id = "6",
                Statement = """
                    <p>Considere a Lei de Leibniz: $\forall x \forall y (x = y \to (\varphi(x) \leftrightarrow \varphi(y)))$. Se definirmos a propriedade $\varphi(k)$ como "o ponteiro $k$ aponta para o endereço de memória 0xFA3", e assumirmos que $a = b$. O que podemos concluir logicamente?</p>
                """,
                Solution = """
                    <ul>
                        <li>Pela Lei de Leibniz, se $a = b$, eles compartilham todas as propriedades.</li>
                        <li>Se $\varphi(a)$ é verdade (a aponta para 0xFA3), então $\varphi(b)$ <b>obrigatoriamente</b> deve ser verdade.</li>
                        <li>Conclusão: O ponteiro $b$ também aponta para o endereço 0xFA3.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "7",
                Statement = """
                    <p>Utilize a Lei de Leibniz para demonstrar formalmente a propriedade da <b>Transitividade</b>: Se $x = y$ e $y = z$, prove que $x = z$.</p>
                """,
                Solution = """
                    <ul>
                        <li>Premissa: $x = y$ e $y = z$.</li>
                        <li>Defina a propriedade $\varphi(w)$ como "$x = w$".</li>
                        <li>Sabemos que $\varphi(y)$ é verdade (pois nossa premissa diz $x = y$).</li>
                        <li>Como $y = z$, pela Lei de Leibniz, podemos substituir $y$ por $z$ na propriedade.</li>
                        <li>Logo, $\varphi(z)$ deve ser verdade.</li>
                        <li>Substituindo na definição de $\varphi$: $x = z$.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "8",
                Statement = """
                    <p>No contexto de Banco de Dados Relacionais, explique como o axioma da igualdade garante a integridade de uma Chave Primária (Primary Key).</p>
                """,
                Solution = """
                    <ul>
                        <li>O banco de dados assume a premissa de unicidade baseada na igualdade estrita.</li>
                        <li>Se $ID_{registroA} = ID_{registroB}$, o sistema assume que se trata do <b>mesmo</b> registro (Reflexividade e Unicidade).</li>
                        <li>Isso impede duplicidade e garante que uma atualização no registro A afete o que é lido como registro B (Leibniz).</li>
                    </ul>
                """
            },
            new()
            {
                Id = "9",
                Statement = """
                    <p>Se a intuição visual de "superposição" era funcional para Euclides, por que ela falha ao analisarmos o conceito de limites de funções ou séries infinitas?</p>
                """,
                Solution = """
                    <ul>
                        <li>A superposição exige objetos físicos ou geométricos finitos e estáticos.</li>
                        <li>Funções ou séries podem convergir para o mesmo valor sem serem a mesma função.</li>
                        <li>A "Armadilha da Substituição" ocorre quando assumimos igualdade baseada em aparência (aproximação) em vez de identidade lógica rigorosa.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "10",
                Statement = """
                    <p>Traduza a seguinte sentença para a notação formal de Lógica de Primeira Ordem apresentada no texto: "Se dois objetos $a$ e $b$ são iguais, então se $a$ é um número par, $b$ também é um número par."</p>
                """,
                Solution = """
                    <ul>
                        <li>Defina $P(k)$ como "k é par".</li>
                        <li>A sentença é uma aplicação direta da Lei de Leibniz.</li>
                        <li>Notação: $a = b \to (P(a) \leftrightarrow P(b))$</li>
                        <li>Ou mais especificamente: $a = b \land P(a) \to P(b)$.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "11",
                Statement = """
                    <p>Analise o seguinte trecho de código em C#: <code>string s1 = "ola"; string s2 = "ola";</code>. Embora tenham o mesmo valor, em algumas linguagens antigas eles poderiam ser objetos diferentes na memória. Se a linguagem não garantir a "Indiscernibilidade dos Idênticos" para strings, que problema poderia ocorrer?</p>
                """,
                Solution = """
                    <ul>
                        <li>Se a linguagem tratar <code>s1</code> e <code>s2</code> como iguais logicamente ($s1 == s2$) mas eles forem entidades distintas na memória sem sincronia...</li>
                        <li>Alterar <code>s1</code> poderia não alterar <code>s2</code>.</li>
                        <li>Isso violaria a Lei de Leibniz: teríamos $s1 = s2$ mas uma propriedade (valor interno) diferente, quebrando a lógica do sistema.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "12",
                Statement = """
                    <p>O texto afirma que a prova de que $1 + 1 = 2$ depende da transitividade. Reconstrua o silogismo lógico apresentado que permite essa conclusão.</p>
                """,
                Solution = """
                    <ul>
                        <li>Passo 1: $1 + 1$ é definido/igual a "Sucessor de 1".</li>
                        <li>Passo 2: "Sucessor de 1" é definido/igual a $2$.</li>
                        <li>Passo 3 (Transitividade): Se A = B e B = C, então A = C.</li>
                        <li>Conclusão: $1 + 1 = 2$.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "13",
                Statement = """
                    <p>Qual a diferença técnica entre os símbolos $\leftrightarrow$ (equivalência) e $=$ (igualdade) apresentada no texto?</p>
                """,
                Solution = """
                    <ul>
                        <li>$=$ (Igualdade) é um predicado que afirma que dois termos referem-se ao <b>mesmo objeto</b>.</li>
                        <li>$\leftrightarrow$ (Equivalência) é um conectivo lógico que afirma que duas <b>proposições</b> têm o mesmo valor de verdade (ambas V ou ambas F).</li>
                    </ul>
                """
            },
            new()
            {
                Id = "14",
                Statement = """
                    <p>Explique o conceito de "Aliasing" em computação utilizando a Lei de Leibniz.</p>
                """,
                Solution = """
                    <ul>
                        <li>Aliasing ocorre quando dois ponteiros ou referências diferentes ($ptrA$ e $ptrB$) apontam para o mesmo local de memória.</li>
                        <li>Matematicamente, $ptrA = ptrB$.</li>
                        <li>Pela Lei de Leibniz, qualquer alteração de estado (propriedade) feita via $ptrA$ deve ser imediatamente observável via $ptrB$, pois são indistinguíveis.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "15",
                Statement = """
                    <p>Dado o axioma $\forall x (x = x)$, explique por que a declaração <code>NaN != NaN</code> (Not a Number) em padrões de ponto flutuante (IEEE 754) é uma exceção curiosa à lógica clássica.</p>
                """,
                Solution = """
                    <ul>
                        <li>Na lógica clássica (Axioma 1.2.1), a reflexividade é absoluta: tudo é igual a si mesmo.</li>
                        <li>No padrão IEEE 754, <code>NaN</code> representa um valor indefinido. A computação define que um erro não é igual a outro erro.</li>
                        <li>Isso ilustra a diferença entre o rigor matemático puro (o texto) e implementações de engenharia pragmática.</li>
                    </ul>
                """
            },

            // --- NÍVEL 3: ANÁLISE (DIFÍCIL) ---
            new()
            {
                Id = "16",
                Statement = """
                    <p>Por que os matemáticos modernos preferem derivar a Simetria e a Transitividade a partir da Lei de Leibniz em vez de defini-las como axiomas independentes? Discuta o conceito de "elegância" ou "minimalismo" lógico.</p>
                """,
                Solution = """
                    <ul>
                        <li>Na axiomática, busca-se o número <b>mínimo</b> de pressupostos necessários.</li>
                        <li>Se a Simetria e Transitividade podem ser provadas usando apenas Reflexividade e Leibniz, transformá-las em axiomas seria redundante.</li>
                        <li>Um sistema com menos axiomas é mais robusto ("elegante") e mais fácil de verificar quanto à consistência.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "17",
                Statement = """
                    <p>Imagine um sistema lógico onde a Lei de Leibniz fosse falsa (existem objetos iguais com propriedades diferentes). Descreva uma consequência catastrófica para a aritmética básica (ex: soma) nesse universo.</p>
                """,
                Solution = """
                    <ul>
                        <li>Se $x = y$ mas eles pudessem ter propriedades diferentes, a substituição falharia.</li>
                        <li>Poderíamos ter $2 + 2 = 4$ sendo verdade para o "4 da esquerda", mas falso para o "4 da direita".</li>
                        <li>O resultado de uma conta deixaria de ser único, destruindo a confiabilidade de qualquer cálculo matemático.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "18",
                Statement = """
                    <p>O texto menciona que a falta de rigor na igualdade impedia a construção dos Números Naturais. Como a definição de "Sucessor" ($S(n)$) depende intrinsecamente da noção de igualdade?</p>
                """,
                Solution = """
                    <ul>
                        <li>Para definir uma função $S(n)$ (sucessor), precisamos garantir que ela seja uma <b>função</b> bem definida.</li>
                        <li>Isso significa que se $a = b$, então $S(a)$ <b>deve</b> ser igual a $S(b)$.</li>
                        <li>Sem a igualdade rigorosa (substitutividade), o sucessor de um número poderia ser ambíguo, impedindo a sequência 1, 2, 3...</li>
                    </ul>
                """
            },
            new()
            {
                Id = "19",
                Statement = """
                    <p>Analise a afirmação: "A crise dos fundamentos foi uma crise de sintaxe, não de semântica". Com base no texto, concorda ou discorda? Justifique.</p>
                """,
                Solution = """
                    <ul>
                        <li><b>Concorda.</b> O texto destaca que a intuição (semântica) existia e funcionava para casos simples (triângulos).</li>
                        <li>O problema era a linguagem (sintaxe) ambígua do "ser" e a falta de regras formais de manipulação de símbolos.</li>
                        <li>A solução foi criar uma definição sintática (axiomas formais) para controlar o raciocínio.</li>
                    </ul>
                """
            },
            new()
            {
                Id = "20",
                Statement = """
                    <p>Na Programação Orientada a Objetos, temos a distinção entre "Reference Equality" e "Value Equality" (ex: método <code>.Equals()</code> vs operador <code>==</code>). Relacione isso com a tensão histórica entre "Identidade" e "Superposição" descrita no texto.</p>
                """,
                Solution = """
                    <ul>
                        <li><b>Reference Equality</b> é análoga à Identidade Lógica estrita (é o mesmo objeto/átomo no universo?).</li>
                        <li><b>Value Equality</b> é análoga à Superposição Euclidiana (eles têm a mesma "forma" ou valor, mesmo sendo objetos distintos?).</li>
                        <li>A computação moderna resolveu a tensão mantendo ambas as definições, mas obrigando o programador a ser explícito sobre qual está usando.</li>
                    </ul>
                """
            }
        }
    };
}