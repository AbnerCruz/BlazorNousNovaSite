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
            // ---------------------------------------------------------
            // DOMÍNIO A: LÓGICA, FUNDAMENTOS E MATEMÁTICA
            // ---------------------------------------------------------
            new Course()
            {
                Name = "Domínio A - Lógica, Fundamentos e Matemática",
                Curriculum = new()
                {
                    new()
                    {
                        Name = "Nível I: Alfabetização Lógica",
                        Duration = "Semestral",
                        Contents = new()
                        {
                            "Lógica Proposicional Básica (Conectivos, Tabelas-Verdade).",
                            "Teoria Ingênua dos Conjuntos (Pertinência, Inclusão).",
                            "Estrutura dos Naturais (N) e Indução Informal."
                        }
                    },
                    new()
                    {
                        Name = "Nível II: Formalismo e Demonstração",
                        Duration = "Semestral",
                        Contents = new()
                        {
                            "Lógica de Predicados (Quantificadores: Para todo, Existe).",
                            "O Método Axiomático e Regras de Inferência.",
                            "Relações Binárias (Ordem, Equivalência)."
                        }
                    },
                    new()
                    {
                        Name = "Nível III: Mapeamentos e Funções (Set-Theoretic)",
                        Duration = "Semestral",
                        Contents = new()
                        {
                            "Definição Formal de Função (Domínio, Contradomínio, Imagem).",
                            "Injetividade, Sobrejetividade e Bijetividade.",
                            "Famílias de Conjuntos."
                        }
                    },
                    new()
                    {
                        Name = "Nível IV: Infinito e Cardinalidade",
                        Duration = "Semestral",
                        Contents = new()
                        {
                            "Equipotência e Contabilidade.",
                            "Aritmética dos Cardinais (Cantor).",
                            "Hierarquia do Infinito (Alephs)."
                        }
                    },
                    new()
                    {
                        Name = "Nível V: Metamatemática e Sistemas Formais",
                        Duration = "Semestral",
                        Contents = new()
                        {
                            "Fundamentos Axiomáticos (ZFC - Zermelo-Fraenkel com Escolha).",
                            "Consistência e Completude.",
                            "Limites da Lógica (Teoremas de Gödel - Introdução Conceitual)."
                        }
                    }
                }
            },

            // ---------------------------------------------------------
            // DOMÍNIO B: ÁLGEBRA E TEORIA DOS NÚMEROS
            // ---------------------------------------------------------
            new Course()
            {
                Name = "Domínio B - Álgebra e Teoria dos Números",
                Curriculum = new()
                {
                    new()
                    {
                        Name = "Nível I: Aritmética Operacional",
                        Duration = "Semestral",
                        Contents = new()
                        {
                            "O Sistema Decimal Posicional.",
                            "Algoritmos das Operações em N.",
                            "Expressões Numéricas e Ordem de Operações."
                        }
                    },
                    new()
                    {
                        Name = "Nível II: O Anel dos Inteiros (Z)",
                        Duration = "Semestral",
                        Contents = new()
                        {
                            "Números Negativos e a Reta Inteira.",
                            "Divisibilidade (MDC, MMC, Algoritmo de Euclides).",
                            "Teorema Fundamental da Aritmética (Primos)."
                        }
                    },
                    new()
                    {
                        Name = "Nível III: O Corpo dos Racionais (Q)",
                        Duration = "Semestral",
                        Contents = new()
                        {
                            "Frações como Classes de Equivalência.",
                            "Dízimas e Expansão Decimal.",
                            "Potenciação e Radiciação em R."
                        }
                    },
                    new()
                    {
                        Name = "Nível IV: Polinômios e Estruturas Algébricas",
                        Duration = "Semestral",
                        Contents = new()
                        {
                            "O Anel de Polinômios R[x].",
                            "Fatoração e Produtos Notáveis.",
                            "Desigualdades Clássicas (Médias, Cauchy-Schwarz)."
                        }
                    },
                    new()
                    {
                        Name = "Nível V: Álgebra Superior e Complexos",
                        Duration = "Semestral",
                        Contents = new()
                        {
                            "O Corpo dos Complexos (C) - Forma Algébrica e Polar.",
                            "Introdução a Grupos, Anéis e Corpos.",
                            "Teorema Fundamental da Álgebra."
                        }
                    }
                }
            },

            // ---------------------------------------------------------
            // DOMÍNIO C: GEOMETRIA E ÁLGEBRA LINEAR
            // ---------------------------------------------------------
            new Course()
            {
                Name = "Domínio C - Geometria e Álgebra Linear",
                Curriculum = new()
                {
                    new()
                    {
                        Name = "Nível I: Geometria Intuitiva e Topológica",
                        Duration = "Semestral",
                        Contents = new()
                        {
                            "Entes Primitivos (Ponto, Reta, Plano).",
                            "Ângulos e Polígonos Convexos.",
                            "Noções de Topologia (Interior, Fronteira, Exterior)."
                        }
                    },
                    new()
                    {
                        Name = "Nível II: Geometria Euclidiana Plana",
                        Duration = "Semestral",
                        Contents = new()
                        {
                            "Congruência de Triângulos e Teorema de Tales.",
                            "Semelhança e Relações Métricas.",
                            "Área e Círculo."
                        }
                    },
                    new()
                    {
                        Name = "Nível III: Geometria Analítica (Plano R2)",
                        Duration = "Semestral",
                        Contents = new()
                        {
                            "Sistema Cartesiano e Distância.",
                            "Estudo da Reta e Circunferência.",
                            "Vetores no Plano (Operações Geométricas)."
                        }
                    },
                    new()
                    {
                        Name = "Nível IV: Matrizes e Transformações",
                        Duration = "Semestral",
                        Contents = new()
                        {
                            "Álgebra Matricial e Determinantes.",
                            "Sistemas Lineares.",
                            "Cônicas (Elipse, Hipérbole, Parábola)."
                        }
                    },
                    new()
                    {
                        Name = "Nível V: Espaço (R3) e Vetores",
                        Duration = "Semestral",
                        Contents = new()
                        {
                            "Geometria de Posição Espacial (Poliedros).",
                            "Volumes e Sólidos de Revolução.",
                            "Produto Escalar e Vetorial no Espaço."
                        }
                    }
                }
            },

            // ---------------------------------------------------------
            // DOMÍNIO D: ANÁLISE REAL E CÁLCULO
            // ---------------------------------------------------------
            new Course()
            {
                Name = "Domínio D - Análise Real e Cálculo",
                Curriculum = new()
                {
                    new()
                    {
                        Name = "Nível I: Fundamentos da Variação",
                        Duration = "Semestral",
                        Contents = new()
                        {
                            "Razão, Proporção e Grandezas.",
                            "Variação Linear e Afim.",
                            "Modelagem de Fenômenos Simples."
                        }
                    },
                    new()
                    {
                        Name = "Nível II: Anatomia das Funções",
                        Duration = "Semestral",
                        Contents = new()
                        {
                            "Definição Rigorosa de Função Real (f: A -> B).",
                            "Composição e Inversão de Funções.",
                            "Análise de Gráficos (Crescimento, Paridade)."
                        }
                    },
                    new()
                    {
                        Name = "Nível III: Funções Elementares",
                        Duration = "Semestral",
                        Contents = new()
                        {
                            "Funções Quadráticas e Modulares.",
                            "Trigonometria no Ciclo (Funções Circulares).",
                            "Identidades Trigonométricas."
                        }
                    },
                    new()
                    {
                        Name = "Nível IV: Transcendentes e Limites",
                        Duration = "Semestral",
                        Contents = new()
                        {
                            "Exponenciais e Logaritmos.",
                            "Sequências e Séries Numéricas.",
                            "Limites e Continuidade (Definição epsilon-delta)."
                        }
                    },
                    new()
                    {
                        Name = "Nível V: Cálculo Infinitesimal",
                        Duration = "Semestral",
                        Contents = new()
                        {
                            "A Derivada (Taxa de variação e Reta Tangente).",
                            "A Integral (Área e Teorema Fundamental do Cálculo).",
                            "Equações Diferenciais Ordinárias (Intro)."
                        }
                    }
                }
            },

            // ---------------------------------------------------------
            // DOMÍNIO E: MATEMÁTICA DISCRETA (COMBINATÓRIA)
            // ---------------------------------------------------------
            new Course()
            {
                Name = "Domínio E - Matemática Discreta (Combinatória)",
                Curriculum = new()
                {
                    new()
                    {
                        Name = "Nível I: Lógica de Contagem",
                        Duration = "Semestral",
                        Contents = new()
                        {
                            "Listagem Sistemática e Árvore de Possibilidades.",
                            "O Princípio Aditivo.",
                            "Padrões Numéricos Discretos."
                        }
                    },
                    new()
                    {
                        Name = "Nível II: Princípios Multiplicativos",
                        Duration = "Semestral",
                        Contents = new()
                        {
                            "O Princípio Fundamental da Contagem (PFC).",
                            "Fatorial e Permutações Simples.",
                            "Arranjos Simples."
                        }
                    },
                    new()
                    {
                        Name = "Nível III: Estruturas Combinatórias",
                        Duration = "Semestral",
                        Contents = new()
                        {
                            "Combinação Simples e o Triângulo de Pascal.",
                            "Permutação com Repetição.",
                            "Binômio de Newton."
                        }
                    },
                    new()
                    {
                        Name = "Nível IV: Combinatória Avançada",
                        Duration = "Semestral",
                        Contents = new()
                        {
                            "Princípio da Casa dos Pombos (Dirichlet).",
                            "Princípio da Inclusão-Exclusão.",
                            "Lemas de Kaplansky."
                        }
                    },
                    new()
                    {
                        Name = "Nível V: Teoria dos Grafos e Algoritmos",
                        Duration = "Semestral",
                        Contents = new()
                        {
                            "Grafos: Vértices, Arestas, Caminhos e Ciclos.",
                            "Grafos Eulerianos e Hamiltonianos.",
                            "Árvores e Algoritmos de Busca."
                        }
                    }
                }
            },

            // ---------------------------------------------------------
            // DOMÍNIO F: ESTOCÁSTICA (PROBABILIDADE E ESTATÍSTICA)
            // ---------------------------------------------------------
            new Course()
            {
                Name = "Domínio F - Estocástica (Probabilidade e Estatística)",
                Curriculum = new()
                {
                    new()
                    {
                        Name = "Nível I: Tratamento da Informação",
                        Duration = "Semestral",
                        Contents = new()
                        {
                            "Coleta e Organização de Dados Brutos.",
                            "Tabelas de Frequência (Absoluta e Relativa).",
                            "Leitura Crítica de Gráficos Básicos."
                        }
                    },
                    new()
                    {
                        Name = "Nível II: Estatística Descritiva",
                        Duration = "Semestral",
                        Contents = new()
                        {
                            "Medidas de Tendência Central (Média, Mediana, Moda).",
                            "Medidas de Dispersão (Amplitude, Variância, Desvio Padrão).",
                            "Histogramas e Diagramas de Box-Plot."
                        }
                    },
                    new()
                    {
                        Name = "Nível III: Introdução à Incerteza",
                        Duration = "Semestral",
                        Contents = new()
                        {
                            "Experimentos Aleatórios e Espaço Amostral.",
                            "Definição Clássica de Probabilidade (Laplace).",
                            "Eventos Complementares e União."
                        }
                    },
                    new()
                    {
                        Name = "Nível IV: Probabilidade Intermediária",
                        Duration = "Semestral",
                        Contents = new()
                        {
                            "Probabilidade Condicional.",
                            "Independência de Eventos.",
                            "Teorema de Bayes e Probabilidade Total."
                        }
                    },
                    new()
                    {
                        Name = "Nível V: Variáveis Aleatórias",
                        Duration = "Semestral",
                        Contents = new()
                        {
                            "Variáveis Discretas e Valor Esperado.",
                            "A Distribuição Binomial.",
                            "A Distribuição Normal (Gaussiana)."
                        }
                    }
                }
            }
        };
    }
}