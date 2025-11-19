namespace SchoolData.Disciplines;

public class DisciplineMath : Discipline
{
    public DisciplineMath()
    {
        Name = "Matemática";
        Label = "math";
        Price = 45;
        Subtitle = "A matemática é usada em áreas como finanças, engenharia, culinária e até no planejamento do dia a dia. Aprenda agora e descubra como usar a matemática como uma ferramenta prática em suas tarefas diárias e profissionais.";
        Description = $"Por apenas R${Price.ToString("F2")} onde pode aprender matemática desde o zero até o mais avançado focando totalmente em seus próprios objetivos, com acompanhamento contínuo com professores qualificados e que acreditam na sua educação!";
        Courses = GenerateCourses();
        Sections = GenerateSections();
        Sections.Add("Conteúdos", Courses);
        Active = true;
    }

    public override List<Course> GenerateCourses()
    {
        return new()
        {
            new Course()
            {
                Name = "Matemática I",
                Curriculum = new()
                {
                    new()
                    {
                        Name = "Números e Operações Básicas",
                        Duration = "",
                        Contents = new()
                        {
                            "Introdução à história da matemática",
                            "Noções de quantidade",
                            "Algarismos e sistemas de numeração",
                            "Soma e subtração",
                            "Multiplicação e Divisão"
                        },
                    },
                    new()
                    {
                        Name = "Noções de Lógica Matemática",
                        Duration = "",
                        Contents = new()
                        {
                            "Proposição",
                            "Negação",
                            "Conectivos",
                            "Condicionais",
                            "Proposições logicamente falsas",
                            "Relação de implicação",
                            "Relação de equivalência",
                            "Sentenças abertas",
                            "Como negar proposições"
                        }
                    },
                    new()
                    {
                        Name = "Conjuntos",
                        Duration = "",
                        Contents = new()
                        {
                            "Noções básicas",
                            "Igualdade de conjuntos",
                            "Relação de pertinência e de inclusão",
                            "Operações",
                            "Conjuntos numéricos",
                            "Geratriz das Dizimas Periódicas Simples e Compostas",
                            "Intervalos",
                            "Operações com Intervalos",
                        }
                    },
                    new()
                    {
                        Name = "Fundamentos da Aritmética",
                        Duration = "",
                        Contents = new(){
                            "Noção intuitiva de igualdade",
                            "Operações com números inteiros",
                            "Operações com números fracionários",
                            "Operações com números decimais",
                            "Potenciação e radiciação",
                            "Múltiplos e divisores",
                            "Critérios de divisibilidade",
                            "Números pares, ímpares, primos, compostos, mistos",
                            "MDC e MMC"
                        }
                    },
                },
            },

            new Course()
            {
                Name = "Matemática II",
                Curriculum = new()
                {
                    new()
                    {
                        Name = "Introdução à Álgebra",
                        Duration = "",
                        Contents = new()
                        {
                            "Propriedades dos números reais",
                            "Produtos notaveis",
                            "Racionalização",
                            "Fatoração"
                        }
                    },
                    new()
                    {
                        Name = "Razão e Proporção",
                        Duration = "",
                        Contents = new()
                        {
                            "Razões e Proporções",
                            "Regra da sociedade",
                            "Regra de três simples e composta",
                        }
                    },
                    new()
                    {
                        Name = "Unidades de medida",
                        Duration = "",
                        Contents = new()
                        {
                            "Sistema internacional de unidades e medidas",
                            "Conversão entre unidades",
                            "Grandezas compostas e derivadas",
                        }
                    },
                    new()
                    {
                        Name = "Matemática Financeira",
                        Duration = "",
                        Contents = new()
                        {
                            "Porcentagem",
                            "Juros compostos",
                            "Descontos e acréscimos",
                        }
                    },
                    new()
                    {
                        Name = "Equações",
                        Duration = "",
                        Contents = new()
                        {
                            "Conceito de equação e propriedades da igualdade",
                            "Equações do 1° e 2° grau",
                            "Sistemas lineares simples",
                            "Introdução aos logaritmos e exponenciais",
                            "Noções de trigonometria"
                        }
                    }
                }
            },

            new Course()
            {
                Name = "Matemática III",
                Curriculum = new()
                {
                    new()
                    {
                        Name = "Funções",
                        Duration = "",
                        Contents = new()
                        {
                            "Conceito",
                            "Função sobrejetora",
                            "Função injetora",
                            "Função bijetora",
                            "Lei de formação",
                            "Construindo gráficos",
                            "Função inversa",
                            "Função polinômial de grau 1 e 2",
                            "Função constante",
                            "Função linear",
                            "Função afim",
                            "Função identidade",
                            "Gráfico e concavidade de uma função quadrática",
                            "Raizes da função",
                            "Vertice, valor máximo e valor mínimo",
                            "Crescimento e decrescimento",
                            "Função par e função impar",
                            "Função composta",
                            "Algumas funções",
                        }
                    },
                    new()
                    {
                        Name = "Sequências",
                        Duration = "",
                        Contents = new()
                        {
                            "Determinando uma sequência",
                            "Progressão Aritmética",
                            "Soma dos termos de uma PA",
                            "Progressão Geométrica",
                            "Soma dos termos de uma PG",
                            "Produto dos termos de uma PG",
                            "Relação entre juros e progressões"
                        }
                    }
                }
            },

            new Course()
            {
                Name = "Matemática IV",
                Curriculum = new()
                {
                    new()
                    {
                        Name = "Análise combinatória",
                        Duration = "",
                        Contents = new()
                        {
                            "Principio fundamental da contagem",
                            "Fatorial",
                            "Agrupamentos",
                            "Arranjos",
                            "Permutações",
                            "Combinações",
                            "Número binomial",
                            "Propriedades do triângulo de Pascal",
                            "Binômio de Newton",
                        }
                    },
                }
            }
        };
    }

}