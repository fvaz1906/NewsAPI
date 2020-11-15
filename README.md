# NewsAPI

* API simples para criação de notícias.

## Pacotes Utilizados

* Microsoft.EntityFrameworkCore.InMemory

## Utilização da API

* Rodar o comando dentro da pasta do projeto: dotnet dev-certs https --trust (Para aceitar o certificado HTTPS)
* Rodar dentro da pasta do projeto: dotnet run ou dotnet watch run.

## Rotas

* GET /v1/news
* POST /v1/news

Obs. Exemplo abaixo de uma notícia.

{
    "title": "Lucas Selfie é eliminado em A Fazenda 2020, quebra regra na despedida e gera punição para os outros peões",
    "title_description": "Lucas Selfie disputou a roça da semana com Jojo Todynho e Raíssa Barbora. Ele recebeu 26,45% dos votos pela permanência na casa",
    "news": "O apresentador Lucas Selfie foi o nono eliminado da 12º edição de A Fazenda nesta quinta-feira, 12. Na roça da semana ele enfrentou a funkeira MC Todynho e a influencer Raíssa Barbosa."
}