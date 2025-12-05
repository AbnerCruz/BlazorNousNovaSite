using System.Collections.Generic;

namespace SchoolData.Disciplines;

public class PlanDetail
{
    public string Name { get; set; } = "unnamed";
    public decimal Price { get; set; } = 0;
    public decimal FakePrice { get; set; } = 0;
    public string Description { get; set; } = "no description";
    public List<string> Features { get; set; } = new();
}

public class SubscriptionPlanRepository
{
    private readonly decimal _basePrice = 29.90m;

    public List<PlanDetail> GetPlans()
    {
        return new List<PlanDetail>()
        {
            new()
            {
                Name = "Ouvinte",
                Price = _basePrice * 5,
                FakePrice = (_basePrice * 5) / 0.8m,
                Description = "Acesso intelectual completo. Ideal para autodidatas disciplinados ou estudantes de outras cidades.",
                Features = new()
                {
                    "Acesso a eventos online",
                    "Acesso a todas as aulas gravadas",
                    "Material didático digital",
                    "Lista de exercícios com gabarito"
                }
            },

            new()
            {
                Name = "Membro",
                Price = _basePrice * 10,
                FakePrice = (_basePrice * 10) / 0.85m,
                Description = "Imersão no ambiente. Para quem precisa da estrutura física e do convívio acadêmico.",
                Features = new()
                {
                    "Todos os benefícios de Ouvinte",
                    "Acesso às aulas presenciais (Auditório)",
                    "Acesso ao CLUBE DE ESTUDOS (Monitoria em grupo)",
                }
            },

            new()
            {
                Name = "Pleno",
                Price = _basePrice * 15,
                FakePrice = (_basePrice * 15) / 0.9m,
                Description = "Alta performance. Focado em métricas, competição saudável e eliminação de lacunas.",
                Features = new()
                {
                    "Todos os benefícios de Membro",
                    "Participação em Simulados Ranqueados",
                    "Dashboard de Métricas de Desempenho",
                }
            },

            new()
            {
                Name = "Elite",
                Price = _basePrice * 20,
                FakePrice = (_basePrice * 20) / 0.9m,
                Description = "Acompanhamento cirúrgico individual. O caminho mais rápido e seguro para objetivos de elite.",
                Features = new()
                {
                    "Todos os benefícios de Fellow",
                    "MENTORIA INDIVIDUAL SEMANAL (1h)",
                    "Plano de Estudos Personalizado (Cronograma)",
                    "Correção de provas discursivas pelo Mentor",
                    "Acesso direto ao WhatsApp do Mentor"
                }
            },
        };
    }
}