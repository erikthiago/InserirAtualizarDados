# InserirAtualizarDados
App WinForms usando Dapper para inserir e atualizar dados

  Aplicativo Windows Forms que utiliza dapper para acesso à dados no sql server.
  Não é utilizada uma arquitetura robusta. Apenas uma trivial, pois o intituito do projeto é apenas realizar a exclusão de dados 
em cascata.

## Artigo de referência
 * [Medium](https://medium.com/@erikthiago/insert-com-dapper-e-winforms-7c466a8ece32) - Artigo que explica em detalhes o código do projeto
   
  ## Frameworks utilizados:<br/>
  - Dapper para acesso a dados.<br/>
  - Microsoft.Extensions.Configuration(.Json) para ler o arquivo json e encontrar a string de conexão com o banco de dados.<br/>
  - Unity para configurar e resolver as dependências.<br/>

## Referências
* [Dapper](http://dapper-tutorial.net/dapper) - Documentação do Dapper
* [Inserts e Updates](https://stackoverflow.com/questions/5957774/performing-inserts-and-updates-with-dapper) - Como fazer inserts no banco de dados usando Dapper.
 * [Medium](https://medium.com/@erikthiago/insert-com-dapper-e-winforms-7c466a8ece32) - Artigo 2
