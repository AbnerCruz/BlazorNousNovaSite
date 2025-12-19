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
                Curriculum = new()
                {
                    new()
                    {
                        Id="module-1",
                        Name = "Sistemas de Numeração e Bases",
                        Active=true,
                        Duration = "3 Semanas",
                        Chapters = new()
                        {
                            new()
                            {
                                Id="fundamentos-do-valor-posicional",
                                Name="Capítulo 1 Fundamentos do Valor Posicional",
                                Topics = new()
                                {
                                    Math1Module1Chapter1Section1.Topic,
                                    Math1Module1Chapter1Section2.Topic,
                                    Math1Module1Chapter1Section3.Topic,
                                    Math1Module1Chapter1Section4.Topic,
                                }
                            },
                            new(){
                                Id="logica-binaria-e-computacional",
                                Name="Capítulo 2 Lógica Binária e Computacional",
                                Topics = new()
                                {
                                    Math1Module1Chapter2Section1.Topic,
                                    Math1Module1Chapter2Section2.Topic,
                                    Math1Module1Chapter2Section3.Topic,
                                }
                            },
                            new()
                            {
                                Id="abstracao-e-hexadecimal",
                                Name="Capítulo 3 Abstração e Hexadecimal",
                                Topics = new()
                                {
                                    Math1Module1Chapter3Section1.Topic,
                                    Math1Module1Chapter3Section2.Topic,
                                    Math1Module1Chapter3Section3.Topic,
                                }
                            }
                        },
                    },
                    new()
                    {
                        Id="module-2",
                        Name = "Algoritmos de Aritmética Mental",
                        Duration = "4 Semanas",
                        Chapters= new()
                        {
                            new()
                            {
                                Topics = new()
                                {
                                    new()
                                    {

                                    },
                                }
                            },
                        },
                    },
                    new()
                    {
                        Id="module-3",
                        Name = "Aritmética Estrutural",
                        Duration = "4 Semanas",
                        Chapters= new()
                        {
                            new()
                            {
                                Topics = new()
                                {
                                    new()
                                    {

                                    },
                                }
                            },
                        },
                    },
                    new()
                    {
                        Id="logica-formal-e-conjuntos",
                        Name = "Lógica Formal e Conjuntos",
                        Duration = "5 Semanas", // Lógica Booleana é uma linguagem nova
                        Chapters= new()
                        {
                            new()
                            {
                                Topics = new()
                                {
                                    new()
                                    {

                                    },
                                }
                            },
                        },
                    },
                    new()
                    {
                        Id="geometria-euclidiana-fundamentos",
                        Name = "Geometria Euclidiana: Fundamentos",
                        Duration = "4 Semanas",
                        Chapters= new()
                        {
                            new()
                            {
                                Topics = new()
                                {
                                    new()
                                    {

                                    },
                                }
                            },
                        },
                    },
                    new()
                    {
                        Id="geometria-posicional-e-tesselacoes",
                        Name = "Geometria Posicional e Tesselações",
                        Duration = "3 Semanas",
                        Chapters= new()
                        {
                            new()
                            {
                                Topics = new()
                                {
                                    new()
                                    {

                                    },
                                }
                            },
                        },
                    },
                    new()
                    {
                        Id="logica-de-programacao-e-algoritmos",
                        Name = "Lógica de Programação e Algoritmos",
                        Duration = "4 Semanas",
                        Chapters= new()
                        {
                            new()
                            {
                                Topics = new()
                                {
                                    new()
                                    {

                                    },
                                }
                            },
                        },
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
                        Chapters= new()
                        {
                            new()
                            {
                                Topics = new()
                                {
                                    new()
                                    {

                                    },
                                }
                            },
                        },
                    },
                    new()
                    {
                        Id="corpo-dos-racionais",
                        Name = "O Corpo dos Racionais $\\mathbb{Q}$",
                        Duration = "3 Semanas",
                        Chapters= new()
                        {
                            new()
                            {
                                Topics = new()
                                {
                                    new()
                                    {

                                    },
                                }
                            },
                        },
                    },
                    new()
                    {
                        Id="analise-combinatoria-I",
                        Name = "Análise Combinatória I",
                        Duration = "5 Semanas", // Combinatória é difícil de intuir, precisa de tempo
                        Chapters= new()
                        {
                            new()
                            {
                                Topics = new()
                                {
                                    new()
                                    {

                                    },
                                }
                            },
                        },
                    },
                    new()
                    {
                        Id="geometria-euclidiana-dedutiva",
                        Name = "Geometria Euclidiana: Dedutiva",
                        Duration = "5 Semanas", // Foco em demonstração formal
                        Chapters= new()
                        {
                            new()
                            {
                                Topics = new()
                                {
                                    new()
                                    {

                                    },
                                }
                            },
                        },
                    },
                    new()
                    {
                        Id="fundamentos-da-algebra",
                        Name = "Fundamentos da Álgebra",
                        Duration = "6 Semanas", // O ponto crítico onde muitos desistem. Precisa ser lento.
                        Chapters= new()
                        {
                            new()
                            {
                                Topics = new()
                                {
                                    new()
                                    {

                                    },
                                }
                            },
                        },
                    },
                    new()
                    {
                        Id="linguagem-algebrica-e-paridade",
                        Name = "Linguagem Algébrica e Paridade",
                        Duration = "2 Semanas",
                        Chapters= new()
                        {
                            new()
                            {
                                Topics = new()
                                {
                                    new()
                                    {

                                    },
                                }
                            },
                        },
                    },
                    new()
                    {
                        Id="introducao-as-funcoes-reais",
                        Name = "Introdução às Funções Reais",
                        Duration = "4 Semanas",
                        Chapters= new()
                        {
                            new()
                            {
                                Topics = new()
                                {
                                    new()
                                    {

                                    },
                                }
                            },
                        },
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
                        Id="sistemas lineares-e-matrizes",
                        Name = "Sistemas Lineares e Matrizes",
                        Duration = "5 Semanas",
                        Chapters= new()
                        {
                            new()
                            {
                                Topics = new()
                                {
                                    new()
                                    {

                                    },
                                }
                            },
                        },
                    },
                    new()
                    {
                        Id="teoria-dos-polinomis-I",
                        Name = "Teoria dos Polinômios I",
                        Duration = "4 Semanas",
                        Chapters= new()
                        {
                            new()
                            {
                                Topics = new()
                                {
                                    new()
                                    {

                                    },
                                }
                            },
                        },
                    },
                    new()
                    {
                        Id="identidades-algebricas-e-series",
                        Name = "Identidades Algébricas e Séries",
                        Duration = "5 Semanas", // Binômio de Newton é complexo
                        Chapters= new()
                        {
                            new()
                            {
                                Topics = new()
                                {
                                    new()
                                    {

                                    },
                                }
                            },
                        },
                    },
                    new()
                    {
                        Id="teoria-da-probabilidade",
                        Name = "Teoria da Probabilidade",
                        Duration = "4 Semanas",
                        Chapters= new()
                        {
                            new()
                            {
                                Topics = new()
                                {
                                    new()
                                    {

                                    },
                                }
                            },
                        },
                    },
                    new()
                    {
                        Id="desigualdades-analiticas",
                        Name = "Desigualdades Analíticas",
                        Duration = "3 Semanas",
                        Chapters= new()
                        {
                            new()
                            {
                                Topics = new()
                                {
                                    new()
                                    {

                                    },
                                }
                            },
                        },
                    },
                    new()
                    {
                        Id="trigonometria-geometrica",
                        Name = "Trigonometria Geométrica",
                        Duration = "4 Semanas",
                        Chapters= new()
                        {
                            new()
                            {
                                Topics = new()
                                {
                                    new()
                                    {

                                    },
                                }
                            },
                        },
                    },
                    new()
                    {
                        Id="geometria-metrica-avancada",
                        Name = "Geometria Métrica Avançada",
                        Duration = "5 Semanas", // Geometria de competição/Olimpíada
                        Chapters= new()
                        {
                            new()
                            {
                                Topics = new()
                                {
                                    new()
                                    {

                                    },
                                }
                            },
                        },
                    },
                    new()
                    {
                        Id="aritmetica-modular",
                        Name = "Aritmética Modular",
                        Duration = "3 Semanas",
                        Chapters= new()
                        {
                            new()
                            {
                                Topics = new()
                                {
                                    new()
                                    {

                                    },
                                }
                            },
                        },
                    }
                }
            },

            new Course()
            {
                Id="math4",
                Name = "Matemática IV",
                Curriculum = new()
                {
                    new()
                    {
                        Id="teoria-geral-das-funcoes",
                        Name = "Teoria Geral das Funções",
                        Duration = "3 Semanas",
                        Chapters= new()
                        {
                            new()
                            {
                                Topics = new()
                                {
                                    new()
                                    {

                                    },
                                }
                            },
                        },
                    },
                    new()
                    {
                        Id="equacoes-algebricas",
                        Name = "Equações Algébricas",
                        Duration = "3 Semanas",
                        Chapters= new()
                        {
                            new()
                            {
                                Topics = new()
                                {
                                    new()
                                    {

                                    },
                                }
                            },
                        },
                    },
                    new()
                    {
                        Id="corpo-dos-complexos",
                        Name = "O Corpo dos Complexos $\\mathbb{C}$",
                        Duration = "5 Semanas", // Visualizar Euler e raízes da unidade demora
                        Chapters= new()
                        {
                            new()
                            {
                                Topics = new()
                                {
                                    new()
                                    {

                                    },
                                }
                            },
                        },
                    },
                    new()
                    {
                        Id="funcoes-trigonometricas-reais",
                        Name = "Funções Trigonométricas Reais",
                        Duration = "4 Semanas",
                        Chapters= new()
                        {
                            new()
                            {
                                Topics = new()
                                {
                                    new()
                                    {

                                    },
                                }
                            },
                        },
                    },
                    new()
                    {
                        Id="trigonometria-analitica",
                        Name = "Trigonometria Analítica",
                        Duration = "4 Semanas", // Manipulação algébrica pesada
                        Chapters= new()
                        {
                            new()
                            {
                                Topics = new()
                                {
                                    new()
                                    {

                                    },
                                }
                            },
                        },
                    },
                    new()
                    {
                        Id="funcoes-transcendentes-e-assintotas",
                        Name = "Funções Transcendentes e Assíntotas",
                        Duration = "5 Semanas", // Base vital para o Cálculo
                        Chapters= new()
                        {
                            new()
                            {
                                Topics = new()
                                {
                                    new()
                                    {

                                    },
                                }
                            },
                        },
                    },
                    new()
                    {
                        Id="vetores-e-geometria-analitica",
                        Name = "Vetores e Geometria Analítica",
                        Duration = "4 Semanas",
                        Chapters= new()
                        {
                            new()
                            {
                                Topics = new()
                                {
                                    new()
                                    {

                                    },
                                }
                            },
                        },
                    }
                }
            },

            new Course()
            {
                Id="math5",
                Name = "Matemática V",
                Curriculum = new()
                {
                    new()
                    {
                        Id="limites-e-continuidade",
                        Name = "Limites e Continuidade",
                        Duration = "6 Semanas", // Epsilon-Delta é o maior filtro do cálculo
                        Chapters= new()
                        {
                            new()
                            {
                                Topics = new()
                                {
                                    new()
                                    {

                                    },
                                }
                            },
                        },
                    },
                    new()
                    {
                        Id="calculo-diferencial",
                        Name = "Cálculo Diferencial",
                        Duration = "5 Semanas",
                        Chapters= new()
                        {
                            new()
                            {
                                Topics = new()
                                {
                                    new()
                                    {

                                    },
                                }
                            },
                        },
                    },
                    new()
                    {
                        Id="calculo-vetorial-diferencial",
                        Name = "Cálculo Vetorial Diferencial",
                        Duration = "3 Semanas",
                        Chapters= new()
                        {
                            new()
                            {
                                Topics = new()
                                {
                                    new()
                                    {

                                    },
                                }
                            },
                        },
                    },
                    new()
                    {
                        Id="analise-do-comportamento-de-funcoes",
                        Name = "Análise do Comportamento de Funções",
                        Duration = "4 Semanas",
                        Chapters= new()
                        {
                            new()
                            {
                                Topics = new()
                                {
                                    new()
                                    {

                                    },
                                }
                            },
                        },
                    },
                    new()
                    {
                        Id="calculo-integral",
                        Name = "Cálculo Integral",
                        Duration = "8 Semanas", // Onde a maioria reprova. Precisa de muito treino técnico.
                        Chapters= new()
                        {
                            new()
                            {
                                Topics = new()
                                {
                                    new()
                                    {

                                    },
                                }
                            },
                        },
                    },
                    new()
                    {
                        Id="geometria-analitica-espacial",
                        Name = "Geometria Analítica Espacial",
                        Duration = "4 Semanas",
                        Chapters= new()
                        {
                            new()
                            {
                                Topics = new()
                                {
                                    new()
                                    {

                                    },
                                }
                            },
                        },
                    }
                }
            },

            new Course()
            {
                Id="math6",
                Name = "Matemática VI",
                Curriculum = new()
                {
                    new()
                    {
                        Id="algebra-linear-abstrata",
                        Name = "Álgebra Linear Abstrata",
                        Duration = "8 Semanas", // Fundamental para Data Science e Engenharia moderna
                        Chapters= new()
                        {
                            new()
                            {
                                Topics = new()
                                {
                                    new()
                                    {

                                    },
                                }
                            },
                        },
                    },
                    new()
                    {
                        Id="calculo-multivariavel",
                        Name = "Cálculo Multivariável",
                        Duration = "8 Semanas",
                        Chapters= new()
                        {
                            new()
                            {
                                Topics = new()
                                {
                                    new()
                                    {

                                    },
                                }
                            },
                        },
                    },
                    new()
                    {
                        Id="equacoes-diferenciais-ordinarias",
                        Name = "Equações Diferenciais Ordinárias",
                        Duration = "6 Semanas",
                        Chapters= new()
                        {
                            new()
                            {
                                Topics = new()
                                {
                                    new()
                                    {

                                    },
                                }
                            },
                        },
                    },
                    new()
                    {
                        Id="estruturas-algebricas-e-logica",
                        Name = "Estruturas Algébricas e Lógica",
                        Duration = "6 Semanas",
                        Chapters= new()
                        {
                            new()
                            {
                                Topics = new()
                                {
                                    new()
                                    {

                                    },
                                }
                            },
                        },
                    }
                }
            }
        };
    }
}