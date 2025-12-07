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
                        Duration = "3 Semanas", // Conceito de base não é trivial para iniciantes
                        Contents = new()
                        {
                            new()
                            {
                                Id="decomposicao-polinomial",
                                Name="Decomposição polinomial de um número",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="conversao-de-bases",
                                Name="Conversão de bases: Decimal - Binário",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="introducao-ao-hexadecimal",
                                Name="Introdução ao Hexadecimal: relação com o binário",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="operacoes-basicas-na-base-2",
                                Name="Operações básicas diretamente na base 2",
                                Body= """
                                    <h3>Em Breve</h3>
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
                                Id="matematica-vedica",
                                Name="Matemática Védica",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="multiplicacao-verticalmente-cruzada-2-digitos",
                                Name="Multiplicação verticalmente e cruzada para 2 digitos",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="quadrados-de-numeros-terminados-em-5-e-proximos-de-50",
                                Name="Quadrados de números terminados em 5 e próximos a 50",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="estimativa-de-fermi",
                                Name="Estimativa de Fermi: ordens de grandeza e aproximação rápida",
                                Body= """
                                    <h3>Em Breve</h3>
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
                                Id="propriedades-axiomaticas-das-operacoes",
                                Name="Propriedades axiomáticas das operações",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="algoritmo-da-divisao-euclidiana",
                                Name="Algoritmo da divisão euclidiana",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="divisibilidade-simples",
                                Name="Divisibilidade simples: múltiplos, divisores",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="propriedade-fundamental-da-divisao",
                                Name="Propriedade fundamental da divisão",
                                Body= """
                                    <h3>Em Breve</h3>
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
                                Id="logica-booleana",
                                Name="Lógica Booleana: Conectivos e Tabelas-verdade",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="axiomas-de-conjuntos",
                                Name="Axiomas de Conjuntos: Pertinência e inclusão",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="algebra-de-conjuntos",
                                Name="Álgebra de Conjuntos (Diagramas de Venn)",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="conjunto-das-partes-e-cardinalidade",
                                Name="Conjunto das Partes e Cardinalidade",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="classificacao-dos-conjuntos-numericos",
                                Name="Classificação dos Conjuntos Numéricos",
                                Body= """
                                    <h3>Em Breve</h3>
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
                                Id="poligonos",
                                Name="Polígonos: Classificação e Propriedades",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="perimetro-e-contorno",
                                Name="Perímetro e contorno",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="area-de-triangulo-e-quadrilateros-basicos",
                                Name="Área de triângulo e quadriláteros básicos",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="analise-dimensional-e-conversao-de-unidades",
                                Name="Análise dimensional e conversão de unidades",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="teorema-da-semelhanca",
                                Name="Teorema da Semelhança",
                                Body= """
                                    <h3>Em Breve</h3>
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
                                Name="Plano Cartesiano $\\mathbb{R}^2$: Pontos e métricas",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new(){
                                Id="isometrias",
                                Name="Isometrias: Simetria Axial e Radial",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="tesselacoes",
                                Name="Tesselações e o recobrimento do plano",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            }
                        }
                    },
                    new()
                    {
                        Name = "Lógica de Programação e Algoritmos",
                        Duration = "4 Semanas", // Essencial gastar tempo aqui para facilitar Mat V
                        Contents = new()
                        {
                            new()
                            {
                                Id="reconhecimento-de-padroes",
                                Name="Reconhecimento de Padrões: PA e PG visuais",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="fluxogramas",
                                Name="Fluxogramas: Estruturas de Controle",
                                Body= """
                                    <h3>Em Breve</h3>
                                """
                            },
                            new()
                            {
                                Id="pseudocodigo",
                                Name="Pseudocódigo: Condicionais (Se, então, senão)",
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