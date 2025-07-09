# 📇 LiteApp v1.5

**LiteApp** é um aplicativo simples e didático de gerenciamento de contatos, desenvolvido em **C# com Windows Forms**.  
Ele é ideal para iniciantes que desejam aprender os fundamentos do CRUD, organização em camadas, persistência em JSON e agora, exportação de dados para arquivos `.CSV`.

> 🚀 A versão 1.5 traz como principal novidade a **exportação de contatos para arquivos CSV**, compatível com Excel, LibreOffice e Google Sheets.

---

## ✅ Novidades da versão 1.5

- 📤 **Novo botão “Exportar CSV”** para salvar a lista de contatos
- 📂 Usuário escolhe onde salvar o arquivo `.csv`
- 🧾 Arquivo gerado é compatível com planilhas como **Excel**
- 🔡 Contatos são exportados ordenados alfabeticamente
- 🛡️ Formatação segura (com aspas) para evitar que nomes/telefones com vírgulas quebrem o CSV

---

## 🧩 Funcionalidades completas

| Funcionalidade              | Status |
|-----------------------------|--------|
| Adicionar contato           | ✅     |
| Editar contato              | ✅     |
| Excluir contato             | ✅     |
| Buscar contato por nome     | ✅     |
| Ordenar contatos A-Z        | ✅     |
| Salvar em `contatos.json`   | ✅     |
| **Exportar para `.csv`**    | ✅     |

---

## 💻 Interface (v1.5)

[ Buscar ][__________]

[ Nome ][]
[ Telefone ][]

[ Adicionar ] [ Atualizar ] [ Excluir ] [ Exportar CSV ]

[Listagem dos contatos em ordem alfabética]

---

## 📁 Estrutura da solução

LiteAppSolution/
├── LiteApp.Domain/ # Contato.cs (modelo de dados)
├── LiteApp.Data/ # ContatoRepository.cs (salva/carrega JSON)
├── LiteApp.UI/ # Form1.cs (interface com WinForms)
├── contatos.json # Dados persistentes
└── contatos.csv # Exportado pelo usuário (versão 1.5)

---

## 💾 Arquivo CSV gerado

O arquivo `.csv` gerado conterá:

Nome,Telefone
"Ana Souza","(11) 91234-5678"
"Bruno Lima","(21) 99876-5432"

> Basta abrir com o Excel ou importar para o Google Planilhas.

---

## ▶️ Como usar

1. Execute o projeto `LiteAppSolution` pelo Visual Studio
2. Preencha nome e telefone, clique em **Adicionar**
3. Use o campo “Buscar” para filtrar
4. Clique em **Exportar CSV**
5. Escolha onde salvar o arquivo

---

## 🧠 Requisitos

- Visual Studio com suporte a Windows Forms
- Biblioteca [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json) (via NuGet)
- `.NET Framework` compatível com WinForms

---

## 📦 Próximas ideias para a versão 1.6

- [ ] Importar contatos de arquivos CSV
- [ ] Máscara no campo de telefone
- [ ] Campo de **E-mail**
- [ ] Dark Mode (tema escuro)
- [ ] Criação de instalador `.exe` personalizado

---

## 👤 Autor

Desenvolvido por [NathanMesquita]  
 
💡 Projeto educacional para praticar C#, Windows Forms e manipulação de arquivos com JSON e CSV.
