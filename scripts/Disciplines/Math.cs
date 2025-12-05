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
                            "Decomposição polinomial de um número",
                            "Conversão de bases: Decimal - Binário",
                            "Introdução ao Hexadecimal: relação com o binário",
                            "Operações básicas diretamente na base 2"
                        }
                    },
                    new()
                    {
                        Name = "Algoritmos de Aritmética Mental",
                        Duration = "4 Semanas", // Exige prática repetitiva para fixar
                        Contents = new()
                        {
                            "Matemática Védica",
                            "Multiplicação verticalmente e cruzada para 2 digitos",
                            "Quadrados de números terminados em 5 e próximos a 50",
                            "Estimativa de Fermi: ordens de grandeza e aproximação rápida"
                        }
                    },
                    new()
                    {
                        Name = "Aritmética Estrutural",
                        Duration = "4 Semanas", // O aluno precisa aprender a provar o óbvio
                        Contents = new()
                        {
                            "Propriedades axiomáticas das operações",
                            "Algoritmo da divisão euclidiana",
                            "Divisibilidade simples: múltiplos, divisores",
                            "Propriedade fundamental da divisão"
                        }
                    },
                    new()
                    {
                        Name = "Lógica Formal e Conjuntos",
                        Duration = "5 Semanas", // Lógica Booleana é uma linguagem nova
                        Contents = new()
                        {
                            "Lógica Booleana: Conectivos e Tabelas-verdade",
                            "Axiomas de Conjuntos: Pertinência e inclusão",
                            "Álgebra de Conjuntos (Diagramas de Venn)",
                            "Conjunto das Partes e Cardinalidade",
                            "Classificação dos Conjuntos Numéricos"
                        }
                    },
                    new()
                    {
                        Name = "Geometria Euclidiana: Fundamentos",
                        Duration = "4 Semanas",
                        Contents = new()
                        {
                            "Polígonos: Classificação e Propriedades",
                            "Perímetro e contorno",
                            "Área de triângulo e quadriláteros básicos",
                            "Análise dimensional e conversão de unidades",
                            "Teorema da Semelhança"
                        }
                    },
                    new()
                    {
                        Name = "Geometria Posicional e Tesselações",
                        Duration = "3 Semanas",
                        Contents = new()
                        {
                            "Plano Cartesiano $\\mathbb{R}^2$: Pontos e métricas",
                            "Isometrias: Simetria Axial e Radial",
                            "Tesselações e o recobrimento do plano"
                        }
                    },
                    new()
                    {
                        Name = "Lógica de Programação e Algoritmos",
                        Duration = "4 Semanas", // Essencial gastar tempo aqui para facilitar Mat V
                        Contents = new()
                        {
                            "Reconhecimento de Padrões: PA e PG visuais",
                            "Fluxogramas: Estruturas de Controle",
                            "Pseudocódigo: Condicionais (Se, então, senão)"
                        }
                    }
                }
            },

            new Course()
            {
                Name = "Matemática II",
                // Estimativa Total: ~8 Meses
                Curriculum = new()
                {
                    new()
                    {
                        Name = "Teoria Elementar dos Números",
                        Duration = "4 Semanas",
                        Contents = new()
                        {
                            "Crivo de Eratóstenes e a primalidade",
                            "Teorema Fundamental da Aritmética",
                            "Algoritmo de Euclides para MDC",
                            "Relação Fundamental entre MMC e MDC"
                        }
                    },
                    new()
                    {
                        Name = "O Corpo dos Racionais $\\mathbb{Q}$",
                        Duration = "3 Semanas",
                        Contents = new()
                        {
                            "Fração como classe de equivalência e operador",
                            "Fração Geratriz e expansão decimal",
                            "Densidade dos Racionais na reta real"
                        }
                    },
                    new()
                    {
                        Name = "Análise Combinatória I",
                        Duration = "5 Semanas", // Combinatória é difícil de intuir, precisa de tempo
                        Contents = new()
                        {
                            "Árvore de Decisão e Princípio Fundamental da Contagem",
                            "Permutações e Fatorial",
                            "Arranjos e Combinações Simples",
                            "Introdução a Grafos: 4 Cores e Dijkstra"
                        }
                    },
                    new()
                    {
                        Name = "Geometria Euclidiana: Dedutiva",
                        Duration = "5 Semanas", // Foco em demonstração formal
                        Contents = new()
                        {
                            "Ângulos e Transversalidade",
                            "Postulado das Paralelas",
                            "Soma dos ângulos internos (Polígonos convexos)",
                            "Desigualdade Triangular",
                            "Axiomas de Congruência de Triângulos"
                        }
                    },
                    new()
                    {
                        Name = "Fundamentos da Álgebra",
                        Duration = "6 Semanas", // O ponto crítico onde muitos desistem. Precisa ser lento.
                        Contents = new()
                        {
                            "Abstração Algébrica",
                            "Propriedade distributiva e fatoração primária",
                            "Resolução de Equações Lineares",
                            "Modelagem de problemas reais",
                            "Equações Quadráticas: Bhaskara e Discriminante"
                        }
                    },
                    new()
                    {
                        Name = "Linguagem Algébrica e Paridade",
                        Duration = "2 Semanas",
                        Contents = new()
                        {
                            "Variável vs. Incógnita vs. Parâmetro",
                            "Tradução de linguagem natural para algébrica",
                            "Demonstrações de Paridade (Pares e Ímpares)"
                        }
                    },
                    new()
                    {
                        Name = "Introdução às Funções Reais",
                        Duration = "4 Semanas",
                        Contents = new()
                        {
                            "Função Afim e Linearidade",
                            "Geometria Analítica da Reta (Introdutória)",
                            "Sistemas Lineares 2x2: Visão Geométrica",
                            "Função Quadrática: Parábola e Vértice"
                        }
                    }
                }
            },

            new Course()
            {
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
                            "Métodos de resolução analíticos",
                            "Discussão de Sistemas (SPD, SPI, SI)",
                            "Álgebra Matricial e Determinantes",
                            "Método de Escalonamento (Gauss)"
                        }
                    },
                    new()
                    {
                        Name = "Teoria dos Polinômios I",
                        Duration = "4 Semanas",
                        Contents = new()
                        {
                            "Definição formal e Grau",
                            "Algoritmo da Divisão Polinomial",
                            "Raízes, Zeros e Multiplicidade",
                            "Comportamento gráfico local"
                        }
                    },
                    new()
                    {
                        Name = "Identidades Algébricas e Séries",
                        Duration = "5 Semanas", // Binômio de Newton é complexo
                        Contents = new()
                        {
                            "Operadores de Somatório ($\\Sigma$) e Produtório ($\\Pi$)",
                            "Teorema do Binômio de Newton",
                            "Triângulo de Pascal e Combinatória",
                            "Identidades de Sophie Germain e Lagrange",
                            "Técnica de Completar Quadrados"
                        }
                    },
                    new()
                    {
                        Name = "Teoria da Probabilidade",
                        Duration = "4 Semanas",
                        Contents = new()
                        {
                            "Espaço Amostral e Axiomas de Kolmogorov (Intro)",
                            "Probabilidade de Laplace",
                            "Eventos Independentes e Condicionais",
                            "Teorema de Bayes"
                        }
                    },
                    new()
                    {
                        Name = "Desigualdades Analíticas",
                        Duration = "3 Semanas",
                        Contents = new()
                        {
                            "Médias: MA $\\ge$ MG",
                            "Desigualdade de Bernoulli",
                            "Desigualdade Triangular (Módulos)"
                        }
                    },
                    new()
                    {
                        Name = "Trigonometria Geométrica",
                        Duration = "4 Semanas",
                        Contents = new()
                        {
                            "Razões Trigonométricas no Triângulo Retângulo",
                            "Relação Fundamental da Trigonometria",
                            "Lei dos Senos e Cossenos (Antecipado para Geo)",
                            "Círculo Trigonométrico: Introdução"
                        }
                    },
                    new()
                    {
                        Name = "Geometria Métrica Avançada",
                        Duration = "5 Semanas", // Geometria de competição/Olimpíada
                        Contents = new()
                        {
                            "Pontos Notáveis do Triângulo",
                            "Teorema de Ceva e Menelaus (Trigonométrico)",
                            "Potência de Ponto",
                            "Quadriláteros Cíclicos (Brahmagupta)",
                            "Relações métricas no círculo"
                        }
                    },
                    new()
                    {
                        Name = "Aritmética Modular",
                        Duration = "3 Semanas",
                        Contents = new()
                        {
                            "Congruências e Classes de Resto",
                            "Critérios de Divisibilidade Avançados",
                            "Pequeno Teorema de Fermat",
                            "Teorema Chinês do Resto"
                        }
                    }
                }
            },

            new Course()
            {
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
                            "Formalismo: Domínio, Contradomínio e Imagem",
                            "Paridade e Simetria de Funções",
                            "Funções Bijetoras e Inversas",
                            "Álgebra de Funções e Composição"
                        }
                    },
                    new()
                    {
                        Name = "Equações Algébricas",
                        Duration = "3 Semanas",
                        Contents = new()
                        {
                            "Dispositivo de Briot-Ruffini",
                            "Teorema do Resto e D'Alembert",
                            "Relações de Girard (Vieta)",
                            "Teorema das Raízes Racionais"
                        }
                    },
                    new()
                    {
                        Name = "O Corpo dos Complexos $\\mathbb{C}$",
                        Duration = "5 Semanas", // Visualizar Euler e raízes da unidade demora
                        Contents = new()
                        {
                            "Unidade imaginária $i$",
                            "Forma Polar e Argumento Principal",
                            "Fórmula de Euler ($e^{i\\theta}$)",
                            "Teorema de De Moivre",
                            "Raízes da Unidade e Polígonos Regulares"
                        }
                    },
                    new()
                    {
                        Name = "Funções Trigonométricas Reais",
                        Duration = "4 Semanas",
                        Contents = new()
                        {
                            "Domínio, Imagem e Periodicidade",
                            "Gráficos das Funções Circulares",
                            "Transformações: Amplitude e Fase",
                            "Identidades Trigonométricas Fundamentais"
                        }
                    },
                    new()
                    {
                        Name = "Trigonometria Analítica",
                        Duration = "4 Semanas", // Manipulação algébrica pesada
                        Contents = new()
                        {
                            "Redução ao 1º Quadrante",
                            "Transformações de Arcos (Soma/Diferença)",
                            "Prostaférese (Fatoração Trigonométrica)",
                            "Funções Trigonométricas Inversas (Arcsen, Arccos)"
                        }
                    },
                    new()
                    {
                        Name = "Funções Transcendentes e Assíntotas",
                        Duration = "5 Semanas", // Base vital para o Cálculo
                        Contents = new()
                        {
                            "Exponenciais e Logaritmos Naturais",
                            "Propriedades Operatórias",
                            "Transformações de Gráficos",
                            "Limites no Infinito e Assíntotas (Intuição)",
                            "Taxas de Crescimento"
                        }
                    },
                    new()
                    {
                        Name = "Vetores e Geometria Analítica",
                        Duration = "4 Semanas",
                        Contents = new()
                        {
                            "Álgebra Vetorial no $\\mathbb{R}^2$",
                            "Produto Escalar e Projeções",
                            "Equações da Reta (Vetorial, Paramétrica, Geral)",
                            "Distância Ponto-Reta"
                        }
                    }
                }
            },

            new Course()
            {
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
                            "Definição Formal $\\epsilon-\\delta$",
                            "Propriedades dos Limites",
                            "Limites Fundamentais",
                            "Continuidade e Teorema do Valor Intermediário"
                        }
                    },
                    new()
                    {
                        Name = "Cálculo Diferencial",
                        Duration = "5 Semanas",
                        Contents = new()
                        {
                            "Interpretação Geométrica e Física",
                            "Regras de Derivação (Cadeia, Produto)",
                            "Derivação Implícita",
                            "Diferenciabilidade"
                        }
                    },
                    new()
                    {
                        Name = "Cálculo Vetorial Diferencial",
                        Duration = "3 Semanas",
                        Contents = new()
                        {
                            "Curvas Paramétricas Planas",
                            "Vetores Tangentes e Velocidade",
                            "Introdução a Campos Vetoriais",
                            "Curvatura (Intro)"
                        }
                    },
                    new()
                    {
                        Name = "Análise do Comportamento de Funções",
                        Duration = "4 Semanas",
                        Contents = new()
                        {
                            "Teoremas de Fermat, Rolle e Valor Médio",
                            "Critérios da 1ª e 2ª Derivada",
                            "Otimização e Taxas Relacionadas",
                            "Indeterminações e L'Hôpital"
                        }
                    },
                    new()
                    {
                        Name = "Cálculo Integral",
                        Duration = "8 Semanas", // Onde a maioria reprova. Precisa de muito treino técnico.
                        Contents = new()
                        {
                            "Integral Indefinida e Primitivas",
                            "Integral Definida de Riemann",
                            "Teorema Fundamental do Cálculo",
                            "Técnicas: Substituição e Partes",
                            "Integração de Racionais (Frações Parciais)"
                        }
                    },
                    new()
                    {
                        Name = "Geometria Analítica Espacial",
                        Duration = "4 Semanas",
                        Contents = new()
                        {
                            "Vetores no $\\mathbb{R}^3$ e Produto Vetorial",
                            "Produto Misto e Volumes",
                            "Planos e Esferas",
                            "Superfícies Quádricas"
                        }
                    }
                }
            },

            new Course()
            {
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
                            "Espaços Vetoriais e Subespaços",
                            "Base, Dimensão e Coordenadas",
                            "Transformações Lineares",
                            "Diagonalização e Teorema Espectral"
                        }
                    },
                    new()
                    {
                        Name = "Cálculo Multivariável",
                        Duration = "8 Semanas",
                        Contents = new()
                        {
                            "Topologia do $\\mathbb{R}^n$ (Curvas de Nível)",
                            "Derivadas Parciais e Diferencial Total",
                            "Gradiente e Direcional",
                            "Integrais Múltiplas e Mudança de Variável (Polar)"
                        }
                    },
                    new()
                    {
                        Name = "Equações Diferenciais Ordinárias",
                        Duration = "6 Semanas",
                        Contents = new()
                        {
                            "EDOs de 1ª ordem e Campos de Direção",
                            "EDOs Lineares de 2ª ordem",
                            "Osciladores Harmônicos",
                            "Transformada de Laplace"
                        }
                    },
                    new()
                    {
                        Name = "Estruturas Algébricas e Lógica",
                        Duration = "6 Semanas", // Abstração pura
                        Contents = new()
                        {
                            "Métodos Formais de Prova (Indução, Contradição)",
                            "Introdução à Teoria dos Grupos",
                            "Grupos Cíclicos e Permutações",
                            "Isomorfismos (Conceito)"
                        }
                    }
                }
            }
        };
    }
}