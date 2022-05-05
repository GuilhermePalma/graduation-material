### Junit4

- Framework OpenSource responsavel por realizar testes em classes java
- Usado p/ Testes Unitarios: Testar uma Funcionalidade/Metodos
- O ideal é ter uma classe de teste p/ cada classe

#### Ambiente de Testes

- Classes de Testes ficam dentro de `src/test/java/com/nameProject`
- O Nome da Classe deve terminar em `Test`
- Para cada metodo da classe, criar metodos de testes
  - Nesses metodos é importante ter uma Instancia da Classe que será testada
  - Usar das Bibliotecas `Asserts` para realizar os Testes

#### Rules

- Permite realizar algo antes ou após dos metodos serem executados
- Criar arquivos, diretorios, criar um recurso externo (ex: conexões sockets)
- Usar a Anotação ``@Rule`` no Metodo/Variavel que será utilizada

#### Testando Exceções

- É essencial testar os possiveis comportamentos anormais do software 
- Esperando que ocorra a Exceção na Execução de um Metodo
  - Marcar o Metodo como: `@Test(expected = ExceptionName.class)`
    - Essa anotação define que o resultado experado daquele metodo é ser gerado uma exceção
    - Caso não ocorra uma exceção no metodo, o Teste irá retornar como "Falha"
- Usando a classe `ExpectedException`
  - Criar uma variavel da Classe `ExpectedException` e Instancia-la
  - Marca-la como `@Rule`
  - Definir `expectedException.expect(codeOfException)`, e passar como parametro o codigo que irá gerar a `Exception` 
- Usando Tracked Message
  - Usar o `try/catch`
  - Usar o `fail` para Informar que a Exceção irá ocorrer
  - Dentro do Bloco `catch`, usar o `assertThat`
    - 1° Parametro: Mensagem da Exceção Recebida
    - 2° Parametro: Usar o metodo `is` e implementar a Mensagem de Exceção que será retornada

### Asserts

- São metodos utilitarios para validar se um caso de teste teve sucesso ou não
- É recomendado importar o metodo Estatico `Assert` p/ deixar o codigo mais legivel
- Asserts Disponiveis:
  - ``assertFalse``/``assertTrue``: Valida se o Resultado será true/false 
  - ``assertNotNull``/``assertNull``: Verifica se o Resultado é Nulo ou não
  - ``assetArrayEquals``: Verifica se o Resultado e igual ao Array informado
  - ``assertSame``/``assertNotSame``: Verifica se o Resultado possuem ou não a mesma referencia de Classe

### JUnit5

- Dá Suporte à novas Funcionalidades do Java 8
- Algumas Anotações Novas: ``@BeforeAll``, ``@BeforeAt``, ``@DiplayName``, ``@AfterAll``, ``@AfterAt``
- Dá suporte à Expressões `lambda`
- `assertAll`: Permite cirar Testes mais Complexos
  - Mais Simples de Identificar onde ocorreu um Erro
- **Assumptions**: Permite Realizar Testes que só permitem que o Codigo continue sendo executado se derem certo
  - ``assumingTrue(condition)``, ``assumingFalse(condition)``,``assumingThat(condition)``
  - Caso a **Assumptions** dê erro, é gerado uma exceção e os Demais Testes não são realizados
  - Muito utilizados para Validaçõs de Dependencias Externas (Ex: Database, APIs)

### Mocks

- Objetos que simulam comportamentos de Objetos Reais
- Frameworks de Mocks
  - Mockito: Erros de Facil Identificação
  - EasyMock: Semelhante ao Mockit
  - PowerMockito: Extenção do Mockit que permite Trabalhar com Java Reflection, Metodos Estatiticos, Finais e Estaticos

#### Mockito

- Seguir os mesmos Passos para criar o Ambiente de Testes (JUnit)
- Ao inves de Intanciar a Classe que será Testada com uma Intancia Propria, usar o `mock(ClassName.class)`
  - Passar a Referencia da Classe dentro do `mock`
- Para realizar o Teste: ``when(result).thenReturn(valueExpected)``


### Hamcrest

- Framework usado para Teste de Unidade, funcionando com JUnit
- Usa Predicados para fazer `Asserts`
- Usa o `AssertThat` com os `Matcher` correspondentes ao Resultado Esperado

#### Matcher

- Object Matche
- Bean Matcher: Verifica Propriedades Dentro do Objeto
  - ex:  Verificar se a Intancia de uma Classe (intanceOfClass) possue a Propriedade Informada (nameOfPropriety) ``assertThat(intanceOfClass, HasPropriety.hasPropriety(nameOfPropriety))`` 


### AssertJ

- Permite Testar alguns tipos de Arquivos
- Irá usar o `assertThat(data)` junto de:
  - ``.isEqualsTo(expectedValue)``: Verifica se o valor de `data` é igual ao ``expectedValue`` 


### TDD

- Tecnica de Construção de Software que guia sua construção a partir da escrita de Testes Inicialmente
- Metodologia de Testes e não um Framework
- Escreve um Teste --> Esperar o Teste Falhar --> Adicionar a Funcionalidade no Sistema --> Executar o Teste Novamente --> Refatorar o Codigo --> Voltar para o Inicio (Escerever um Teste)
- Principios
  - Um Codigo só deve ser Implementado quando um Teste Falhar
  - Deve ser Escrito o Minimo possivel de Codigo para um Teste Passar
  - Quando o Ciclo Concluir (Todos os Testes Passarem), um novo ciclo deve começão para uma nova funcionalidade  
- Obtem Codigo com menos erros
- Codigos mais simples
- Codigo é focado em resolver o Erro
- Mais separação no Codigo: Um codigo deve ser pequeno para que seja possivel testa-lo
