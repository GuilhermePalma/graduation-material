# Contribuições em Repositorios

### Processo de Fork

- Uma das formas de contribuir em repositorios de outras pessoas, é por meio do ``Fork``.
- ``Fork``: Processo que ocorre no GitHub em que um Repositorio de Outra Pessoa é "Clonado" para o Meu Perfil
  - Após o ``Fork``, eu consigo realizar um ``git clone`` no Repositorio, Realizar Alterações e Enviar para o Repositorio Online (GitHub)
  - Para Deixar mais organizado, após o ``Fork`` e ``Clone`` é recomendado criar uma nova ``branch`` que armazenará as alterações no Projeto
    - Isso facilita com o Pull-Request seja aprovado
    - O ambiente de trabalho fica mais organizado
  - Caso a pessoa não seja um contribuidor no Projeto de outra pessoa e ele tente ``clonar`` e fazer um ``push`` com alterações, não será permitido por conta da falta de Autorização de Acesso nesse Repositorio Online
- Após Fazer Alterações e um ``push`` para o Repositorio ``Forked``, é possivel iniciar o processo de [Pull Request](#pull-request)

### Contribuidores

- No Repositorio Online (GitHub) -> ``Settings`` -> ``Manage Acess`` -> ``Invite Collaborator``: Nesse Processo é possivel convidar Pessoas para ajudar a contribuir no Projeto
- Após tornar uma pessoa contribuidora no Repositorio Online (GitHub), não é mais necessario o Processo de [Pull Request](#pull-request). A partir desse momento, a pessoa consegue criar novos ``branches`` e realizar ``push`` nese Projeto
- É mais utilizado para Colaborações entre Equipes, Focado em determinadas pessoas

### Pull Request

- É mais utilizado quando se trata de Projetos Maiores e Open Source. Por meio dele é possivel controlar como serão feitas as contribuições e alterações na base de codigo daquele projeto
- A ``Pull Request`` é um Processo em que é mesclado as alterações de codigos. Normalmente, é executado em Projetos que aceitam contribuição de outros usuarios
- A aba ``Pull Request`` pode ser encontrada na Pagina do Repositorio no GitHub. Ela é dividida em dois cenarios:
  - Criador da ``Pull Request``:
    - Nesse caso, normalmente será feito a partir de um repositorio ``forked``, em que o usuario já fez as alterações na base de codigo e deseja inserir no Repositorio Original
    - Para isso, ele acessa o repositorio no seu perfil (repoisitorio ``forked``) e Clica em ``Compare & Pull Request``
    - Irá abrir uma Tela que contem:
      - Origem (``Forked``) e Destino (Original) do Repositorio e ``Branch`` que será feita as alterações
      - Titulo da ``Pull Request``
      - Descrição/Detalhamento
  - Dono do Repositorio de destino da ``Pull Request``:
    - Ao acessar, será exibido uma lista com as ``Pull Request`` Pendentes e Concluidas do Repositorio

### Organizações

- São Equipes de Desenvolvedores que contribuem em um Projeto/Repositorio no GitHub
- É possivel configurar niveis de permissões dentro da organização
- Sempre consultar as documentações de como fazer uma Issues, Pull Request e Contribuição no Projeto
- Dentro da Organização é possivel configurar os ``Times``
  - Nos Time sé possivel configura-lo a partir das areas em que as pessoas atuaram no repositorio

### Template para Pull Request

- Na raiz do Repositorio, criar um arquivo Chamado: ``pull_request_template.md``
- Colocar um checklist com itens antes de enviar a Pull Request, descrever o que deve conter e qual modelo deve seguir
- A cada Pull Request iniciada é carregado esse **Template**

### Issues

- Criando Template: ``Settings`` -> ``Features`` -> ``Issues`` -> ``Set up Template``
  - Escolher o Tipo de Modelo de ``Issues``
  - Editar o Template
  - ``Commit Changes``: Cria os arquivos de modelo na pasta ``.github/ISSUE_TEMPLATE1``
- Sempre que for inciar uma ``Issues``, será colocado pra o Usuario escolher a partir de qual modelo será criado

### Aliases

- Configuração especifica no Git para dar "apelidos" à comandos
- ``git config --global alias.novo_nome comando_git``
  - O comando ``comando_git`` tambem será executado como ``git novo_nome``
  - Ex: ``git config --global alias.st status``
    - Depois de executar o comando, para executar o comando ``git status`` pode ser executado apenas com ``git st``
- ``git config --global --unset alias.novo_nome``: Retira o ``alias`` criado no Git
  - Ex: ``git config --global --unset alias.st status``
    - Após esse comando o ``alias`` ``st`` será removido
