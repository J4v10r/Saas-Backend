# Saas-Backend
Status(Em andamento)
📦 Catálogo Digital SaaS (Multi-Tenant)
Plataforma white-label para revendedores criarem e gerenciarem catálogos digitais com foco em eletrônicos, e em produtos diversos.
Desenvolvida com arquitetura moderna, escalável e preparada para integração com diversos frontends.

🚀 Funcionalidades
✅ Multi-Tenancy – Isolamento completo de dados por revendedor (TenantId).

✅ Catálogos Personalizáveis – Templates, cores, identidade visual e domínios customizáveis.

✅ Pedidos & Pagamentos – Checkout com integração para PIX e cartão de crédito.

✅ Gestão de Assinaturas – Suporte a planos mensais e anuais para revendedores.

✅ Integrações – Conectores prontos para WhatsApp, Mercado Pago e geração automática de catálogos em PDF.

🛠️ Tecnologias
Plataforma: ASP.NET Core 9.0

Backend: .NET 9.0, Entity Framework Core (MySQL)

Arquitetura: Em camadas, com elementos de DDD (Domain-Driven Design)

Integração com Frontend: Suporte completo a CORS para comunicação segura com aplicações frontend

Autenticação: JWT (JSON Web Tokens)

Bibliotecas & Ferramentas:

AutoMapper

FluentValidation

Serilog

🔒 Segurança
🔐 Filtros por Tenant – Aplicados com HasQueryFilter para garantir isolamento de dados.

🛡️ Validação de Escopo – Autorização presente em todas as camadas da aplicação.

🔏 Isolamento de Dados Sensíveis – Informações como dados de pagamento são protegidas e segregadas.
